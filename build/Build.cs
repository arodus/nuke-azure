// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Nuke.Azure.Generator;
using Nuke.CodeGeneration;
using Nuke.Common;
using Nuke.Common.Git;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Tools.OpenCover;
using Nuke.Common.Tools.Xunit;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.GitHub;
using Octokit;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.OpenCover.OpenCoverTasks;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.Tools.Xunit.XunitTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.ChangeLog.ChangelogTasks;
using static RegenerateTasks;
using static Nuke.GitHub.GitHubTasks;

class Build : NukeBuild
{
	public static int Main() => Execute<Build>(x => x.Pack);

	const string c_addonRepoOwner = "nuke-build";
	const string c_addonRepoName = "azure";
	const string c_addonName = "Azure CLI";
	const string c_azureRepoOwner = "Azure";
	const string c_azureCliRepo = "azure-cli";
	const string c_azureCliDocsRepo = "azure-docs-cli-python";
	const string c_documentationBranch = "live";
	const string c_toolNamespace = "Nuke.Azure";
	const string c_azureCliDocsRepository = "https://github.com/" + c_azureRepoOwner + "/" + c_azureCliDocsRepo + ".git";

	public Build()
	{
		LatestCliReleases = new Lazy<IReadOnlyList<Release>>(() =>
			GetReleases(x => x.SetRepositoryName(c_azureCliRepo)
					.SetRepositoryOwner(c_azureRepoOwner)
					.SetToken(GitHubApiKey), numberOfReleases: 10)
				.GetAwaiter().GetResult()
				.Where(x => !x.Prerelease && x.TagName.StartsWith("azure-cli"))
				.ToArray());
	}

	readonly Lazy<IReadOnlyList<Release>> LatestCliReleases;

	[GitVersion] readonly GitVersion GitVersion;
	[GitRepository] readonly GitRepository GitRepository;
	[Solution] readonly Solution Solution;

	[Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
	readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

	[Parameter("Api key to push packages to nuget.org.")] readonly string NugetApiKey;
	[Parameter("Api key to access the github.")] readonly string GitHubApiKey;
	AbsolutePath OutputDirectory => RootDirectory / "output";
	AbsolutePath SourceDirectory => RootDirectory / "src";
	AbsolutePath TestsDirectory => RootDirectory / "tests";

	AbsolutePath SpecificationPath => AddonProject.Directory / "specifications";
	AbsolutePath GenerationBaseDirectory => AddonProject.Directory / "Generated";
	AbsolutePath DefinitionRepositoryPath => TemporaryDirectory / "definition-repository";
	Release LatestCliRelease => LatestCliReleases.Value[index: 0];

	Nuke.Common.ProjectModel.Project AddonProject => Solution.GetProject(c_toolNamespace);
	string ChangelogFile => RootDirectory / "CHANGELOG.md";

	Target Clean => _ => _
		.Executes(() =>
		{
			SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
			EnsureCleanDirectory(OutputDirectory);
			Logger.Info("Deleting generated files ...");
		});

	Target CleanGeneratedFiles => _ => _
	.Executes(() =>
	{
		DeleteDirectory(DefinitionRepositoryPath);
		DeleteDirectory(SpecificationPath);
		DeleteDirectory(GenerationBaseDirectory);
	});



	Target Restore => _ => _
		.DependsOn(Clean)
		.Executes(() =>
		{
			DotNetRestore(s => s
				.SetWorkingDirectory(Solution.Directory)
				.SetProjectFile(Solution));
		});

	Target Compile => _ => _
		.DependsOn(Restore)
		.Executes(() =>
		{
			DotNetBuild(x => x
				.SetWorkingDirectory(Solution.Directory)
				.SetConfiguration(Configuration)
				.SetAssemblyVersion(GitVersion?.GetNormalizedAssemblyVersion())
				.SetFileVersion(GitVersion?.GetNormalizedFileVersion())
				.SetInformationalVersion(GitVersion?.InformationalVersion)
				.SetProjectFile(Solution)
				.EnableNoRestore());
		});

	Target Test => _ => _
		.DependsOn(Compile)
		.Executes(() =>
		{
			var xUnitSettings = new Xunit2Settings()
				.SetFramework("net461")
				.AddTargetAssemblies(TestsDirectory.GlobFiles($"*/bin/{Configuration}/net4*/Nuke.*.Tests.dll").NotEmpty().Select(t => t.ToString()))
				.AddResultReport(Xunit2ResultFormat.Xml, OutputDirectory / "tests.xml");

			if (IsWin)
			{
				OpenCover(s => s
						.SetWorkingDirectory(RootDirectory)
						.SetRegistration(RegistrationType.User)
						.SetTargetExitCodeOffset(targetExitCodeOffset: 0)
						.SetFilters(
							"+[*]*",
							"-[xunit.*]*",
							"-[NUnit.*]*",
							"-[FluentAssertions.*]*",
							"-[Machine.Specifications.*]*")
						.SetExcludeByAttributes(
							"*.Explicit*",
							"*.Ignore*",
							"System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute")
						.SetExcludeByFile(
							"*/*.Generated.cs",
							"*/*.Designer.cs",
							"*/*.g.cs",
							"*/*.g.i.cs")
					.SetOutput(OutputDirectory / "coverage.xml")
					.SetTargetSettings(xUnitSettings));
			}
			else
				Xunit2(s => xUnitSettings);
		});

	Target Clone => _ => _
		.DependsOn(CleanGeneratedFiles)
		.Executes(() =>
		{
			Git($"clone {c_azureCliDocsRepository} {DefinitionRepositoryPath}");
			Git($"checkout {c_documentationBranch}", DefinitionRepositoryPath);

			// Fix for broken yml definition of az sql vm show's --expand parameter
			// which is adding an empty collection for values, which breaks code generation
			var filePath = DefinitionRepositoryPath / "latest" / "docs-ref-autogen" / "sql" / "vm.yml";

			var tmpFilePath = TemporaryDirectory / (Path.GetFileName("vm.yml") + ".tmp");

			using (var reader = new StreamReader(filePath))
			using (var writer = new StreamWriter(tmpFilePath))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					if (line == null) continue;

					if (line.IndexOf("parameterValueGroup: ''", StringComparison.Ordinal) > -1)
						continue; //We just skip that line

					writer.WriteLine(line);
				}
			}

			File.Copy(tmpFilePath, filePath, overwrite: true);
			File.Delete(tmpFilePath);
		});

	Target GenerateSpecifications => _ => _
		.DependentFor(GenerateAddon)
		.DependsOn(Clone)
		.Executes(() =>
		{
			var reference = Git($"rev-parse --short {c_documentationBranch}", DefinitionRepositoryPath).Single();
			Logger.Log(LogLevel.Normal, $"Generating specifications for {reference}");
			var generationSettings = new SpecificationGeneratorSettings
			{
				BaseNamespace = AddonProject.Name,
				DefinitionFolder = DefinitionRepositoryPath / "latest" / "docs-ref-autogen",
				OutputFolder = SpecificationPath,
				GenerateExtension = false,
				MaxDepth = 1,
				MinDepthForCategory = 1,
				MinSubTasksForCategory = 0,
				SingleNamespace = true,
				Reference = reference.Text
			};
			SpecificationGenerator.GenerateSpecifications(generationSettings);
		});

	IEnumerable<string> SpecificationFiles => GlobFiles(SpecificationPath, "*.json");

	Target GenerateAddon => _ => _
		.OnlyWhenDynamic(() => SpecificationFiles.Any())
		.Executes(() =>
		{
			string GetNamespace(string specificationFile)
				=> Solution.Projects.Single(x => IsDescendantPath(x.Directory, specificationFile)).Name;

			CodeGenerator.GenerateCode(
				SpecificationFiles.ToList(),
				outputFileProvider: x => GenerationBaseDirectory / Path.ChangeExtension(Path.GetFileName(x.SpecificationFile), "Generated.cs"),
				namespaceProvider: x => GetNamespace(x.SpecificationFile),
				sourceFileProvider: x => GitRepository.GetGitHubBrowseUrl(x.SpecificationFile));

			GlobFiles(GenerationBaseDirectory, "AzureMonitor*.Generated.cs", "AzureNetwork*.Generated.cs", "AzureStorage*.Generated.cs").ForEach(
				filePath =>
				{
					var tmpFilePath = TemporaryDirectory / (Path.GetFileName(filePath) + ".tmp");
					using (var reader = new StreamReader(filePath))
					{
						using (var writer = new StreamWriter(tmpFilePath))
						{
							while (!reader.EndOfStream)
							{
								var line = reader.ReadLine();
								if (line == null) continue;

								if (line.IndexOf("public static NetworkNsgRuleProtocol __ = new NetworkNsgRuleProtocol { Value = \"*\" };",
									    StringComparison.Ordinal) > -1)
									line = line.Replace("__", "any");
								else if (line.IndexOf(
									         "public static MonitorAlertUpdateOperator __ = new MonitorAlertUpdateOperator { Value = \"<\" };",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("__", "SmallerThan");
								else if (line.IndexOf(
									         "public static MonitorAlertUpdateOperator ___ = new MonitorAlertUpdateOperator { Value = \"<=\" };",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("___", "SmallerThanOrEqualTo");
								else if (line.IndexOf(
									         "public static MonitorAlertUpdateOperator __ = new MonitorAlertUpdateOperator { Value = \">\" };",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("__", "GreaterThan");
								else if (line.IndexOf(
									         "public static MonitorAlertUpdateOperator ___ = new MonitorAlertUpdateOperator { Value = \">=\" };",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("___", "GreatherThanOrEqualTo");
								else if (line.IndexOf(".Add(\"--404-document {value}\", 404Document)",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("404Document", "PathTo404Document");
								else if (line.IndexOf("public virtual string 404Document { get; internal set; }",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("404Document", "PathTo404Document");
								else if (line.IndexOf("AzureStorageBlobServicePropertiesUpdateSettings.404Document",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("404Document", "PathTo404Document");
								else if (line.IndexOf("#region 404Document",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("404Document", "PathTo404Document");
								else if (line.IndexOf(
									         "Set404Document(this AzureStorageBlobServicePropertiesUpdateSettings toolSettings, string 404Document)",
									         StringComparison.Ordinal) > -1)
									line = line.Replace(
										"Set404Document(this AzureStorageBlobServicePropertiesUpdateSettings toolSettings, string 404Document)",
										"SetPathTo404Document(this AzureStorageBlobServicePropertiesUpdateSettings toolSettings, string pathTo404Document)");
								else if (line.IndexOf("toolSettings.404Document = 404Document;",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("toolSettings.404Document = 404Document;",
										"toolSettings.PathTo404Document = pathTo404Document;");
								else if (line.IndexOf("Reset404Document(this AzureStorageBlobServicePropertiesUpdateSettings toolSettings)",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("Reset404Document", "ResetPathTo404Document");
								else if (line.IndexOf("toolSettings.404Document = null;",
									         StringComparison.Ordinal) > -1)
									line = line.Replace("toolSettings.404Document = null;", "toolSettings.PathTo404Document = null;");

								writer.WriteLine(line);
							}
						}
					}

					File.Copy(tmpFilePath, filePath, overwrite: true);
					File.Delete(tmpFilePath);
				});
		});

	Target CompileAddon => _ => _
		.DependsOn(GenerateAddon, Clean)
		.Executes(() =>
		{
			DotNetRestore(s => s
				.SetWorkingDirectory(Solution.Directory)
				.SetProjectFile(AddonProject));

			DotNetBuild(x => x
				.SetWorkingDirectory(Solution.Directory)
				.SetConfiguration(Configuration)
				.SetAssemblyVersion(GitVersion?.GetNormalizedAssemblyVersion())
				.SetFileVersion(GitVersion?.GetNormalizedFileVersion())
				.SetInformationalVersion(GitVersion?.InformationalVersion)
				.SetProjectFile(AddonProject)
				.EnableNoRestore());
		});

	Target Pack => _ => _
		.DependsOn(CompileAddon)
		.Executes(() =>
		{
			var releaseNotes = ExtractChangelogSectionNotes(ChangelogFile)
				.Select(x => x.Replace("- ", "\u2022 ").Replace("`", string.Empty).Replace(",", "%2C"))
				.Concat(string.Empty)
				.Concat($"Full changelog at {GitRepository.SetBranch("master").GetGitHubBrowseUrl(ChangelogFile)}")
				.JoinNewLine();

			DotNetPack(s => s
				.SetWorkingDirectory(Solution.Directory)
				.SetConfiguration(Configuration)
				.EnableIncludeSymbols()
				.SetOutputDirectory(OutputDirectory)
				.SetProject(AddonProject)
				.EnableNoBuild()
				.EnableNoRestore()
				.SetVersion(GitVersion.NuGetVersionV2)
				.SetPackageReleaseNotes(releaseNotes));
		});

	Target Changelog => _ => _
		.OnlyWhenDynamic(() => ShouldUpdateChangelog())
		.Executes(() =>
		{
			FinalizeChangelog(ChangelogFile, GitVersion.MajorMinorPatch, GitRepository);
		});

	Target Push => _ => _
		.DependsOn(Pack)
		.Requires(() => NugetApiKey)
		.Requires(() => GitHasCleanWorkingCopy())
		.Requires(() => Configuration.Equals(Configuration.Release))
		.Requires(() => IsReleaseBranch || IsMasterBranch)
		.Executes(() =>
		{
			GlobFiles(OutputDirectory, "*.nupkg")
				.Where(x => !x.EndsWith(".symbols.nupkg")).NotEmpty()
				.ForEach(x => DotNetNuGetPush(s => s
					.SetTargetPath(x)
					.SetSource("https://api.nuget.org/v3/index.json")
					.SetSymbolSource("https://nuget.smbsrc.net/")
					.SetApiKey(NugetApiKey)));
		});

	Target Regenerate => _ => _
		.Requires(() => GitHubApiKey)
		.Requires(() => LatestCliRelease != null)
		.OnlyWhenDynamic(() => IsUpdateAvailable($"{c_addonName} v{ParseVersion(LatestCliRelease)}", ChangelogFile))
		.WhenSkipped(DependencyBehavior.Skip)
		.DependsOn(CompileAddon, GenerateSpecifications)
		.Executes(async () =>
		{
			var release = GetReleaseInformation(LatestCliReleases.Value, ParseVersion);
			var branch = $"{c_addonRepoName}-update-{release.Version}";
			var versionName = $"{c_addonName} v{release.Version}";
			var message = $"Regenerate for {versionName}";
			var latestReleaseDate = LatestCliRelease.PublishedAt?.ToString("MMMM-d-yyyy");
			var changelogUrl = $"https://docs.microsoft.com/cli/azure/release-notes-azure-cli?view=azure-cli-latest#{latestReleaseDate}";

			var commitMessage = new List<string> { message };
			if (release.Bump != Bump.Patch) commitMessage.Add($"+semver: {release.Bump.ToString().ToLowerInvariant()}");
			var prBody = $"Regenerate for [{versionName}]({LatestCliRelease.HtmlUrl}).\n[Changelog]({changelogUrl})";

			CheckoutBranchOrCreateNewFrom(branch, "master");
			UpdateChangeLog(ChangelogFile, versionName, changelogUrl);
			AddAndCommitChanges(commitMessage.ToArray(), new[] { AddonProject.Directory, ChangelogFile }, addUntracked: true);

			Git($"push --force --set-upstream origin {branch}");

			await CreatePullRequest(x => x
				.SetRepositoryName(c_addonRepoName)
				.SetRepositoryOwner(c_addonRepoOwner)
				.SetBase("master")
				.SetHead(branch)
				.SetTitle(message)
				.SetBody(prBody)
				.SetToken(GitHubApiKey));
		});

	Target Release => _ => _
		.Requires(() => GitHubApiKey)
		.DependsOn(Push)
		.After(PrepareRelease)
		.Executes(async () =>
		{
			var releaseNotes = new[]
							   {
								   $"- [Nuget](https://www.nuget.org/packages/{c_toolNamespace}/{GitVersion.SemVer})",
								   $"- [Changelog](https://github.com/{c_addonRepoOwner}/{c_addonRepoName}/blob/{GitVersion.SemVer}/CHANGELOG.md)"
							   };

			await PublishRelease(x => x.SetToken(GitHubApiKey)
				.SetArtifactPaths(GlobFiles(OutputDirectory, "*.nupkg").ToArray())
				.SetRepositoryName(c_addonRepoName)
				.SetRepositoryOwner(c_addonRepoOwner)
				.SetCommitSha("master")
				.SetName($"NUKE {c_addonName} Addon v{GitVersion.MajorMinorPatch}")
				.SetTag($"{GitVersion.MajorMinorPatch}")
				.SetReleaseNotes(releaseNotes.Join("\n"))
			);
		});

	Target PrepareRelease => _ => _
		.Before(CompileAddon)
		.DependsOn(Changelog, Clean)
		.Executes(() =>
		{
			var releaseBranch = IsReleaseBranch ? GitRepository.Branch : $"release/v{GitVersion.MajorMinorPatch}";
			var isMasterBranch = IsMasterBranch;
			var pushMaster = false;
			if (!isMasterBranch && !IsReleaseBranch) Git($"checkout -b {releaseBranch}");

			if (!GitHasCleanWorkingCopy())
			{
				Git($"add {ChangelogFile}");
				Git($"commit -m \"Finalize v{GitVersion.MajorMinorPatch}\"");
				pushMaster = true;
			}

			if (!isMasterBranch)
			{
				Git("checkout master");
				Git($"merge --no-ff --no-edit {releaseBranch}");
				Git($"branch -D {releaseBranch}");
				pushMaster = true;
			}

			if (IsReleaseBranch) Git($"push origin --delete {releaseBranch}");
			if (pushMaster) Git("push origin master");
		});

	bool IsReleaseBranch => GitRepository?.Branch?.StartsWith("release/") ?? false;
	bool IsMasterBranch => GitRepository.Branch == "master";

	bool ShouldUpdateChangelog()
	{
		bool TryGetChangelogSectionNotes(string tag, out string[] sectionNotes)
		{
			sectionNotes = new string[0];
			try
			{
				sectionNotes = ExtractChangelogSectionNotes(ChangelogFile, tag).ToArray();
				return sectionNotes.Length > 0;
			}
			catch (Exception)
			{
				return false;
			}
		}

		var nextSectionAvailable = TryGetChangelogSectionNotes("vNext", out _);
		var semVerSectionAvailable = TryGetChangelogSectionNotes(GitVersion.MajorMinorPatch, out _);
		if (semVerSectionAvailable)
		{
			ControlFlow.Assert(!nextSectionAvailable, $"{GitVersion.MajorMinorPatch} is already in changelog.");
			return false;
		}

		return nextSectionAvailable;
	}

	Version ParseVersion(Release release) => Version.Parse(Regex.Match(release.TagName, @"^azure-cli-(\d+(?>\.\d+){0,2})").Groups[groupnum: 1].Value);
}