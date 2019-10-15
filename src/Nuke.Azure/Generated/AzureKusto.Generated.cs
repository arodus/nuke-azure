// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureKusto.json
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
    public static partial class AzureKustoTasks
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public static string AzureKustoPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREKUSTO_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureKustoLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Kusto resources.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKusto(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureKustoPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureKustoLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKusto(AzureKustoSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKusto(Configure<AzureKustoSettings> configurator)
        {
            return AzureKusto(configurator(new AzureKustoSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoSettings Settings, IReadOnlyCollection<Output> Output)> AzureKusto(CombinatorialConfigure<AzureKustoSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKusto, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseCreate(AzureKustoDatabaseCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoDatabaseCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseCreateSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseCreateSettings.Help"/></li>
        ///     <li><c>--hot-cache-period</c> via <see cref="AzureKustoDatabaseCreateSettings.HotCachePeriod"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--soft-delete-period</c> via <see cref="AzureKustoDatabaseCreateSettings.SoftDeletePeriod"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseCreate(Configure<AzureKustoDatabaseCreateSettings> configurator)
        {
            return AzureKustoDatabaseCreate(configurator(new AzureKustoDatabaseCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseCreateSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseCreateSettings.Help"/></li>
        ///     <li><c>--hot-cache-period</c> via <see cref="AzureKustoDatabaseCreateSettings.HotCachePeriod"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--soft-delete-period</c> via <see cref="AzureKustoDatabaseCreateSettings.SoftDeletePeriod"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoDatabaseCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoDatabaseCreate(CombinatorialConfigure<AzureKustoDatabaseCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoDatabaseCreate, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseDelete(AzureKustoDatabaseDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoDatabaseDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseDeleteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureKustoDatabaseDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseDelete(Configure<AzureKustoDatabaseDeleteSettings> configurator)
        {
            return AzureKustoDatabaseDelete(configurator(new AzureKustoDatabaseDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseDeleteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureKustoDatabaseDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoDatabaseDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoDatabaseDelete(CombinatorialConfigure<AzureKustoDatabaseDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoDatabaseDelete, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseList(AzureKustoDatabaseListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoDatabaseListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseListSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseList(Configure<AzureKustoDatabaseListSettings> configurator)
        {
            return AzureKustoDatabaseList(configurator(new AzureKustoDatabaseListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseListSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoDatabaseListSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoDatabaseList(CombinatorialConfigure<AzureKustoDatabaseListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoDatabaseList, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseShow(AzureKustoDatabaseShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoDatabaseShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseShowSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseShow(Configure<AzureKustoDatabaseShowSettings> configurator)
        {
            return AzureKustoDatabaseShow(configurator(new AzureKustoDatabaseShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseShowSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoDatabaseShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoDatabaseShow(CombinatorialConfigure<AzureKustoDatabaseShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoDatabaseShow, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseUpdate(AzureKustoDatabaseUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoDatabaseUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureKustoDatabaseUpdateSettings.Add"/></li>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseUpdateSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureKustoDatabaseUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseUpdateSettings.Help"/></li>
        ///     <li><c>--hot-cache-period</c> via <see cref="AzureKustoDatabaseUpdateSettings.HotCachePeriod"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureKustoDatabaseUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureKustoDatabaseUpdateSettings.Set"/></li>
        ///     <li><c>--soft-delete-period</c> via <see cref="AzureKustoDatabaseUpdateSettings.SoftDeletePeriod"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseUpdate(Configure<AzureKustoDatabaseUpdateSettings> configurator)
        {
            return AzureKustoDatabaseUpdate(configurator(new AzureKustoDatabaseUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureKustoDatabaseUpdateSettings.Add"/></li>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseUpdateSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureKustoDatabaseUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseUpdateSettings.Help"/></li>
        ///     <li><c>--hot-cache-period</c> via <see cref="AzureKustoDatabaseUpdateSettings.HotCachePeriod"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureKustoDatabaseUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureKustoDatabaseUpdateSettings.Set"/></li>
        ///     <li><c>--soft-delete-period</c> via <see cref="AzureKustoDatabaseUpdateSettings.SoftDeletePeriod"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoDatabaseUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoDatabaseUpdate(CombinatorialConfigure<AzureKustoDatabaseUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoDatabaseUpdate, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseWait(AzureKustoDatabaseWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoDatabaseWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseWaitSettings.ClusterName"/></li>
        ///     <li><c>--created</c> via <see cref="AzureKustoDatabaseWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureKustoDatabaseWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureKustoDatabaseWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureKustoDatabaseWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureKustoDatabaseWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureKustoDatabaseWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureKustoDatabaseWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoDatabaseWait(Configure<AzureKustoDatabaseWaitSettings> configurator)
        {
            return AzureKustoDatabaseWait(configurator(new AzureKustoDatabaseWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureKustoDatabaseWaitSettings.ClusterName"/></li>
        ///     <li><c>--created</c> via <see cref="AzureKustoDatabaseWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureKustoDatabaseWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoDatabaseWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureKustoDatabaseWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureKustoDatabaseWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoDatabaseWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoDatabaseWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureKustoDatabaseWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoDatabaseWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoDatabaseWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoDatabaseWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoDatabaseWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoDatabaseWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureKustoDatabaseWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureKustoDatabaseWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoDatabaseWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoDatabaseWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoDatabaseWait(CombinatorialConfigure<AzureKustoDatabaseWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoDatabaseWait, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterCreate(AzureKustoClusterCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--capacity</c> via <see cref="AzureKustoClusterCreateSettings.Capacity"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureKustoClusterCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoClusterCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureKustoClusterCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterCreate(Configure<AzureKustoClusterCreateSettings> configurator)
        {
            return AzureKustoClusterCreate(configurator(new AzureKustoClusterCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--capacity</c> via <see cref="AzureKustoClusterCreateSettings.Capacity"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureKustoClusterCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoClusterCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureKustoClusterCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterCreate(CombinatorialConfigure<AzureKustoClusterCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterCreate, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterDelete(AzureKustoClusterDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureKustoClusterDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterDelete(Configure<AzureKustoClusterDeleteSettings> configurator)
        {
            return AzureKustoClusterDelete(configurator(new AzureKustoClusterDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureKustoClusterDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterDelete(CombinatorialConfigure<AzureKustoClusterDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterDelete, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterList(AzureKustoClusterListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterList(Configure<AzureKustoClusterListSettings> configurator)
        {
            return AzureKustoClusterList(configurator(new AzureKustoClusterListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterListSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterList(CombinatorialConfigure<AzureKustoClusterListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterList, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterShow(AzureKustoClusterShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterShow(Configure<AzureKustoClusterShowSettings> configurator)
        {
            return AzureKustoClusterShow(configurator(new AzureKustoClusterShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterShow(CombinatorialConfigure<AzureKustoClusterShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterShow, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterStart(AzureKustoClusterStartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterStartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterStartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterStartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoClusterStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterStartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterStart(Configure<AzureKustoClusterStartSettings> configurator)
        {
            return AzureKustoClusterStart(configurator(new AzureKustoClusterStartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterStartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterStartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoClusterStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterStartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterStartSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterStart(CombinatorialConfigure<AzureKustoClusterStartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterStart, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterStop(AzureKustoClusterStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterStopSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoClusterStopSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterStop(Configure<AzureKustoClusterStopSettings> configurator)
        {
            return AzureKustoClusterStop(configurator(new AzureKustoClusterStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterStopSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureKustoClusterStopSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterStopSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterStop(CombinatorialConfigure<AzureKustoClusterStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterStop, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterUpdate(AzureKustoClusterUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureKustoClusterUpdateSettings.Add"/></li>
        ///     <li><c>--capacity</c> via <see cref="AzureKustoClusterUpdateSettings.Capacity"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureKustoClusterUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureKustoClusterUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureKustoClusterUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureKustoClusterUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterUpdate(Configure<AzureKustoClusterUpdateSettings> configurator)
        {
            return AzureKustoClusterUpdate(configurator(new AzureKustoClusterUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureKustoClusterUpdateSettings.Add"/></li>
        ///     <li><c>--capacity</c> via <see cref="AzureKustoClusterUpdateSettings.Capacity"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureKustoClusterUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureKustoClusterUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureKustoClusterUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureKustoClusterUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterUpdate(CombinatorialConfigure<AzureKustoClusterUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterUpdate, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureKustoClusterWait(AzureKustoClusterWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureKustoClusterWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureKustoClusterWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureKustoClusterWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureKustoClusterWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureKustoClusterWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureKustoClusterWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureKustoClusterWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureKustoClusterWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureKustoClusterWait(Configure<AzureKustoClusterWaitSettings> configurator)
        {
            return AzureKustoClusterWait(configurator(new AzureKustoClusterWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kusto resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/kusto?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureKustoClusterWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureKustoClusterWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureKustoClusterWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureKustoClusterWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureKustoClusterWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureKustoClusterWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureKustoClusterWaitSettings.Ids"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureKustoClusterWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureKustoClusterWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureKustoClusterWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureKustoClusterWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureKustoClusterWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureKustoClusterWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureKustoClusterWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureKustoClusterWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureKustoClusterWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureKustoClusterWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureKustoClusterWait(CombinatorialConfigure<AzureKustoClusterWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureKustoClusterWait, AzureKustoLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureKustoSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
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
              .Add("kusto")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKustoDatabaseCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoDatabaseCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Amount of time that data should be kept in cache.Duration in ISO8601 format (for example, 100 days would be P100D).
        /// </summary>
        public virtual string HotCachePeriod { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Amount of time that data should be kept so it is available to query. Duration in ISO8601 format (for example, 100 days would be P100D).
        /// </summary>
        public virtual string SoftDeletePeriod { get; internal set; }
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
              .Add("kusto database create")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--hot-cache-period {value}", HotCachePeriod)
              .Add("--no-wait", NoWait)
              .Add("--soft-delete-period {value}", SoftDeletePeriod)
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
    #region AzureKustoDatabaseDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoDatabaseDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto database delete")
              .Add("--yes {value}", Yes)
              .Add("--cluster-name {value}", ClusterName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoDatabaseListSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoDatabaseListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto database list")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoDatabaseShowSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoDatabaseShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto database show")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoDatabaseUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoDatabaseUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   Amount of time that data should be kept so it is available to query. Duration in ISO8601 format (for example, 100 days would be P100D).
        /// </summary>
        public virtual string SoftDeletePeriod { get; internal set; }
        /// <summary>
        ///   Amount of time that data should be kept in cache.Duration in ISO8601 format (for example, 100 days would be P100D).
        /// </summary>
        public virtual string HotCachePeriod { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.
        /// </summary>
        public virtual string Add { get; internal set; }
        /// <summary>
        ///   When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public virtual string ForceString { get; internal set; }
        /// <summary>
        ///   Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.
        /// </summary>
        public virtual string Remove { get; internal set; }
        /// <summary>
        ///   Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.
        /// </summary>
        public virtual string Set { get; internal set; }
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
              .Add("kusto database update")
              .Add("--soft-delete-period {value}", SoftDeletePeriod)
              .Add("--hot-cache-period {value}", HotCachePeriod)
              .Add("--no-wait", NoWait)
              .Add("--cluster-name {value}", ClusterName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKustoDatabaseWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoDatabaseWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the database.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
        /// <summary>
        ///   Wait until the resource exists.
        /// </summary>
        public virtual string Exists { get; internal set; }
        /// <summary>
        ///   Polling interval in seconds.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Maximum wait in seconds.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
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
              .Add("kusto database wait")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKustoClusterCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name of the sku.
        /// </summary>
        public virtual KustoClusterSku Sku { get; internal set; }
        /// <summary>
        ///   The instance number of the VM.
        /// </summary>
        public virtual string Capacity { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("kusto cluster create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--capacity {value}", Capacity)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
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
    #region AzureKustoClusterDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto cluster delete")
              .Add("--yes {value}", Yes)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoClusterListSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto cluster list")
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoClusterShowSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto cluster show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoClusterStartSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterStartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto cluster start")
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoClusterStopSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("kusto cluster stop")
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureKustoClusterUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   The instance number of the VM.
        /// </summary>
        public virtual string Capacity { get; internal set; }
        /// <summary>
        ///   The name of the sku.
        /// </summary>
        public virtual KustoClusterSku Sku { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.
        /// </summary>
        public virtual string Add { get; internal set; }
        /// <summary>
        ///   When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public virtual string ForceString { get; internal set; }
        /// <summary>
        ///   Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.
        /// </summary>
        public virtual string Remove { get; internal set; }
        /// <summary>
        ///   Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.
        /// </summary>
        public virtual string Set { get; internal set; }
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
              .Add("kusto cluster update")
              .Add("--capacity {value}", Capacity)
              .Add("--sku {value}", Sku)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKustoClusterWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureKustoClusterWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureKusto executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureKustoTasks.AzureKustoPath;
        public override Action<OutputType, string> CustomLogger => AzureKustoTasks.AzureKustoLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.
        /// </summary>
        public virtual string Subscription { get; internal set; }
        /// <summary>
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
        /// <summary>
        ///   Wait until the resource exists.
        /// </summary>
        public virtual string Exists { get; internal set; }
        /// <summary>
        ///   Polling interval in seconds.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Maximum wait in seconds.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
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
              .Add("kusto cluster wait")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureKustoSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings SetDebug(this AzureKustoSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings ResetDebug(this AzureKustoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings SetHelp(this AzureKustoSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings ResetHelp(this AzureKustoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings SetOutput(this AzureKustoSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings ResetOutput(this AzureKustoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings SetQuery(this AzureKustoSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings ResetQuery(this AzureKustoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings SetVerbose(this AzureKustoSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoSettings ResetVerbose(this AzureKustoSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoDatabaseCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoDatabaseCreateSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetClusterName(this AzureKustoDatabaseCreateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetClusterName(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetName(this AzureKustoDatabaseCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetName(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetResourceGroup(this AzureKustoDatabaseCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetResourceGroup(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region HotCachePeriod
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.HotCachePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept in cache.Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetHotCachePeriod(this AzureKustoDatabaseCreateSettings toolSettings, string hotCachePeriod)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HotCachePeriod = hotCachePeriod;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.HotCachePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept in cache.Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetHotCachePeriod(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HotCachePeriod = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetNoWait(this AzureKustoDatabaseCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetNoWait(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings EnableNoWait(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings DisableNoWait(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureKustoDatabaseCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ToggleNoWait(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SoftDeletePeriod
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.SoftDeletePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept so it is available to query. Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetSoftDeletePeriod(this AzureKustoDatabaseCreateSettings toolSettings, string softDeletePeriod)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SoftDeletePeriod = softDeletePeriod;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.SoftDeletePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept so it is available to query. Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetSoftDeletePeriod(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SoftDeletePeriod = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetSubscription(this AzureKustoDatabaseCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetSubscription(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetDebug(this AzureKustoDatabaseCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetDebug(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetHelp(this AzureKustoDatabaseCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetHelp(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetOutput(this AzureKustoDatabaseCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetOutput(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetQuery(this AzureKustoDatabaseCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetQuery(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings SetVerbose(this AzureKustoDatabaseCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseCreateSettings ResetVerbose(this AzureKustoDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoDatabaseDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoDatabaseDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetYes(this AzureKustoDatabaseDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetYes(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetClusterName(this AzureKustoDatabaseDeleteSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetClusterName(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetIds(this AzureKustoDatabaseDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetIds(this AzureKustoDatabaseDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings AddIds(this AzureKustoDatabaseDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings AddIds(this AzureKustoDatabaseDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ClearIds(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings RemoveIds(this AzureKustoDatabaseDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings RemoveIds(this AzureKustoDatabaseDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetName(this AzureKustoDatabaseDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetName(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetResourceGroup(this AzureKustoDatabaseDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetResourceGroup(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetSubscription(this AzureKustoDatabaseDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetSubscription(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetDebug(this AzureKustoDatabaseDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetDebug(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetHelp(this AzureKustoDatabaseDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetHelp(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetOutput(this AzureKustoDatabaseDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetOutput(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetQuery(this AzureKustoDatabaseDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetQuery(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings SetVerbose(this AzureKustoDatabaseDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseDeleteSettings ResetVerbose(this AzureKustoDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoDatabaseListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoDatabaseListSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetClusterName(this AzureKustoDatabaseListSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetClusterName(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetResourceGroup(this AzureKustoDatabaseListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetResourceGroup(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetSubscription(this AzureKustoDatabaseListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetSubscription(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetDebug(this AzureKustoDatabaseListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetDebug(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetHelp(this AzureKustoDatabaseListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetHelp(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetOutput(this AzureKustoDatabaseListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetOutput(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetQuery(this AzureKustoDatabaseListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetQuery(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings SetVerbose(this AzureKustoDatabaseListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseListSettings ResetVerbose(this AzureKustoDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoDatabaseShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoDatabaseShowSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetClusterName(this AzureKustoDatabaseShowSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetClusterName(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetIds(this AzureKustoDatabaseShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetIds(this AzureKustoDatabaseShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings AddIds(this AzureKustoDatabaseShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings AddIds(this AzureKustoDatabaseShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoDatabaseShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ClearIds(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings RemoveIds(this AzureKustoDatabaseShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings RemoveIds(this AzureKustoDatabaseShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetName(this AzureKustoDatabaseShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetName(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetResourceGroup(this AzureKustoDatabaseShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetResourceGroup(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetSubscription(this AzureKustoDatabaseShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetSubscription(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetDebug(this AzureKustoDatabaseShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetDebug(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetHelp(this AzureKustoDatabaseShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetHelp(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetOutput(this AzureKustoDatabaseShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetOutput(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetQuery(this AzureKustoDatabaseShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetQuery(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings SetVerbose(this AzureKustoDatabaseShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseShowSettings ResetVerbose(this AzureKustoDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoDatabaseUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoDatabaseUpdateSettingsExtensions
    {
        #region SoftDeletePeriod
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.SoftDeletePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept so it is available to query. Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetSoftDeletePeriod(this AzureKustoDatabaseUpdateSettings toolSettings, string softDeletePeriod)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SoftDeletePeriod = softDeletePeriod;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.SoftDeletePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept so it is available to query. Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetSoftDeletePeriod(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SoftDeletePeriod = null;
            return toolSettings;
        }
        #endregion
        #region HotCachePeriod
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.HotCachePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept in cache.Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetHotCachePeriod(this AzureKustoDatabaseUpdateSettings toolSettings, string hotCachePeriod)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HotCachePeriod = hotCachePeriod;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.HotCachePeriod"/></em></p>
        ///   <p>Amount of time that data should be kept in cache.Duration in ISO8601 format (for example, 100 days would be P100D).</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetHotCachePeriod(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HotCachePeriod = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetNoWait(this AzureKustoDatabaseUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetNoWait(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings EnableNoWait(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings DisableNoWait(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureKustoDatabaseUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ToggleNoWait(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetClusterName(this AzureKustoDatabaseUpdateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetClusterName(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetIds(this AzureKustoDatabaseUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetIds(this AzureKustoDatabaseUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings AddIds(this AzureKustoDatabaseUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings AddIds(this AzureKustoDatabaseUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ClearIds(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings RemoveIds(this AzureKustoDatabaseUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings RemoveIds(this AzureKustoDatabaseUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetName(this AzureKustoDatabaseUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetName(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetResourceGroup(this AzureKustoDatabaseUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetResourceGroup(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetSubscription(this AzureKustoDatabaseUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetSubscription(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetAdd(this AzureKustoDatabaseUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetAdd(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetForceString(this AzureKustoDatabaseUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetForceString(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetRemove(this AzureKustoDatabaseUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetRemove(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetSet(this AzureKustoDatabaseUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetSet(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetDebug(this AzureKustoDatabaseUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetDebug(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetHelp(this AzureKustoDatabaseUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetHelp(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetOutput(this AzureKustoDatabaseUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetOutput(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetQuery(this AzureKustoDatabaseUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetQuery(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings SetVerbose(this AzureKustoDatabaseUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseUpdateSettings ResetVerbose(this AzureKustoDatabaseUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoDatabaseWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoDatabaseWaitSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetClusterName(this AzureKustoDatabaseWaitSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetClusterName(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetIds(this AzureKustoDatabaseWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetIds(this AzureKustoDatabaseWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings AddIds(this AzureKustoDatabaseWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoDatabaseWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings AddIds(this AzureKustoDatabaseWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoDatabaseWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ClearIds(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings RemoveIds(this AzureKustoDatabaseWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoDatabaseWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings RemoveIds(this AzureKustoDatabaseWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetName(this AzureKustoDatabaseWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Name"/></em></p>
        ///   <p>The name of the database.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetName(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetResourceGroup(this AzureKustoDatabaseWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetResourceGroup(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetSubscription(this AzureKustoDatabaseWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetSubscription(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetCreated(this AzureKustoDatabaseWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetCreated(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetCustom(this AzureKustoDatabaseWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetCustom(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetDeleted(this AzureKustoDatabaseWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetDeleted(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetExists(this AzureKustoDatabaseWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetExists(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetInterval(this AzureKustoDatabaseWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetInterval(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetTimeout(this AzureKustoDatabaseWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetTimeout(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetUpdated(this AzureKustoDatabaseWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetUpdated(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetDebug(this AzureKustoDatabaseWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetDebug(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetHelp(this AzureKustoDatabaseWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetHelp(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetOutput(this AzureKustoDatabaseWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetOutput(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetQuery(this AzureKustoDatabaseWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetQuery(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoDatabaseWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings SetVerbose(this AzureKustoDatabaseWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoDatabaseWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoDatabaseWaitSettings ResetVerbose(this AzureKustoDatabaseWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetName(this AzureKustoClusterCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetName(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetResourceGroup(this AzureKustoClusterCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetResourceGroup(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Sku"/></em></p>
        ///   <p>The name of the sku.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetSku(this AzureKustoClusterCreateSettings toolSettings, KustoClusterSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Sku"/></em></p>
        ///   <p>The name of the sku.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetSku(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Capacity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Capacity"/></em></p>
        ///   <p>The instance number of the VM.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetCapacity(this AzureKustoClusterCreateSettings toolSettings, string capacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = capacity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Capacity"/></em></p>
        ///   <p>The instance number of the VM.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetCapacity(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetLocation(this AzureKustoClusterCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetLocation(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetNoWait(this AzureKustoClusterCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetNoWait(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureKustoClusterCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings EnableNoWait(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureKustoClusterCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings DisableNoWait(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureKustoClusterCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ToggleNoWait(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetSubscription(this AzureKustoClusterCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetSubscription(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetDebug(this AzureKustoClusterCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetDebug(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetHelp(this AzureKustoClusterCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetHelp(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetOutput(this AzureKustoClusterCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetOutput(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetQuery(this AzureKustoClusterCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetQuery(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings SetVerbose(this AzureKustoClusterCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterCreateSettings ResetVerbose(this AzureKustoClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetYes(this AzureKustoClusterDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetYes(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetIds(this AzureKustoClusterDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetIds(this AzureKustoClusterDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings AddIds(this AzureKustoClusterDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings AddIds(this AzureKustoClusterDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ClearIds(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings RemoveIds(this AzureKustoClusterDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings RemoveIds(this AzureKustoClusterDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetName(this AzureKustoClusterDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetName(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetResourceGroup(this AzureKustoClusterDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetResourceGroup(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetSubscription(this AzureKustoClusterDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetSubscription(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetDebug(this AzureKustoClusterDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetDebug(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetHelp(this AzureKustoClusterDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetHelp(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetOutput(this AzureKustoClusterDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetOutput(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetQuery(this AzureKustoClusterDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetQuery(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings SetVerbose(this AzureKustoClusterDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterDeleteSettings ResetVerbose(this AzureKustoClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetResourceGroup(this AzureKustoClusterListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetResourceGroup(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetSubscription(this AzureKustoClusterListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetSubscription(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetDebug(this AzureKustoClusterListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetDebug(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetHelp(this AzureKustoClusterListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetHelp(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetOutput(this AzureKustoClusterListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetOutput(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetQuery(this AzureKustoClusterListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetQuery(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings SetVerbose(this AzureKustoClusterListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterListSettings ResetVerbose(this AzureKustoClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetIds(this AzureKustoClusterShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetIds(this AzureKustoClusterShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings AddIds(this AzureKustoClusterShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings AddIds(this AzureKustoClusterShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ClearIds(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings RemoveIds(this AzureKustoClusterShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings RemoveIds(this AzureKustoClusterShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetName(this AzureKustoClusterShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetName(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetResourceGroup(this AzureKustoClusterShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetResourceGroup(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetSubscription(this AzureKustoClusterShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetSubscription(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetDebug(this AzureKustoClusterShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetDebug(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetHelp(this AzureKustoClusterShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetHelp(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetOutput(this AzureKustoClusterShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetOutput(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetQuery(this AzureKustoClusterShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetQuery(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings SetVerbose(this AzureKustoClusterShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterShowSettings ResetVerbose(this AzureKustoClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterStartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterStartSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetNoWait(this AzureKustoClusterStartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetNoWait(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureKustoClusterStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings EnableNoWait(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureKustoClusterStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings DisableNoWait(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureKustoClusterStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ToggleNoWait(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetIds(this AzureKustoClusterStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetIds(this AzureKustoClusterStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings AddIds(this AzureKustoClusterStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings AddIds(this AzureKustoClusterStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoClusterStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ClearIds(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings RemoveIds(this AzureKustoClusterStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings RemoveIds(this AzureKustoClusterStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetName(this AzureKustoClusterStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetName(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetResourceGroup(this AzureKustoClusterStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetResourceGroup(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetSubscription(this AzureKustoClusterStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetSubscription(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetDebug(this AzureKustoClusterStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetDebug(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetHelp(this AzureKustoClusterStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetHelp(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetOutput(this AzureKustoClusterStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetOutput(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetQuery(this AzureKustoClusterStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetQuery(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings SetVerbose(this AzureKustoClusterStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStartSettings ResetVerbose(this AzureKustoClusterStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterStopSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetNoWait(this AzureKustoClusterStopSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetNoWait(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureKustoClusterStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings EnableNoWait(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureKustoClusterStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings DisableNoWait(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureKustoClusterStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ToggleNoWait(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetIds(this AzureKustoClusterStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetIds(this AzureKustoClusterStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings AddIds(this AzureKustoClusterStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings AddIds(this AzureKustoClusterStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoClusterStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ClearIds(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings RemoveIds(this AzureKustoClusterStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings RemoveIds(this AzureKustoClusterStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetName(this AzureKustoClusterStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetName(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetResourceGroup(this AzureKustoClusterStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetResourceGroup(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetSubscription(this AzureKustoClusterStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetSubscription(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetDebug(this AzureKustoClusterStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetDebug(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetHelp(this AzureKustoClusterStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetHelp(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetOutput(this AzureKustoClusterStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetOutput(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetQuery(this AzureKustoClusterStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetQuery(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings SetVerbose(this AzureKustoClusterStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterStopSettings ResetVerbose(this AzureKustoClusterStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterUpdateSettingsExtensions
    {
        #region Capacity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Capacity"/></em></p>
        ///   <p>The instance number of the VM.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetCapacity(this AzureKustoClusterUpdateSettings toolSettings, string capacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = capacity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Capacity"/></em></p>
        ///   <p>The instance number of the VM.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetCapacity(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Sku"/></em></p>
        ///   <p>The name of the sku.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetSku(this AzureKustoClusterUpdateSettings toolSettings, KustoClusterSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Sku"/></em></p>
        ///   <p>The name of the sku.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetSku(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetIds(this AzureKustoClusterUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetIds(this AzureKustoClusterUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings AddIds(this AzureKustoClusterUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings AddIds(this AzureKustoClusterUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoClusterUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ClearIds(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings RemoveIds(this AzureKustoClusterUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings RemoveIds(this AzureKustoClusterUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetName(this AzureKustoClusterUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetName(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetResourceGroup(this AzureKustoClusterUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetResourceGroup(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetSubscription(this AzureKustoClusterUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetSubscription(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetAdd(this AzureKustoClusterUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetAdd(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetForceString(this AzureKustoClusterUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetForceString(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetRemove(this AzureKustoClusterUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetRemove(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetSet(this AzureKustoClusterUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetSet(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetDebug(this AzureKustoClusterUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetDebug(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetHelp(this AzureKustoClusterUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetHelp(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetOutput(this AzureKustoClusterUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetOutput(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetQuery(this AzureKustoClusterUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetQuery(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings SetVerbose(this AzureKustoClusterUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterUpdateSettings ResetVerbose(this AzureKustoClusterUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureKustoClusterWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureKustoClusterWaitSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetIds(this AzureKustoClusterWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetIds(this AzureKustoClusterWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings AddIds(this AzureKustoClusterWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureKustoClusterWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings AddIds(this AzureKustoClusterWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureKustoClusterWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ClearIds(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings RemoveIds(this AzureKustoClusterWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureKustoClusterWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings RemoveIds(this AzureKustoClusterWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetName(this AzureKustoClusterWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetName(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetResourceGroup(this AzureKustoClusterWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetResourceGroup(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetSubscription(this AzureKustoClusterWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetSubscription(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetCreated(this AzureKustoClusterWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetCreated(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetCustom(this AzureKustoClusterWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetCustom(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetDeleted(this AzureKustoClusterWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetDeleted(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetExists(this AzureKustoClusterWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetExists(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetInterval(this AzureKustoClusterWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetInterval(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetTimeout(this AzureKustoClusterWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetTimeout(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetUpdated(this AzureKustoClusterWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetUpdated(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetDebug(this AzureKustoClusterWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetDebug(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetHelp(this AzureKustoClusterWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetHelp(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetOutput(this AzureKustoClusterWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetOutput(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetQuery(this AzureKustoClusterWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetQuery(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureKustoClusterWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings SetVerbose(this AzureKustoClusterWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureKustoClusterWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureKustoClusterWaitSettings ResetVerbose(this AzureKustoClusterWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region KustoClusterSku
    /// <summary>
    ///   Used within <see cref="AzureKustoTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<KustoClusterSku>))]
    public partial class KustoClusterSku : Enumeration
    {
        public static KustoClusterSku d11_v2 = new KustoClusterSku { Value = "d11_v2" };
        public static KustoClusterSku d12_v2 = new KustoClusterSku { Value = "d12_v2" };
        public static KustoClusterSku d13_v2 = new KustoClusterSku { Value = "d13_v2" };
        public static KustoClusterSku d14_v2 = new KustoClusterSku { Value = "d14_v2" };
        public static KustoClusterSku l16 = new KustoClusterSku { Value = "l16" };
        public static KustoClusterSku l4 = new KustoClusterSku { Value = "l4" };
        public static KustoClusterSku l8 = new KustoClusterSku { Value = "l8" };
    }
    #endregion
}
