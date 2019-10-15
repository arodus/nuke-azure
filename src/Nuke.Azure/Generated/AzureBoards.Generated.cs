// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureBoards.json
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
    public static partial class AzureBoardsTasks
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public static string AzureBoardsPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREBOARDS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureBoardsLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Boards.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoards(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureBoardsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureBoardsLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsQuery(AzureBoardsQuerySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsQuerySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsQuerySettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsQuerySettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsQuerySettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsQuerySettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsQuerySettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsQuerySettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsQuerySettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsQuerySettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsQuerySettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsQuerySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsQuerySettings.Verbose"/></li>
        ///     <li><c>--wiql</c> via <see cref="AzureBoardsQuerySettings.Wiql"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsQuery(Configure<AzureBoardsQuerySettings> configurator)
        {
            return AzureBoardsQuery(configurator(new AzureBoardsQuerySettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsQuerySettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsQuerySettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsQuerySettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsQuerySettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsQuerySettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsQuerySettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsQuerySettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsQuerySettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsQuerySettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsQuerySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsQuerySettings.Verbose"/></li>
        ///     <li><c>--wiql</c> via <see cref="AzureBoardsQuerySettings.Wiql"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsQuerySettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsQuery(CombinatorialConfigure<AzureBoardsQuerySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsQuery, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemCreate(AzureBoardsWorkItemCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--area</c> via <see cref="AzureBoardsWorkItemCreateSettings.Area"/></li>
        ///     <li><c>--assigned-to</c> via <see cref="AzureBoardsWorkItemCreateSettings.AssignedTo"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureBoardsWorkItemCreateSettings.Description"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></li>
        ///     <li><c>--discussion</c> via <see cref="AzureBoardsWorkItemCreateSettings.Discussion"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemCreateSettings.Help"/></li>
        ///     <li><c>--iteration</c> via <see cref="AzureBoardsWorkItemCreateSettings.Iteration"/></li>
        ///     <li><c>--open</c> via <see cref="AzureBoardsWorkItemCreateSettings.Open"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemCreateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemCreateSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsWorkItemCreateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemCreateSettings.Query"/></li>
        ///     <li><c>--reason</c> via <see cref="AzureBoardsWorkItemCreateSettings.Reason"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemCreateSettings.Subscription"/></li>
        ///     <li><c>--title</c> via <see cref="AzureBoardsWorkItemCreateSettings.Title"/></li>
        ///     <li><c>--type</c> via <see cref="AzureBoardsWorkItemCreateSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemCreate(Configure<AzureBoardsWorkItemCreateSettings> configurator)
        {
            return AzureBoardsWorkItemCreate(configurator(new AzureBoardsWorkItemCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--area</c> via <see cref="AzureBoardsWorkItemCreateSettings.Area"/></li>
        ///     <li><c>--assigned-to</c> via <see cref="AzureBoardsWorkItemCreateSettings.AssignedTo"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureBoardsWorkItemCreateSettings.Description"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></li>
        ///     <li><c>--discussion</c> via <see cref="AzureBoardsWorkItemCreateSettings.Discussion"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemCreateSettings.Help"/></li>
        ///     <li><c>--iteration</c> via <see cref="AzureBoardsWorkItemCreateSettings.Iteration"/></li>
        ///     <li><c>--open</c> via <see cref="AzureBoardsWorkItemCreateSettings.Open"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemCreateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemCreateSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsWorkItemCreateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemCreateSettings.Query"/></li>
        ///     <li><c>--reason</c> via <see cref="AzureBoardsWorkItemCreateSettings.Reason"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemCreateSettings.Subscription"/></li>
        ///     <li><c>--title</c> via <see cref="AzureBoardsWorkItemCreateSettings.Title"/></li>
        ///     <li><c>--type</c> via <see cref="AzureBoardsWorkItemCreateSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemCreate(CombinatorialConfigure<AzureBoardsWorkItemCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemCreate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemDelete(AzureBoardsWorkItemDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Debug"/></li>
        ///     <li><c>--destroy</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Destroy"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemDelete(Configure<AzureBoardsWorkItemDeleteSettings> configurator)
        {
            return AzureBoardsWorkItemDelete(configurator(new AzureBoardsWorkItemDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Debug"/></li>
        ///     <li><c>--destroy</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Destroy"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsWorkItemDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemDelete(CombinatorialConfigure<AzureBoardsWorkItemDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemDelete, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemShow(AzureBoardsWorkItemShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemShowSettings.Id"/></li>
        ///     <li><c>--open</c> via <see cref="AzureBoardsWorkItemShowSettings.Open"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemShow(Configure<AzureBoardsWorkItemShowSettings> configurator)
        {
            return AzureBoardsWorkItemShow(configurator(new AzureBoardsWorkItemShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemShowSettings.Id"/></li>
        ///     <li><c>--open</c> via <see cref="AzureBoardsWorkItemShowSettings.Open"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemShow(CombinatorialConfigure<AzureBoardsWorkItemShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemShow, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemUpdate(AzureBoardsWorkItemUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--area</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Area"/></li>
        ///     <li><c>--assigned-to</c> via <see cref="AzureBoardsWorkItemUpdateSettings.AssignedTo"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Description"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></li>
        ///     <li><c>--discussion</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Discussion"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Id"/></li>
        ///     <li><c>--iteration</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Iteration"/></li>
        ///     <li><c>--open</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Open"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Query"/></li>
        ///     <li><c>--reason</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Reason"/></li>
        ///     <li><c>--state</c> via <see cref="AzureBoardsWorkItemUpdateSettings.State"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Subscription"/></li>
        ///     <li><c>--title</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Title"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemUpdate(Configure<AzureBoardsWorkItemUpdateSettings> configurator)
        {
            return AzureBoardsWorkItemUpdate(configurator(new AzureBoardsWorkItemUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--area</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Area"/></li>
        ///     <li><c>--assigned-to</c> via <see cref="AzureBoardsWorkItemUpdateSettings.AssignedTo"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Description"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></li>
        ///     <li><c>--discussion</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Discussion"/></li>
        ///     <li><c>--fields</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Id"/></li>
        ///     <li><c>--iteration</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Iteration"/></li>
        ///     <li><c>--open</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Open"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Query"/></li>
        ///     <li><c>--reason</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Reason"/></li>
        ///     <li><c>--state</c> via <see cref="AzureBoardsWorkItemUpdateSettings.State"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Subscription"/></li>
        ///     <li><c>--title</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Title"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemUpdate(CombinatorialConfigure<AzureBoardsWorkItemUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemUpdate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsArea(AzureBoardsAreaSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsArea(Configure<AzureBoardsAreaSettings> configurator)
        {
            return AzureBoardsArea(configurator(new AzureBoardsAreaSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsArea(CombinatorialConfigure<AzureBoardsAreaSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsArea, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIteration(AzureBoardsIterationSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIteration(Configure<AzureBoardsIterationSettings> configurator)
        {
            return AzureBoardsIteration(configurator(new AzureBoardsIterationSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIteration(CombinatorialConfigure<AzureBoardsIterationSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIteration, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectCreate(AzureBoardsAreaProjectCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaProjectCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectCreate(Configure<AzureBoardsAreaProjectCreateSettings> configurator)
        {
            return AzureBoardsAreaProjectCreate(configurator(new AzureBoardsAreaProjectCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaProjectCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaProjectCreate(CombinatorialConfigure<AzureBoardsAreaProjectCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaProjectCreate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectDelete(AzureBoardsAreaProjectDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaProjectDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectDelete(Configure<AzureBoardsAreaProjectDeleteSettings> configurator)
        {
            return AzureBoardsAreaProjectDelete(configurator(new AzureBoardsAreaProjectDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsAreaProjectDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaProjectDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaProjectDelete(CombinatorialConfigure<AzureBoardsAreaProjectDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaProjectDelete, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectList(AzureBoardsAreaProjectListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaProjectListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectListSettings.Debug"/></li>
        ///     <li><c>--depth</c> via <see cref="AzureBoardsAreaProjectListSettings.Depth"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectListSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectListSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectList(Configure<AzureBoardsAreaProjectListSettings> configurator)
        {
            return AzureBoardsAreaProjectList(configurator(new AzureBoardsAreaProjectListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectListSettings.Debug"/></li>
        ///     <li><c>--depth</c> via <see cref="AzureBoardsAreaProjectListSettings.Depth"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectListSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectListSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaProjectListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaProjectList(CombinatorialConfigure<AzureBoardsAreaProjectListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaProjectList, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectShow(AzureBoardsAreaProjectShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaProjectShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsAreaProjectShowSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectShowSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectShowSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectShow(Configure<AzureBoardsAreaProjectShowSettings> configurator)
        {
            return AzureBoardsAreaProjectShow(configurator(new AzureBoardsAreaProjectShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsAreaProjectShowSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectShowSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectShowSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaProjectShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaProjectShow(CombinatorialConfigure<AzureBoardsAreaProjectShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaProjectShow, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectUpdate(AzureBoardsAreaProjectUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaProjectUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--child-id</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.ChildId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaProjectUpdate(Configure<AzureBoardsAreaProjectUpdateSettings> configurator)
        {
            return AzureBoardsAreaProjectUpdate(configurator(new AzureBoardsAreaProjectUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--child-id</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.ChildId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaProjectUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaProjectUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaProjectUpdate(CombinatorialConfigure<AzureBoardsAreaProjectUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaProjectUpdate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamAdd(AzureBoardsAreaTeamAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaTeamAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamAddSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamAddSettings.Help"/></li>
        ///     <li><c>--include-sub-areas</c> via <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamAddSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamAddSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaTeamAddSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamAddSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamAddSettings.Query"/></li>
        ///     <li><c>--set-as-default</c> via <see cref="AzureBoardsAreaTeamAddSettings.SetAsDefault"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamAddSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamAddSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamAdd(Configure<AzureBoardsAreaTeamAddSettings> configurator)
        {
            return AzureBoardsAreaTeamAdd(configurator(new AzureBoardsAreaTeamAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamAddSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamAddSettings.Help"/></li>
        ///     <li><c>--include-sub-areas</c> via <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamAddSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamAddSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaTeamAddSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamAddSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamAddSettings.Query"/></li>
        ///     <li><c>--set-as-default</c> via <see cref="AzureBoardsAreaTeamAddSettings.SetAsDefault"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamAddSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamAddSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaTeamAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaTeamAdd(CombinatorialConfigure<AzureBoardsAreaTeamAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaTeamAdd, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamList(AzureBoardsAreaTeamListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaTeamListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamListSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamListSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamListSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamListSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamList(Configure<AzureBoardsAreaTeamListSettings> configurator)
        {
            return AzureBoardsAreaTeamList(configurator(new AzureBoardsAreaTeamListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamListSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamListSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamListSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamListSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaTeamListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaTeamList(CombinatorialConfigure<AzureBoardsAreaTeamListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaTeamList, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamRemove(AzureBoardsAreaTeamRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaTeamRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamRemove(Configure<AzureBoardsAreaTeamRemoveSettings> configurator)
        {
            return AzureBoardsAreaTeamRemove(configurator(new AzureBoardsAreaTeamRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaTeamRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaTeamRemove(CombinatorialConfigure<AzureBoardsAreaTeamRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaTeamRemove, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamUpdate(AzureBoardsAreaTeamUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsAreaTeamUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Help"/></li>
        ///     <li><c>--include-sub-areas</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Query"/></li>
        ///     <li><c>--set-as-default</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.SetAsDefault"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsAreaTeamUpdate(Configure<AzureBoardsAreaTeamUpdateSettings> configurator)
        {
            return AzureBoardsAreaTeamUpdate(configurator(new AzureBoardsAreaTeamUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Help"/></li>
        ///     <li><c>--include-sub-areas</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Query"/></li>
        ///     <li><c>--set-as-default</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.SetAsDefault"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsAreaTeamUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsAreaTeamUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsAreaTeamUpdate(CombinatorialConfigure<AzureBoardsAreaTeamUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsAreaTeamUpdate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationAdd(AzureBoardsWorkItemRelationAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemRelationAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Query"/></li>
        ///     <li><c>--relation-type</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.RelationType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Subscription"/></li>
        ///     <li><c>--target-id</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.TargetId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationAdd(Configure<AzureBoardsWorkItemRelationAddSettings> configurator)
        {
            return AzureBoardsWorkItemRelationAdd(configurator(new AzureBoardsWorkItemRelationAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Query"/></li>
        ///     <li><c>--relation-type</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.RelationType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Subscription"/></li>
        ///     <li><c>--target-id</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.TargetId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemRelationAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemRelationAdd(CombinatorialConfigure<AzureBoardsWorkItemRelationAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemRelationAdd, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationListType(AzureBoardsWorkItemRelationListTypeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemRelationListTypeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationListType(Configure<AzureBoardsWorkItemRelationListTypeSettings> configurator)
        {
            return AzureBoardsWorkItemRelationListType(configurator(new AzureBoardsWorkItemRelationListTypeSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationListTypeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemRelationListTypeSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemRelationListType(CombinatorialConfigure<AzureBoardsWorkItemRelationListTypeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemRelationListType, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationRemove(AzureBoardsWorkItemRelationRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemRelationRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Query"/></li>
        ///     <li><c>--relation-type</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.RelationType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Subscription"/></li>
        ///     <li><c>--target-id</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.TargetId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationRemove(Configure<AzureBoardsWorkItemRelationRemoveSettings> configurator)
        {
            return AzureBoardsWorkItemRelationRemove(configurator(new AzureBoardsWorkItemRelationRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Query"/></li>
        ///     <li><c>--relation-type</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.RelationType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Subscription"/></li>
        ///     <li><c>--target-id</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.TargetId"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsWorkItemRelationRemoveSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemRelationRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemRelationRemove(CombinatorialConfigure<AzureBoardsWorkItemRelationRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemRelationRemove, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationShow(AzureBoardsWorkItemRelationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsWorkItemRelationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsWorkItemRelationShow(Configure<AzureBoardsWorkItemRelationShowSettings> configurator)
        {
            return AzureBoardsWorkItemRelationShow(configurator(new AzureBoardsWorkItemRelationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsWorkItemRelationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsWorkItemRelationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsWorkItemRelationShow(CombinatorialConfigure<AzureBoardsWorkItemRelationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsWorkItemRelationShow, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectCreate(AzureBoardsIterationProjectCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationProjectCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></li>
        ///     <li><c>--finish-date</c> via <see cref="AzureBoardsIterationProjectCreateSettings.FinishDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBoardsIterationProjectCreateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectCreate(Configure<AzureBoardsIterationProjectCreateSettings> configurator)
        {
            return AzureBoardsIterationProjectCreate(configurator(new AzureBoardsIterationProjectCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></li>
        ///     <li><c>--finish-date</c> via <see cref="AzureBoardsIterationProjectCreateSettings.FinishDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBoardsIterationProjectCreateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationProjectCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationProjectCreate(CombinatorialConfigure<AzureBoardsIterationProjectCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationProjectCreate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectDelete(AzureBoardsIterationProjectDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationProjectDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectDelete(Configure<AzureBoardsIterationProjectDeleteSettings> configurator)
        {
            return AzureBoardsIterationProjectDelete(configurator(new AzureBoardsIterationProjectDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureBoardsIterationProjectDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationProjectDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationProjectDelete(CombinatorialConfigure<AzureBoardsIterationProjectDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationProjectDelete, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectList(AzureBoardsIterationProjectListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationProjectListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectListSettings.Debug"/></li>
        ///     <li><c>--depth</c> via <see cref="AzureBoardsIterationProjectListSettings.Depth"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectListSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectListSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectList(Configure<AzureBoardsIterationProjectListSettings> configurator)
        {
            return AzureBoardsIterationProjectList(configurator(new AzureBoardsIterationProjectListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectListSettings.Debug"/></li>
        ///     <li><c>--depth</c> via <see cref="AzureBoardsIterationProjectListSettings.Depth"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectListSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectListSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationProjectListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationProjectList(CombinatorialConfigure<AzureBoardsIterationProjectListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationProjectList, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectShow(AzureBoardsIterationProjectShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationProjectShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationProjectShowSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectShowSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectShowSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectShow(Configure<AzureBoardsIterationProjectShowSettings> configurator)
        {
            return AzureBoardsIterationProjectShow(configurator(new AzureBoardsIterationProjectShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectShowSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectShowSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationProjectShowSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectShowSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectShowSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectShowSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationProjectShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationProjectShow(CombinatorialConfigure<AzureBoardsIterationProjectShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationProjectShow, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectUpdate(AzureBoardsIterationProjectUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationProjectUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--child-id</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.ChildId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></li>
        ///     <li><c>--finish-date</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.FinishDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationProjectUpdate(Configure<AzureBoardsIterationProjectUpdateSettings> configurator)
        {
            return AzureBoardsIterationProjectUpdate(configurator(new AzureBoardsIterationProjectUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--child-id</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.ChildId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></li>
        ///     <li><c>--finish-date</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.FinishDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Name"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Output"/></li>
        ///     <li><c>--path</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Path"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationProjectUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationProjectUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationProjectUpdate(CombinatorialConfigure<AzureBoardsIterationProjectUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationProjectUpdate, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamAdd(AzureBoardsIterationTeamAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamAddSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamAddSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamAddSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamAddSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamAddSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamAddSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamAddSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamAdd(Configure<AzureBoardsIterationTeamAddSettings> configurator)
        {
            return AzureBoardsIterationTeamAdd(configurator(new AzureBoardsIterationTeamAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamAddSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamAddSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamAddSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamAddSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamAddSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamAddSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamAddSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamAddSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamAddSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamAdd(CombinatorialConfigure<AzureBoardsIterationTeamAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamAdd, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamList(AzureBoardsIterationTeamListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamListSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamListSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamListSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamListSettings.Team"/></li>
        ///     <li><c>--timeframe</c> via <see cref="AzureBoardsIterationTeamListSettings.Timeframe"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamList(Configure<AzureBoardsIterationTeamListSettings> configurator)
        {
            return AzureBoardsIterationTeamList(configurator(new AzureBoardsIterationTeamListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamListSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamListSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamListSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamListSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamListSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamListSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamListSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamListSettings.Team"/></li>
        ///     <li><c>--timeframe</c> via <see cref="AzureBoardsIterationTeamListSettings.Timeframe"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamList(CombinatorialConfigure<AzureBoardsIterationTeamListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamList, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamListWorkItems(AzureBoardsIterationTeamListWorkItemsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamListWorkItemsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamListWorkItems(Configure<AzureBoardsIterationTeamListWorkItemsSettings> configurator)
        {
            return AzureBoardsIterationTeamListWorkItems(configurator(new AzureBoardsIterationTeamListWorkItemsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamListWorkItemsSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamListWorkItems(CombinatorialConfigure<AzureBoardsIterationTeamListWorkItemsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamListWorkItems, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamRemove(AzureBoardsIterationTeamRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamRemove(Configure<AzureBoardsIterationTeamRemoveSettings> configurator)
        {
            return AzureBoardsIterationTeamRemove(configurator(new AzureBoardsIterationTeamRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamRemove(CombinatorialConfigure<AzureBoardsIterationTeamRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamRemove, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamSetBacklogIteration(AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamSetBacklogIterationSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamSetBacklogIteration(Configure<AzureBoardsIterationTeamSetBacklogIterationSettings> configurator)
        {
            return AzureBoardsIterationTeamSetBacklogIteration(configurator(new AzureBoardsIterationTeamSetBacklogIterationSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamSetBacklogIterationSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamSetBacklogIteration(CombinatorialConfigure<AzureBoardsIterationTeamSetBacklogIterationSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamSetBacklogIteration, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamSetDefaultIteration(AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamSetDefaultIterationSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Debug"/></li>
        ///     <li><c>--default-iteration-macro</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.DefaultIterationMacro"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamSetDefaultIteration(Configure<AzureBoardsIterationTeamSetDefaultIterationSettings> configurator)
        {
            return AzureBoardsIterationTeamSetDefaultIteration(configurator(new AzureBoardsIterationTeamSetDefaultIterationSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Debug"/></li>
        ///     <li><c>--default-iteration-macro</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.DefaultIterationMacro"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Id"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamSetDefaultIterationSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamSetDefaultIteration(CombinatorialConfigure<AzureBoardsIterationTeamSetDefaultIterationSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamSetDefaultIteration, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamShowBacklogIteration(AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamShowBacklogIterationSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamShowBacklogIteration(Configure<AzureBoardsIterationTeamShowBacklogIterationSettings> configurator)
        {
            return AzureBoardsIterationTeamShowBacklogIteration(configurator(new AzureBoardsIterationTeamShowBacklogIterationSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamShowBacklogIterationSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamShowBacklogIteration(CombinatorialConfigure<AzureBoardsIterationTeamShowBacklogIterationSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamShowBacklogIteration, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamShowDefaultIteration(AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBoardsIterationTeamShowDefaultIterationSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBoardsIterationTeamShowDefaultIteration(Configure<AzureBoardsIterationTeamShowDefaultIterationSettings> configurator)
        {
            return AzureBoardsIterationTeamShowDefaultIteration(configurator(new AzureBoardsIterationTeamShowDefaultIterationSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Boards.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/boards?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Debug"/></li>
        ///     <li><c>--detect</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Help"/></li>
        ///     <li><c>--org</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Org"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Output"/></li>
        ///     <li><c>--project</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Project"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Subscription"/></li>
        ///     <li><c>--team</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Team"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBoardsIterationTeamShowDefaultIterationSettings Settings, IReadOnlyCollection<Output> Output)> AzureBoardsIterationTeamShowDefaultIteration(CombinatorialConfigure<AzureBoardsIterationTeamShowDefaultIterationSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBoardsIterationTeamShowDefaultIteration, AzureBoardsLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureBoardsQuerySettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsQuerySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   The ID of an existing query.  Required unless --path or --wiql are specified.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   The path of an existing query.  Ignored if --id is specified.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   The query in Work Item Query Language format.  Ignored if --id or --path is specified.
        /// </summary>
        public virtual string Wiql { get; internal set; }
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
              .Add("boards query")
              .Add("--detect", Detect)
              .Add("--id {value}", Id)
              .Add("--org {value}", Org)
              .Add("--path {value}", Path)
              .Add("--project {value}", Project)
              .Add("--wiql {value}", Wiql)
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
    #region AzureBoardsWorkItemCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Title of the work item.
        /// </summary>
        public virtual string Title { get; internal set; }
        /// <summary>
        ///   Name of the work item type (e.g. Bug).
        /// </summary>
        public virtual string Type { get; internal set; }
        /// <summary>
        ///   Area the work item is assigned to (e.g. Demos).
        /// </summary>
        public virtual string Area { get; internal set; }
        /// <summary>
        ///   Name of the person the work item is assigned-to (e.g. fabrikam).
        /// </summary>
        public virtual string AssignedTo { get; internal set; }
        /// <summary>
        ///   Description of the work item.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Comment to add to a discussion in a work item.
        /// </summary>
        public virtual string Discussion { get; internal set; }
        /// <summary>
        ///   Space separated "field=value" pairs for custom fields you would like to set.
        /// </summary>
        public virtual IReadOnlyList<string> Fields => FieldsInternal.AsReadOnly();
        internal List<string> FieldsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Iteration path of the work item (e.g. DemosIteration 1).
        /// </summary>
        public virtual string Iteration { get; internal set; }
        /// <summary>
        ///   Open the work item in the default web browser.
        /// </summary>
        public virtual string Open { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Reason for the state of the work item.
        /// </summary>
        public virtual string Reason { get; internal set; }
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
              .Add("boards work-item create")
              .Add("--title {value}", Title)
              .Add("--type {value}", Type)
              .Add("--area {value}", Area)
              .Add("--assigned-to {value}", AssignedTo)
              .Add("--description {value}", Description)
              .Add("--detect", Detect)
              .Add("--discussion {value}", Discussion)
              .Add("--fields {value}", Fields, separator: ' ')
              .Add("--iteration {value}", Iteration)
              .Add("--open {value}", Open)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--reason {value}", Reason)
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
    #region AzureBoardsWorkItemDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Unique id of the work item.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Permanently delete this work item.
        /// </summary>
        public virtual string Destroy { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("boards work-item delete")
              .Add("--id {value}", Id)
              .Add("--destroy {value}", Destroy)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--yes {value}", Yes)
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
    #region AzureBoardsWorkItemShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The ID of the work item.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Open the work item in the default web browser.
        /// </summary>
        public virtual string Open { get; internal set; }
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
              .Add("boards work-item show")
              .Add("--id {value}", Id)
              .Add("--detect", Detect)
              .Add("--open {value}", Open)
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
    #region AzureBoardsWorkItemUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The id of the work item to update.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Area the work item is assigned to (e.g. Demos).
        /// </summary>
        public virtual string Area { get; internal set; }
        /// <summary>
        ///   Name of the person the work item is assigned-to (e.g. fabrikam).
        /// </summary>
        public virtual string AssignedTo { get; internal set; }
        /// <summary>
        ///   Description of the work item.
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Comment to add to a discussion in a work item.
        /// </summary>
        public virtual string Discussion { get; internal set; }
        /// <summary>
        ///   Space separated "field=value" pairs for custom fields you would like to set.
        /// </summary>
        public virtual IReadOnlyList<string> Fields => FieldsInternal.AsReadOnly();
        internal List<string> FieldsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Iteration path of the work item (e.g. DemosIteration 1).
        /// </summary>
        public virtual string Iteration { get; internal set; }
        /// <summary>
        ///   Open the work item in the default web browser.
        /// </summary>
        public virtual string Open { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Reason for the state of the work item.
        /// </summary>
        public virtual string Reason { get; internal set; }
        /// <summary>
        ///   State of the work item (e.g. active).
        /// </summary>
        public virtual string State { get; internal set; }
        /// <summary>
        ///   Title of the work item.
        /// </summary>
        public virtual string Title { get; internal set; }
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
              .Add("boards work-item update")
              .Add("--id {value}", Id)
              .Add("--area {value}", Area)
              .Add("--assigned-to {value}", AssignedTo)
              .Add("--description {value}", Description)
              .Add("--detect", Detect)
              .Add("--discussion {value}", Discussion)
              .Add("--fields {value}", Fields, separator: ' ')
              .Add("--iteration {value}", Iteration)
              .Add("--open {value}", Open)
              .Add("--org {value}", Org)
              .Add("--reason {value}", Reason)
              .Add("--state {value}", State)
              .Add("--title {value}", Title)
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
    #region AzureBoardsAreaSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
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
              .Add("boards area")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBoardsIterationSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
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
              .Add("boards iteration")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBoardsAreaProjectCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaProjectCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Name of the area.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Absolute path of an area. Creates an area at root level if --path is not specified. Example:ProjectNameAreaAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards area project create")
              .Add("--name {value}", Name)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--path {value}", Path)
              .Add("--project {value}", Project)
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
    #region AzureBoardsAreaProjectDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaProjectDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Absolute path of an area. Example:ProjectNameAreaAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("boards area project delete")
              .Add("--path {value}", Path)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--yes {value}", Yes)
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
    #region AzureBoardsAreaProjectListSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaProjectListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Depth of child nodes to be fetched. Example: --depth 3.
        /// </summary>
        public virtual string Depth { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Absolute path of an area. Example:ProjectNameAreaAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards area project list")
              .Add("--depth {value}", Depth)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--path {value}", Path)
              .Add("--project {value}", Project)
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
    #region AzureBoardsAreaProjectShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaProjectShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Area ID.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards area project show")
              .Add("--id {value}", Id)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsAreaProjectUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaProjectUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Absolute path of an area. Example:ProjectNameAreaAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Move an existing area and add as child node for this area.
        /// </summary>
        public virtual string ChildId { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   New name of the area.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards area project update")
              .Add("--path {value}", Path)
              .Add("--child-id {value}", ChildId)
              .Add("--detect", Detect)
              .Add("--name {value}", Name)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsAreaTeamAddSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaTeamAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Area path. Example:ProjectNameAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   The name or id of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Include child nodes of this area.
        /// </summary>
        public virtual bool? IncludeSubAreas { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Set this area path as default area for this team. Default: False.
        /// </summary>
        public virtual string SetAsDefault { get; internal set; }
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
              .Add("boards area team add")
              .Add("--path {value}", Path)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--include-sub-areas", IncludeSubAreas)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--set-as-default {value}", SetAsDefault)
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
    #region AzureBoardsAreaTeamListSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaTeamListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The name or id of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards area team list")
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsAreaTeamRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaTeamRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Area path. Example:ProjectNameAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   The name or id of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards area team remove")
              .Add("--path {value}", Path)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsAreaTeamUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsAreaTeamUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Area path. Example:ProjectNameAreaName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   The name or id of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Include child nodes of this area.
        /// </summary>
        public virtual bool? IncludeSubAreas { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Set as default team area path. Default: False.
        /// </summary>
        public virtual string SetAsDefault { get; internal set; }
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
              .Add("boards area team update")
              .Add("--path {value}", Path)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--include-sub-areas", IncludeSubAreas)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--set-as-default {value}", SetAsDefault)
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
    #region AzureBoardsWorkItemRelationAddSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemRelationAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The ID of the work item.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Relation type to create. Example: parent, child.
        /// </summary>
        public virtual string RelationType { get; internal set; }
        /// <summary>
        ///   ID(s) of work-items to create relation with.                          Multiple values can be passed comma separated. Example: 1,2.
        /// </summary>
        public virtual string TargetId { get; internal set; }
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
              .Add("boards work-item relation add")
              .Add("--id {value}", Id)
              .Add("--relation-type {value}", RelationType)
              .Add("--target-id {value}", TargetId)
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
    #region AzureBoardsWorkItemRelationListTypeSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemRelationListTypeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
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
              .Add("boards work-item relation list-type")
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
    #region AzureBoardsWorkItemRelationRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemRelationRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The ID of the work item.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Relation type to remove. Example: parent, child.
        /// </summary>
        public virtual string RelationType { get; internal set; }
        /// <summary>
        ///   ID(s) of work-items to remove relation from.                          Multiple values can be passed comma separated. Example: 1,2.
        /// </summary>
        public virtual string TargetId { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("boards work-item relation remove")
              .Add("--id {value}", Id)
              .Add("--relation-type {value}", RelationType)
              .Add("--target-id {value}", TargetId)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--yes {value}", Yes)
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
    #region AzureBoardsWorkItemRelationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsWorkItemRelationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The ID of the work item.
        /// </summary>
        public virtual string Id { get; internal set; }
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
              .Add("boards work-item relation show")
              .Add("--id {value}", Id)
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
    #region AzureBoardsIterationProjectCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationProjectCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Name of the iteration.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Finish date of the iteration. Example : "2019-06-21".
        /// </summary>
        public virtual string FinishDate { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Absolute path of an iteration. Creates an iteration at root level if --path is not specified. Example:ProjectNameIterationIterationName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Start date of the iteration. Example : "2019-06-03".
        /// </summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("boards iteration project create")
              .Add("--name {value}", Name)
              .Add("--detect", Detect)
              .Add("--finish-date {value}", FinishDate)
              .Add("--org {value}", Org)
              .Add("--path {value}", Path)
              .Add("--project {value}", Project)
              .Add("--start-date {value}", StartDate)
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
    #region AzureBoardsIterationProjectDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationProjectDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Absolute path of an iteration. Example:ProjectNameIterationIterationName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("boards iteration project delete")
              .Add("--path {value}", Path)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--yes {value}", Yes)
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
    #region AzureBoardsIterationProjectListSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationProjectListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Depth of child nodes to be fetched. Example: --depth 3.
        /// </summary>
        public virtual string Depth { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Absolute path of an iteration. Example:ProjectNameIterationIterationName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration project list")
              .Add("--depth {value}", Depth)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--path {value}", Path)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationProjectShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationProjectShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Iteration ID.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration project show")
              .Add("--id {value}", Id)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationProjectUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationProjectUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Absolute path of an iteration. Example:ProjectNameIterationIterationName.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Move an existing iteration and add as child node for this iteration.
        /// </summary>
        public virtual string ChildId { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Finish date of the iteration. Example : "2019-06-21".
        /// </summary>
        public virtual string FinishDate { get; internal set; }
        /// <summary>
        ///   New name of the iteration.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   Start date of the iteration. Example : "2019-06-03".
        /// </summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("boards iteration project update")
              .Add("--path {value}", Path)
              .Add("--child-id {value}", ChildId)
              .Add("--detect", Detect)
              .Add("--finish-date {value}", FinishDate)
              .Add("--name {value}", Name)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--start-date {value}", StartDate)
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
    #region AzureBoardsIterationTeamAddSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Identifier of the iteration.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team add")
              .Add("--id {value}", Id)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationTeamListSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   The name or id of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
        /// <summary>
        ///   A filter for which iterations are returned based on relative time. Only Current is supported currently.
        /// </summary>
        public virtual string Timeframe { get; internal set; }
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
              .Add("boards iteration team list")
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
              .Add("--timeframe {value}", Timeframe)
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
    #region AzureBoardsIterationTeamListWorkItemsSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamListWorkItemsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Identifier of the iteration.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team list-work-items")
              .Add("--id {value}", Id)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationTeamRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Identifier of the iteration.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team remove")
              .Add("--id {value}", Id)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationTeamSetBacklogIterationSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamSetBacklogIterationSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Identifier of the iteration which needs to be set as backlog iteration.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team set-backlog-iteration")
              .Add("--id {value}", Id)
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationTeamSetDefaultIterationSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamSetDefaultIterationSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Default iteration macro. Example: @CurrentIteration.
        /// </summary>
        public virtual string DefaultIterationMacro { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Identifier of the iteration which needs to be set as default.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team set-default-iteration")
              .Add("--team {value}", Team)
              .Add("--default-iteration-macro {value}", DefaultIterationMacro)
              .Add("--detect", Detect)
              .Add("--id {value}", Id)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationTeamShowBacklogIterationSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamShowBacklogIterationSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team show-backlog-iteration")
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsIterationTeamShowDefaultIterationSettings
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBoardsIterationTeamShowDefaultIterationSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBoards executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBoardsTasks.AzureBoardsPath;
        public override Action<OutputType, string> CustomLogger => AzureBoardsTasks.AzureBoardsLogger;
        /// <summary>
        ///   Name or ID of the team.
        /// </summary>
        public virtual string Team { get; internal set; }
        /// <summary>
        ///   Automatically detect organization.
        /// </summary>
        public virtual bool? Detect { get; internal set; }
        /// <summary>
        ///   Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.
        /// </summary>
        public virtual string Org { get; internal set; }
        /// <summary>
        ///   Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.
        /// </summary>
        public virtual string Project { get; internal set; }
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
              .Add("boards iteration team show-default-iteration")
              .Add("--team {value}", Team)
              .Add("--detect", Detect)
              .Add("--org {value}", Org)
              .Add("--project {value}", Project)
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
    #region AzureBoardsQuerySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsQuerySettingsExtensions
    {
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetDetect(this AzureBoardsQuerySettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetDetect(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsQuerySettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings EnableDetect(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsQuerySettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings DisableDetect(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsQuerySettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ToggleDetect(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Id"/></em></p>
        ///   <p>The ID of an existing query.  Required unless --path or --wiql are specified.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetId(this AzureBoardsQuerySettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Id"/></em></p>
        ///   <p>The ID of an existing query.  Required unless --path or --wiql are specified.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetId(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetOrg(this AzureBoardsQuerySettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetOrg(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Path"/></em></p>
        ///   <p>The path of an existing query.  Ignored if --id is specified.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetPath(this AzureBoardsQuerySettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Path"/></em></p>
        ///   <p>The path of an existing query.  Ignored if --id is specified.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetPath(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetProject(this AzureBoardsQuerySettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetProject(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Wiql
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Wiql"/></em></p>
        ///   <p>The query in Work Item Query Language format.  Ignored if --id or --path is specified.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetWiql(this AzureBoardsQuerySettings toolSettings, string wiql)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wiql = wiql;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Wiql"/></em></p>
        ///   <p>The query in Work Item Query Language format.  Ignored if --id or --path is specified.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetWiql(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wiql = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetSubscription(this AzureBoardsQuerySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetSubscription(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetDebug(this AzureBoardsQuerySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetDebug(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetHelp(this AzureBoardsQuerySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetHelp(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetOutput(this AzureBoardsQuerySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetOutput(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetQuery(this AzureBoardsQuerySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetQuery(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsQuerySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings SetVerbose(this AzureBoardsQuerySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsQuerySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsQuerySettings ResetVerbose(this AzureBoardsQuerySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemCreateSettingsExtensions
    {
        #region Title
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Title"/></em></p>
        ///   <p>Title of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetTitle(this AzureBoardsWorkItemCreateSettings toolSettings, string title)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = title;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Title"/></em></p>
        ///   <p>Title of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetTitle(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = null;
            return toolSettings;
        }
        #endregion
        #region Type
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Type"/></em></p>
        ///   <p>Name of the work item type (e.g. Bug).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetType(this AzureBoardsWorkItemCreateSettings toolSettings, string type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Type"/></em></p>
        ///   <p>Name of the work item type (e.g. Bug).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetType(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region Area
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Area"/></em></p>
        ///   <p>Area the work item is assigned to (e.g. Demos).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetArea(this AzureBoardsWorkItemCreateSettings toolSettings, string area)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Area = area;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Area"/></em></p>
        ///   <p>Area the work item is assigned to (e.g. Demos).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetArea(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Area = null;
            return toolSettings;
        }
        #endregion
        #region AssignedTo
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.AssignedTo"/></em></p>
        ///   <p>Name of the person the work item is assigned-to (e.g. fabrikam).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetAssignedTo(this AzureBoardsWorkItemCreateSettings toolSettings, string assignedTo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignedTo = assignedTo;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.AssignedTo"/></em></p>
        ///   <p>Name of the person the work item is assigned-to (e.g. fabrikam).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetAssignedTo(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignedTo = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Description"/></em></p>
        ///   <p>Description of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetDescription(this AzureBoardsWorkItemCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Description"/></em></p>
        ///   <p>Description of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetDescription(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetDetect(this AzureBoardsWorkItemCreateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetDetect(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings EnableDetect(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings DisableDetect(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ToggleDetect(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Discussion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Discussion"/></em></p>
        ///   <p>Comment to add to a discussion in a work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetDiscussion(this AzureBoardsWorkItemCreateSettings toolSettings, string discussion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Discussion = discussion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Discussion"/></em></p>
        ///   <p>Comment to add to a discussion in a work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetDiscussion(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Discussion = null;
            return toolSettings;
        }
        #endregion
        #region Fields
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Fields"/> to a new list</em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetFields(this AzureBoardsWorkItemCreateSettings toolSettings, params string[] fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal = fields.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Fields"/> to a new list</em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetFields(this AzureBoardsWorkItemCreateSettings toolSettings, IEnumerable<string> fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal = fields.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings AddFields(this AzureBoardsWorkItemCreateSettings toolSettings, params string[] fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.AddRange(fields);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings AddFields(this AzureBoardsWorkItemCreateSettings toolSettings, IEnumerable<string> fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.AddRange(fields);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ClearFields(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings RemoveFields(this AzureBoardsWorkItemCreateSettings toolSettings, params string[] fields)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(fields);
            toolSettings.FieldsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBoardsWorkItemCreateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings RemoveFields(this AzureBoardsWorkItemCreateSettings toolSettings, IEnumerable<string> fields)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(fields);
            toolSettings.FieldsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Iteration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Iteration"/></em></p>
        ///   <p>Iteration path of the work item (e.g. DemosIteration 1).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetIteration(this AzureBoardsWorkItemCreateSettings toolSettings, string iteration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Iteration = iteration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Iteration"/></em></p>
        ///   <p>Iteration path of the work item (e.g. DemosIteration 1).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetIteration(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Iteration = null;
            return toolSettings;
        }
        #endregion
        #region Open
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Open"/></em></p>
        ///   <p>Open the work item in the default web browser.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetOpen(this AzureBoardsWorkItemCreateSettings toolSettings, string open)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Open = open;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Open"/></em></p>
        ///   <p>Open the work item in the default web browser.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetOpen(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Open = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetOrg(this AzureBoardsWorkItemCreateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetOrg(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetProject(this AzureBoardsWorkItemCreateSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetProject(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Reason
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Reason"/></em></p>
        ///   <p>Reason for the state of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetReason(this AzureBoardsWorkItemCreateSettings toolSettings, string reason)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reason = reason;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Reason"/></em></p>
        ///   <p>Reason for the state of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetReason(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reason = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetSubscription(this AzureBoardsWorkItemCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetSubscription(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetDebug(this AzureBoardsWorkItemCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetDebug(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetHelp(this AzureBoardsWorkItemCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetHelp(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetOutput(this AzureBoardsWorkItemCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetOutput(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetQuery(this AzureBoardsWorkItemCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetQuery(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings SetVerbose(this AzureBoardsWorkItemCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemCreateSettings ResetVerbose(this AzureBoardsWorkItemCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemDeleteSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Id"/></em></p>
        ///   <p>Unique id of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetId(this AzureBoardsWorkItemDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Id"/></em></p>
        ///   <p>Unique id of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetId(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Destroy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Destroy"/></em></p>
        ///   <p>Permanently delete this work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetDestroy(this AzureBoardsWorkItemDeleteSettings toolSettings, string destroy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destroy = destroy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Destroy"/></em></p>
        ///   <p>Permanently delete this work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetDestroy(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Destroy = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetDetect(this AzureBoardsWorkItemDeleteSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetDetect(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings EnableDetect(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings DisableDetect(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ToggleDetect(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetOrg(this AzureBoardsWorkItemDeleteSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetOrg(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetProject(this AzureBoardsWorkItemDeleteSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetProject(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetYes(this AzureBoardsWorkItemDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetYes(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetSubscription(this AzureBoardsWorkItemDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetSubscription(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetDebug(this AzureBoardsWorkItemDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetDebug(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetHelp(this AzureBoardsWorkItemDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetHelp(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetOutput(this AzureBoardsWorkItemDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetOutput(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetQuery(this AzureBoardsWorkItemDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetQuery(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings SetVerbose(this AzureBoardsWorkItemDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemDeleteSettings ResetVerbose(this AzureBoardsWorkItemDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemShowSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetId(this AzureBoardsWorkItemShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetId(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetDetect(this AzureBoardsWorkItemShowSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetDetect(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings EnableDetect(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings DisableDetect(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ToggleDetect(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Open
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Open"/></em></p>
        ///   <p>Open the work item in the default web browser.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetOpen(this AzureBoardsWorkItemShowSettings toolSettings, string open)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Open = open;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Open"/></em></p>
        ///   <p>Open the work item in the default web browser.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetOpen(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Open = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetOrg(this AzureBoardsWorkItemShowSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetOrg(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetSubscription(this AzureBoardsWorkItemShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetSubscription(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetDebug(this AzureBoardsWorkItemShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetDebug(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetHelp(this AzureBoardsWorkItemShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetHelp(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetOutput(this AzureBoardsWorkItemShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetOutput(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetQuery(this AzureBoardsWorkItemShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetQuery(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings SetVerbose(this AzureBoardsWorkItemShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemShowSettings ResetVerbose(this AzureBoardsWorkItemShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemUpdateSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Id"/></em></p>
        ///   <p>The id of the work item to update.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetId(this AzureBoardsWorkItemUpdateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Id"/></em></p>
        ///   <p>The id of the work item to update.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetId(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Area
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Area"/></em></p>
        ///   <p>Area the work item is assigned to (e.g. Demos).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetArea(this AzureBoardsWorkItemUpdateSettings toolSettings, string area)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Area = area;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Area"/></em></p>
        ///   <p>Area the work item is assigned to (e.g. Demos).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetArea(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Area = null;
            return toolSettings;
        }
        #endregion
        #region AssignedTo
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.AssignedTo"/></em></p>
        ///   <p>Name of the person the work item is assigned-to (e.g. fabrikam).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetAssignedTo(this AzureBoardsWorkItemUpdateSettings toolSettings, string assignedTo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignedTo = assignedTo;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.AssignedTo"/></em></p>
        ///   <p>Name of the person the work item is assigned-to (e.g. fabrikam).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetAssignedTo(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignedTo = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Description"/></em></p>
        ///   <p>Description of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetDescription(this AzureBoardsWorkItemUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Description"/></em></p>
        ///   <p>Description of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetDescription(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetDetect(this AzureBoardsWorkItemUpdateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetDetect(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings EnableDetect(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings DisableDetect(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ToggleDetect(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Discussion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Discussion"/></em></p>
        ///   <p>Comment to add to a discussion in a work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetDiscussion(this AzureBoardsWorkItemUpdateSettings toolSettings, string discussion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Discussion = discussion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Discussion"/></em></p>
        ///   <p>Comment to add to a discussion in a work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetDiscussion(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Discussion = null;
            return toolSettings;
        }
        #endregion
        #region Fields
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/> to a new list</em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetFields(this AzureBoardsWorkItemUpdateSettings toolSettings, params string[] fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal = fields.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/> to a new list</em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetFields(this AzureBoardsWorkItemUpdateSettings toolSettings, IEnumerable<string> fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal = fields.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings AddFields(this AzureBoardsWorkItemUpdateSettings toolSettings, params string[] fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.AddRange(fields);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings AddFields(this AzureBoardsWorkItemUpdateSettings toolSettings, IEnumerable<string> fields)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.AddRange(fields);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ClearFields(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings RemoveFields(this AzureBoardsWorkItemUpdateSettings toolSettings, params string[] fields)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(fields);
            toolSettings.FieldsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureBoardsWorkItemUpdateSettings.Fields"/></em></p>
        ///   <p>Space separated "field=value" pairs for custom fields you would like to set.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings RemoveFields(this AzureBoardsWorkItemUpdateSettings toolSettings, IEnumerable<string> fields)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(fields);
            toolSettings.FieldsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Iteration
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Iteration"/></em></p>
        ///   <p>Iteration path of the work item (e.g. DemosIteration 1).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetIteration(this AzureBoardsWorkItemUpdateSettings toolSettings, string iteration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Iteration = iteration;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Iteration"/></em></p>
        ///   <p>Iteration path of the work item (e.g. DemosIteration 1).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetIteration(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Iteration = null;
            return toolSettings;
        }
        #endregion
        #region Open
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Open"/></em></p>
        ///   <p>Open the work item in the default web browser.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetOpen(this AzureBoardsWorkItemUpdateSettings toolSettings, string open)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Open = open;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Open"/></em></p>
        ///   <p>Open the work item in the default web browser.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetOpen(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Open = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetOrg(this AzureBoardsWorkItemUpdateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetOrg(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Reason
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Reason"/></em></p>
        ///   <p>Reason for the state of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetReason(this AzureBoardsWorkItemUpdateSettings toolSettings, string reason)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reason = reason;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Reason"/></em></p>
        ///   <p>Reason for the state of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetReason(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reason = null;
            return toolSettings;
        }
        #endregion
        #region State
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.State"/></em></p>
        ///   <p>State of the work item (e.g. active).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetState(this AzureBoardsWorkItemUpdateSettings toolSettings, string state)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.State = state;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.State"/></em></p>
        ///   <p>State of the work item (e.g. active).</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetState(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.State = null;
            return toolSettings;
        }
        #endregion
        #region Title
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Title"/></em></p>
        ///   <p>Title of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetTitle(this AzureBoardsWorkItemUpdateSettings toolSettings, string title)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = title;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Title"/></em></p>
        ///   <p>Title of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetTitle(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetSubscription(this AzureBoardsWorkItemUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetSubscription(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetDebug(this AzureBoardsWorkItemUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetDebug(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetHelp(this AzureBoardsWorkItemUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetHelp(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetOutput(this AzureBoardsWorkItemUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetOutput(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetQuery(this AzureBoardsWorkItemUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetQuery(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings SetVerbose(this AzureBoardsWorkItemUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemUpdateSettings ResetVerbose(this AzureBoardsWorkItemUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings SetDebug(this AzureBoardsAreaSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings ResetDebug(this AzureBoardsAreaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings SetHelp(this AzureBoardsAreaSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings ResetHelp(this AzureBoardsAreaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings SetOutput(this AzureBoardsAreaSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings ResetOutput(this AzureBoardsAreaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings SetQuery(this AzureBoardsAreaSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings ResetQuery(this AzureBoardsAreaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings SetVerbose(this AzureBoardsAreaSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaSettings ResetVerbose(this AzureBoardsAreaSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings SetDebug(this AzureBoardsIterationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings ResetDebug(this AzureBoardsIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings SetHelp(this AzureBoardsIterationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings ResetHelp(this AzureBoardsIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings SetOutput(this AzureBoardsIterationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings ResetOutput(this AzureBoardsIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings SetQuery(this AzureBoardsIterationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings ResetQuery(this AzureBoardsIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings SetVerbose(this AzureBoardsIterationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationSettings ResetVerbose(this AzureBoardsIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaProjectCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaProjectCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Name"/></em></p>
        ///   <p>Name of the area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetName(this AzureBoardsAreaProjectCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Name"/></em></p>
        ///   <p>Name of the area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetName(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetDetect(this AzureBoardsAreaProjectCreateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetDetect(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings EnableDetect(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings DisableDetect(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ToggleDetect(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetOrg(this AzureBoardsAreaProjectCreateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetOrg(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Creates an area at root level if --path is not specified. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetPath(this AzureBoardsAreaProjectCreateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Creates an area at root level if --path is not specified. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetPath(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetProject(this AzureBoardsAreaProjectCreateSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetProject(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetSubscription(this AzureBoardsAreaProjectCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetSubscription(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetDebug(this AzureBoardsAreaProjectCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetDebug(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetHelp(this AzureBoardsAreaProjectCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetHelp(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetOutput(this AzureBoardsAreaProjectCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetOutput(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetQuery(this AzureBoardsAreaProjectCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetQuery(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings SetVerbose(this AzureBoardsAreaProjectCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectCreateSettings ResetVerbose(this AzureBoardsAreaProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaProjectDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaProjectDeleteSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetPath(this AzureBoardsAreaProjectDeleteSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetPath(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetDetect(this AzureBoardsAreaProjectDeleteSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetDetect(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings EnableDetect(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings DisableDetect(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ToggleDetect(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetOrg(this AzureBoardsAreaProjectDeleteSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetOrg(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetProject(this AzureBoardsAreaProjectDeleteSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetProject(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetYes(this AzureBoardsAreaProjectDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetYes(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetSubscription(this AzureBoardsAreaProjectDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetSubscription(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetDebug(this AzureBoardsAreaProjectDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetDebug(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetHelp(this AzureBoardsAreaProjectDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetHelp(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetOutput(this AzureBoardsAreaProjectDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetOutput(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetQuery(this AzureBoardsAreaProjectDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetQuery(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings SetVerbose(this AzureBoardsAreaProjectDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectDeleteSettings ResetVerbose(this AzureBoardsAreaProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaProjectListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaProjectListSettingsExtensions
    {
        #region Depth
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Depth"/></em></p>
        ///   <p>Depth of child nodes to be fetched. Example: --depth 3.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetDepth(this AzureBoardsAreaProjectListSettings toolSettings, string depth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Depth = depth;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Depth"/></em></p>
        ///   <p>Depth of child nodes to be fetched. Example: --depth 3.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetDepth(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Depth = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetDetect(this AzureBoardsAreaProjectListSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetDetect(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings EnableDetect(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings DisableDetect(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ToggleDetect(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetOrg(this AzureBoardsAreaProjectListSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetOrg(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetPath(this AzureBoardsAreaProjectListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetPath(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetProject(this AzureBoardsAreaProjectListSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetProject(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetSubscription(this AzureBoardsAreaProjectListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetSubscription(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetDebug(this AzureBoardsAreaProjectListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetDebug(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetHelp(this AzureBoardsAreaProjectListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetHelp(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetOutput(this AzureBoardsAreaProjectListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetOutput(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetQuery(this AzureBoardsAreaProjectListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetQuery(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings SetVerbose(this AzureBoardsAreaProjectListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectListSettings ResetVerbose(this AzureBoardsAreaProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaProjectShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaProjectShowSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Id"/></em></p>
        ///   <p>Area ID.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetId(this AzureBoardsAreaProjectShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Id"/></em></p>
        ///   <p>Area ID.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetId(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetDetect(this AzureBoardsAreaProjectShowSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetDetect(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings EnableDetect(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings DisableDetect(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ToggleDetect(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetOrg(this AzureBoardsAreaProjectShowSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetOrg(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetProject(this AzureBoardsAreaProjectShowSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetProject(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetSubscription(this AzureBoardsAreaProjectShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetSubscription(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetDebug(this AzureBoardsAreaProjectShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetDebug(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetHelp(this AzureBoardsAreaProjectShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetHelp(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetOutput(this AzureBoardsAreaProjectShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetOutput(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetQuery(this AzureBoardsAreaProjectShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetQuery(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings SetVerbose(this AzureBoardsAreaProjectShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectShowSettings ResetVerbose(this AzureBoardsAreaProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaProjectUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaProjectUpdateSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetPath(this AzureBoardsAreaProjectUpdateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Path"/></em></p>
        ///   <p>Absolute path of an area. Example:ProjectNameAreaAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetPath(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ChildId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.ChildId"/></em></p>
        ///   <p>Move an existing area and add as child node for this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetChildId(this AzureBoardsAreaProjectUpdateSettings toolSettings, string childId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChildId = childId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.ChildId"/></em></p>
        ///   <p>Move an existing area and add as child node for this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetChildId(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChildId = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetDetect(this AzureBoardsAreaProjectUpdateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetDetect(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings EnableDetect(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings DisableDetect(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ToggleDetect(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Name"/></em></p>
        ///   <p>New name of the area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetName(this AzureBoardsAreaProjectUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Name"/></em></p>
        ///   <p>New name of the area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetName(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetOrg(this AzureBoardsAreaProjectUpdateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetOrg(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetProject(this AzureBoardsAreaProjectUpdateSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetProject(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetSubscription(this AzureBoardsAreaProjectUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetSubscription(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetDebug(this AzureBoardsAreaProjectUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetDebug(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetHelp(this AzureBoardsAreaProjectUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetHelp(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetOutput(this AzureBoardsAreaProjectUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetOutput(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetQuery(this AzureBoardsAreaProjectUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetQuery(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaProjectUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings SetVerbose(this AzureBoardsAreaProjectUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaProjectUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaProjectUpdateSettings ResetVerbose(this AzureBoardsAreaProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaTeamAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaTeamAddSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Path"/></em></p>
        ///   <p>Area path. Example:ProjectNameAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetPath(this AzureBoardsAreaTeamAddSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Path"/></em></p>
        ///   <p>Area path. Example:ProjectNameAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetPath(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetTeam(this AzureBoardsAreaTeamAddSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetTeam(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetDetect(this AzureBoardsAreaTeamAddSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetDetect(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings EnableDetect(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings DisableDetect(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ToggleDetect(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region IncludeSubAreas
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetIncludeSubAreas(this AzureBoardsAreaTeamAddSettings toolSettings, bool? includeSubAreas)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = includeSubAreas;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetIncludeSubAreas(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings EnableIncludeSubAreas(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings DisableIncludeSubAreas(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaTeamAddSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ToggleIncludeSubAreas(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = !toolSettings.IncludeSubAreas;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetOrg(this AzureBoardsAreaTeamAddSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetOrg(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetProject(this AzureBoardsAreaTeamAddSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetProject(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region SetAsDefault
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.SetAsDefault"/></em></p>
        ///   <p>Set this area path as default area for this team. Default: False.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetSetAsDefault(this AzureBoardsAreaTeamAddSettings toolSettings, string setAsDefault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetAsDefault = setAsDefault;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.SetAsDefault"/></em></p>
        ///   <p>Set this area path as default area for this team. Default: False.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetSetAsDefault(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetAsDefault = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetSubscription(this AzureBoardsAreaTeamAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetSubscription(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetDebug(this AzureBoardsAreaTeamAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetDebug(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetHelp(this AzureBoardsAreaTeamAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetHelp(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetOutput(this AzureBoardsAreaTeamAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetOutput(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetQuery(this AzureBoardsAreaTeamAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetQuery(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings SetVerbose(this AzureBoardsAreaTeamAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamAddSettings ResetVerbose(this AzureBoardsAreaTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaTeamListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaTeamListSettingsExtensions
    {
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetTeam(this AzureBoardsAreaTeamListSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetTeam(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetDetect(this AzureBoardsAreaTeamListSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetDetect(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings EnableDetect(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings DisableDetect(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ToggleDetect(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetOrg(this AzureBoardsAreaTeamListSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetOrg(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetProject(this AzureBoardsAreaTeamListSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetProject(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetSubscription(this AzureBoardsAreaTeamListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetSubscription(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetDebug(this AzureBoardsAreaTeamListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetDebug(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetHelp(this AzureBoardsAreaTeamListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetHelp(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetOutput(this AzureBoardsAreaTeamListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetOutput(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetQuery(this AzureBoardsAreaTeamListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetQuery(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings SetVerbose(this AzureBoardsAreaTeamListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamListSettings ResetVerbose(this AzureBoardsAreaTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaTeamRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaTeamRemoveSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Path"/></em></p>
        ///   <p>Area path. Example:ProjectNameAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetPath(this AzureBoardsAreaTeamRemoveSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Path"/></em></p>
        ///   <p>Area path. Example:ProjectNameAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetPath(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetTeam(this AzureBoardsAreaTeamRemoveSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetTeam(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetDetect(this AzureBoardsAreaTeamRemoveSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetDetect(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings EnableDetect(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings DisableDetect(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ToggleDetect(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetOrg(this AzureBoardsAreaTeamRemoveSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetOrg(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetProject(this AzureBoardsAreaTeamRemoveSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetProject(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetSubscription(this AzureBoardsAreaTeamRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetSubscription(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetDebug(this AzureBoardsAreaTeamRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetDebug(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetHelp(this AzureBoardsAreaTeamRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetHelp(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetOutput(this AzureBoardsAreaTeamRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetOutput(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetQuery(this AzureBoardsAreaTeamRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetQuery(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings SetVerbose(this AzureBoardsAreaTeamRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamRemoveSettings ResetVerbose(this AzureBoardsAreaTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsAreaTeamUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsAreaTeamUpdateSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Path"/></em></p>
        ///   <p>Area path. Example:ProjectNameAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetPath(this AzureBoardsAreaTeamUpdateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Path"/></em></p>
        ///   <p>Area path. Example:ProjectNameAreaName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetPath(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetTeam(this AzureBoardsAreaTeamUpdateSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetTeam(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetDetect(this AzureBoardsAreaTeamUpdateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetDetect(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings EnableDetect(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings DisableDetect(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaTeamUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ToggleDetect(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region IncludeSubAreas
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetIncludeSubAreas(this AzureBoardsAreaTeamUpdateSettings toolSettings, bool? includeSubAreas)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = includeSubAreas;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetIncludeSubAreas(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings EnableIncludeSubAreas(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings DisableIncludeSubAreas(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsAreaTeamUpdateSettings.IncludeSubAreas"/></em></p>
        ///   <p>Include child nodes of this area.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ToggleIncludeSubAreas(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeSubAreas = !toolSettings.IncludeSubAreas;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetOrg(this AzureBoardsAreaTeamUpdateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetOrg(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetProject(this AzureBoardsAreaTeamUpdateSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetProject(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region SetAsDefault
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.SetAsDefault"/></em></p>
        ///   <p>Set as default team area path. Default: False.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetSetAsDefault(this AzureBoardsAreaTeamUpdateSettings toolSettings, string setAsDefault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetAsDefault = setAsDefault;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.SetAsDefault"/></em></p>
        ///   <p>Set as default team area path. Default: False.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetSetAsDefault(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetAsDefault = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetSubscription(this AzureBoardsAreaTeamUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetSubscription(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetDebug(this AzureBoardsAreaTeamUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetDebug(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetHelp(this AzureBoardsAreaTeamUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetHelp(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetOutput(this AzureBoardsAreaTeamUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetOutput(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetQuery(this AzureBoardsAreaTeamUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetQuery(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsAreaTeamUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings SetVerbose(this AzureBoardsAreaTeamUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsAreaTeamUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsAreaTeamUpdateSettings ResetVerbose(this AzureBoardsAreaTeamUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemRelationAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemRelationAddSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetId(this AzureBoardsWorkItemRelationAddSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetId(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region RelationType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.RelationType"/></em></p>
        ///   <p>Relation type to create. Example: parent, child.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetRelationType(this AzureBoardsWorkItemRelationAddSettings toolSettings, string relationType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelationType = relationType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.RelationType"/></em></p>
        ///   <p>Relation type to create. Example: parent, child.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetRelationType(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelationType = null;
            return toolSettings;
        }
        #endregion
        #region TargetId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.TargetId"/></em></p>
        ///   <p>ID(s) of work-items to create relation with.                          Multiple values can be passed comma separated. Example: 1,2.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetTargetId(this AzureBoardsWorkItemRelationAddSettings toolSettings, string targetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = targetId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.TargetId"/></em></p>
        ///   <p>ID(s) of work-items to create relation with.                          Multiple values can be passed comma separated. Example: 1,2.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetTargetId(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetDetect(this AzureBoardsWorkItemRelationAddSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetDetect(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings EnableDetect(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings DisableDetect(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemRelationAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ToggleDetect(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetOrg(this AzureBoardsWorkItemRelationAddSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetOrg(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetSubscription(this AzureBoardsWorkItemRelationAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetSubscription(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetDebug(this AzureBoardsWorkItemRelationAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetDebug(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetHelp(this AzureBoardsWorkItemRelationAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetHelp(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetOutput(this AzureBoardsWorkItemRelationAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetOutput(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetQuery(this AzureBoardsWorkItemRelationAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetQuery(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings SetVerbose(this AzureBoardsWorkItemRelationAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationAddSettings ResetVerbose(this AzureBoardsWorkItemRelationAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemRelationListTypeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemRelationListTypeSettingsExtensions
    {
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetDetect(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetDetect(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings EnableDetect(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings DisableDetect(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemRelationListTypeSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ToggleDetect(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetOrg(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetOrg(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetSubscription(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetSubscription(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetDebug(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetDebug(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetHelp(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetHelp(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetOutput(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetOutput(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetQuery(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetQuery(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings SetVerbose(this AzureBoardsWorkItemRelationListTypeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationListTypeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationListTypeSettings ResetVerbose(this AzureBoardsWorkItemRelationListTypeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemRelationRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemRelationRemoveSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetId(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetId(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region RelationType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.RelationType"/></em></p>
        ///   <p>Relation type to remove. Example: parent, child.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetRelationType(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string relationType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelationType = relationType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.RelationType"/></em></p>
        ///   <p>Relation type to remove. Example: parent, child.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetRelationType(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelationType = null;
            return toolSettings;
        }
        #endregion
        #region TargetId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.TargetId"/></em></p>
        ///   <p>ID(s) of work-items to remove relation from.                          Multiple values can be passed comma separated. Example: 1,2.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetTargetId(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string targetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = targetId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.TargetId"/></em></p>
        ///   <p>ID(s) of work-items to remove relation from.                          Multiple values can be passed comma separated. Example: 1,2.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetTargetId(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetDetect(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetDetect(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings EnableDetect(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings DisableDetect(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemRelationRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ToggleDetect(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetOrg(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetOrg(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetYes(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetYes(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetSubscription(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetSubscription(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetDebug(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetDebug(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetHelp(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetHelp(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetOutput(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetOutput(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetQuery(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetQuery(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings SetVerbose(this AzureBoardsWorkItemRelationRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationRemoveSettings ResetVerbose(this AzureBoardsWorkItemRelationRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsWorkItemRelationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsWorkItemRelationShowSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetId(this AzureBoardsWorkItemRelationShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Id"/></em></p>
        ///   <p>The ID of the work item.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetId(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetDetect(this AzureBoardsWorkItemRelationShowSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetDetect(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings EnableDetect(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings DisableDetect(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsWorkItemRelationShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ToggleDetect(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetOrg(this AzureBoardsWorkItemRelationShowSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetOrg(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetSubscription(this AzureBoardsWorkItemRelationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetSubscription(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetDebug(this AzureBoardsWorkItemRelationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetDebug(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetHelp(this AzureBoardsWorkItemRelationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetHelp(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetOutput(this AzureBoardsWorkItemRelationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetOutput(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetQuery(this AzureBoardsWorkItemRelationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetQuery(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsWorkItemRelationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings SetVerbose(this AzureBoardsWorkItemRelationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsWorkItemRelationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsWorkItemRelationShowSettings ResetVerbose(this AzureBoardsWorkItemRelationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationProjectCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationProjectCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Name"/></em></p>
        ///   <p>Name of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetName(this AzureBoardsIterationProjectCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Name"/></em></p>
        ///   <p>Name of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetName(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetDetect(this AzureBoardsIterationProjectCreateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetDetect(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings EnableDetect(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings DisableDetect(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationProjectCreateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ToggleDetect(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region FinishDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.FinishDate"/></em></p>
        ///   <p>Finish date of the iteration. Example : "2019-06-21".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetFinishDate(this AzureBoardsIterationProjectCreateSettings toolSettings, string finishDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FinishDate = finishDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.FinishDate"/></em></p>
        ///   <p>Finish date of the iteration. Example : "2019-06-21".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetFinishDate(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FinishDate = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetOrg(this AzureBoardsIterationProjectCreateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetOrg(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Creates an iteration at root level if --path is not specified. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetPath(this AzureBoardsIterationProjectCreateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Creates an iteration at root level if --path is not specified. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetPath(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetProject(this AzureBoardsIterationProjectCreateSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetProject(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.StartDate"/></em></p>
        ///   <p>Start date of the iteration. Example : "2019-06-03".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetStartDate(this AzureBoardsIterationProjectCreateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.StartDate"/></em></p>
        ///   <p>Start date of the iteration. Example : "2019-06-03".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetStartDate(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetSubscription(this AzureBoardsIterationProjectCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetSubscription(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetDebug(this AzureBoardsIterationProjectCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetDebug(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetHelp(this AzureBoardsIterationProjectCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetHelp(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetOutput(this AzureBoardsIterationProjectCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetOutput(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetQuery(this AzureBoardsIterationProjectCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetQuery(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings SetVerbose(this AzureBoardsIterationProjectCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectCreateSettings ResetVerbose(this AzureBoardsIterationProjectCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationProjectDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationProjectDeleteSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetPath(this AzureBoardsIterationProjectDeleteSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetPath(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetDetect(this AzureBoardsIterationProjectDeleteSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetDetect(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings EnableDetect(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings DisableDetect(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationProjectDeleteSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ToggleDetect(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetOrg(this AzureBoardsIterationProjectDeleteSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetOrg(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetProject(this AzureBoardsIterationProjectDeleteSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetProject(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetYes(this AzureBoardsIterationProjectDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetYes(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetSubscription(this AzureBoardsIterationProjectDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetSubscription(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetDebug(this AzureBoardsIterationProjectDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetDebug(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetHelp(this AzureBoardsIterationProjectDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetHelp(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetOutput(this AzureBoardsIterationProjectDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetOutput(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetQuery(this AzureBoardsIterationProjectDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetQuery(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings SetVerbose(this AzureBoardsIterationProjectDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectDeleteSettings ResetVerbose(this AzureBoardsIterationProjectDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationProjectListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationProjectListSettingsExtensions
    {
        #region Depth
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Depth"/></em></p>
        ///   <p>Depth of child nodes to be fetched. Example: --depth 3.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetDepth(this AzureBoardsIterationProjectListSettings toolSettings, string depth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Depth = depth;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Depth"/></em></p>
        ///   <p>Depth of child nodes to be fetched. Example: --depth 3.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetDepth(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Depth = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetDetect(this AzureBoardsIterationProjectListSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetDetect(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings EnableDetect(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings DisableDetect(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationProjectListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ToggleDetect(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetOrg(this AzureBoardsIterationProjectListSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetOrg(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetPath(this AzureBoardsIterationProjectListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetPath(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetProject(this AzureBoardsIterationProjectListSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetProject(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetSubscription(this AzureBoardsIterationProjectListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetSubscription(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetDebug(this AzureBoardsIterationProjectListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetDebug(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetHelp(this AzureBoardsIterationProjectListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetHelp(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetOutput(this AzureBoardsIterationProjectListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetOutput(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetQuery(this AzureBoardsIterationProjectListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetQuery(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings SetVerbose(this AzureBoardsIterationProjectListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectListSettings ResetVerbose(this AzureBoardsIterationProjectListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationProjectShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationProjectShowSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Id"/></em></p>
        ///   <p>Iteration ID.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetId(this AzureBoardsIterationProjectShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Id"/></em></p>
        ///   <p>Iteration ID.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetId(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetDetect(this AzureBoardsIterationProjectShowSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetDetect(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings EnableDetect(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings DisableDetect(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationProjectShowSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ToggleDetect(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetOrg(this AzureBoardsIterationProjectShowSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetOrg(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetProject(this AzureBoardsIterationProjectShowSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetProject(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetSubscription(this AzureBoardsIterationProjectShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetSubscription(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetDebug(this AzureBoardsIterationProjectShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetDebug(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetHelp(this AzureBoardsIterationProjectShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetHelp(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetOutput(this AzureBoardsIterationProjectShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetOutput(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetQuery(this AzureBoardsIterationProjectShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetQuery(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings SetVerbose(this AzureBoardsIterationProjectShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectShowSettings ResetVerbose(this AzureBoardsIterationProjectShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationProjectUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationProjectUpdateSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetPath(this AzureBoardsIterationProjectUpdateSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Path"/></em></p>
        ///   <p>Absolute path of an iteration. Example:ProjectNameIterationIterationName.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetPath(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region ChildId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.ChildId"/></em></p>
        ///   <p>Move an existing iteration and add as child node for this iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetChildId(this AzureBoardsIterationProjectUpdateSettings toolSettings, string childId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChildId = childId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.ChildId"/></em></p>
        ///   <p>Move an existing iteration and add as child node for this iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetChildId(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChildId = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetDetect(this AzureBoardsIterationProjectUpdateSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetDetect(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings EnableDetect(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings DisableDetect(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationProjectUpdateSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ToggleDetect(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region FinishDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.FinishDate"/></em></p>
        ///   <p>Finish date of the iteration. Example : "2019-06-21".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetFinishDate(this AzureBoardsIterationProjectUpdateSettings toolSettings, string finishDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FinishDate = finishDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.FinishDate"/></em></p>
        ///   <p>Finish date of the iteration. Example : "2019-06-21".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetFinishDate(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FinishDate = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Name"/></em></p>
        ///   <p>New name of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetName(this AzureBoardsIterationProjectUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Name"/></em></p>
        ///   <p>New name of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetName(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetOrg(this AzureBoardsIterationProjectUpdateSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetOrg(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetProject(this AzureBoardsIterationProjectUpdateSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetProject(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.StartDate"/></em></p>
        ///   <p>Start date of the iteration. Example : "2019-06-03".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetStartDate(this AzureBoardsIterationProjectUpdateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.StartDate"/></em></p>
        ///   <p>Start date of the iteration. Example : "2019-06-03".</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetStartDate(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetSubscription(this AzureBoardsIterationProjectUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetSubscription(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetDebug(this AzureBoardsIterationProjectUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetDebug(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetHelp(this AzureBoardsIterationProjectUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetHelp(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetOutput(this AzureBoardsIterationProjectUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetOutput(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetQuery(this AzureBoardsIterationProjectUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetQuery(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationProjectUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings SetVerbose(this AzureBoardsIterationProjectUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationProjectUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationProjectUpdateSettings ResetVerbose(this AzureBoardsIterationProjectUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamAddSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetId(this AzureBoardsIterationTeamAddSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetId(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetTeam(this AzureBoardsIterationTeamAddSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetTeam(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetDetect(this AzureBoardsIterationTeamAddSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetDetect(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings EnableDetect(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings DisableDetect(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamAddSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ToggleDetect(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetOrg(this AzureBoardsIterationTeamAddSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetOrg(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetProject(this AzureBoardsIterationTeamAddSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetProject(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetSubscription(this AzureBoardsIterationTeamAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetSubscription(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetDebug(this AzureBoardsIterationTeamAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetDebug(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetHelp(this AzureBoardsIterationTeamAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetHelp(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetOutput(this AzureBoardsIterationTeamAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetOutput(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetQuery(this AzureBoardsIterationTeamAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetQuery(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings SetVerbose(this AzureBoardsIterationTeamAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamAddSettings ResetVerbose(this AzureBoardsIterationTeamAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamListSettingsExtensions
    {
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetTeam(this AzureBoardsIterationTeamListSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Team"/></em></p>
        ///   <p>The name or id of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetTeam(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetDetect(this AzureBoardsIterationTeamListSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetDetect(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings EnableDetect(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings DisableDetect(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamListSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ToggleDetect(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetOrg(this AzureBoardsIterationTeamListSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetOrg(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetProject(this AzureBoardsIterationTeamListSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetProject(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Timeframe
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Timeframe"/></em></p>
        ///   <p>A filter for which iterations are returned based on relative time. Only Current is supported currently.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetTimeframe(this AzureBoardsIterationTeamListSettings toolSettings, string timeframe)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeframe = timeframe;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Timeframe"/></em></p>
        ///   <p>A filter for which iterations are returned based on relative time. Only Current is supported currently.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetTimeframe(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeframe = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetSubscription(this AzureBoardsIterationTeamListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetSubscription(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetDebug(this AzureBoardsIterationTeamListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetDebug(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetHelp(this AzureBoardsIterationTeamListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetHelp(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetOutput(this AzureBoardsIterationTeamListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetOutput(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetQuery(this AzureBoardsIterationTeamListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetQuery(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings SetVerbose(this AzureBoardsIterationTeamListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListSettings ResetVerbose(this AzureBoardsIterationTeamListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamListWorkItemsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamListWorkItemsSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetId(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetId(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetTeam(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetTeam(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetDetect(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetDetect(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings EnableDetect(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings DisableDetect(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ToggleDetect(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetOrg(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetOrg(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetProject(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetProject(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetSubscription(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetSubscription(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetDebug(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetDebug(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetHelp(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetHelp(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetOutput(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetOutput(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetQuery(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetQuery(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings SetVerbose(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamListWorkItemsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamListWorkItemsSettings ResetVerbose(this AzureBoardsIterationTeamListWorkItemsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamRemoveSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetId(this AzureBoardsIterationTeamRemoveSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetId(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetTeam(this AzureBoardsIterationTeamRemoveSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetTeam(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetDetect(this AzureBoardsIterationTeamRemoveSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetDetect(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings EnableDetect(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings DisableDetect(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamRemoveSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ToggleDetect(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetOrg(this AzureBoardsIterationTeamRemoveSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetOrg(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetProject(this AzureBoardsIterationTeamRemoveSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetProject(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetSubscription(this AzureBoardsIterationTeamRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetSubscription(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetDebug(this AzureBoardsIterationTeamRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetDebug(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetHelp(this AzureBoardsIterationTeamRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetHelp(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetOutput(this AzureBoardsIterationTeamRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetOutput(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetQuery(this AzureBoardsIterationTeamRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetQuery(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings SetVerbose(this AzureBoardsIterationTeamRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamRemoveSettings ResetVerbose(this AzureBoardsIterationTeamRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamSetBacklogIterationSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamSetBacklogIterationSettingsExtensions
    {
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration which needs to be set as backlog iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetId(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration which needs to be set as backlog iteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetId(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetTeam(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetTeam(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetDetect(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetDetect(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings EnableDetect(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings DisableDetect(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ToggleDetect(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetOrg(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetOrg(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetProject(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetProject(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetSubscription(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetSubscription(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetDebug(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetDebug(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetHelp(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetHelp(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetOutput(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetOutput(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetQuery(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetQuery(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings SetVerbose(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetBacklogIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetBacklogIterationSettings ResetVerbose(this AzureBoardsIterationTeamSetBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamSetDefaultIterationSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamSetDefaultIterationSettingsExtensions
    {
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetTeam(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetTeam(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region DefaultIterationMacro
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.DefaultIterationMacro"/></em></p>
        ///   <p>Default iteration macro. Example: @CurrentIteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetDefaultIterationMacro(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string defaultIterationMacro)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultIterationMacro = defaultIterationMacro;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.DefaultIterationMacro"/></em></p>
        ///   <p>Default iteration macro. Example: @CurrentIteration.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetDefaultIterationMacro(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultIterationMacro = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetDetect(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetDetect(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings EnableDetect(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings DisableDetect(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ToggleDetect(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration which needs to be set as default.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetId(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Id"/></em></p>
        ///   <p>Identifier of the iteration which needs to be set as default.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetId(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetOrg(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetOrg(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetProject(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetProject(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetSubscription(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetSubscription(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetDebug(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetDebug(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetHelp(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetHelp(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetOutput(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetOutput(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetQuery(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetQuery(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings SetVerbose(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamSetDefaultIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamSetDefaultIterationSettings ResetVerbose(this AzureBoardsIterationTeamSetDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamShowBacklogIterationSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamShowBacklogIterationSettingsExtensions
    {
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetTeam(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetTeam(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetDetect(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetDetect(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings EnableDetect(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings DisableDetect(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ToggleDetect(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetOrg(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetOrg(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetProject(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetProject(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetSubscription(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetSubscription(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetDebug(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetDebug(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetHelp(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetHelp(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetOutput(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetOutput(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetQuery(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetQuery(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings SetVerbose(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowBacklogIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowBacklogIterationSettings ResetVerbose(this AzureBoardsIterationTeamShowBacklogIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBoardsIterationTeamShowDefaultIterationSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBoardsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBoardsIterationTeamShowDefaultIterationSettingsExtensions
    {
        #region Team
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetTeam(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string team)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = team;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Team"/></em></p>
        ///   <p>Name or ID of the team.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetTeam(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Team = null;
            return toolSettings;
        }
        #endregion
        #region Detect
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetDetect(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, bool? detect)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = detect;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetDetect(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings EnableDetect(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings DisableDetect(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Detect"/></em></p>
        ///   <p>Automatically detect organization.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ToggleDetect(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Detect = !toolSettings.Detect;
            return toolSettings;
        }
        #endregion
        #region Org
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetOrg(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string org)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = org;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Org"/></em></p>
        ///   <p>Azure DevOps organization URL. You can configure the default organization using az devops configure -d organization=ORG_URL. Required if not configured as default or picked up via git config. Example: <a href="https://dev.azure.com/MyOrganizationName/">https://dev.azure.com/MyOrganizationName/</a>.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetOrg(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Org = null;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetProject(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Project"/></em></p>
        ///   <p>Name or ID of the project. You can configure the default project using az devops configure -d project=NAME_OR_ID. Required if not configured as default or picked up via git config.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetProject(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetSubscription(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetSubscription(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetDebug(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetDebug(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetHelp(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetHelp(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetOutput(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetOutput(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetQuery(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetQuery(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings SetVerbose(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBoardsIterationTeamShowDefaultIterationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBoardsIterationTeamShowDefaultIterationSettings ResetVerbose(this AzureBoardsIterationTeamShowDefaultIterationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
