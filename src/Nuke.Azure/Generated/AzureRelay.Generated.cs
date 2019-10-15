// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureRelay.json
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
    public static partial class AzureRelayTasks
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public static string AzureRelayPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURERELAY_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureRelayLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelay(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureRelayPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureRelayLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelay(AzureRelaySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelaySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelaySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelaySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelaySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelaySettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelaySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelay(Configure<AzureRelaySettings> configurator)
        {
            return AzureRelay(configurator(new AzureRelaySettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelaySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelaySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelaySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelaySettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelaySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelaySettings Settings, IReadOnlyCollection<Output> Output)> AzureRelay(CombinatorialConfigure<AzureRelaySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelay, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoCreate(AzureRelayHycoCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoCreateSettings.Query"/></li>
        ///     <li><c>--requires-client-authorization</c> via <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoCreateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayHycoCreateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoCreate(Configure<AzureRelayHycoCreateSettings> configurator)
        {
            return AzureRelayHycoCreate(configurator(new AzureRelayHycoCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoCreateSettings.Query"/></li>
        ///     <li><c>--requires-client-authorization</c> via <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoCreateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayHycoCreateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoCreate(CombinatorialConfigure<AzureRelayHycoCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoCreate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoDelete(AzureRelayHycoDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoDelete(Configure<AzureRelayHycoDeleteSettings> configurator)
        {
            return AzureRelayHycoDelete(configurator(new AzureRelayHycoDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoDelete(CombinatorialConfigure<AzureRelayHycoDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoDelete, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoList(AzureRelayHycoListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoList(Configure<AzureRelayHycoListSettings> configurator)
        {
            return AzureRelayHycoList(configurator(new AzureRelayHycoListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoList(CombinatorialConfigure<AzureRelayHycoListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoShow(AzureRelayHycoShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoShow(Configure<AzureRelayHycoShowSettings> configurator)
        {
            return AzureRelayHycoShow(configurator(new AzureRelayHycoShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoShow(CombinatorialConfigure<AzureRelayHycoShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoShow, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoUpdate(AzureRelayHycoUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayHycoUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayHycoUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayHycoUpdateSettings.Remove"/></li>
        ///     <li><c>--requires-client-authorization</c> via <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayHycoUpdateSettings.Set"/></li>
        ///     <li><c>--status</c> via <see cref="AzureRelayHycoUpdateSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoUpdateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayHycoUpdateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoUpdate(Configure<AzureRelayHycoUpdateSettings> configurator)
        {
            return AzureRelayHycoUpdate(configurator(new AzureRelayHycoUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayHycoUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayHycoUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayHycoUpdateSettings.Remove"/></li>
        ///     <li><c>--requires-client-authorization</c> via <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayHycoUpdateSettings.Set"/></li>
        ///     <li><c>--status</c> via <see cref="AzureRelayHycoUpdateSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoUpdateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayHycoUpdateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoUpdate(CombinatorialConfigure<AzureRelayHycoUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoUpdate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayCreate(AzureRelayWcfrelayCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayCreateSettings.Query"/></li>
        ///     <li><c>--relay-type</c> via <see cref="AzureRelayWcfrelayCreateSettings.RelayType"/></li>
        ///     <li><c>--requires-client-authorization</c> via <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></li>
        ///     <li><c>--requires-transport-security</c> via <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayCreateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayWcfrelayCreateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayCreate(Configure<AzureRelayWcfrelayCreateSettings> configurator)
        {
            return AzureRelayWcfrelayCreate(configurator(new AzureRelayWcfrelayCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayCreateSettings.Query"/></li>
        ///     <li><c>--relay-type</c> via <see cref="AzureRelayWcfrelayCreateSettings.RelayType"/></li>
        ///     <li><c>--requires-client-authorization</c> via <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></li>
        ///     <li><c>--requires-transport-security</c> via <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayCreateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayWcfrelayCreateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayCreate(CombinatorialConfigure<AzureRelayWcfrelayCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayCreate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayDelete(AzureRelayWcfrelayDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayDelete(Configure<AzureRelayWcfrelayDeleteSettings> configurator)
        {
            return AzureRelayWcfrelayDelete(configurator(new AzureRelayWcfrelayDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayDelete(CombinatorialConfigure<AzureRelayWcfrelayDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayDelete, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayList(AzureRelayWcfrelayListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayList(Configure<AzureRelayWcfrelayListSettings> configurator)
        {
            return AzureRelayWcfrelayList(configurator(new AzureRelayWcfrelayListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayList(CombinatorialConfigure<AzureRelayWcfrelayListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayShow(AzureRelayWcfrelayShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayShow(Configure<AzureRelayWcfrelayShowSettings> configurator)
        {
            return AzureRelayWcfrelayShow(configurator(new AzureRelayWcfrelayShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayShow(CombinatorialConfigure<AzureRelayWcfrelayShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayShow, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayUpdate(AzureRelayWcfrelayUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayWcfrelayUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Query"/></li>
        ///     <li><c>--relay-type</c> via <see cref="AzureRelayWcfrelayUpdateSettings.RelayType"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Set"/></li>
        ///     <li><c>--status</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayWcfrelayUpdateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayUpdate(Configure<AzureRelayWcfrelayUpdateSettings> configurator)
        {
            return AzureRelayWcfrelayUpdate(configurator(new AzureRelayWcfrelayUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayWcfrelayUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Query"/></li>
        ///     <li><c>--relay-type</c> via <see cref="AzureRelayWcfrelayUpdateSettings.RelayType"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Set"/></li>
        ///     <li><c>--status</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Subscription"/></li>
        ///     <li><c>--user-metadata</c> via <see cref="AzureRelayWcfrelayUpdateSettings.UserMetadata"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayUpdate(CombinatorialConfigure<AzureRelayWcfrelayUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayUpdate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceCreate(AzureRelayNamespaceCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureRelayNamespaceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureRelayNamespaceCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceCreate(Configure<AzureRelayNamespaceCreateSettings> configurator)
        {
            return AzureRelayNamespaceCreate(configurator(new AzureRelayNamespaceCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureRelayNamespaceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureRelayNamespaceCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceCreate(CombinatorialConfigure<AzureRelayNamespaceCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceCreate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceDelete(AzureRelayNamespaceDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceDelete(Configure<AzureRelayNamespaceDeleteSettings> configurator)
        {
            return AzureRelayNamespaceDelete(configurator(new AzureRelayNamespaceDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceDelete(CombinatorialConfigure<AzureRelayNamespaceDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceDelete, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceExists(AzureRelayNamespaceExistsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceExistsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceExistsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceExists(Configure<AzureRelayNamespaceExistsSettings> configurator)
        {
            return AzureRelayNamespaceExists(configurator(new AzureRelayNamespaceExistsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceExistsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceExistsSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceExists(CombinatorialConfigure<AzureRelayNamespaceExistsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceExists, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceList(AzureRelayNamespaceListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceList(Configure<AzureRelayNamespaceListSettings> configurator)
        {
            return AzureRelayNamespaceList(configurator(new AzureRelayNamespaceListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceList(CombinatorialConfigure<AzureRelayNamespaceListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceShow(AzureRelayNamespaceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceShow(Configure<AzureRelayNamespaceShowSettings> configurator)
        {
            return AzureRelayNamespaceShow(configurator(new AzureRelayNamespaceShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceShow(CombinatorialConfigure<AzureRelayNamespaceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceShow, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceUpdate(AzureRelayNamespaceUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayNamespaceUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayNamespaceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayNamespaceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayNamespaceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureRelayNamespaceUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceUpdate(Configure<AzureRelayNamespaceUpdateSettings> configurator)
        {
            return AzureRelayNamespaceUpdate(configurator(new AzureRelayNamespaceUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayNamespaceUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayNamespaceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayNamespaceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayNamespaceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureRelayNamespaceUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceUpdate(CombinatorialConfigure<AzureRelayNamespaceUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceUpdate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleCreate(AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleCreate(Configure<AzureRelayWcfrelayAuthorizationRuleCreateSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleCreate(configurator(new AzureRelayWcfrelayAuthorizationRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleCreate(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleCreate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleDelete(AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleDelete(Configure<AzureRelayWcfrelayAuthorizationRuleDeleteSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleDelete(configurator(new AzureRelayWcfrelayAuthorizationRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleDelete(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleDelete, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleList(AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleList(Configure<AzureRelayWcfrelayAuthorizationRuleListSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleList(configurator(new AzureRelayWcfrelayAuthorizationRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleList(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleShow(AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleShow(Configure<AzureRelayWcfrelayAuthorizationRuleShowSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleShow(configurator(new AzureRelayWcfrelayAuthorizationRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleShow(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleShow, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleUpdate(AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.RelayName"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleUpdate(Configure<AzureRelayWcfrelayAuthorizationRuleUpdateSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleUpdate(configurator(new AzureRelayWcfrelayAuthorizationRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.RelayName"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleUpdate(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleUpdate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleCreate(AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleCreate(Configure<AzureRelayNamespaceAuthorizationRuleCreateSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleCreate(configurator(new AzureRelayNamespaceAuthorizationRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleCreate(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleCreate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleDelete(AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleDelete(Configure<AzureRelayNamespaceAuthorizationRuleDeleteSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleDelete(configurator(new AzureRelayNamespaceAuthorizationRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleDelete(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleDelete, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleList(AzureRelayNamespaceAuthorizationRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleList(Configure<AzureRelayNamespaceAuthorizationRuleListSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleList(configurator(new AzureRelayNamespaceAuthorizationRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Help"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleList(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleShow(AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleShow(Configure<AzureRelayNamespaceAuthorizationRuleShowSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleShow(configurator(new AzureRelayNamespaceAuthorizationRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleShow(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleShow, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleUpdate(AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleUpdate(Configure<AzureRelayNamespaceAuthorizationRuleUpdateSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleUpdate(configurator(new AzureRelayNamespaceAuthorizationRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleUpdate(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleUpdate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleCreate(AzureRelayHycoAuthorizationRuleCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.HybridConnectionName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleCreate(Configure<AzureRelayHycoAuthorizationRuleCreateSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleCreate(configurator(new AzureRelayHycoAuthorizationRuleCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.HybridConnectionName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleCreate(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleCreate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleDelete(AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleDelete(Configure<AzureRelayHycoAuthorizationRuleDeleteSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleDelete(configurator(new AzureRelayHycoAuthorizationRuleDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleDelete(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleDelete, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleList(AzureRelayHycoAuthorizationRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.HybridConnectionName"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleList(Configure<AzureRelayHycoAuthorizationRuleListSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleList(configurator(new AzureRelayHycoAuthorizationRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.HybridConnectionName"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleList(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleShow(AzureRelayHycoAuthorizationRuleShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleShow(Configure<AzureRelayHycoAuthorizationRuleShowSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleShow(configurator(new AzureRelayHycoAuthorizationRuleShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleShow(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleShow, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleUpdate(AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleUpdate(Configure<AzureRelayHycoAuthorizationRuleUpdateSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleUpdate(configurator(new AzureRelayHycoAuthorizationRuleUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--rights</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></li>
        ///     <li><c>--set</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleUpdate(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleUpdate, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleKeysList(AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleKeysListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleKeysList(Configure<AzureRelayWcfrelayAuthorizationRuleKeysListSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleKeysList(configurator(new AzureRelayWcfrelayAuthorizationRuleKeysListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleKeysListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleKeysList(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleKeysListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleKeysList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleKeysRenew(AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Key"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.KeyValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayWcfrelayAuthorizationRuleKeysRenew(Configure<AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings> configurator)
        {
            return AzureRelayWcfrelayAuthorizationRuleKeysRenew(configurator(new AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Key"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.KeyValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Query"/></li>
        ///     <li><c>--relay-name</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.RelayName"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayWcfrelayAuthorizationRuleKeysRenew(CombinatorialConfigure<AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayWcfrelayAuthorizationRuleKeysRenew, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleKeysList(AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleKeysListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleKeysList(Configure<AzureRelayNamespaceAuthorizationRuleKeysListSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleKeysList(configurator(new AzureRelayNamespaceAuthorizationRuleKeysListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleKeysListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleKeysList(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleKeysListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleKeysList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleKeysRenew(AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayNamespaceAuthorizationRuleKeysRenewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Key"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.KeyValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayNamespaceAuthorizationRuleKeysRenew(Configure<AzureRelayNamespaceAuthorizationRuleKeysRenewSettings> configurator)
        {
            return AzureRelayNamespaceAuthorizationRuleKeysRenew(configurator(new AzureRelayNamespaceAuthorizationRuleKeysRenewSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Key"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.KeyValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayNamespaceAuthorizationRuleKeysRenewSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayNamespaceAuthorizationRuleKeysRenew(CombinatorialConfigure<AzureRelayNamespaceAuthorizationRuleKeysRenewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayNamespaceAuthorizationRuleKeysRenew, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleKeysList(AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleKeysListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.HybridConnectionName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleKeysList(Configure<AzureRelayHycoAuthorizationRuleKeysListSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleKeysList(configurator(new AzureRelayHycoAuthorizationRuleKeysListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.HybridConnectionName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleKeysListSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleKeysList(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleKeysListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleKeysList, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleKeysRenew(AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureRelayHycoAuthorizationRuleKeysRenewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Key"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.KeyValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureRelayHycoAuthorizationRuleKeysRenew(Configure<AzureRelayHycoAuthorizationRuleKeysRenewSettings> configurator)
        {
            return AzureRelayHycoAuthorizationRuleKeysRenew(configurator(new AzureRelayHycoAuthorizationRuleKeysRenewSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Relay Service namespaces, WCF relays, hybrid connections, and rules.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/relay?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Help"/></li>
        ///     <li><c>--hybrid-connection-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.HybridConnectionName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></li>
        ///     <li><c>--key</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Key"/></li>
        ///     <li><c>--key-value</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.KeyValue"/></li>
        ///     <li><c>--name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Name"/></li>
        ///     <li><c>--namespace-name</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.NamespaceName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureRelayHycoAuthorizationRuleKeysRenewSettings Settings, IReadOnlyCollection<Output> Output)> AzureRelayHycoAuthorizationRuleKeysRenew(CombinatorialConfigure<AzureRelayHycoAuthorizationRuleKeysRenewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureRelayHycoAuthorizationRuleKeysRenew, AzureRelayLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureRelaySettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelaySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
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
              .Add("relay")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRelayHycoCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Indicates whether client authorization is required.
        /// </summary>
        public virtual bool? RequiresClientAuthorization { get; internal set; }
        /// <summary>
        ///   Endpoint metadata.
        /// </summary>
        public virtual string UserMetadata { get; internal set; }
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
              .Add("relay hyco create")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--requires-client-authorization", RequiresClientAuthorization)
              .Add("--user-metadata {value}", UserMetadata)
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
    #region AzureRelayHycoDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco list")
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Indicates whether client authorization is required.
        /// </summary>
        public virtual bool? RequiresClientAuthorization { get; internal set; }
        /// <summary>
        ///   Enumerates the possible values for the status of a messaging entity.
        /// </summary>
        public virtual RelayHycoStatus Status { get; internal set; }
        /// <summary>
        ///   Endpoint metadata.
        /// </summary>
        public virtual string UserMetadata { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco update")
              .Add("--requires-client-authorization", RequiresClientAuthorization)
              .Add("--status {value}", Status)
              .Add("--user-metadata {value}", UserMetadata)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayWcfrelayCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Relay type.
        /// </summary>
        public virtual RelayWcfrelayRelayType RelayType { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Indicates whether client authorization is required.
        /// </summary>
        public virtual bool? RequiresClientAuthorization { get; internal set; }
        /// <summary>
        ///   Indicates whether transport security is required.
        /// </summary>
        public virtual bool? RequiresTransportSecurity { get; internal set; }
        /// <summary>
        ///   Endpoint metadata.
        /// </summary>
        public virtual string UserMetadata { get; internal set; }
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
              .Add("relay wcfrelay create")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-type {value}", RelayType)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--requires-client-authorization", RequiresClientAuthorization)
              .Add("--requires-transport-security", RequiresTransportSecurity)
              .Add("--user-metadata {value}", UserMetadata)
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
    #region AzureRelayWcfrelayDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay wcfrelay delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayWcfrelayListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay wcfrelay list")
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayWcfrelayShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay wcfrelay show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayWcfrelayUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Relay type.
        /// </summary>
        public virtual RelayWcfrelayRelayType RelayType { get; internal set; }
        /// <summary>
        ///   Enumerates the possible values for the status of a messaging entity.
        /// </summary>
        public virtual RelayHycoStatus Status { get; internal set; }
        /// <summary>
        ///   Endpoint metadata.
        /// </summary>
        public virtual string UserMetadata { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay wcfrelay update")
              .Add("--relay-type {value}", RelayType)
              .Add("--status {value}", Status)
              .Add("--user-metadata {value}", UserMetadata)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayNamespaceCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
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
              .Add("relay namespace create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--tags {value}", Tags)
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
    #region AzureRelayNamespaceDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace.
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
              .Add("relay namespace delete")
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
    #region AzureRelayNamespaceExistsSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceExistsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Namespace name. Name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number.
        /// </summary>
        public virtual string Name { get; internal set; }
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
              .Add("relay namespace exists")
              .Add("--name {value}", Name)
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
    #region AzureRelayNamespaceListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
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
              .Add("relay namespace list")
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
    #region AzureRelayNamespaceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace.
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
              .Add("relay namespace show")
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
    #region AzureRelayNamespaceUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace.
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
              .Add("relay namespace update")
              .Add("--tags {value}", Tags)
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
    #region AzureRelayWcfrelayAuthorizationRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of WCF Relay Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space-separated list of Authorization rule rights.
        /// </summary>
        public virtual IReadOnlyList<RelayWcfrelayAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<RelayWcfrelayAuthorizationRuleRights> RightsInternal { get; set; } = new List<RelayWcfrelayAuthorizationRuleRights>();
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
              .Add("relay wcfrelay authorization-rule create")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
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
    #region AzureRelayWcfrelayAuthorizationRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
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
              .Add("relay wcfrelay authorization-rule delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
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
    #region AzureRelayWcfrelayAuthorizationRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
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
              .Add("relay wcfrelay authorization-rule list")
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
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
    #region AzureRelayWcfrelayAuthorizationRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
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
              .Add("relay wcfrelay authorization-rule show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
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
    #region AzureRelayWcfrelayAuthorizationRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Space-separated list of Authorization rule rights.
        /// </summary>
        public virtual IReadOnlyList<RelayWcfrelayAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<RelayWcfrelayAuthorizationRuleRights> RightsInternal { get; set; } = new List<RelayWcfrelayAuthorizationRuleRights>();
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
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
              .Add("relay wcfrelay authorization-rule update")
              .Add("--rights {value}", Rights, separator: ' ')
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
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
    #region AzureRelayNamespaceAuthorizationRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Namespace Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space-separated list of Authorization rule rights.
        /// </summary>
        public virtual IReadOnlyList<RelayWcfrelayAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<RelayWcfrelayAuthorizationRuleRights> RightsInternal { get; set; } = new List<RelayWcfrelayAuthorizationRuleRights>();
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
              .Add("relay namespace authorization-rule create")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
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
    #region AzureRelayNamespaceAuthorizationRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay namespace authorization-rule delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayNamespaceAuthorizationRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of the Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay namespace authorization-rule list")
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayNamespaceAuthorizationRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay namespace authorization-rule show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayNamespaceAuthorizationRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Space-separated list of Authorization rule rights.
        /// </summary>
        public virtual IReadOnlyList<RelayWcfrelayAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<RelayWcfrelayAuthorizationRuleRights> RightsInternal { get; set; } = new List<RelayWcfrelayAuthorizationRuleRights>();
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay namespace authorization-rule update")
              .Add("--rights {value}", Rights, separator: ' ')
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoAuthorizationRuleCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   Name of Hybrid Connection Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space-separated list of Authorization rule rights.
        /// </summary>
        public virtual IReadOnlyList<RelayWcfrelayAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<RelayWcfrelayAuthorizationRuleRights> RightsInternal { get; set; } = new List<RelayWcfrelayAuthorizationRuleRights>();
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
              .Add("relay hyco authorization-rule create")
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--rights {value}", Rights, separator: ' ')
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
    #region AzureRelayHycoAuthorizationRuleDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco authorization-rule delete")
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoAuthorizationRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco authorization-rule list")
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoAuthorizationRuleShowSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco authorization-rule show")
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoAuthorizationRuleUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Space-separated list of Authorization rule rights.
        /// </summary>
        public virtual IReadOnlyList<RelayWcfrelayAuthorizationRuleRights> Rights => RightsInternal.AsReadOnly();
        internal List<RelayWcfrelayAuthorizationRuleRights> RightsInternal { get; set; } = new List<RelayWcfrelayAuthorizationRuleRights>();
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco authorization-rule update")
              .Add("--rights {value}", Rights, separator: ' ')
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayWcfrelayAuthorizationRuleKeysListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleKeysListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of WCF Relay Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
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
              .Add("relay wcfrelay authorization-rule keys list")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
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
    #region AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Specifies Primary or Secondary key needs to be reset.
        /// </summary>
        public virtual RelayWcfrelayAuthorizationRuleKeysKey Key { get; internal set; }
        /// <summary>
        ///   Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.
        /// </summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of WCF Relay Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
        /// <summary>
        ///   Name of WCF Relay.
        /// </summary>
        public virtual string RelayName { get; internal set; }
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
              .Add("relay wcfrelay authorization-rule keys renew")
              .Add("--key {value}", Key)
              .Add("--key-value {value}", KeyValue)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
              .Add("--relay-name {value}", RelayName)
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
    #region AzureRelayNamespaceAuthorizationRuleKeysListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleKeysListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Namespace Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay namespace authorization-rule keys list")
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayNamespaceAuthorizationRuleKeysRenewSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayNamespaceAuthorizationRuleKeysRenewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Specifies Primary or Secondary key needs to be reset.
        /// </summary>
        public virtual RelayWcfrelayAuthorizationRuleKeysKey Key { get; internal set; }
        /// <summary>
        ///   Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.
        /// </summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Namespace Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay namespace authorization-rule keys renew")
              .Add("--key {value}", Key)
              .Add("--key-value {value}", KeyValue)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoAuthorizationRuleKeysListSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleKeysListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   Name of Hybrid Connection Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco authorization-rule keys list")
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelayHycoAuthorizationRuleKeysRenewSettings
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRelayHycoAuthorizationRuleKeysRenewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureRelay executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureRelayTasks.AzureRelayPath;
        public override Action<OutputType, string> CustomLogger => AzureRelayTasks.AzureRelayLogger;
        /// <summary>
        ///   Specifies Primary or Secondary key needs to be reset.
        /// </summary>
        public virtual RelayWcfrelayAuthorizationRuleKeysKey Key { get; internal set; }
        /// <summary>
        ///   Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.
        /// </summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary>
        ///   Name of Hybrid Connection.
        /// </summary>
        public virtual string HybridConnectionName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of Hybrid Connection Authorization Rule.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of Namespace.
        /// </summary>
        public virtual string NamespaceName { get; internal set; }
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
              .Add("relay hyco authorization-rule keys renew")
              .Add("--key {value}", Key)
              .Add("--key-value {value}", KeyValue)
              .Add("--hybrid-connection-name {value}", HybridConnectionName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace-name {value}", NamespaceName)
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
    #region AzureRelaySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelaySettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelaySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings SetDebug(this AzureRelaySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelaySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings ResetDebug(this AzureRelaySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelaySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings SetHelp(this AzureRelaySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelaySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings ResetHelp(this AzureRelaySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelaySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings SetOutput(this AzureRelaySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelaySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings ResetOutput(this AzureRelaySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelaySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings SetQuery(this AzureRelaySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelaySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings ResetQuery(this AzureRelaySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelaySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings SetVerbose(this AzureRelaySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelaySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelaySettings ResetVerbose(this AzureRelaySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetName(this AzureRelayHycoCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetName(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetNamespaceName(this AzureRelayHycoCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetNamespaceName(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetResourceGroup(this AzureRelayHycoCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetResourceGroup(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RequiresClientAuthorization
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetRequiresClientAuthorization(this AzureRelayHycoCreateSettings toolSettings, bool? requiresClientAuthorization)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = requiresClientAuthorization;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetRequiresClientAuthorization(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings EnableRequiresClientAuthorization(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings DisableRequiresClientAuthorization(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureRelayHycoCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ToggleRequiresClientAuthorization(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = !toolSettings.RequiresClientAuthorization;
            return toolSettings;
        }
        #endregion
        #region UserMetadata
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetUserMetadata(this AzureRelayHycoCreateSettings toolSettings, string userMetadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = userMetadata;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetUserMetadata(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetSubscription(this AzureRelayHycoCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetSubscription(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetDebug(this AzureRelayHycoCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetDebug(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetHelp(this AzureRelayHycoCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetHelp(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetOutput(this AzureRelayHycoCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetOutput(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetQuery(this AzureRelayHycoCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetQuery(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings SetVerbose(this AzureRelayHycoCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoCreateSettings ResetVerbose(this AzureRelayHycoCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetIds(this AzureRelayHycoDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetIds(this AzureRelayHycoDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings AddIds(this AzureRelayHycoDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings AddIds(this AzureRelayHycoDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ClearIds(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings RemoveIds(this AzureRelayHycoDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings RemoveIds(this AzureRelayHycoDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetName(this AzureRelayHycoDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetName(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetNamespaceName(this AzureRelayHycoDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetNamespaceName(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetResourceGroup(this AzureRelayHycoDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetResourceGroup(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetSubscription(this AzureRelayHycoDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetSubscription(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetDebug(this AzureRelayHycoDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetDebug(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetHelp(this AzureRelayHycoDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetHelp(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetOutput(this AzureRelayHycoDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetOutput(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetQuery(this AzureRelayHycoDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetQuery(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings SetVerbose(this AzureRelayHycoDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoDeleteSettings ResetVerbose(this AzureRelayHycoDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoListSettingsExtensions
    {
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetNamespaceName(this AzureRelayHycoListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetNamespaceName(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetResourceGroup(this AzureRelayHycoListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetResourceGroup(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetSubscription(this AzureRelayHycoListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetSubscription(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetDebug(this AzureRelayHycoListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetDebug(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetHelp(this AzureRelayHycoListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetHelp(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetOutput(this AzureRelayHycoListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetOutput(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetQuery(this AzureRelayHycoListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetQuery(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings SetVerbose(this AzureRelayHycoListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoListSettings ResetVerbose(this AzureRelayHycoListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetIds(this AzureRelayHycoShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetIds(this AzureRelayHycoShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings AddIds(this AzureRelayHycoShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings AddIds(this AzureRelayHycoShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ClearIds(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings RemoveIds(this AzureRelayHycoShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings RemoveIds(this AzureRelayHycoShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetName(this AzureRelayHycoShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetName(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetNamespaceName(this AzureRelayHycoShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetNamespaceName(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetResourceGroup(this AzureRelayHycoShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetResourceGroup(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetSubscription(this AzureRelayHycoShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetSubscription(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetDebug(this AzureRelayHycoShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetDebug(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetHelp(this AzureRelayHycoShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetHelp(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetOutput(this AzureRelayHycoShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetOutput(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetQuery(this AzureRelayHycoShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetQuery(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings SetVerbose(this AzureRelayHycoShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoShowSettings ResetVerbose(this AzureRelayHycoShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoUpdateSettingsExtensions
    {
        #region RequiresClientAuthorization
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetRequiresClientAuthorization(this AzureRelayHycoUpdateSettings toolSettings, bool? requiresClientAuthorization)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = requiresClientAuthorization;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetRequiresClientAuthorization(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings EnableRequiresClientAuthorization(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings DisableRequiresClientAuthorization(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureRelayHycoUpdateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ToggleRequiresClientAuthorization(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = !toolSettings.RequiresClientAuthorization;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Status"/></em></p>
        ///   <p>Enumerates the possible values for the status of a messaging entity.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetStatus(this AzureRelayHycoUpdateSettings toolSettings, RelayHycoStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Status"/></em></p>
        ///   <p>Enumerates the possible values for the status of a messaging entity.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetStatus(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region UserMetadata
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetUserMetadata(this AzureRelayHycoUpdateSettings toolSettings, string userMetadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = userMetadata;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetUserMetadata(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetIds(this AzureRelayHycoUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetIds(this AzureRelayHycoUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings AddIds(this AzureRelayHycoUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings AddIds(this AzureRelayHycoUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ClearIds(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings RemoveIds(this AzureRelayHycoUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings RemoveIds(this AzureRelayHycoUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetName(this AzureRelayHycoUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetName(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetNamespaceName(this AzureRelayHycoUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetNamespaceName(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetResourceGroup(this AzureRelayHycoUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetResourceGroup(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetSubscription(this AzureRelayHycoUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetSubscription(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetAdd(this AzureRelayHycoUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetAdd(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetForceString(this AzureRelayHycoUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetForceString(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetRemove(this AzureRelayHycoUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetRemove(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetSet(this AzureRelayHycoUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetSet(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetDebug(this AzureRelayHycoUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetDebug(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetHelp(this AzureRelayHycoUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetHelp(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetOutput(this AzureRelayHycoUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetOutput(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetQuery(this AzureRelayHycoUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetQuery(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings SetVerbose(this AzureRelayHycoUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoUpdateSettings ResetVerbose(this AzureRelayHycoUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetName(this AzureRelayWcfrelayCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetName(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetNamespaceName(this AzureRelayWcfrelayCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetNamespaceName(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.RelayType"/></em></p>
        ///   <p>Relay type.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetRelayType(this AzureRelayWcfrelayCreateSettings toolSettings, RelayWcfrelayRelayType relayType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayType = relayType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.RelayType"/></em></p>
        ///   <p>Relay type.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetRelayType(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayType = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetResourceGroup(this AzureRelayWcfrelayCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetResourceGroup(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RequiresClientAuthorization
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetRequiresClientAuthorization(this AzureRelayWcfrelayCreateSettings toolSettings, bool? requiresClientAuthorization)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = requiresClientAuthorization;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetRequiresClientAuthorization(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings EnableRequiresClientAuthorization(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings DisableRequiresClientAuthorization(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureRelayWcfrelayCreateSettings.RequiresClientAuthorization"/></em></p>
        ///   <p>Indicates whether client authorization is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ToggleRequiresClientAuthorization(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresClientAuthorization = !toolSettings.RequiresClientAuthorization;
            return toolSettings;
        }
        #endregion
        #region RequiresTransportSecurity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></em></p>
        ///   <p>Indicates whether transport security is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetRequiresTransportSecurity(this AzureRelayWcfrelayCreateSettings toolSettings, bool? requiresTransportSecurity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresTransportSecurity = requiresTransportSecurity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></em></p>
        ///   <p>Indicates whether transport security is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetRequiresTransportSecurity(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresTransportSecurity = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></em></p>
        ///   <p>Indicates whether transport security is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings EnableRequiresTransportSecurity(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresTransportSecurity = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></em></p>
        ///   <p>Indicates whether transport security is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings DisableRequiresTransportSecurity(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresTransportSecurity = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureRelayWcfrelayCreateSettings.RequiresTransportSecurity"/></em></p>
        ///   <p>Indicates whether transport security is required.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ToggleRequiresTransportSecurity(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiresTransportSecurity = !toolSettings.RequiresTransportSecurity;
            return toolSettings;
        }
        #endregion
        #region UserMetadata
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetUserMetadata(this AzureRelayWcfrelayCreateSettings toolSettings, string userMetadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = userMetadata;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetUserMetadata(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetSubscription(this AzureRelayWcfrelayCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetSubscription(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetDebug(this AzureRelayWcfrelayCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetDebug(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetHelp(this AzureRelayWcfrelayCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetHelp(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetOutput(this AzureRelayWcfrelayCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetOutput(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetQuery(this AzureRelayWcfrelayCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetQuery(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings SetVerbose(this AzureRelayWcfrelayCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayCreateSettings ResetVerbose(this AzureRelayWcfrelayCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetIds(this AzureRelayWcfrelayDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetIds(this AzureRelayWcfrelayDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings AddIds(this AzureRelayWcfrelayDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings AddIds(this AzureRelayWcfrelayDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ClearIds(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings RemoveIds(this AzureRelayWcfrelayDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings RemoveIds(this AzureRelayWcfrelayDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetName(this AzureRelayWcfrelayDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetName(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetNamespaceName(this AzureRelayWcfrelayDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetNamespaceName(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetResourceGroup(this AzureRelayWcfrelayDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetResourceGroup(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetSubscription(this AzureRelayWcfrelayDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetSubscription(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetDebug(this AzureRelayWcfrelayDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetDebug(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetHelp(this AzureRelayWcfrelayDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetHelp(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetOutput(this AzureRelayWcfrelayDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetOutput(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetQuery(this AzureRelayWcfrelayDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetQuery(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings SetVerbose(this AzureRelayWcfrelayDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayDeleteSettings ResetVerbose(this AzureRelayWcfrelayDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayListSettingsExtensions
    {
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetNamespaceName(this AzureRelayWcfrelayListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetNamespaceName(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetResourceGroup(this AzureRelayWcfrelayListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetResourceGroup(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetSubscription(this AzureRelayWcfrelayListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetSubscription(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetDebug(this AzureRelayWcfrelayListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetDebug(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetHelp(this AzureRelayWcfrelayListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetHelp(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetOutput(this AzureRelayWcfrelayListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetOutput(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetQuery(this AzureRelayWcfrelayListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetQuery(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings SetVerbose(this AzureRelayWcfrelayListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayListSettings ResetVerbose(this AzureRelayWcfrelayListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetIds(this AzureRelayWcfrelayShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetIds(this AzureRelayWcfrelayShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings AddIds(this AzureRelayWcfrelayShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings AddIds(this AzureRelayWcfrelayShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ClearIds(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings RemoveIds(this AzureRelayWcfrelayShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings RemoveIds(this AzureRelayWcfrelayShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetName(this AzureRelayWcfrelayShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetName(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetNamespaceName(this AzureRelayWcfrelayShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetNamespaceName(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetResourceGroup(this AzureRelayWcfrelayShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetResourceGroup(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetSubscription(this AzureRelayWcfrelayShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetSubscription(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetDebug(this AzureRelayWcfrelayShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetDebug(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetHelp(this AzureRelayWcfrelayShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetHelp(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetOutput(this AzureRelayWcfrelayShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetOutput(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetQuery(this AzureRelayWcfrelayShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetQuery(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings SetVerbose(this AzureRelayWcfrelayShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayShowSettings ResetVerbose(this AzureRelayWcfrelayShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayUpdateSettingsExtensions
    {
        #region RelayType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.RelayType"/></em></p>
        ///   <p>Relay type.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetRelayType(this AzureRelayWcfrelayUpdateSettings toolSettings, RelayWcfrelayRelayType relayType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayType = relayType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.RelayType"/></em></p>
        ///   <p>Relay type.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetRelayType(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayType = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Status"/></em></p>
        ///   <p>Enumerates the possible values for the status of a messaging entity.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetStatus(this AzureRelayWcfrelayUpdateSettings toolSettings, RelayHycoStatus status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Status"/></em></p>
        ///   <p>Enumerates the possible values for the status of a messaging entity.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetStatus(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region UserMetadata
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetUserMetadata(this AzureRelayWcfrelayUpdateSettings toolSettings, string userMetadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = userMetadata;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.UserMetadata"/></em></p>
        ///   <p>Endpoint metadata.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetUserMetadata(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserMetadata = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetIds(this AzureRelayWcfrelayUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetIds(this AzureRelayWcfrelayUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings AddIds(this AzureRelayWcfrelayUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings AddIds(this AzureRelayWcfrelayUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ClearIds(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings RemoveIds(this AzureRelayWcfrelayUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings RemoveIds(this AzureRelayWcfrelayUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetName(this AzureRelayWcfrelayUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetName(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetNamespaceName(this AzureRelayWcfrelayUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetNamespaceName(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetResourceGroup(this AzureRelayWcfrelayUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetResourceGroup(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetSubscription(this AzureRelayWcfrelayUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetSubscription(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetAdd(this AzureRelayWcfrelayUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetAdd(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetForceString(this AzureRelayWcfrelayUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetForceString(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetRemove(this AzureRelayWcfrelayUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetRemove(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetSet(this AzureRelayWcfrelayUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetSet(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetDebug(this AzureRelayWcfrelayUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetDebug(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetHelp(this AzureRelayWcfrelayUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetHelp(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetOutput(this AzureRelayWcfrelayUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetOutput(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetQuery(this AzureRelayWcfrelayUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetQuery(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings SetVerbose(this AzureRelayWcfrelayUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayUpdateSettings ResetVerbose(this AzureRelayWcfrelayUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetName(this AzureRelayNamespaceCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetName(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetResourceGroup(this AzureRelayNamespaceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetResourceGroup(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetLocation(this AzureRelayNamespaceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetLocation(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetTags(this AzureRelayNamespaceCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetTags(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetSubscription(this AzureRelayNamespaceCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetSubscription(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetDebug(this AzureRelayNamespaceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetDebug(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetHelp(this AzureRelayNamespaceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetHelp(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetOutput(this AzureRelayNamespaceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetOutput(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetQuery(this AzureRelayNamespaceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetQuery(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings SetVerbose(this AzureRelayNamespaceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceCreateSettings ResetVerbose(this AzureRelayNamespaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetIds(this AzureRelayNamespaceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetIds(this AzureRelayNamespaceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings AddIds(this AzureRelayNamespaceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings AddIds(this AzureRelayNamespaceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ClearIds(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings RemoveIds(this AzureRelayNamespaceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings RemoveIds(this AzureRelayNamespaceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetName(this AzureRelayNamespaceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetName(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetResourceGroup(this AzureRelayNamespaceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetResourceGroup(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetSubscription(this AzureRelayNamespaceDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetSubscription(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetDebug(this AzureRelayNamespaceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetDebug(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetHelp(this AzureRelayNamespaceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetHelp(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetOutput(this AzureRelayNamespaceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetOutput(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetQuery(this AzureRelayNamespaceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetQuery(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings SetVerbose(this AzureRelayNamespaceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceDeleteSettings ResetVerbose(this AzureRelayNamespaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceExistsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceExistsSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Name"/></em></p>
        ///   <p>Namespace name. Name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetName(this AzureRelayNamespaceExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Name"/></em></p>
        ///   <p>Namespace name. Name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetName(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetSubscription(this AzureRelayNamespaceExistsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetSubscription(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetDebug(this AzureRelayNamespaceExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetDebug(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetHelp(this AzureRelayNamespaceExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetHelp(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetOutput(this AzureRelayNamespaceExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetOutput(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetQuery(this AzureRelayNamespaceExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetQuery(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings SetVerbose(this AzureRelayNamespaceExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceExistsSettings ResetVerbose(this AzureRelayNamespaceExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetResourceGroup(this AzureRelayNamespaceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetResourceGroup(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetSubscription(this AzureRelayNamespaceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetSubscription(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetDebug(this AzureRelayNamespaceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetDebug(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetHelp(this AzureRelayNamespaceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetHelp(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetOutput(this AzureRelayNamespaceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetOutput(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetQuery(this AzureRelayNamespaceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetQuery(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings SetVerbose(this AzureRelayNamespaceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceListSettings ResetVerbose(this AzureRelayNamespaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetIds(this AzureRelayNamespaceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetIds(this AzureRelayNamespaceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings AddIds(this AzureRelayNamespaceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings AddIds(this AzureRelayNamespaceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ClearIds(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings RemoveIds(this AzureRelayNamespaceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings RemoveIds(this AzureRelayNamespaceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetName(this AzureRelayNamespaceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetName(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetResourceGroup(this AzureRelayNamespaceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetResourceGroup(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetSubscription(this AzureRelayNamespaceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetSubscription(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetDebug(this AzureRelayNamespaceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetDebug(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetHelp(this AzureRelayNamespaceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetHelp(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetOutput(this AzureRelayNamespaceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetOutput(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetQuery(this AzureRelayNamespaceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetQuery(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings SetVerbose(this AzureRelayNamespaceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceShowSettings ResetVerbose(this AzureRelayNamespaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetTags(this AzureRelayNamespaceUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetTags(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetIds(this AzureRelayNamespaceUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetIds(this AzureRelayNamespaceUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings AddIds(this AzureRelayNamespaceUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings AddIds(this AzureRelayNamespaceUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ClearIds(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings RemoveIds(this AzureRelayNamespaceUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings RemoveIds(this AzureRelayNamespaceUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetName(this AzureRelayNamespaceUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Name"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetName(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetResourceGroup(this AzureRelayNamespaceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetResourceGroup(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetSubscription(this AzureRelayNamespaceUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetSubscription(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetAdd(this AzureRelayNamespaceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetAdd(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetForceString(this AzureRelayNamespaceUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetForceString(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetRemove(this AzureRelayNamespaceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetRemove(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetSet(this AzureRelayNamespaceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetSet(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetDebug(this AzureRelayNamespaceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetDebug(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetHelp(this AzureRelayNamespaceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetHelp(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetOutput(this AzureRelayNamespaceUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetOutput(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetQuery(this AzureRelayNamespaceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetQuery(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings SetVerbose(this AzureRelayNamespaceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceUpdateSettings ResetVerbose(this AzureRelayNamespaceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetName(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetName(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings AddRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings AddRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ClearRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings RemoveRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings RemoveRights(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleCreateSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ClearIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetName(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetName(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleDeleteSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleListSettingsExtensions
    {
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleListSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ClearIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetName(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetName(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleShowSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleUpdateSettingsExtensions
    {
        #region Rights
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings AddRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings AddRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ClearRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings RemoveRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings RemoveRights(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ClearIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetName(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetName(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetAdd(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetAdd(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetForceString(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetForceString(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetRemove(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetRemove(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetSet(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetSet(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleUpdateSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetName(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetName(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings AddRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings AddRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ClearRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings RemoveRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings RemoveRights(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleCreateSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings AddIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings AddIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ClearIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetName(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetName(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleDeleteSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleListSettingsExtensions
    {
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.NamespaceName"/></em></p>
        ///   <p>Name of the Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.NamespaceName"/></em></p>
        ///   <p>Name of the Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleListSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings AddIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings AddIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ClearIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetName(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetName(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleShowSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleUpdateSettingsExtensions
    {
        #region Rights
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings AddRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings AddRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ClearRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings RemoveRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings RemoveRights(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings AddIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings AddIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ClearIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetName(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetName(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetAdd(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetAdd(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetForceString(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetForceString(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetRemove(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetRemove(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetSet(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetSet(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleUpdateSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleCreateSettingsExtensions
    {
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetName(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetName(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Rights
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings AddRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings AddRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ClearRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings RemoveRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings RemoveRights(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetSubscription(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetDebug(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetDebug(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetHelp(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetHelp(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetOutput(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetOutput(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetQuery(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetQuery(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings SetVerbose(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleCreateSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleDeleteSettingsExtensions
    {
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings AddIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings AddIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ClearIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings RemoveIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings RemoveIds(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetName(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetName(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetSubscription(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetDebug(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetDebug(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetHelp(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetHelp(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetOutput(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetOutput(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetQuery(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetQuery(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings SetVerbose(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleDeleteSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleListSettingsExtensions
    {
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetSubscription(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetDebug(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetDebug(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetHelp(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetHelp(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetOutput(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetOutput(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetQuery(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetQuery(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings SetVerbose(this AzureRelayHycoAuthorizationRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleListSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleShowSettingsExtensions
    {
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings AddIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings AddIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ClearIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings RemoveIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings RemoveIds(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetName(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetName(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetSubscription(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetDebug(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetDebug(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetHelp(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetHelp(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetOutput(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetOutput(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetQuery(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetQuery(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings SetVerbose(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleShowSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleUpdateSettingsExtensions
    {
        #region Rights
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/> to a new list</em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal = rights.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings AddRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings AddRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.AddRange(rights);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ClearRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RightsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings RemoveRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, params RelayWcfrelayAuthorizationRuleRights[] rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Rights"/></em></p>
        ///   <p>Space-separated list of Authorization rule rights.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings RemoveRights(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, IEnumerable<RelayWcfrelayAuthorizationRuleRights> rights)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<RelayWcfrelayAuthorizationRuleRights>(rights);
            toolSettings.RightsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings AddIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings AddIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ClearIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings RemoveIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings RemoveIds(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetName(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetName(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetSubscription(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetAdd(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetAdd(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetForceString(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetForceString(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetRemove(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetRemove(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetSet(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetSet(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetDebug(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetDebug(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetHelp(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetHelp(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetOutput(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetOutput(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetQuery(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetQuery(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings SetVerbose(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleUpdateSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleKeysListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleKeysListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetName(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetName(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysListSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayWcfrelayAuthorizationRuleKeysRenewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayWcfrelayAuthorizationRuleKeysRenewSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Key"/></em></p>
        ///   <p>Specifies Primary or Secondary key needs to be reset.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetKey(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, RelayWcfrelayAuthorizationRuleKeysKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Key"/></em></p>
        ///   <p>Specifies Primary or Secondary key needs to be reset.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetKey(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.KeyValue"/></em></p>
        ///   <p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetKeyValue(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.KeyValue"/></em></p>
        ///   <p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetKeyValue(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings AddIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ClearIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings RemoveIds(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetName(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Name"/></em></p>
        ///   <p>Name of WCF Relay Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetName(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetNamespaceName(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region RelayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetRelayName(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string relayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = relayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.RelayName"/></em></p>
        ///   <p>Name of WCF Relay.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetRelayName(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RelayName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetResourceGroup(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetSubscription(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetSubscription(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetDebug(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetDebug(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetHelp(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetHelp(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetOutput(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetOutput(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetQuery(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetQuery(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings SetVerbose(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings ResetVerbose(this AzureRelayWcfrelayAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleKeysListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleKeysListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetName(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetName(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysListSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayNamespaceAuthorizationRuleKeysRenewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayNamespaceAuthorizationRuleKeysRenewSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Key"/></em></p>
        ///   <p>Specifies Primary or Secondary key needs to be reset.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetKey(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, RelayWcfrelayAuthorizationRuleKeysKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Key"/></em></p>
        ///   <p>Specifies Primary or Secondary key needs to be reset.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetKey(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.KeyValue"/></em></p>
        ///   <p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetKeyValue(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.KeyValue"/></em></p>
        ///   <p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetKeyValue(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings AddIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings AddIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ClearIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings RemoveIds(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetName(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Name"/></em></p>
        ///   <p>Name of Namespace Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetName(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetNamespaceName(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetNamespaceName(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetResourceGroup(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetResourceGroup(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetSubscription(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetSubscription(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetDebug(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetDebug(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetHelp(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetHelp(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetOutput(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetOutput(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetQuery(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetQuery(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings SetVerbose(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayNamespaceAuthorizationRuleKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayNamespaceAuthorizationRuleKeysRenewSettings ResetVerbose(this AzureRelayNamespaceAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleKeysListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleKeysListSettingsExtensions
    {
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetName(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetName(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetSubscription(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetDebug(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetDebug(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetHelp(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetHelp(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetOutput(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetOutput(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetQuery(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetQuery(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings SetVerbose(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysListSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRelayHycoAuthorizationRuleKeysRenewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRelayHycoAuthorizationRuleKeysRenewSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Key"/></em></p>
        ///   <p>Specifies Primary or Secondary key needs to be reset.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetKey(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, RelayWcfrelayAuthorizationRuleKeysKey key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Key"/></em></p>
        ///   <p>Specifies Primary or Secondary key needs to be reset.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetKey(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.KeyValue"/></em></p>
        ///   <p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetKeyValue(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.KeyValue"/></em></p>
        ///   <p>Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetKeyValue(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region HybridConnectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetHybridConnectionName(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string hybridConnectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = hybridConnectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.HybridConnectionName"/></em></p>
        ///   <p>Name of Hybrid Connection.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetHybridConnectionName(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnectionName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings AddIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings AddIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ClearIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings RemoveIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings RemoveIds(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetName(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Name"/></em></p>
        ///   <p>Name of Hybrid Connection Authorization Rule.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetName(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NamespaceName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetNamespaceName(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string namespaceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = namespaceName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.NamespaceName"/></em></p>
        ///   <p>Name of Namespace.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetNamespaceName(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NamespaceName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetResourceGroup(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetResourceGroup(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetSubscription(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetSubscription(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetDebug(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetDebug(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetHelp(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetHelp(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetOutput(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetOutput(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetQuery(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetQuery(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings SetVerbose(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureRelayHycoAuthorizationRuleKeysRenewSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureRelayHycoAuthorizationRuleKeysRenewSettings ResetVerbose(this AzureRelayHycoAuthorizationRuleKeysRenewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region RelayHycoStatus
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RelayHycoStatus>))]
    public partial class RelayHycoStatus : Enumeration
    {
        public static RelayHycoStatus active = new RelayHycoStatus { Value = "active" };
        public static RelayHycoStatus disabled = new RelayHycoStatus { Value = "disabled" };
        public static RelayHycoStatus receivedisabled = new RelayHycoStatus { Value = "receivedisabled" };
        public static RelayHycoStatus senddisabled = new RelayHycoStatus { Value = "senddisabled" };
    }
    #endregion
    #region RelayWcfrelayRelayType
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RelayWcfrelayRelayType>))]
    public partial class RelayWcfrelayRelayType : Enumeration
    {
        public static RelayWcfrelayRelayType http = new RelayWcfrelayRelayType { Value = "http" };
        public static RelayWcfrelayRelayType nettcp = new RelayWcfrelayRelayType { Value = "nettcp" };
    }
    #endregion
    #region RelayWcfrelayAuthorizationRuleRights
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RelayWcfrelayAuthorizationRuleRights>))]
    public partial class RelayWcfrelayAuthorizationRuleRights : Enumeration
    {
        public static RelayWcfrelayAuthorizationRuleRights listen = new RelayWcfrelayAuthorizationRuleRights { Value = "listen" };
        public static RelayWcfrelayAuthorizationRuleRights manage = new RelayWcfrelayAuthorizationRuleRights { Value = "manage" };
        public static RelayWcfrelayAuthorizationRuleRights send = new RelayWcfrelayAuthorizationRuleRights { Value = "send" };
    }
    #endregion
    #region RelayWcfrelayAuthorizationRuleKeysKey
    /// <summary>
    ///   Used within <see cref="AzureRelayTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<RelayWcfrelayAuthorizationRuleKeysKey>))]
    public partial class RelayWcfrelayAuthorizationRuleKeysKey : Enumeration
    {
        public static RelayWcfrelayAuthorizationRuleKeysKey primarykey = new RelayWcfrelayAuthorizationRuleKeysKey { Value = "primarykey" };
        public static RelayWcfrelayAuthorizationRuleKeysKey secondarykey = new RelayWcfrelayAuthorizationRuleKeysKey { Value = "secondarykey" };
    }
    #endregion
}
