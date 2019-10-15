// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureArtifacts.json
// Generated with Nuke.CodeGeneration version 0.20.1 (OSX,.NETStandard,Version=v2.0)

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Azure
{
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureArtifactsTasks
    {
        /// <summary>
        ///   Path to the AzureArtifacts executable.
        /// </summary>
        public static string AzureArtifactsPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREARTIFACTS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureArtifactsLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Artifacts.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureArtifacts(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureArtifactsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureArtifactsLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureArtifacts(AzureArtifactsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureArtifactsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureArtifactsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureArtifactsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureArtifactsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureArtifactsSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureArtifactsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureArtifacts(Configure<AzureArtifactsSettings> configurator)
        {
            return AzureArtifacts(configurator(new AzureArtifactsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureArtifactsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureArtifactsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureArtifactsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureArtifactsSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureArtifactsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureArtifactsSettings Settings, IReadOnlyCollection<Output> Output)> AzureArtifacts(CombinatorialConfigure<AzureArtifactsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureArtifacts, AzureArtifactsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureArtifactsUniversalDownload(AzureArtifactsUniversalDownloadSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureArtifactsUniversalDownloadSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></li>
        ///     <li><c>--feed</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Feed"/></li>
        ///     <li><c>--file-filter</c> via <see cref="AzureArtifactsUniversalDownloadSettings.FileFilter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureArtifactsUniversalDownload(Configure<AzureArtifactsUniversalDownloadSettings> configurator)
        {
            return AzureArtifactsUniversalDownload(configurator(new AzureArtifactsUniversalDownloadSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></li>
        ///     <li><c>--feed</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Feed"/></li>
        ///     <li><c>--file-filter</c> via <see cref="AzureArtifactsUniversalDownloadSettings.FileFilter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureArtifactsUniversalDownloadSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureArtifactsUniversalDownloadSettings Settings, IReadOnlyCollection<Output> Output)> AzureArtifactsUniversalDownload(CombinatorialConfigure<AzureArtifactsUniversalDownloadSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureArtifactsUniversalDownload, AzureArtifactsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureArtifactsUniversalPublish(AzureArtifactsUniversalPublishSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureArtifactsUniversalPublishSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureArtifactsUniversalPublishSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureArtifactsUniversalPublishSettings.Description"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></li>
        ///     <li><c>--feed</c> via <see cref="AzureArtifactsUniversalPublishSettings.Feed"/></li>
        ///     <li><c>--help</c> via <see cref="AzureArtifactsUniversalPublishSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureArtifactsUniversalPublishSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureArtifactsUniversalPublishSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureArtifactsUniversalPublishSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureArtifactsUniversalPublishSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureArtifactsUniversalPublishSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureArtifactsUniversalPublishSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureArtifactsUniversalPublishSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureArtifactsUniversalPublishSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureArtifactsUniversalPublish(Configure<AzureArtifactsUniversalPublishSettings> configurator)
        {
            return AzureArtifactsUniversalPublish(configurator(new AzureArtifactsUniversalPublishSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Artifacts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/artifacts?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureArtifactsUniversalPublishSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureArtifactsUniversalPublishSettings.Description"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></li>
        ///     <li><c>--feed</c> via <see cref="AzureArtifactsUniversalPublishSettings.Feed"/></li>
        ///     <li><c>--help</c> via <see cref="AzureArtifactsUniversalPublishSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureArtifactsUniversalPublishSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureArtifactsUniversalPublishSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureArtifactsUniversalPublishSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureArtifactsUniversalPublishSettings.Path"/></li>
        ///     <li><c>--query</c> via <see cref="AzureArtifactsUniversalPublishSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureArtifactsUniversalPublishSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureArtifactsUniversalPublishSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureArtifactsUniversalPublishSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureArtifactsUniversalPublishSettings Settings, IReadOnlyCollection<Output> Output)> AzureArtifactsUniversalPublish(CombinatorialConfigure<AzureArtifactsUniversalPublishSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureArtifactsUniversalPublish, AzureArtifactsLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureArtifactsSettings
    /// <summary>
    ///   Used within <see cref="AzureArtifactsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureArtifactsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureArtifacts executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureArtifactsTasks.AzureArtifactsPath;
        public override Action<OutputType, string> CustomLogger => AzureArtifactsTasks.AzureArtifactsLogger;
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("artifacts")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureArtifactsUniversalDownloadSettings
    /// <summary>
    ///   Used within <see cref="AzureArtifactsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureArtifactsUniversalDownloadSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureArtifacts executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureArtifactsTasks.AzureArtifactsPath;
        public override Action<OutputType, string> CustomLogger => AzureArtifactsTasks.AzureArtifactsLogger;
        /// <summary>
        ///   Name or ID of the feed.
        /// </summary>
        public virtual string Feed { get; internal set; }
        /// <summary>
        ///   Name of the package, e.g. 'foo-package'.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Directory to place the package contents.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Version of the package, e.g. 1.0.0.
        /// </summary>
        public virtual string Version { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Wildcard filter for file download.
        /// </summary>
        public virtual string FileFilter { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("artifacts universal download")
              .Add("--feed {value}", Feed)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
              .Add("--version {value}", Version)
              .Add("--detect", Detect)
              .Add("--file-filter {value}", FileFilter)
              .Add("--org {value}", Org)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureArtifactsUniversalPublishSettings
    /// <summary>
    ///   Used within <see cref="AzureArtifactsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureArtifactsUniversalPublishSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureArtifacts executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureArtifactsTasks.AzureArtifactsPath;
        public override Action<OutputType, string> CustomLogger => AzureArtifactsTasks.AzureArtifactsLogger;
        /// <summary>
        ///   Name or ID of the feed.
        /// </summary>
        public virtual string Feed { get; internal set; }
        /// <summary>
        ///   Name of the package, e.g. 'foo-package'.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Directory containing the package contents.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Version of the package, e.g. '1.0.0'.
        /// </summary>
        public virtual string Version { get; internal set; }
        /// <summary>
        ///   Description of the package.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity to show all debug logs.
        /// </summary>
        public virtual string Debug { get; internal set; }
        /// <summary>
        ///   Show this help message and exit.
        /// </summary>
        public virtual string Help { get; internal set; }
        /// <summary>
        ///   Output format.
        /// </summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary>
        ///   JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.
        /// </summary>
        public virtual string Query { get; internal set; }
        /// <summary>
        ///   Increase logging verbosity. Use --debug for full debug logs.
        /// </summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("artifacts universal publish")
              .Add("--feed {value}", Feed)
              .Add("--name {value}", Name)
              .Add("--path {value}", Path)
              .Add("--version {value}", Version)
              .Add("--description {value}", Description)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureArtifactsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureArtifactsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureArtifactsSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings SetDebug(this AzureArtifactsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings ResetDebug(this AzureArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings SetHelp(this AzureArtifactsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings ResetHelp(this AzureArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings SetOutput(this AzureArtifactsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings ResetOutput(this AzureArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings SetQuery(this AzureArtifactsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings ResetQuery(this AzureArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings SetVerbose(this AzureArtifactsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsSettings ResetVerbose(this AzureArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureArtifactsUniversalDownloadSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureArtifactsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureArtifactsUniversalDownloadSettingsExtensions
    {
        #region Feed
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Feed"/></em></p>
        ///   <p>Name or ID of the feed.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetFeed(this AzureArtifactsUniversalDownloadSettings toolSettings, string feed)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Feed = feed;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Feed"/></em></p>
        ///   <p>Name or ID of the feed.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetFeed(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Feed = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Name"/></em></p>
        ///   <p>Name of the package, e.g. 'foo-package'.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetName(this AzureArtifactsUniversalDownloadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Name"/></em></p>
        ///   <p>Name of the package, e.g. 'foo-package'.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetName(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Path"/></em></p>
        ///   <p>Directory to place the package contents.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetPath(this AzureArtifactsUniversalDownloadSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Path"/></em></p>
        ///   <p>Directory to place the package contents.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetPath(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Version"/></em></p>
        ///   <p>Version of the package, e.g. 1.0.0.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetVersion(this AzureArtifactsUniversalDownloadSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Version"/></em></p>
        ///   <p>Version of the package, e.g. 1.0.0.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetVersion(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetDetect(this AzureArtifactsUniversalDownloadSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetDetect(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings EnableDetect(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings DisableDetect(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureArtifactsUniversalDownloadSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ToggleDetect(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region FileFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.FileFilter"/></em></p>
        ///   <p>Wildcard filter for file download.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetFileFilter(this AzureArtifactsUniversalDownloadSettings toolSettings, string fileFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFilter = fileFilter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.FileFilter"/></em></p>
        ///   <p>Wildcard filter for file download.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetFileFilter(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFilter = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetOrg(this AzureArtifactsUniversalDownloadSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetOrg(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetSubscription(this AzureArtifactsUniversalDownloadSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetSubscription(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetDebug(this AzureArtifactsUniversalDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetDebug(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetHelp(this AzureArtifactsUniversalDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetHelp(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetOutput(this AzureArtifactsUniversalDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetOutput(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetQuery(this AzureArtifactsUniversalDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetQuery(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings SetVerbose(this AzureArtifactsUniversalDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalDownloadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalDownloadSettings ResetVerbose(this AzureArtifactsUniversalDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureArtifactsUniversalPublishSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureArtifactsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureArtifactsUniversalPublishSettingsExtensions
    {
        #region Feed
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Feed"/></em></p>
        ///   <p>Name or ID of the feed.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetFeed(this AzureArtifactsUniversalPublishSettings toolSettings, string feed)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Feed = feed;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Feed"/></em></p>
        ///   <p>Name or ID of the feed.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetFeed(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Feed = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Name"/></em></p>
        ///   <p>Name of the package, e.g. 'foo-package'.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetName(this AzureArtifactsUniversalPublishSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Name"/></em></p>
        ///   <p>Name of the package, e.g. 'foo-package'.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetName(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Path"/></em></p>
        ///   <p>Directory containing the package contents.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetPath(this AzureArtifactsUniversalPublishSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Path"/></em></p>
        ///   <p>Directory containing the package contents.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetPath(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Version"/></em></p>
        ///   <p>Version of the package, e.g. '1.0.0'.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetVersion(this AzureArtifactsUniversalPublishSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Version"/></em></p>
        ///   <p>Version of the package, e.g. '1.0.0'.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetVersion(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Description"/></em></p>
        ///   <p>Description of the package.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetDescription(this AzureArtifactsUniversalPublishSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Description"/></em></p>
        ///   <p>Description of the package.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetDescription(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetDetect(this AzureArtifactsUniversalPublishSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetDetect(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings EnableDetect(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings DisableDetect(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureArtifactsUniversalPublishSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ToggleDetect(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetOrg(this AzureArtifactsUniversalPublishSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetOrg(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetSubscription(this AzureArtifactsUniversalPublishSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetSubscription(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetDebug(this AzureArtifactsUniversalPublishSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetDebug(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetHelp(this AzureArtifactsUniversalPublishSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetHelp(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetOutput(this AzureArtifactsUniversalPublishSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetOutput(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetQuery(this AzureArtifactsUniversalPublishSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetQuery(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureArtifactsUniversalPublishSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings SetVerbose(this AzureArtifactsUniversalPublishSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureArtifactsUniversalPublishSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureArtifactsUniversalPublishSettings ResetVerbose(this AzureArtifactsUniversalPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
