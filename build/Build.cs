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
using Nuke.Common.Git;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.Xunit;
using Nuke.Common.Tools.OpenCover;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
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
using static GitHubTasks;
using Path = System.IO.Path;

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
            GetLatestReleases(c_azureRepoOwner, c_azureCliRepo, numberOfReleases: 2, token: GitHubApiKey));
    }

    readonly Lazy<IReadOnlyList<Release>> LatestCliReleases;

    [GitVersion] readonly GitVersion GitVersion;
    [GitRepository] readonly GitRepository GitRepository;
    [Solution] readonly Solution Solution;

    [Parameter("ApiKey for the specified source.")] readonly string ApiKey;
    [Parameter("Indicates to push to nuget.org feed.")] readonly bool NuGet;
    [Parameter("Api key to access the github.com api. Must have permissions to create pull-requests.")] readonly string GitHubApiKey;

    AbsolutePath SpecificationPath => AddonProject.Directory / "specifications";
    AbsolutePath GenerationBaseDirectory => AddonProject.Directory / "Generated";
    AbsolutePath DefinitionRepositoryPath => TemporaryDirectory / "definition-repository";
    Release LatestCliRelease => LatestCliReleases.Value[index: 0];

    Nuke.Common.ProjectModel.Project AddonProject => Solution.GetProject(c_toolNamespace);
    string ChangelogFile => RootDirectory / "CHANGELOG.md";

    string Source => NuGet
        ? "https://api.nuget.org/v3/index.json"
        : "https://www.myget.org/F/nukebuild/api/v2/package";

    string SymbolSource => NuGet
        ? "https://nuget.smbsrc.net"
        : "https://www.myget.org/F/nukebuild/symbols/api/v2/package";

    Target Clean => _ => _
        .Executes(() =>
        {
            DeleteDirectories(GlobDirectories(SourceDirectory, "**/bin", "**/obj"));
            EnsureCleanDirectory(OutputDirectory);
            Logger.Info("Deleting generated files ...");
            DeleteDirectory(DefinitionRepositoryPath);
            DeleteDirectory(SpecificationPath);
            DeleteDirectory(GenerationBaseDirectory);
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(s => DefaultDotNetRestore);
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(x => DefaultDotNetBuild.EnableNoRestore());
        });

    Target Test => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            var xUnitSettings = new Xunit2Settings()
                .AddTargetAssemblies(GlobFiles(SolutionDirectory / "tests", $"*/bin/{Configuration}/net4*/Nuke.*.Tests.dll").NotEmpty())
                .AddResultReport(Xunit2ResultFormat.Xml, OutputDirectory / "tests.xml");

            if (IsWin)
            {
                OpenCover(s => DefaultOpenCover
                    .SetOutput(OutputDirectory / "coverage.xml")
                    .SetTargetSettings(xUnitSettings));
            }
            else
                Xunit2(s => xUnitSettings);
        });

    Target Clone => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            Git($"clone {c_azureCliDocsRepository} {DefinitionRepositoryPath}");
            Git($"checkout {c_documentationBranch}", DefinitionRepositoryPath);
        });

    Target GenerateSpecifications => _ => _
        .DependsOn(Clone)
        .Executes(() =>
        {
            var reference = Git($"rev-parse --short {c_documentationBranch}", DefinitionRepositoryPath, redirectOutput: true).Single();
            Logger.Log($"Generating specifications for {reference}");
            var generationSettings = new SpecificationGeneratorSettings
                                     {
                                         BaseNamespace = AddonProject.Name,
                                         DefinitonFolder = DefinitionRepositoryPath / "latest" / "docs-ref-autogen",
                                         OutputFolder = SpecificationPath,
                                         GenerateExtension = false,
                                         MaxDepth = 1,
                                         MinDepthForCategory = 1,
                                         MinSubTasksForCategory = 0,
                                         SingleNamespace = true,
                                         Reference = reference
                                     };
            SpecificationGenerator.GenerateSpecifications(generationSettings);
        });

    Target GenerateTools => _ => _
        .DependsOn(GenerateSpecifications)
        .Executes(() =>
        {
            GlobDirectories(SpecificationPath, "*").Concat(SpecificationPath).ForEach(directoryPath =>
            {
                var relativePath = GetRelativePath(SpecificationPath, directoryPath);
                var ns =
                    ($"{c_toolNamespace}." + relativePath.Replace(oldChar: '\\', newChar: '.').Replace(oldChar: '/', newChar: '.')).Trim(
                        new[] { '.' });

                CodeGenerator.GenerateCode(Directory.GetFiles(directoryPath, "*.json", SearchOption.TopDirectoryOnly),
                    GenerationBaseDirectory / relativePath,
                    useNestedNamespaces: false,
                    baseNamespace: ns,
                    repository: GitRepository.SetBranch("master"));
            });

            GlobFiles(GenerationBaseDirectory, "AzureMonitor*.Generated.cs", "AzureNetwork*.Generated.cs").ForEach(filePath =>
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
                            {
                                line = line.Replace("__", "any");
                            }
                            else if (line.IndexOf("public static MonitorAlertUpdateOperator __ = new MonitorAlertUpdateOperator { Value = \"<\" };",
                                         StringComparison.Ordinal) > -1)
                            {
                                line = line.Replace("__", "SmallerThan");
                            }
                            else if (line.IndexOf("public static MonitorAlertUpdateOperator ___ = new MonitorAlertUpdateOperator { Value = \"<=\" };",
                                         StringComparison.Ordinal) > -1)
                            {
                                line = line.Replace("___", "SmallerThanOrEqualTo");
                            }
                            else if (line.IndexOf("public static MonitorAlertUpdateOperator __ = new MonitorAlertUpdateOperator { Value = \">\" };",
                                         StringComparison.Ordinal) > -1)
                            {
                                line = line.Replace("__", "GreaterThan");
                            }
                            else if (line.IndexOf("public static MonitorAlertUpdateOperator ___ = new MonitorAlertUpdateOperator { Value = \">=\" };",
                                         StringComparison.Ordinal) > -1)
                            {
                                line = line.Replace("___", "GreatherThanOrEqualTo");
                            }

                            writer.WriteLine(line);
                        }
                    }
                }

                File.Copy(tmpFilePath, filePath, overwrite: true);
                File.Delete(tmpFilePath);
            });
        });

    Target CompilePlugin => _ => _
        .DependsOn(GenerateTools)
        .Executes(() =>
        {
            DotNetRestore(s => DefaultDotNetRestore.SetProjectFile(AddonProject));
            DotNetBuild(s => DefaultDotNetBuild.SetProjectFile(AddonProject).EnableNoRestore());
        });

    Target Pack => _ => _
        .DependsOn(CompilePlugin)
        .Executes(() =>
        {
            var releaseNotes = ExtractChangelogSectionNotes(ChangelogFile)
                .Select(x => x.Replace("- ", "\u2022 ").Replace("`", string.Empty).Replace(",", "%2C"))
                .Concat(string.Empty)
                .Concat($"Full changelog at {GitRepository.GetGitHubBrowseUrl(ChangelogFile)}")
                .JoinNewLine();

            DotNetPack(s => DefaultDotNetPack
                .SetProject(AddonProject)
                .EnableNoBuild()
                .EnableNoRestore()
                .SetVersion(GitVersion.NuGetVersionV2)
                .SetPackageReleaseNotes(releaseNotes));
        });

    Target Changelog => _ => _
        .OnlyWhen(() => InvokedTargets.Contains(nameof(Changelog)))
        .Executes(() =>
        {
            FinalizeChangelog(ChangelogFile, GitVersion.SemVer, GitRepository);
        });

    Target Push => _ => _
        .DependsOn(Pack)
        .Requires(() => ApiKey)
        .Requires(() => !GitHasUncommitedChanges())
        .Requires(() => !NuGet || Configuration.EqualsOrdinalIgnoreCase("release"))
        .Requires(() => !NuGet || GitVersion.BranchName.Equals("master"))
        .Executes(() =>
        {
            GlobFiles(OutputDirectory, "*.nupkg")
                .Where(x => !x.EndsWith(".symbols.nupkg")).NotEmpty()
                .ForEach(x => DotNetNuGetPush(s => s
                    .SetTargetPath(x)
                    .SetSource(Source)
                    .SetSymbolSource(SymbolSource)
                    .SetApiKey(ApiKey)));
        });

    Target Regenerate => _ => _
        .Requires(() => GitHubApiKey)
        .Requires(() => LatestCliRelease != null)
        .OnlyWhen(() => IsUpdateAvailable($"{c_addonName} v{LatestCliRelease}", ChangelogFile))
        .DependsOn(CompilePlugin)
        .Executes(() =>
        {
            // var (fullVersion, version, preReleaseTag) = Regex.Match(LatestCliRelease.Name, @"((?:\d+\.){2}\d+)(?:-([\d\w-]+))?$").Groups.Select(x => x.Value).ToArray();
            Version ParseVersion(Release x) => Version.Parse(Regex.Match(x.Name, @"(?'version'(?:\d+\.){2}\d+)$").Groups["version"].Value);

            var release = GetReleaseInformation(LatestCliReleases.Value, ParseVersion);

            var branch = $"{c_addonRepoName}-update-{release.Version}";
            var versionName = $"{c_addonName} v{release.Version}";
            var message = $"Regenerate for {versionName}";

            var commitMessage = new List<string> { message };
            if (release.Bump != GitVersionBump.Patch) commitMessage.Add($"+semver: {release.Bump.ToString().ToLowerInvariant()}");
            var prBody = $"Regenerate for [{versionName}]({LatestCliRelease.HtmlUrl}).";

            CheckoutBranchOrCreateNewFrom(branch, "master");

            UpdateChangeLog(ChangelogFile, versionName, LatestCliRelease.HtmlUrl);
            FinalizeChangelog(ChangelogFile, GitVersion.NextSemVer(release.Bump), GitRepository);
            AddAndCommitChanges(commitMessage.ToArray(), new[] { AddonProject.Directory, ChangelogFile }, addUntracked: true);
            Git($"push --force --set-upstream origin {branch}");
            CreatePullRequestIfNeeded(GitRepository.Identifier, branch, $"{message}", prBody, GitHubApiKey);
        });

    Target Release => _ => _
        .Requires(() => GitHubApiKey)
        .DependsOn(Push)
        .Executes(() =>
        {
            var lastCommitMessage = GitLastCommitMessage();
            var tagAnnotations = lastCommitMessage.Aggregate(string.Empty, (x, y) => $"{x} -m \"{y}\"").Trim();
            var tagName = GitVersion.SemVer;

            Git($"tag -a {tagName} {tagAnnotations}");
            Git($"push origin {tagName}");
            var releaseMessage = new[]
                                 {
                                     "- [Nuget](https://www.nuget.org/packages/{c_toolNamespace}/)",
                                     $"- [Changelog](https://github.com/{c_addonRepoOwner}/{c_addonRepoName}/blob/{tagName}/CHANGELOG.md)"
                                 }.JoinNewLine();
            CreateRelease(GitRepository.Identifier, tagName, GitHubApiKey, $"{c_toolNamespace} v{tagName}", releaseMessage, !NuGet);
        });
}