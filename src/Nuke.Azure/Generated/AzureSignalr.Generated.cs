// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureSignalr.json
// Generated with Nuke.CodeGeneration version 0.20.1 (Windows,.NETStandard,Version=v2.0)

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
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSignalrCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCreateSettings.ResourceGroup"/></li>
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
        ///     <li><c>--debug</c> via <see cref="AzureSignalrCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSignalrCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSignalrCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSignalrCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSignalrCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSignalrCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSignalrCreateSettings.ResourceGroup"/></li>
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
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("--location {value}", Location)
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
