// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.IO;
using System.Linq;
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
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.OpenCover.OpenCoverTasks;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.Tools.Xunit.XunitTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.ChangeLog.ChangelogTasks;
using Path = System.IO.Path;

class Build : NukeBuild
{
    public static int Main() => Execute<Build>(x => x.Pack);

    readonly string ToolNamespace = "Nuke.Azure";
    readonly string AzureCliDocsRepository = "https://github.com/Azure/azure-docs-cli-python.git";
   

    [GitVersion] readonly GitVersion GitVersion;
    [GitRepository] readonly GitRepository GitRepository;
    [Solution] readonly Solution Solution;

    [Parameter("ApiKey for the specified source.")] readonly string ApiKey;
    [Parameter("Indicates to push to nuget.org feed.")] readonly bool NuGet;
    [Parameter] readonly string AzureCliGitBranch = "live";

    AbsolutePath SpecificationPath => (AbsolutePath) AzureProject.Directory / "specifications";
    AbsolutePath GenerationBaseDirectory => (AbsolutePath) AzureProject.Directory / "Generated";
    AbsolutePath DefinitonRepositoryPath => TemporaryDirectory / "definition-repository";

    
    Project AzureProject => Solution.GetProject("Nuke.Azure");
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
            DeleteDirectory(DefinitonRepositoryPath);
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
            Git($"clone {AzureCliDocsRepository} {DefinitonRepositoryPath}");
            Git($"checkout {AzureCliGitBranch}", DefinitonRepositoryPath);
        });

    Target GenerateSpecifications => _ => _
        .DependsOn(Clone)
        .Executes(() =>
        {
            var reference = Git($"rev-parse --short {AzureCliGitBranch}", DefinitonRepositoryPath).Single();
            Logger.Log($"Generating specifications for {reference}");
            var generationSettings = new SpecificationGeneratorSettings
                                     {
                                         BaseNamespace = AzureProject.Name,
                                         DefinitonFolder = DefinitonRepositoryPath / "latest" / "docs-ref-autogen",
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
                    ($"{ToolNamespace}." + relativePath.Replace(oldChar: '\\', newChar: '.').Replace(oldChar: '/', newChar: '.')).Trim(new[] { '.' });

                CodeGenerator.GenerateCode(Directory.GetFiles(directoryPath, "*.json", SearchOption.TopDirectoryOnly),
                    GenerationBaseDirectory / relativePath,
                    useNestedNamespaces: false,
                    baseNamespace: ns,
                    repository: GitRepository);
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
            DotNetRestore(s => DefaultDotNetRestore.SetProjectFile(AzureProject));
            DotNetBuild(s => DefaultDotNetBuild.SetProjectFile(AzureProject).EnableNoRestore());
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
                .SetProject(AzureProject)
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

            Git($"add {ChangelogFile}");
            Git($"commit -m \"Finalize {Path.GetFileName(ChangelogFile)} for {GitVersion.SemVer}.\" -m \"+semver: skip\"");
            Git($"tag -f {GitVersion.SemVer}");
        });

    Target Push => _ => _
        .DependsOn(Pack)
        .Requires(() => ApiKey)
        .Requires(() => !GitHasUncommitedChanges())
        .Requires(() => !NuGet || GitVersionAttribute.Bump.HasValue)
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
}