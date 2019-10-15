// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCache.json
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
    public static partial class AzureCacheTasks
    {
        /// <summary>
        ///   Path to the AzureCache executable.
        /// </summary>
        public static string AzureCachePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURECACHE_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureCacheLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Commands to manage CLI objects cached using the `--defer` argument.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCache(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureCachePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureCacheLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCacheDelete(AzureCacheDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCacheDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCacheDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCacheDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCacheDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCacheDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCacheDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCacheDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureCacheDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCacheDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCacheDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCacheDelete(Configure<AzureCacheDeleteSettings> configurator)
        {
            return AzureCacheDelete(configurator(new AzureCacheDeleteSettings()));
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCacheDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCacheDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCacheDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCacheDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCacheDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCacheDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureCacheDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCacheDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCacheDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCacheDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCacheDelete(CombinatorialConfigure<AzureCacheDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCacheDelete, AzureCacheLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCacheList(AzureCacheListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCacheListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCacheListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCacheListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCacheListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCacheListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCacheListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCacheListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCacheList(Configure<AzureCacheListSettings> configurator)
        {
            return AzureCacheList(configurator(new AzureCacheListSettings()));
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCacheListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCacheListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCacheListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCacheListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCacheListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCacheListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCacheListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCacheList(CombinatorialConfigure<AzureCacheListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCacheList, AzureCacheLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCachePurge(AzureCachePurgeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCachePurgeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCachePurgeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCachePurgeSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCachePurgeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCachePurgeSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCachePurgeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCachePurgeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCachePurge(Configure<AzureCachePurgeSettings> configurator)
        {
            return AzureCachePurge(configurator(new AzureCachePurgeSettings()));
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCachePurgeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCachePurgeSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCachePurgeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCachePurgeSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCachePurgeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCachePurgeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCachePurgeSettings Settings, IReadOnlyCollection<Output> Output)> AzureCachePurge(CombinatorialConfigure<AzureCachePurgeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCachePurge, AzureCacheLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCacheShow(AzureCacheShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCacheShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCacheShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCacheShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCacheShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCacheShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCacheShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCacheShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureCacheShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCacheShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCacheShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCacheShow(Configure<AzureCacheShowSettings> configurator)
        {
            return AzureCacheShow(configurator(new AzureCacheShowSettings()));
        }
        /// <summary>
        ///   <p>Commands to manage CLI objects cached using the `--defer` argument.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cache?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCacheShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCacheShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCacheShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCacheShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCacheShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCacheShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureCacheShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCacheShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCacheShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCacheShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCacheShow(CombinatorialConfigure<AzureCacheShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCacheShow, AzureCacheLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureCacheDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCacheDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCache executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCacheTasks.AzureCachePath;
        public override Action<OutputType, string> CustomLogger => AzureCacheTasks.AzureCacheLogger;
        /// <summary>
        ///   The resource name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type.
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("cache delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureCacheListSettings
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCacheListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCache executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCacheTasks.AzureCachePath;
        public override Action<OutputType, string> CustomLogger => AzureCacheTasks.AzureCacheLogger;
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
              .Add("cache list")
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
    #region AzureCachePurgeSettings
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCachePurgeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCache executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCacheTasks.AzureCachePath;
        public override Action<OutputType, string> CustomLogger => AzureCacheTasks.AzureCacheLogger;
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
              .Add("cache purge")
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
    #region AzureCacheShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCacheShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCache executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCacheTasks.AzureCachePath;
        public override Action<OutputType, string> CustomLogger => AzureCacheTasks.AzureCacheLogger;
        /// <summary>
        ///   The resource name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type.
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("cache show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureCacheDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCacheDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Name"/></em></p>
        ///   <p>The resource name.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetName(this AzureCacheDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Name"/></em></p>
        ///   <p>The resource name.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetName(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetResourceGroup(this AzureCacheDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetResourceGroup(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetResourceType(this AzureCacheDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetResourceType(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetSubscription(this AzureCacheDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetSubscription(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetDebug(this AzureCacheDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetDebug(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetHelp(this AzureCacheDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetHelp(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetOutput(this AzureCacheDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetOutput(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetQuery(this AzureCacheDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetQuery(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings SetVerbose(this AzureCacheDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheDeleteSettings ResetVerbose(this AzureCacheDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCacheListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCacheListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings SetSubscription(this AzureCacheListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings ResetSubscription(this AzureCacheListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings SetDebug(this AzureCacheListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings ResetDebug(this AzureCacheListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings SetHelp(this AzureCacheListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings ResetHelp(this AzureCacheListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings SetOutput(this AzureCacheListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings ResetOutput(this AzureCacheListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings SetQuery(this AzureCacheListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings ResetQuery(this AzureCacheListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings SetVerbose(this AzureCacheListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheListSettings ResetVerbose(this AzureCacheListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCachePurgeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCachePurgeSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCachePurgeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings SetSubscription(this AzureCachePurgeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCachePurgeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings ResetSubscription(this AzureCachePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCachePurgeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings SetDebug(this AzureCachePurgeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCachePurgeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings ResetDebug(this AzureCachePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCachePurgeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings SetHelp(this AzureCachePurgeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCachePurgeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings ResetHelp(this AzureCachePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCachePurgeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings SetOutput(this AzureCachePurgeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCachePurgeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings ResetOutput(this AzureCachePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCachePurgeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings SetQuery(this AzureCachePurgeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCachePurgeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings ResetQuery(this AzureCachePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCachePurgeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings SetVerbose(this AzureCachePurgeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCachePurgeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCachePurgeSettings ResetVerbose(this AzureCachePurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCacheShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCacheTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCacheShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Name"/></em></p>
        ///   <p>The resource name.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetName(this AzureCacheShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Name"/></em></p>
        ///   <p>The resource name.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetName(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetResourceGroup(this AzureCacheShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetResourceGroup(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetResourceType(this AzureCacheShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetResourceType(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetSubscription(this AzureCacheShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetSubscription(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetDebug(this AzureCacheShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetDebug(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetHelp(this AzureCacheShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetHelp(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetOutput(this AzureCacheShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetOutput(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetQuery(this AzureCacheShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetQuery(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCacheShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings SetVerbose(this AzureCacheShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCacheShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCacheShowSettings ResetVerbose(this AzureCacheShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
