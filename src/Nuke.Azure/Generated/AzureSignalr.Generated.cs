// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureSignalr.json
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
    public static partial class AzureSignalrTasks
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public static string AzureSignalrPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURESIGNALR_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureSignalrLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure SignalR Service.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalr(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureSignalrPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureSignalrLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrCreate(AzureSignalrCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSignalrCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-mode</c> via <see cref="AzureSignalrCreateSettings.ServiceMode"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSignalrCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSignalrCreateSettings.Tags"/></li>
        ///     <li><c>--unit-count</c> via <see cref="AzureSignalrCreateSettings.UnitCount"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrCreate(Configure<AzureSignalrCreateSettings> configurator)
        {
            return AzureSignalrCreate(configurator(new AzureSignalrCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSignalrCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-mode</c> via <see cref="AzureSignalrCreateSettings.ServiceMode"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSignalrCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSignalrCreateSettings.Tags"/></li>
        ///     <li><c>--unit-count</c> via <see cref="AzureSignalrCreateSettings.UnitCount"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrCreate(CombinatorialConfigure<AzureSignalrCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrCreate, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrDelete(AzureSignalrDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrDelete(Configure<AzureSignalrDeleteSettings> configurator)
        {
            return AzureSignalrDelete(configurator(new AzureSignalrDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrDelete(CombinatorialConfigure<AzureSignalrDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrDelete, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrList(AzureSignalrListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrList(Configure<AzureSignalrListSettings> configurator)
        {
            return AzureSignalrList(configurator(new AzureSignalrListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrList(CombinatorialConfigure<AzureSignalrListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrList, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrRestart(AzureSignalrRestartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrRestartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrRestartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrRestart(Configure<AzureSignalrRestartSettings> configurator)
        {
            return AzureSignalrRestart(configurator(new AzureSignalrRestartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrRestartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrRestartSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrRestartSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrRestartSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrRestartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrRestartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrRestartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrRestartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrRestartSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrRestart(CombinatorialConfigure<AzureSignalrRestartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrRestart, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrShow(AzureSignalrShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrShow(Configure<AzureSignalrShowSettings> configurator)
        {
            return AzureSignalrShow(configurator(new AzureSignalrShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrShow(CombinatorialConfigure<AzureSignalrShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrShow, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrUpdate(AzureSignalrUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSignalrUpdateSettings.Add"/></li>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSignalrUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSignalrUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-mode</c> via <see cref="AzureSignalrUpdateSettings.ServiceMode"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSignalrUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSignalrUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSignalrUpdateSettings.Tags"/></li>
        ///     <li><c>--unit-count</c> via <see cref="AzureSignalrUpdateSettings.UnitCount"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrUpdate(Configure<AzureSignalrUpdateSettings> configurator)
        {
            return AzureSignalrUpdate(configurator(new AzureSignalrUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureSignalrUpdateSettings.Add"/></li>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureSignalrUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureSignalrUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-mode</c> via <see cref="AzureSignalrUpdateSettings.ServiceMode"/></li>
        ///     <li><c>--set</c> via <see cref="AzureSignalrUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureSignalrUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureSignalrUpdateSettings.Tags"/></li>
        ///     <li><c>--unit-count</c> via <see cref="AzureSignalrUpdateSettings.UnitCount"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrUpdate(CombinatorialConfigure<AzureSignalrUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrUpdate, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrCorsAdd(AzureSignalrCorsAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrCorsAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCorsAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCorsAddSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCorsAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCorsAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCorsAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCorsAddSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCorsAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCorsAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrCorsAdd(Configure<AzureSignalrCorsAddSettings> configurator)
        {
            return AzureSignalrCorsAdd(configurator(new AzureSignalrCorsAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCorsAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCorsAddSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCorsAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCorsAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCorsAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCorsAddSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCorsAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCorsAddSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrCorsAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrCorsAdd(CombinatorialConfigure<AzureSignalrCorsAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrCorsAdd, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrCorsList(AzureSignalrCorsListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrCorsListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCorsListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCorsListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCorsListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCorsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCorsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCorsListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCorsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCorsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrCorsList(Configure<AzureSignalrCorsListSettings> configurator)
        {
            return AzureSignalrCorsList(configurator(new AzureSignalrCorsListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCorsListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCorsListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCorsListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCorsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCorsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCorsListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCorsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCorsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrCorsListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrCorsList(CombinatorialConfigure<AzureSignalrCorsListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrCorsList, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrCorsRemove(AzureSignalrCorsRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrCorsRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCorsRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCorsRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCorsRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCorsRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCorsRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCorsRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCorsRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCorsRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrCorsRemove(Configure<AzureSignalrCorsRemoveSettings> configurator)
        {
            return AzureSignalrCorsRemove(configurator(new AzureSignalrCorsRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--allowed-origins</c> via <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCorsRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCorsRemoveSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCorsRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCorsRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCorsRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCorsRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrCorsRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrCorsRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrCorsRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrCorsRemove(CombinatorialConfigure<AzureSignalrCorsRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrCorsRemove, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrKeyList(AzureSignalrKeyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrKeyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrKeyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrKeyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrKeyList(Configure<AzureSignalrKeyListSettings> configurator)
        {
            return AzureSignalrKeyList(configurator(new AzureSignalrKeyListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrKeyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrKeyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrKeyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrKeyList(CombinatorialConfigure<AzureSignalrKeyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrKeyList, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSignalrKeyRenew(AzureSignalrKeyRenewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSignalrKeyRenewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrKeyRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrKeyRenewSettings.Help"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureSignalrKeyRenewSettings.KeyType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrKeyRenewSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrKeyRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrKeyRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrKeyRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrKeyRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrKeyRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSignalrKeyRenew(Configure<AzureSignalrKeyRenewSettings> configurator)
        {
            return AzureSignalrKeyRenew(configurator(new AzureSignalrKeyRenewSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure SignalR Service.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/signalr?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSignalrKeyRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrKeyRenewSettings.Help"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureSignalrKeyRenewSettings.KeyType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrKeyRenewSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrKeyRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrKeyRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrKeyRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSignalrKeyRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSignalrKeyRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSignalrKeyRenewSettings Settings, IReadOnlyCollection<Output> Output)> AzureSignalrKeyRenew(CombinatorialConfigure<AzureSignalrKeyRenewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSignalrKeyRenew, AzureSignalrLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureSignalrCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The sku name of the signalr service. E.g. Standard_S1.
        /// </summary>
        public virtual string Sku { get; internal set; }
        /// <summary>
        ///   Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".
        /// </summary>
        public virtual IReadOnlyList<string> AllowedOrigins => AllowedOriginsInternal.AsReadOnly();
        internal List<string> AllowedOriginsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The service mode which signalr service will be working on.
        /// </summary>
        public virtual SignalrServiceMode ServiceMode { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The number of signalr service unit count.
        /// </summary>
        public virtual string UnitCount { get; internal set; }
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
              .Add("signalr create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--allowed-origins {value}", AllowedOrigins, separator: ' ')
              .Add("--location {value}", Location)
              .Add("--service-mode {value}", ServiceMode)
              .Add("--tags {value}", Tags)
              .Add("--unit-count {value}", UnitCount)
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
    #region AzureSignalrDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr delete")
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
    #region AzureSignalrListSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
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
              .Add("signalr list")
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
    #region AzureSignalrRestartSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrRestartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr restart")
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
    #region AzureSignalrShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr show")
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
    #region AzureSignalrUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".
        /// </summary>
        public virtual IReadOnlyList<string> AllowedOrigins => AllowedOriginsInternal.AsReadOnly();
        internal List<string> AllowedOriginsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The service mode which signalr service will be working on.
        /// </summary>
        public virtual SignalrServiceMode ServiceMode { get; internal set; }
        /// <summary>
        ///   The sku name of the signalr service. E.g. Standard_S1.
        /// </summary>
        public virtual string Sku { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The number of signalr service unit count.
        /// </summary>
        public virtual string UnitCount { get; internal set; }
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
              .Add("signalr update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--allowed-origins {value}", AllowedOrigins, separator: ' ')
              .Add("--service-mode {value}", ServiceMode)
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
              .Add("--unit-count {value}", UnitCount)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
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
    #region AzureSignalrCorsAddSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrCorsAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".
        /// </summary>
        public virtual IReadOnlyList<string> AllowedOrigins => AllowedOriginsInternal.AsReadOnly();
        internal List<string> AllowedOriginsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr cors add")
              .Add("--allowed-origins {value}", AllowedOrigins, separator: ' ')
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
    #region AzureSignalrCorsListSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrCorsListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr cors list")
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
    #region AzureSignalrCorsRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrCorsRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".
        /// </summary>
        public virtual IReadOnlyList<string> AllowedOrigins => AllowedOriginsInternal.AsReadOnly();
        internal List<string> AllowedOriginsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr cors remove")
              .Add("--allowed-origins {value}", AllowedOrigins, separator: ' ')
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
    #region AzureSignalrKeyListSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrKeyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr key list")
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
    #region AzureSignalrKeyRenewSettings
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSignalrKeyRenewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSignalr executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSignalrTasks.AzureSignalrPath;
        public override Action<OutputType, string> CustomLogger => AzureSignalrTasks.AzureSignalrLogger;
        /// <summary>
        ///   The name of access key to regenerate.
        /// </summary>
        public virtual SignalrKeyRenewKeyType KeyType { get; internal set; }
        /// <summary>
        ///   Name of signalr service.
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
              .Add("signalr key renew")
              .Add("--key-type {value}", KeyType)
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
    #region AzureSignalrCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetName(this AzureSignalrCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetName(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetResourceGroup(this AzureSignalrCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetResourceGroup(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Sku"/></em></p>
        ///   <p>The sku name of the signalr service. E.g. Standard_S1.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetSku(this AzureSignalrCreateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Sku"/></em></p>
        ///   <p>The sku name of the signalr service. E.g. Standard_S1.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetSku(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region AllowedOrigins
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetAllowedOrigins(this AzureSignalrCreateSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetAllowedOrigins(this AzureSignalrCreateSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings AddAllowedOrigins(this AzureSignalrCreateSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings AddAllowedOrigins(this AzureSignalrCreateSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ClearAllowedOrigins(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings RemoveAllowedOrigins(this AzureSignalrCreateSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrCreateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings RemoveAllowedOrigins(this AzureSignalrCreateSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetLocation(this AzureSignalrCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetLocation(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ServiceMode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.ServiceMode"/></em></p>
        ///   <p>The service mode which signalr service will be working on.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetServiceMode(this AzureSignalrCreateSettings toolSettings, SignalrServiceMode serviceMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceMode = serviceMode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.ServiceMode"/></em></p>
        ///   <p>The service mode which signalr service will be working on.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetServiceMode(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceMode = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetTags(this AzureSignalrCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetTags(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region UnitCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.UnitCount"/></em></p>
        ///   <p>The number of signalr service unit count.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetUnitCount(this AzureSignalrCreateSettings toolSettings, string unitCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnitCount = unitCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.UnitCount"/></em></p>
        ///   <p>The number of signalr service unit count.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetUnitCount(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnitCount = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetSubscription(this AzureSignalrCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetSubscription(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetDebug(this AzureSignalrCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetDebug(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetHelp(this AzureSignalrCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetHelp(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetOutput(this AzureSignalrCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetOutput(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetQuery(this AzureSignalrCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetQuery(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings SetVerbose(this AzureSignalrCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCreateSettings ResetVerbose(this AzureSignalrCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetName(this AzureSignalrDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetName(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetResourceGroup(this AzureSignalrDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetResourceGroup(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetSubscription(this AzureSignalrDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetSubscription(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetDebug(this AzureSignalrDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetDebug(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetHelp(this AzureSignalrDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetHelp(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetOutput(this AzureSignalrDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetOutput(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetQuery(this AzureSignalrDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetQuery(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings SetVerbose(this AzureSignalrDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrDeleteSettings ResetVerbose(this AzureSignalrDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetResourceGroup(this AzureSignalrListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetResourceGroup(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetSubscription(this AzureSignalrListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetSubscription(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetDebug(this AzureSignalrListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetDebug(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetHelp(this AzureSignalrListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetHelp(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetOutput(this AzureSignalrListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetOutput(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetQuery(this AzureSignalrListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetQuery(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings SetVerbose(this AzureSignalrListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrListSettings ResetVerbose(this AzureSignalrListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrRestartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrRestartSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetName(this AzureSignalrRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetName(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetResourceGroup(this AzureSignalrRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetResourceGroup(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetSubscription(this AzureSignalrRestartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetSubscription(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetDebug(this AzureSignalrRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetDebug(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetHelp(this AzureSignalrRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetHelp(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetOutput(this AzureSignalrRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetOutput(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetQuery(this AzureSignalrRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetQuery(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings SetVerbose(this AzureSignalrRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrRestartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrRestartSettings ResetVerbose(this AzureSignalrRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetName(this AzureSignalrShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetName(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetResourceGroup(this AzureSignalrShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetResourceGroup(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetSubscription(this AzureSignalrShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetSubscription(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetDebug(this AzureSignalrShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetDebug(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetHelp(this AzureSignalrShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetHelp(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetOutput(this AzureSignalrShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetOutput(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetQuery(this AzureSignalrShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetQuery(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings SetVerbose(this AzureSignalrShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrShowSettings ResetVerbose(this AzureSignalrShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetName(this AzureSignalrUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetName(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetResourceGroup(this AzureSignalrUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetResourceGroup(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AllowedOrigins
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetAllowedOrigins(this AzureSignalrUpdateSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetAllowedOrigins(this AzureSignalrUpdateSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings AddAllowedOrigins(this AzureSignalrUpdateSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings AddAllowedOrigins(this AzureSignalrUpdateSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ClearAllowedOrigins(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings RemoveAllowedOrigins(this AzureSignalrUpdateSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrUpdateSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings RemoveAllowedOrigins(this AzureSignalrUpdateSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ServiceMode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.ServiceMode"/></em></p>
        ///   <p>The service mode which signalr service will be working on.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetServiceMode(this AzureSignalrUpdateSettings toolSettings, SignalrServiceMode serviceMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceMode = serviceMode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.ServiceMode"/></em></p>
        ///   <p>The service mode which signalr service will be working on.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetServiceMode(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceMode = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Sku"/></em></p>
        ///   <p>The sku name of the signalr service. E.g. Standard_S1.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetSku(this AzureSignalrUpdateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Sku"/></em></p>
        ///   <p>The sku name of the signalr service. E.g. Standard_S1.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetSku(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetTags(this AzureSignalrUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetTags(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region UnitCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.UnitCount"/></em></p>
        ///   <p>The number of signalr service unit count.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetUnitCount(this AzureSignalrUpdateSettings toolSettings, string unitCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnitCount = unitCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.UnitCount"/></em></p>
        ///   <p>The number of signalr service unit count.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetUnitCount(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UnitCount = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetAdd(this AzureSignalrUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetAdd(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetForceString(this AzureSignalrUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetForceString(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetRemove(this AzureSignalrUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetRemove(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetSet(this AzureSignalrUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetSet(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetSubscription(this AzureSignalrUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetSubscription(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetDebug(this AzureSignalrUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetDebug(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetHelp(this AzureSignalrUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetHelp(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetOutput(this AzureSignalrUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetOutput(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetQuery(this AzureSignalrUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetQuery(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings SetVerbose(this AzureSignalrUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrUpdateSettings ResetVerbose(this AzureSignalrUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrCorsAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrCorsAddSettingsExtensions
    {
        #region AllowedOrigins
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings AddAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings AddAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ClearAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings RemoveAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrCorsAddSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings RemoveAllowedOrigins(this AzureSignalrCorsAddSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetName(this AzureSignalrCorsAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetName(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetResourceGroup(this AzureSignalrCorsAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetResourceGroup(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetSubscription(this AzureSignalrCorsAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetSubscription(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetDebug(this AzureSignalrCorsAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetDebug(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetHelp(this AzureSignalrCorsAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetHelp(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetOutput(this AzureSignalrCorsAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetOutput(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetQuery(this AzureSignalrCorsAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetQuery(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings SetVerbose(this AzureSignalrCorsAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsAddSettings ResetVerbose(this AzureSignalrCorsAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrCorsListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrCorsListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetName(this AzureSignalrCorsListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetName(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetResourceGroup(this AzureSignalrCorsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetResourceGroup(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetSubscription(this AzureSignalrCorsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetSubscription(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetDebug(this AzureSignalrCorsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetDebug(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetHelp(this AzureSignalrCorsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetHelp(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetOutput(this AzureSignalrCorsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetOutput(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetQuery(this AzureSignalrCorsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetQuery(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings SetVerbose(this AzureSignalrCorsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsListSettings ResetVerbose(this AzureSignalrCorsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrCorsRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrCorsRemoveSettingsExtensions
    {
        #region AllowedOrigins
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/> to a new list</em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal = allowedOrigins.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings AddAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings AddAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.AddRange(allowedOrigins);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ClearAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowedOriginsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings RemoveAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings, params string[] allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureSignalrCorsRemoveSettings.AllowedOrigins"/></em></p>
        ///   <p>Space separated origins that should be allowed to make cross-origin calls (for example: <a href="http://example.com:12345">http://example.com:12345</a>). To allow all, use "\*".</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings RemoveAllowedOrigins(this AzureSignalrCorsRemoveSettings toolSettings, IEnumerable<string> allowedOrigins)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(allowedOrigins);
            toolSettings.AllowedOriginsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetName(this AzureSignalrCorsRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetName(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetResourceGroup(this AzureSignalrCorsRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetResourceGroup(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetSubscription(this AzureSignalrCorsRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetSubscription(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetDebug(this AzureSignalrCorsRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetDebug(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetHelp(this AzureSignalrCorsRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetHelp(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetOutput(this AzureSignalrCorsRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetOutput(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetQuery(this AzureSignalrCorsRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetQuery(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrCorsRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings SetVerbose(this AzureSignalrCorsRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrCorsRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrCorsRemoveSettings ResetVerbose(this AzureSignalrCorsRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrKeyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrKeyListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetName(this AzureSignalrKeyListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetName(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetResourceGroup(this AzureSignalrKeyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetResourceGroup(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetSubscription(this AzureSignalrKeyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetSubscription(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetDebug(this AzureSignalrKeyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetDebug(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetHelp(this AzureSignalrKeyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetHelp(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetOutput(this AzureSignalrKeyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetOutput(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetQuery(this AzureSignalrKeyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetQuery(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings SetVerbose(this AzureSignalrKeyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyListSettings ResetVerbose(this AzureSignalrKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSignalrKeyRenewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSignalrKeyRenewSettingsExtensions
    {
        #region KeyType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.KeyType"/></em></p>
        ///   <p>The name of access key to regenerate.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetKeyType(this AzureSignalrKeyRenewSettings toolSettings, SignalrKeyRenewKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.KeyType"/></em></p>
        ///   <p>The name of access key to regenerate.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetKeyType(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetName(this AzureSignalrKeyRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Name"/></em></p>
        ///   <p>Name of signalr service.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetName(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetResourceGroup(this AzureSignalrKeyRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetResourceGroup(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetSubscription(this AzureSignalrKeyRenewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetSubscription(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetDebug(this AzureSignalrKeyRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetDebug(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetHelp(this AzureSignalrKeyRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetHelp(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetOutput(this AzureSignalrKeyRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetOutput(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetQuery(this AzureSignalrKeyRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetQuery(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSignalrKeyRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings SetVerbose(this AzureSignalrKeyRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSignalrKeyRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSignalrKeyRenewSettings ResetVerbose(this AzureSignalrKeyRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region SignalrServiceMode
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SignalrServiceMode>))]
    public partial class SignalrServiceMode : Enumeration
    {
        public static SignalrServiceMode classic = new SignalrServiceMode { Value = "classic" };
        public static SignalrServiceMode default_ = new SignalrServiceMode { Value = "default" };
        public static SignalrServiceMode serverless = new SignalrServiceMode { Value = "serverless" };
    }
    #endregion
    #region SignalrKeyRenewKeyType
    /// <summary>
    ///   Used within <see cref="AzureSignalrTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<SignalrKeyRenewKeyType>))]
    public partial class SignalrKeyRenewKeyType : Enumeration
    {
        public static SignalrKeyRenewKeyType primary = new SignalrKeyRenewKeyType { Value = "primary" };
        public static SignalrKeyRenewKeyType secondary = new SignalrKeyRenewKeyType { Value = "secondary" };
    }
    #endregion
}
