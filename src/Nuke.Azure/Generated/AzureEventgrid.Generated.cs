// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureEventgrid.json
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
    public static partial class AzureEventgridTasks
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public static string AzureEventgridPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREEVENTGRID_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureEventgridLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Event Grid topics, event subscriptions, domains and domain topics.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgrid(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureEventgridPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureEventgridLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgrid(AzureEventgridSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgrid(Configure<AzureEventgridSettings> configurator)
        {
            return AzureEventgrid(configurator(new AzureEventgridSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgrid(CombinatorialConfigure<AzureEventgridSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgrid, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainCreate(AzureEventgridDomainCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureEventgridDomainCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridDomainCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainCreate(Configure<AzureEventgridDomainCreateSettings> configurator)
        {
            return AzureEventgridDomainCreate(configurator(new AzureEventgridDomainCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureEventgridDomainCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridDomainCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainCreate(CombinatorialConfigure<AzureEventgridDomainCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainCreate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainDelete(AzureEventgridDomainDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainDelete(Configure<AzureEventgridDomainDeleteSettings> configurator)
        {
            return AzureEventgridDomainDelete(configurator(new AzureEventgridDomainDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainDelete(CombinatorialConfigure<AzureEventgridDomainDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainDelete, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainList(AzureEventgridDomainListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainListSettings.Help"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridDomainListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainList(Configure<AzureEventgridDomainListSettings> configurator)
        {
            return AzureEventgridDomainList(configurator(new AzureEventgridDomainListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainListSettings.Help"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridDomainListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainList(CombinatorialConfigure<AzureEventgridDomainListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainShow(AzureEventgridDomainShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainShow(Configure<AzureEventgridDomainShowSettings> configurator)
        {
            return AzureEventgridDomainShow(configurator(new AzureEventgridDomainShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainShow(CombinatorialConfigure<AzureEventgridDomainShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainShow, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainUpdate(AzureEventgridDomainUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureEventgridDomainUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureEventgridDomainUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureEventgridDomainUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureEventgridDomainUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridDomainUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainUpdate(Configure<AzureEventgridDomainUpdateSettings> configurator)
        {
            return AzureEventgridDomainUpdate(configurator(new AzureEventgridDomainUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureEventgridDomainUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureEventgridDomainUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureEventgridDomainUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureEventgridDomainUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridDomainUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainUpdate(CombinatorialConfigure<AzureEventgridDomainUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainUpdate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionCreate(AzureEventgridEventSubscriptionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridEventSubscriptionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--advanced-filter</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.AdvancedFilter"/></li>
        ///     <li><c>--deadletter-endpoint</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.DeadletterEndpoint"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Debug"/></li>
        ///     <li><c>--endpoint</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Endpoint"/></li>
        ///     <li><c>--endpoint-type</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.EndpointType"/></li>
        ///     <li><c>--event-ttl</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.EventTtl"/></li>
        ///     <li><c>--expiration-date</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.ExpirationDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Help"/></li>
        ///     <li><c>--included-event-types</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.IncludedEventTypes"/></li>
        ///     <li><c>--labels</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Labels"/></li>
        ///     <li><c>--max-delivery-attempts</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.MaxDeliveryAttempts"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SourceResourceId"/></li>
        ///     <li><c>--subject-begins-with</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectBeginsWith"/></li>
        ///     <li><c>--subject-case-sensitive</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></li>
        ///     <li><c>--subject-ends-with</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectEndsWith"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionCreate(Configure<AzureEventgridEventSubscriptionCreateSettings> configurator)
        {
            return AzureEventgridEventSubscriptionCreate(configurator(new AzureEventgridEventSubscriptionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--advanced-filter</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.AdvancedFilter"/></li>
        ///     <li><c>--deadletter-endpoint</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.DeadletterEndpoint"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Debug"/></li>
        ///     <li><c>--endpoint</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Endpoint"/></li>
        ///     <li><c>--endpoint-type</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.EndpointType"/></li>
        ///     <li><c>--event-ttl</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.EventTtl"/></li>
        ///     <li><c>--expiration-date</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.ExpirationDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Help"/></li>
        ///     <li><c>--included-event-types</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.IncludedEventTypes"/></li>
        ///     <li><c>--labels</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Labels"/></li>
        ///     <li><c>--max-delivery-attempts</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.MaxDeliveryAttempts"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SourceResourceId"/></li>
        ///     <li><c>--subject-begins-with</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectBeginsWith"/></li>
        ///     <li><c>--subject-case-sensitive</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></li>
        ///     <li><c>--subject-ends-with</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectEndsWith"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridEventSubscriptionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridEventSubscriptionCreate(CombinatorialConfigure<AzureEventgridEventSubscriptionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridEventSubscriptionCreate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionDelete(AzureEventgridEventSubscriptionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridEventSubscriptionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.SourceResourceId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionDelete(Configure<AzureEventgridEventSubscriptionDeleteSettings> configurator)
        {
            return AzureEventgridEventSubscriptionDelete(configurator(new AzureEventgridEventSubscriptionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.SourceResourceId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridEventSubscriptionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridEventSubscriptionDelete(CombinatorialConfigure<AzureEventgridEventSubscriptionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridEventSubscriptionDelete, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionList(AzureEventgridEventSubscriptionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridEventSubscriptionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Location"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridEventSubscriptionListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionListSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionListSettings.SourceResourceId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionListSettings.TopicName"/></li>
        ///     <li><c>--topic-type-name</c> via <see cref="AzureEventgridEventSubscriptionListSettings.TopicTypeName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionList(Configure<AzureEventgridEventSubscriptionListSettings> configurator)
        {
            return AzureEventgridEventSubscriptionList(configurator(new AzureEventgridEventSubscriptionListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Location"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridEventSubscriptionListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionListSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionListSettings.SourceResourceId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionListSettings.TopicName"/></li>
        ///     <li><c>--topic-type-name</c> via <see cref="AzureEventgridEventSubscriptionListSettings.TopicTypeName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridEventSubscriptionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridEventSubscriptionList(CombinatorialConfigure<AzureEventgridEventSubscriptionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridEventSubscriptionList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionShow(AzureEventgridEventSubscriptionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridEventSubscriptionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Help"/></li>
        ///     <li><c>--include-full-endpoint-url</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.SourceResourceId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionShow(Configure<AzureEventgridEventSubscriptionShowSettings> configurator)
        {
            return AzureEventgridEventSubscriptionShow(configurator(new AzureEventgridEventSubscriptionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Help"/></li>
        ///     <li><c>--include-full-endpoint-url</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceId"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.SourceResourceId"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridEventSubscriptionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridEventSubscriptionShow(CombinatorialConfigure<AzureEventgridEventSubscriptionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridEventSubscriptionShow, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionUpdate(AzureEventgridEventSubscriptionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridEventSubscriptionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Add"/></li>
        ///     <li><c>--deadletter-endpoint</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.DeadletterEndpoint"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Debug"/></li>
        ///     <li><c>--endpoint</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Endpoint"/></li>
        ///     <li><c>--endpoint-type</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.EndpointType"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Help"/></li>
        ///     <li><c>--included-event-types</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.IncludedEventTypes"/></li>
        ///     <li><c>--labels</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Labels"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceId"/></li>
        ///     <li><c>--set</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Set"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.SourceResourceId"/></li>
        ///     <li><c>--subject-begins-with</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectBeginsWith"/></li>
        ///     <li><c>--subject-ends-with</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectEndsWith"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionUpdate(Configure<AzureEventgridEventSubscriptionUpdateSettings> configurator)
        {
            return AzureEventgridEventSubscriptionUpdate(configurator(new AzureEventgridEventSubscriptionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Add"/></li>
        ///     <li><c>--deadletter-endpoint</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.DeadletterEndpoint"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Debug"/></li>
        ///     <li><c>--endpoint</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Endpoint"/></li>
        ///     <li><c>--endpoint-type</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.EndpointType"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Help"/></li>
        ///     <li><c>--included-event-types</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.IncludedEventTypes"/></li>
        ///     <li><c>--labels</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Labels"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-id</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceId"/></li>
        ///     <li><c>--set</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Set"/></li>
        ///     <li><c>--source-resource-id</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.SourceResourceId"/></li>
        ///     <li><c>--subject-begins-with</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectBeginsWith"/></li>
        ///     <li><c>--subject-ends-with</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectEndsWith"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Subscription"/></li>
        ///     <li><c>--topic-name</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.TopicName"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridEventSubscriptionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridEventSubscriptionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridEventSubscriptionUpdate(CombinatorialConfigure<AzureEventgridEventSubscriptionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridEventSubscriptionUpdate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeList(AzureEventgridTopicTypeListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicTypeListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicTypeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicTypeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicTypeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicTypeListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicTypeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicTypeListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeList(Configure<AzureEventgridTopicTypeListSettings> configurator)
        {
            return AzureEventgridTopicTypeList(configurator(new AzureEventgridTopicTypeListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicTypeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicTypeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicTypeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicTypeListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicTypeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicTypeListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicTypeListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicTypeList(CombinatorialConfigure<AzureEventgridTopicTypeListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicTypeList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeListEventTypes(AzureEventgridTopicTypeListEventTypesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicTypeListEventTypesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeListEventTypes(Configure<AzureEventgridTopicTypeListEventTypesSettings> configurator)
        {
            return AzureEventgridTopicTypeListEventTypes(configurator(new AzureEventgridTopicTypeListEventTypesSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicTypeListEventTypesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicTypeListEventTypesSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicTypeListEventTypes(CombinatorialConfigure<AzureEventgridTopicTypeListEventTypesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicTypeListEventTypes, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeShow(AzureEventgridTopicTypeShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicTypeShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicTypeShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicTypeShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicTypeShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicTypeShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicTypeShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicTypeShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicTypeShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeShow(Configure<AzureEventgridTopicTypeShowSettings> configurator)
        {
            return AzureEventgridTopicTypeShow(configurator(new AzureEventgridTopicTypeShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicTypeShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicTypeShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicTypeShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicTypeShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicTypeShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicTypeShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicTypeShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicTypeShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicTypeShow(CombinatorialConfigure<AzureEventgridTopicTypeShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicTypeShow, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicCreate(AzureEventgridTopicCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureEventgridTopicCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridTopicCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicCreate(Configure<AzureEventgridTopicCreateSettings> configurator)
        {
            return AzureEventgridTopicCreate(configurator(new AzureEventgridTopicCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureEventgridTopicCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridTopicCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicCreate(CombinatorialConfigure<AzureEventgridTopicCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicCreate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicDelete(AzureEventgridTopicDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridTopicDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicDelete(Configure<AzureEventgridTopicDeleteSettings> configurator)
        {
            return AzureEventgridTopicDelete(configurator(new AzureEventgridTopicDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridTopicDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicDelete(CombinatorialConfigure<AzureEventgridTopicDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicDelete, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicList(AzureEventgridTopicListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicListSettings.Help"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridTopicListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicList(Configure<AzureEventgridTopicListSettings> configurator)
        {
            return AzureEventgridTopicList(configurator(new AzureEventgridTopicListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicListSettings.Help"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridTopicListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicList(CombinatorialConfigure<AzureEventgridTopicListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicShow(AzureEventgridTopicShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridTopicShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicShow(Configure<AzureEventgridTopicShowSettings> configurator)
        {
            return AzureEventgridTopicShow(configurator(new AzureEventgridTopicShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridTopicShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicShow(CombinatorialConfigure<AzureEventgridTopicShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicShow, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicUpdate(AzureEventgridTopicUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureEventgridTopicUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureEventgridTopicUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridTopicUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureEventgridTopicUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureEventgridTopicUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridTopicUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicUpdate(Configure<AzureEventgridTopicUpdateSettings> configurator)
        {
            return AzureEventgridTopicUpdate(configurator(new AzureEventgridTopicUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureEventgridTopicUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureEventgridTopicUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridTopicUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureEventgridTopicUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureEventgridTopicUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureEventgridTopicUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicUpdate(CombinatorialConfigure<AzureEventgridTopicUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicUpdate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainKeyList(AzureEventgridDomainKeyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainKeyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainKeyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainKeyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainKeyList(Configure<AzureEventgridDomainKeyListSettings> configurator)
        {
            return AzureEventgridDomainKeyList(configurator(new AzureEventgridDomainKeyListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainKeyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainKeyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainKeyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainKeyList(CombinatorialConfigure<AzureEventgridDomainKeyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainKeyList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainKeyRegenerate(AzureEventgridDomainKeyRegenerateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainKeyRegenerateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Help"/></li>
        ///     <li><c>--key-name</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.KeyName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainKeyRegenerate(Configure<AzureEventgridDomainKeyRegenerateSettings> configurator)
        {
            return AzureEventgridDomainKeyRegenerate(configurator(new AzureEventgridDomainKeyRegenerateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Help"/></li>
        ///     <li><c>--key-name</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.KeyName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainKeyRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainKeyRegenerateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainKeyRegenerate(CombinatorialConfigure<AzureEventgridDomainKeyRegenerateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainKeyRegenerate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicCreate(AzureEventgridDomainTopicCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainTopicCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicCreateSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicCreate(Configure<AzureEventgridDomainTopicCreateSettings> configurator)
        {
            return AzureEventgridDomainTopicCreate(configurator(new AzureEventgridDomainTopicCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicCreateSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainTopicCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainTopicCreate(CombinatorialConfigure<AzureEventgridDomainTopicCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainTopicCreate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicDelete(AzureEventgridDomainTopicDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainTopicDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicDelete(Configure<AzureEventgridDomainTopicDeleteSettings> configurator)
        {
            return AzureEventgridDomainTopicDelete(configurator(new AzureEventgridDomainTopicDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainTopicDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainTopicDelete(CombinatorialConfigure<AzureEventgridDomainTopicDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainTopicDelete, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicList(AzureEventgridDomainTopicListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainTopicListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicListSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicListSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicListSettings.Help"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridDomainTopicListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicList(Configure<AzureEventgridDomainTopicListSettings> configurator)
        {
            return AzureEventgridDomainTopicList(configurator(new AzureEventgridDomainTopicListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicListSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicListSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicListSettings.Help"/></li>
        ///     <li><c>--odata-query</c> via <see cref="AzureEventgridDomainTopicListSettings.OdataQuery"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainTopicListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainTopicList(CombinatorialConfigure<AzureEventgridDomainTopicListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainTopicList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicShow(AzureEventgridDomainTopicShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridDomainTopicShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicShowSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicShowSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainTopicShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridDomainTopicShow(Configure<AzureEventgridDomainTopicShowSettings> configurator)
        {
            return AzureEventgridDomainTopicShow(configurator(new AzureEventgridDomainTopicShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridDomainTopicShowSettings.Debug"/></li>
        ///     <li><c>--domain-name</c> via <see cref="AzureEventgridDomainTopicShowSettings.DomainName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridDomainTopicShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridDomainTopicShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridDomainTopicShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridDomainTopicShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridDomainTopicShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridDomainTopicShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridDomainTopicShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridDomainTopicShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridDomainTopicShow(CombinatorialConfigure<AzureEventgridDomainTopicShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridDomainTopicShow, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicKeyList(AzureEventgridTopicKeyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicKeyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicKeyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicKeyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicKeyList(Configure<AzureEventgridTopicKeyListSettings> configurator)
        {
            return AzureEventgridTopicKeyList(configurator(new AzureEventgridTopicKeyListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicKeyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicKeyListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicKeyListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicKeyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicKeyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicKeyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicKeyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicKeyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicKeyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicKeyList(CombinatorialConfigure<AzureEventgridTopicKeyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicKeyList, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicKeyRegenerate(AzureEventgridTopicKeyRegenerateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureEventgridTopicKeyRegenerateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Help"/></li>
        ///     <li><c>--key-name</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.KeyName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureEventgridTopicKeyRegenerate(Configure<AzureEventgridTopicKeyRegenerateSettings> configurator)
        {
            return AzureEventgridTopicKeyRegenerate(configurator(new AzureEventgridTopicKeyRegenerateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Event Grid topics, event subscriptions, domains and domain topics.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Help"/></li>
        ///     <li><c>--key-name</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.KeyName"/></li>
        ///     <li><c>--name</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureEventgridTopicKeyRegenerateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureEventgridTopicKeyRegenerateSettings Settings, IReadOnlyCollection<Output> Output)> AzureEventgridTopicKeyRegenerate(CombinatorialConfigure<AzureEventgridTopicKeyRegenerateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureEventgridTopicKeyRegenerate, AzureEventgridLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureEventgridSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
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
              .Add("eventgrid")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventgridDomainCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the domain.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventgrid domain create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridDomainDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the domain.
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
              .Add("eventgrid domain delete")
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
    #region AzureEventgridDomainListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.
        /// </summary>
        public virtual string OdataQuery { get; internal set; }
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
              .Add("eventgrid domain list")
              .Add("--odata-query {value}", OdataQuery)
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
    #region AzureEventgridDomainShowSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the domain.
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
              .Add("eventgrid domain show")
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
    #region AzureEventgridDomainUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
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
        ///   Name of the domain.
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
              .Add("eventgrid domain update")
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
    #region AzureEventgridEventSubscriptionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For other endpoint types, this should be the Azure resource identifier of the endpoint.
        /// </summary>
        public virtual string Endpoint { get; internal set; }
        /// <summary>
        ///   Name of the event subscription.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   An advanced filter enables filtering of events based on a specific event property.
        /// </summary>
        public virtual string AdvancedFilter { get; internal set; }
        /// <summary>
        ///   The Azure resource ID of an Azure Storage blob container destination where EventGrid should deadletter undeliverable events for this event subscription.
        /// </summary>
        public virtual string DeadletterEndpoint { get; internal set; }
        /// <summary>
        ///   The type of the destination endpoint.
        /// </summary>
        public virtual EventgridEventSubscriptionEndpointType EndpointType { get; internal set; }
        /// <summary>
        ///   Event time to live (in minutes). Must be a number between 1 and 1440.
        /// </summary>
        public virtual string EventTtl { get; internal set; }
        /// <summary>
        ///   Date or datetime (in UTC, e.g. '2018-11-30T11:59:59+00:00' or '2018-11-30') after which the event subscription would expire. By default, there is no expiration for the event subscription.
        /// </summary>
        public virtual string ExpirationDate { get; internal set; }
        /// <summary>
        ///   A space-separated list of event types (e.g., Microsoft.Storage.BlobCreated Microsoft.Storage.BlobDeleted). To subscribe to all default event types, do not specify this argument. For event grid topics, event types are customer defined. For Azure events, e.g., Storage Accounts, IoT Hub, etc., you can query their event types using this CLI command 'az eventgrid topic-type list-event-types'.
        /// </summary>
        public virtual string IncludedEventTypes { get; internal set; }
        /// <summary>
        ///   A space-separated list of labels to associate with this event subscription.
        /// </summary>
        public virtual string Labels { get; internal set; }
        /// <summary>
        ///   Maximum number of delivery attempts. Must be a number between 1 and 30.
        /// </summary>
        public virtual int? MaxDeliveryAttempts { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource.
        /// </summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource to which the event subscription needs to be created.
        /// </summary>
        public virtual string SourceResourceId { get; internal set; }
        /// <summary>
        ///   An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.
        /// </summary>
        public virtual string SubjectBeginsWith { get; internal set; }
        /// <summary>
        ///   Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.
        /// </summary>
        public virtual bool? SubjectCaseSensitive { get; internal set; }
        /// <summary>
        ///   An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.
        /// </summary>
        public virtual string SubjectEndsWith { get; internal set; }
        /// <summary>
        ///   Name of Event Grid topic.
        /// </summary>
        public virtual string TopicName { get; internal set; }
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
              .Add("eventgrid event-subscription create")
              .Add("--endpoint {value}", Endpoint)
              .Add("--name {value}", Name)
              .Add("--advanced-filter {value}", AdvancedFilter)
              .Add("--deadletter-endpoint {value}", DeadletterEndpoint)
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--event-ttl {value}", EventTtl)
              .Add("--expiration-date {value}", ExpirationDate)
              .Add("--included-event-types {value}", IncludedEventTypes)
              .Add("--labels {value}", Labels)
              .Add("--max-delivery-attempts {value}", MaxDeliveryAttempts)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--source-resource-id {value}", SourceResourceId)
              .Add("--subject-begins-with {value}", SubjectBeginsWith)
              .Add("--subject-case-sensitive", SubjectCaseSensitive)
              .Add("--subject-ends-with {value}", SubjectEndsWith)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridEventSubscriptionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the event subscription.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource.
        /// </summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.
        /// </summary>
        public virtual string SourceResourceId { get; internal set; }
        /// <summary>
        ///   Name of Event Grid topic.
        /// </summary>
        public virtual string TopicName { get; internal set; }
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
              .Add("eventgrid event-subscription delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--source-resource-id {value}", SourceResourceId)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridEventSubscriptionListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.
        /// </summary>
        public virtual string OdataQuery { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource.
        /// </summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource whose event subscription needs to be listed.
        /// </summary>
        public virtual string SourceResourceId { get; internal set; }
        /// <summary>
        ///   Name of Event Grid topic.
        /// </summary>
        public virtual string TopicName { get; internal set; }
        /// <summary>
        ///   Name of the topic-type whose event subscriptions need to be listed. When this is specified, you must also specify --location.
        /// </summary>
        public virtual string TopicTypeName { get; internal set; }
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
              .Add("eventgrid event-subscription list")
              .Add("--location {value}", Location)
              .Add("--odata-query {value}", OdataQuery)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--source-resource-id {value}", SourceResourceId)
              .Add("--topic-name {value}", TopicName)
              .Add("--topic-type-name {value}", TopicTypeName)
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
    #region AzureEventgridEventSubscriptionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the event subscription.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Specify to indicate whether the full endpoint URL should be returned. True if flag present.
        /// </summary>
        public virtual bool? IncludeFullEndpointUrl { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource.
        /// </summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource whose event subscription needs to be shown.
        /// </summary>
        public virtual string SourceResourceId { get; internal set; }
        /// <summary>
        ///   Name of Event Grid topic.
        /// </summary>
        public virtual string TopicName { get; internal set; }
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
              .Add("eventgrid event-subscription show")
              .Add("--name {value}", Name)
              .Add("--include-full-endpoint-url", IncludeFullEndpointUrl)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--source-resource-id {value}", SourceResourceId)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridEventSubscriptionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the event subscription.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The Azure resource ID of an Azure Storage blob container destination where EventGrid should deadletter undeliverable events for this event subscription.
        /// </summary>
        public virtual string DeadletterEndpoint { get; internal set; }
        /// <summary>
        ///   Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For other endpoint types, this should be the Azure resource identifier of the endpoint.
        /// </summary>
        public virtual string Endpoint { get; internal set; }
        /// <summary>
        ///   The type of the destination endpoint.
        /// </summary>
        public virtual EventgridEventSubscriptionEndpointType EndpointType { get; internal set; }
        /// <summary>
        ///   A space-separated list of event types (e.g., Microsoft.Storage.BlobCreated Microsoft.Storage.BlobDeleted). To subscribe to all default event types, do not specify this argument. For event grid topics, event types are customer defined. For Azure events, e.g., Storage Accounts, IoT Hub, etc., you can query their event types using this CLI command 'az eventgrid topic-type list-event-types'.
        /// </summary>
        public virtual string IncludedEventTypes { get; internal set; }
        /// <summary>
        ///   A space-separated list of labels to associate with this event subscription.
        /// </summary>
        public virtual string Labels { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource.
        /// </summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary>
        ///   Fully qualified identifier of the Azure resource whose event subscription needs to be updated.
        /// </summary>
        public virtual string SourceResourceId { get; internal set; }
        /// <summary>
        ///   An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.
        /// </summary>
        public virtual string SubjectBeginsWith { get; internal set; }
        /// <summary>
        ///   An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.
        /// </summary>
        public virtual string SubjectEndsWith { get; internal set; }
        /// <summary>
        ///   Name of Event Grid topic.
        /// </summary>
        public virtual string TopicName { get; internal set; }
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
              .Add("eventgrid event-subscription update")
              .Add("--name {value}", Name)
              .Add("--deadletter-endpoint {value}", DeadletterEndpoint)
              .Add("--endpoint {value}", Endpoint)
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--included-event-types {value}", IncludedEventTypes)
              .Add("--labels {value}", Labels)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--source-resource-id {value}", SourceResourceId)
              .Add("--subject-begins-with {value}", SubjectBeginsWith)
              .Add("--subject-ends-with {value}", SubjectEndsWith)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridTopicTypeListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicTypeListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
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
              .Add("eventgrid topic-type list")
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
    #region AzureEventgridTopicTypeListEventTypesSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicTypeListEventTypesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the topic type.
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
              .Add("eventgrid topic-type list-event-types")
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
    #region AzureEventgridTopicTypeShowSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicTypeShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the topic type.
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
              .Add("eventgrid topic-type show")
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
    #region AzureEventgridTopicCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the topic.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("eventgrid topic create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridTopicDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the topic.
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
              .Add("eventgrid topic delete")
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
    #region AzureEventgridTopicListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.
        /// </summary>
        public virtual string OdataQuery { get; internal set; }
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
              .Add("eventgrid topic list")
              .Add("--odata-query {value}", OdataQuery)
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
    #region AzureEventgridTopicShowSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the topic.
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
              .Add("eventgrid topic show")
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
    #region AzureEventgridTopicUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
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
        ///   Name of the topic.
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
              .Add("eventgrid topic update")
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
    #region AzureEventgridDomainKeyListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainKeyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the domain.
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
              .Add("eventgrid domain key list")
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
    #region AzureEventgridDomainKeyRegenerateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainKeyRegenerateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Key name to regenerate key1 or key2.
        /// </summary>
        public virtual string KeyName { get; internal set; }
        /// <summary>
        ///   Name of the domain.
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
              .Add("eventgrid domain key regenerate")
              .Add("--key-name {value}", KeyName)
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
    #region AzureEventgridDomainTopicCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainTopicCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the domain.
        /// </summary>
        public virtual string DomainName { get; internal set; }
        /// <summary>
        ///   Name of the domain topic.
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
              .Add("eventgrid domain topic create")
              .Add("--domain-name {value}", DomainName)
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
    #region AzureEventgridDomainTopicDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainTopicDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the domain.
        /// </summary>
        public virtual string DomainName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the domain topic.
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
              .Add("eventgrid domain topic delete")
              .Add("--domain-name {value}", DomainName)
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
    #region AzureEventgridDomainTopicListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainTopicListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the domain.
        /// </summary>
        public virtual string DomainName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.
        /// </summary>
        public virtual string OdataQuery { get; internal set; }
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
              .Add("eventgrid domain topic list")
              .Add("--domain-name {value}", DomainName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--odata-query {value}", OdataQuery)
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
    #region AzureEventgridDomainTopicShowSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridDomainTopicShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the domain.
        /// </summary>
        public virtual string DomainName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the domain topic.
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
              .Add("eventgrid domain topic show")
              .Add("--domain-name {value}", DomainName)
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
    #region AzureEventgridTopicKeyListSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicKeyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Name of the topic.
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
              .Add("eventgrid topic key list")
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
    #region AzureEventgridTopicKeyRegenerateSettings
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicKeyRegenerateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureEventgrid executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        public override Action<OutputType, string> CustomLogger => AzureEventgridTasks.AzureEventgridLogger;
        /// <summary>
        ///   Key name to regenerate key1 or key2.
        /// </summary>
        public virtual string KeyName { get; internal set; }
        /// <summary>
        ///   Name of the topic.
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
              .Add("eventgrid topic key regenerate")
              .Add("--key-name {value}", KeyName)
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
    #region AzureEventgridSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings SetDebug(this AzureEventgridSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings ResetDebug(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings SetHelp(this AzureEventgridSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings ResetHelp(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings SetOutput(this AzureEventgridSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings ResetOutput(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings SetQuery(this AzureEventgridSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings ResetQuery(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings SetVerbose(this AzureEventgridSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridSettings ResetVerbose(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetLocation(this AzureEventgridDomainCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetLocation(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetName(this AzureEventgridDomainCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetName(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetResourceGroup(this AzureEventgridDomainCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetResourceGroup(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetTags(this AzureEventgridDomainCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetTags(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetSubscription(this AzureEventgridDomainCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetSubscription(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetDebug(this AzureEventgridDomainCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetDebug(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetHelp(this AzureEventgridDomainCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetHelp(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetOutput(this AzureEventgridDomainCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetOutput(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetQuery(this AzureEventgridDomainCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetQuery(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings SetVerbose(this AzureEventgridDomainCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainCreateSettings ResetVerbose(this AzureEventgridDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetIds(this AzureEventgridDomainDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetIds(this AzureEventgridDomainDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings AddIds(this AzureEventgridDomainDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings AddIds(this AzureEventgridDomainDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridDomainDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ClearIds(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings RemoveIds(this AzureEventgridDomainDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings RemoveIds(this AzureEventgridDomainDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetName(this AzureEventgridDomainDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetName(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetResourceGroup(this AzureEventgridDomainDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetResourceGroup(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetSubscription(this AzureEventgridDomainDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetSubscription(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetDebug(this AzureEventgridDomainDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetDebug(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetHelp(this AzureEventgridDomainDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetHelp(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetOutput(this AzureEventgridDomainDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetOutput(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetQuery(this AzureEventgridDomainDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetQuery(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings SetVerbose(this AzureEventgridDomainDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainDeleteSettings ResetVerbose(this AzureEventgridDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainListSettingsExtensions
    {
        #region OdataQuery
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetOdataQuery(this AzureEventgridDomainListSettings toolSettings, string odataQuery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = odataQuery;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetOdataQuery(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetResourceGroup(this AzureEventgridDomainListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetResourceGroup(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetSubscription(this AzureEventgridDomainListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetSubscription(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetDebug(this AzureEventgridDomainListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetDebug(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetHelp(this AzureEventgridDomainListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetHelp(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetOutput(this AzureEventgridDomainListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetOutput(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetQuery(this AzureEventgridDomainListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetQuery(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings SetVerbose(this AzureEventgridDomainListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainListSettings ResetVerbose(this AzureEventgridDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetIds(this AzureEventgridDomainShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetIds(this AzureEventgridDomainShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings AddIds(this AzureEventgridDomainShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings AddIds(this AzureEventgridDomainShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridDomainShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ClearIds(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings RemoveIds(this AzureEventgridDomainShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings RemoveIds(this AzureEventgridDomainShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetName(this AzureEventgridDomainShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetName(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetResourceGroup(this AzureEventgridDomainShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetResourceGroup(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetSubscription(this AzureEventgridDomainShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetSubscription(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetDebug(this AzureEventgridDomainShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetDebug(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetHelp(this AzureEventgridDomainShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetHelp(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetOutput(this AzureEventgridDomainShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetOutput(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetQuery(this AzureEventgridDomainShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetQuery(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings SetVerbose(this AzureEventgridDomainShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainShowSettings ResetVerbose(this AzureEventgridDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetTags(this AzureEventgridDomainUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetTags(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetIds(this AzureEventgridDomainUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetIds(this AzureEventgridDomainUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings AddIds(this AzureEventgridDomainUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings AddIds(this AzureEventgridDomainUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridDomainUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ClearIds(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings RemoveIds(this AzureEventgridDomainUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings RemoveIds(this AzureEventgridDomainUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetName(this AzureEventgridDomainUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetName(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetResourceGroup(this AzureEventgridDomainUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetResourceGroup(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetSubscription(this AzureEventgridDomainUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetSubscription(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetAdd(this AzureEventgridDomainUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetAdd(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetForceString(this AzureEventgridDomainUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetForceString(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetRemove(this AzureEventgridDomainUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetRemove(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetSet(this AzureEventgridDomainUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetSet(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetDebug(this AzureEventgridDomainUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetDebug(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetHelp(this AzureEventgridDomainUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetHelp(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetOutput(this AzureEventgridDomainUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetOutput(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetQuery(this AzureEventgridDomainUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetQuery(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings SetVerbose(this AzureEventgridDomainUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainUpdateSettings ResetVerbose(this AzureEventgridDomainUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionCreateSettingsExtensions
    {
        #region Endpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Endpoint"/></em></p>
        ///   <p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For other endpoint types, this should be the Azure resource identifier of the endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetEndpoint(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string endpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = endpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Endpoint"/></em></p>
        ///   <p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For other endpoint types, this should be the Azure resource identifier of the endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetEndpoint(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetName(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetName(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region AdvancedFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.AdvancedFilter"/></em></p>
        ///   <p>An advanced filter enables filtering of events based on a specific event property.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetAdvancedFilter(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string advancedFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdvancedFilter = advancedFilter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.AdvancedFilter"/></em></p>
        ///   <p>An advanced filter enables filtering of events based on a specific event property.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetAdvancedFilter(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdvancedFilter = null;
            return toolSettings;
        }
        #endregion
        #region DeadletterEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.DeadletterEndpoint"/></em></p>
        ///   <p>The Azure resource ID of an Azure Storage blob container destination where EventGrid should deadletter undeliverable events for this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetDeadletterEndpoint(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string deadletterEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeadletterEndpoint = deadletterEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.DeadletterEndpoint"/></em></p>
        ///   <p>The Azure resource ID of an Azure Storage blob container destination where EventGrid should deadletter undeliverable events for this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetDeadletterEndpoint(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeadletterEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region EndpointType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.EndpointType"/></em></p>
        ///   <p>The type of the destination endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetEndpointType(this AzureEventgridEventSubscriptionCreateSettings toolSettings, EventgridEventSubscriptionEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.EndpointType"/></em></p>
        ///   <p>The type of the destination endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetEndpointType(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region EventTtl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.EventTtl"/></em></p>
        ///   <p>Event time to live (in minutes). Must be a number between 1 and 1440.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetEventTtl(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string eventTtl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventTtl = eventTtl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.EventTtl"/></em></p>
        ///   <p>Event time to live (in minutes). Must be a number between 1 and 1440.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetEventTtl(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EventTtl = null;
            return toolSettings;
        }
        #endregion
        #region ExpirationDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.ExpirationDate"/></em></p>
        ///   <p>Date or datetime (in UTC, e.g. '2018-11-30T11:59:59+00:00' or '2018-11-30') after which the event subscription would expire. By default, there is no expiration for the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetExpirationDate(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string expirationDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpirationDate = expirationDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.ExpirationDate"/></em></p>
        ///   <p>Date or datetime (in UTC, e.g. '2018-11-30T11:59:59+00:00' or '2018-11-30') after which the event subscription would expire. By default, there is no expiration for the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetExpirationDate(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpirationDate = null;
            return toolSettings;
        }
        #endregion
        #region IncludedEventTypes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.IncludedEventTypes"/></em></p>
        ///   <p>A space-separated list of event types (e.g., Microsoft.Storage.BlobCreated Microsoft.Storage.BlobDeleted). To subscribe to all default event types, do not specify this argument. For event grid topics, event types are customer defined. For Azure events, e.g., Storage Accounts, IoT Hub, etc., you can query their event types using this CLI command 'az eventgrid topic-type list-event-types'.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetIncludedEventTypes(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string includedEventTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = includedEventTypes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.IncludedEventTypes"/></em></p>
        ///   <p>A space-separated list of event types (e.g., Microsoft.Storage.BlobCreated Microsoft.Storage.BlobDeleted). To subscribe to all default event types, do not specify this argument. For event grid topics, event types are customer defined. For Azure events, e.g., Storage Accounts, IoT Hub, etc., you can query their event types using this CLI command 'az eventgrid topic-type list-event-types'.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetIncludedEventTypes(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = null;
            return toolSettings;
        }
        #endregion
        #region Labels
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Labels"/></em></p>
        ///   <p>A space-separated list of labels to associate with this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetLabels(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string labels)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = labels;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Labels"/></em></p>
        ///   <p>A space-separated list of labels to associate with this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetLabels(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = null;
            return toolSettings;
        }
        #endregion
        #region MaxDeliveryAttempts
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.MaxDeliveryAttempts"/></em></p>
        ///   <p>Maximum number of delivery attempts. Must be a number between 1 and 30.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetMaxDeliveryAttempts(this AzureEventgridEventSubscriptionCreateSettings toolSettings, int? maxDeliveryAttempts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDeliveryAttempts = maxDeliveryAttempts;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.MaxDeliveryAttempts"/></em></p>
        ///   <p>Maximum number of delivery attempts. Must be a number between 1 and 30.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetMaxDeliveryAttempts(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxDeliveryAttempts = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetResourceGroup(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetResourceGroup(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetResourceId(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetResourceId(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SourceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource to which the event subscription needs to be created.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSourceResourceId(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string sourceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = sourceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource to which the event subscription needs to be created.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSourceResourceId(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SubjectBeginsWith
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectBeginsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubjectBeginsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string subjectBeginsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = subjectBeginsWith;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectBeginsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubjectBeginsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = null;
            return toolSettings;
        }
        #endregion
        #region SubjectCaseSensitive
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></em></p>
        ///   <p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings, bool? subjectCaseSensitive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = subjectCaseSensitive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></em></p>
        ///   <p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></em></p>
        ///   <p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings EnableSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></em></p>
        ///   <p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings DisableSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/></em></p>
        ///   <p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ToggleSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = !toolSettings.SubjectCaseSensitive;
            return toolSettings;
        }
        #endregion
        #region SubjectEndsWith
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectEndsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubjectEndsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string subjectEndsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = subjectEndsWith;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectEndsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubjectEndsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetTopicName(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetTopicName(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubscription(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubscription(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetDebug(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetDebug(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetHelp(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetHelp(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetOutput(this AzureEventgridEventSubscriptionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetOutput(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetQuery(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetQuery(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetVerbose(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetVerbose(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetResourceGroup(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetResourceGroup(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetResourceId(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetResourceId(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SourceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetSourceResourceId(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string sourceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = sourceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetSourceResourceId(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetTopicName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetTopicName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetSubscription(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetSubscription(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetDebug(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetDebug(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetHelp(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetHelp(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetOutput(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetOutput(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetQuery(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetQuery(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetVerbose(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetVerbose(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionListSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetLocation(this AzureEventgridEventSubscriptionListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetLocation(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OdataQuery
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetOdataQuery(this AzureEventgridEventSubscriptionListSettings toolSettings, string odataQuery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = odataQuery;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetOdataQuery(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetResourceGroup(this AzureEventgridEventSubscriptionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetResourceGroup(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetResourceId(this AzureEventgridEventSubscriptionListSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetResourceId(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SourceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be listed.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetSourceResourceId(this AzureEventgridEventSubscriptionListSettings toolSettings, string sourceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = sourceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be listed.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetSourceResourceId(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetTopicName(this AzureEventgridEventSubscriptionListSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetTopicName(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region TopicTypeName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.TopicTypeName"/></em></p>
        ///   <p>Name of the topic-type whose event subscriptions need to be listed. When this is specified, you must also specify --location.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetTopicTypeName(this AzureEventgridEventSubscriptionListSettings toolSettings, string topicTypeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicTypeName = topicTypeName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.TopicTypeName"/></em></p>
        ///   <p>Name of the topic-type whose event subscriptions need to be listed. When this is specified, you must also specify --location.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetTopicTypeName(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicTypeName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetSubscription(this AzureEventgridEventSubscriptionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetSubscription(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetDebug(this AzureEventgridEventSubscriptionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetDebug(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetHelp(this AzureEventgridEventSubscriptionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetHelp(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetOutput(this AzureEventgridEventSubscriptionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetOutput(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetQuery(this AzureEventgridEventSubscriptionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetQuery(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetVerbose(this AzureEventgridEventSubscriptionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetVerbose(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetName(this AzureEventgridEventSubscriptionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetName(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region IncludeFullEndpointUrl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></em></p>
        ///   <p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings, bool? includeFullEndpointUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = includeFullEndpointUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></em></p>
        ///   <p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></em></p>
        ///   <p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings EnableIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></em></p>
        ///   <p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings DisableIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/></em></p>
        ///   <p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ToggleIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = !toolSettings.IncludeFullEndpointUrl;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetResourceGroup(this AzureEventgridEventSubscriptionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetResourceGroup(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetResourceId(this AzureEventgridEventSubscriptionShowSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetResourceId(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SourceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be shown.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetSourceResourceId(this AzureEventgridEventSubscriptionShowSettings toolSettings, string sourceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = sourceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be shown.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetSourceResourceId(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetTopicName(this AzureEventgridEventSubscriptionShowSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetTopicName(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetSubscription(this AzureEventgridEventSubscriptionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetSubscription(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetDebug(this AzureEventgridEventSubscriptionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetDebug(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetHelp(this AzureEventgridEventSubscriptionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetHelp(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetOutput(this AzureEventgridEventSubscriptionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetOutput(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetQuery(this AzureEventgridEventSubscriptionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetQuery(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetVerbose(this AzureEventgridEventSubscriptionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetVerbose(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Name"/></em></p>
        ///   <p>Name of the event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region DeadletterEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.DeadletterEndpoint"/></em></p>
        ///   <p>The Azure resource ID of an Azure Storage blob container destination where EventGrid should deadletter undeliverable events for this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetDeadletterEndpoint(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string deadletterEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeadletterEndpoint = deadletterEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.DeadletterEndpoint"/></em></p>
        ///   <p>The Azure resource ID of an Azure Storage blob container destination where EventGrid should deadletter undeliverable events for this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetDeadletterEndpoint(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeadletterEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region Endpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Endpoint"/></em></p>
        ///   <p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For other endpoint types, this should be the Azure resource identifier of the endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetEndpoint(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string endpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = endpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Endpoint"/></em></p>
        ///   <p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For other endpoint types, this should be the Azure resource identifier of the endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetEndpoint(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = null;
            return toolSettings;
        }
        #endregion
        #region EndpointType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.EndpointType"/></em></p>
        ///   <p>The type of the destination endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetEndpointType(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, EventgridEventSubscriptionEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.EndpointType"/></em></p>
        ///   <p>The type of the destination endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetEndpointType(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region IncludedEventTypes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.IncludedEventTypes"/></em></p>
        ///   <p>A space-separated list of event types (e.g., Microsoft.Storage.BlobCreated Microsoft.Storage.BlobDeleted). To subscribe to all default event types, do not specify this argument. For event grid topics, event types are customer defined. For Azure events, e.g., Storage Accounts, IoT Hub, etc., you can query their event types using this CLI command 'az eventgrid topic-type list-event-types'.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetIncludedEventTypes(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string includedEventTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = includedEventTypes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.IncludedEventTypes"/></em></p>
        ///   <p>A space-separated list of event types (e.g., Microsoft.Storage.BlobCreated Microsoft.Storage.BlobDeleted). To subscribe to all default event types, do not specify this argument. For event grid topics, event types are customer defined. For Azure events, e.g., Storage Accounts, IoT Hub, etc., you can query their event types using this CLI command 'az eventgrid topic-type list-event-types'.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetIncludedEventTypes(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = null;
            return toolSettings;
        }
        #endregion
        #region Labels
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Labels"/></em></p>
        ///   <p>A space-separated list of labels to associate with this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetLabels(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string labels)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = labels;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Labels"/></em></p>
        ///   <p>A space-separated list of labels to associate with this event subscription.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetLabels(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetResourceGroup(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetResourceGroup(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetResourceId(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetResourceId(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SourceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be updated.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSourceResourceId(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string sourceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = sourceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SourceResourceId"/></em></p>
        ///   <p>Fully qualified identifier of the Azure resource whose event subscription needs to be updated.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSourceResourceId(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SubjectBeginsWith
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectBeginsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSubjectBeginsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string subjectBeginsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = subjectBeginsWith;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectBeginsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSubjectBeginsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = null;
            return toolSettings;
        }
        #endregion
        #region SubjectEndsWith
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectEndsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSubjectEndsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string subjectEndsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = subjectEndsWith;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectEndsWith"/></em></p>
        ///   <p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSubjectEndsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetTopicName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.TopicName"/></em></p>
        ///   <p>Name of Event Grid topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetTopicName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetAdd(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetAdd(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetForceString(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetForceString(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetRemove(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetRemove(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSet(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSet(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSubscription(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSubscription(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetDebug(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetDebug(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetHelp(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetHelp(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetOutput(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetOutput(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetQuery(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetQuery(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetVerbose(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetVerbose(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicTypeListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicTypeListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetSubscription(this AzureEventgridTopicTypeListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetSubscription(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetDebug(this AzureEventgridTopicTypeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetDebug(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetHelp(this AzureEventgridTopicTypeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetHelp(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetOutput(this AzureEventgridTopicTypeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetOutput(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetQuery(this AzureEventgridTopicTypeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetQuery(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetVerbose(this AzureEventgridTopicTypeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetVerbose(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicTypeListEventTypesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicTypeListEventTypesSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Name"/></em></p>
        ///   <p>Name of the topic type.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetName(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Name"/></em></p>
        ///   <p>Name of the topic type.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetName(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetSubscription(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetSubscription(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetDebug(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetDebug(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetHelp(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetHelp(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetOutput(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetOutput(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetQuery(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetQuery(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetVerbose(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetVerbose(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicTypeShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicTypeShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Name"/></em></p>
        ///   <p>Name of the topic type.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetName(this AzureEventgridTopicTypeShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Name"/></em></p>
        ///   <p>Name of the topic type.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetName(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetSubscription(this AzureEventgridTopicTypeShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetSubscription(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetDebug(this AzureEventgridTopicTypeShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetDebug(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetHelp(this AzureEventgridTopicTypeShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetHelp(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetOutput(this AzureEventgridTopicTypeShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetOutput(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetQuery(this AzureEventgridTopicTypeShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetQuery(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetVerbose(this AzureEventgridTopicTypeShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetVerbose(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicCreateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetLocation(this AzureEventgridTopicCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetLocation(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetName(this AzureEventgridTopicCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetName(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetResourceGroup(this AzureEventgridTopicCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetResourceGroup(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetTags(this AzureEventgridTopicCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetTags(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetSubscription(this AzureEventgridTopicCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetSubscription(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetDebug(this AzureEventgridTopicCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetDebug(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetHelp(this AzureEventgridTopicCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetHelp(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetOutput(this AzureEventgridTopicCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetOutput(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetQuery(this AzureEventgridTopicCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetQuery(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetVerbose(this AzureEventgridTopicCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetVerbose(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetIds(this AzureEventgridTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetIds(this AzureEventgridTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings AddIds(this AzureEventgridTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings AddIds(this AzureEventgridTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ClearIds(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings RemoveIds(this AzureEventgridTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings RemoveIds(this AzureEventgridTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetName(this AzureEventgridTopicDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetName(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetResourceGroup(this AzureEventgridTopicDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetResourceGroup(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetSubscription(this AzureEventgridTopicDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetSubscription(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetDebug(this AzureEventgridTopicDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetDebug(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetHelp(this AzureEventgridTopicDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetHelp(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetOutput(this AzureEventgridTopicDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetOutput(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetQuery(this AzureEventgridTopicDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetQuery(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetVerbose(this AzureEventgridTopicDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetVerbose(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicListSettingsExtensions
    {
        #region OdataQuery
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetOdataQuery(this AzureEventgridTopicListSettings toolSettings, string odataQuery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = odataQuery;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetOdataQuery(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetResourceGroup(this AzureEventgridTopicListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetResourceGroup(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetSubscription(this AzureEventgridTopicListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetSubscription(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetDebug(this AzureEventgridTopicListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetDebug(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetHelp(this AzureEventgridTopicListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetHelp(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetOutput(this AzureEventgridTopicListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetOutput(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetQuery(this AzureEventgridTopicListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetQuery(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetVerbose(this AzureEventgridTopicListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetVerbose(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetIds(this AzureEventgridTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetIds(this AzureEventgridTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings AddIds(this AzureEventgridTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings AddIds(this AzureEventgridTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ClearIds(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings RemoveIds(this AzureEventgridTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings RemoveIds(this AzureEventgridTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetName(this AzureEventgridTopicShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetName(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetResourceGroup(this AzureEventgridTopicShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetResourceGroup(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetSubscription(this AzureEventgridTopicShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetSubscription(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetDebug(this AzureEventgridTopicShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetDebug(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetHelp(this AzureEventgridTopicShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetHelp(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetOutput(this AzureEventgridTopicShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetOutput(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetQuery(this AzureEventgridTopicShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetQuery(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetVerbose(this AzureEventgridTopicShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetVerbose(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetTags(this AzureEventgridTopicUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetTags(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetIds(this AzureEventgridTopicUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetIds(this AzureEventgridTopicUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridTopicUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings AddIds(this AzureEventgridTopicUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridTopicUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings AddIds(this AzureEventgridTopicUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridTopicUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ClearIds(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridTopicUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings RemoveIds(this AzureEventgridTopicUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridTopicUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings RemoveIds(this AzureEventgridTopicUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetName(this AzureEventgridTopicUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetName(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetResourceGroup(this AzureEventgridTopicUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetResourceGroup(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetSubscription(this AzureEventgridTopicUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetSubscription(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetAdd(this AzureEventgridTopicUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetAdd(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetForceString(this AzureEventgridTopicUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetForceString(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetRemove(this AzureEventgridTopicUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetRemove(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetSet(this AzureEventgridTopicUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetSet(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetDebug(this AzureEventgridTopicUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetDebug(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetHelp(this AzureEventgridTopicUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetHelp(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetOutput(this AzureEventgridTopicUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetOutput(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetQuery(this AzureEventgridTopicUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetQuery(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetVerbose(this AzureEventgridTopicUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetVerbose(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainKeyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainKeyListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetName(this AzureEventgridDomainKeyListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetName(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetResourceGroup(this AzureEventgridDomainKeyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetResourceGroup(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetSubscription(this AzureEventgridDomainKeyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetSubscription(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetDebug(this AzureEventgridDomainKeyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetDebug(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetHelp(this AzureEventgridDomainKeyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetHelp(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetOutput(this AzureEventgridDomainKeyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetOutput(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetQuery(this AzureEventgridDomainKeyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetQuery(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings SetVerbose(this AzureEventgridDomainKeyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyListSettings ResetVerbose(this AzureEventgridDomainKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainKeyRegenerateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainKeyRegenerateSettingsExtensions
    {
        #region KeyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.KeyName"/></em></p>
        ///   <p>Key name to regenerate key1 or key2.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetKeyName(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string keyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = keyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.KeyName"/></em></p>
        ///   <p>Key name to regenerate key1 or key2.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetKeyName(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetName(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Name"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetName(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetResourceGroup(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetResourceGroup(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetSubscription(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetSubscription(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetDebug(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetDebug(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetHelp(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetHelp(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetOutput(this AzureEventgridDomainKeyRegenerateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetOutput(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetQuery(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetQuery(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainKeyRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings SetVerbose(this AzureEventgridDomainKeyRegenerateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainKeyRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainKeyRegenerateSettings ResetVerbose(this AzureEventgridDomainKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainTopicCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainTopicCreateSettingsExtensions
    {
        #region DomainName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetDomainName(this AzureEventgridDomainTopicCreateSettings toolSettings, string domainName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = domainName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetDomainName(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Name"/></em></p>
        ///   <p>Name of the domain topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetName(this AzureEventgridDomainTopicCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Name"/></em></p>
        ///   <p>Name of the domain topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetName(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetResourceGroup(this AzureEventgridDomainTopicCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetResourceGroup(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetSubscription(this AzureEventgridDomainTopicCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetSubscription(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetDebug(this AzureEventgridDomainTopicCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetDebug(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetHelp(this AzureEventgridDomainTopicCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetHelp(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetOutput(this AzureEventgridDomainTopicCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetOutput(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetQuery(this AzureEventgridDomainTopicCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetQuery(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings SetVerbose(this AzureEventgridDomainTopicCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicCreateSettings ResetVerbose(this AzureEventgridDomainTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainTopicDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainTopicDeleteSettingsExtensions
    {
        #region DomainName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetDomainName(this AzureEventgridDomainTopicDeleteSettings toolSettings, string domainName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = domainName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetDomainName(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetIds(this AzureEventgridDomainTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetIds(this AzureEventgridDomainTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings AddIds(this AzureEventgridDomainTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings AddIds(this AzureEventgridDomainTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ClearIds(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings RemoveIds(this AzureEventgridDomainTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainTopicDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings RemoveIds(this AzureEventgridDomainTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Name"/></em></p>
        ///   <p>Name of the domain topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetName(this AzureEventgridDomainTopicDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Name"/></em></p>
        ///   <p>Name of the domain topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetName(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetResourceGroup(this AzureEventgridDomainTopicDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetResourceGroup(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetSubscription(this AzureEventgridDomainTopicDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetSubscription(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetDebug(this AzureEventgridDomainTopicDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetDebug(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetHelp(this AzureEventgridDomainTopicDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetHelp(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetOutput(this AzureEventgridDomainTopicDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetOutput(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetQuery(this AzureEventgridDomainTopicDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetQuery(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings SetVerbose(this AzureEventgridDomainTopicDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicDeleteSettings ResetVerbose(this AzureEventgridDomainTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainTopicListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainTopicListSettingsExtensions
    {
        #region DomainName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetDomainName(this AzureEventgridDomainTopicListSettings toolSettings, string domainName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = domainName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetDomainName(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetResourceGroup(this AzureEventgridDomainTopicListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetResourceGroup(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region OdataQuery
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetOdataQuery(this AzureEventgridDomainTopicListSettings toolSettings, string odataQuery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = odataQuery;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.OdataQuery"/></em></p>
        ///   <p>The OData query used for filtering the list results. Filtering is currently allowed on the Name property only. The supported operations include: CONTAINS, eq (for equal), ne (for not equal), AND, OR and NOT.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetOdataQuery(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OdataQuery = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetSubscription(this AzureEventgridDomainTopicListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetSubscription(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetDebug(this AzureEventgridDomainTopicListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetDebug(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetHelp(this AzureEventgridDomainTopicListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetHelp(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetOutput(this AzureEventgridDomainTopicListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetOutput(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetQuery(this AzureEventgridDomainTopicListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetQuery(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings SetVerbose(this AzureEventgridDomainTopicListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicListSettings ResetVerbose(this AzureEventgridDomainTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridDomainTopicShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridDomainTopicShowSettingsExtensions
    {
        #region DomainName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetDomainName(this AzureEventgridDomainTopicShowSettings toolSettings, string domainName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = domainName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.DomainName"/></em></p>
        ///   <p>Name of the domain.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetDomainName(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DomainName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetIds(this AzureEventgridDomainTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetIds(this AzureEventgridDomainTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings AddIds(this AzureEventgridDomainTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings AddIds(this AzureEventgridDomainTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ClearIds(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings RemoveIds(this AzureEventgridDomainTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureEventgridDomainTopicShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings RemoveIds(this AzureEventgridDomainTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Name"/></em></p>
        ///   <p>Name of the domain topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetName(this AzureEventgridDomainTopicShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Name"/></em></p>
        ///   <p>Name of the domain topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetName(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetResourceGroup(this AzureEventgridDomainTopicShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetResourceGroup(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetSubscription(this AzureEventgridDomainTopicShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetSubscription(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetDebug(this AzureEventgridDomainTopicShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetDebug(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetHelp(this AzureEventgridDomainTopicShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetHelp(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetOutput(this AzureEventgridDomainTopicShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetOutput(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetQuery(this AzureEventgridDomainTopicShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetQuery(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridDomainTopicShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings SetVerbose(this AzureEventgridDomainTopicShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridDomainTopicShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridDomainTopicShowSettings ResetVerbose(this AzureEventgridDomainTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicKeyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicKeyListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetName(this AzureEventgridTopicKeyListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetName(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetResourceGroup(this AzureEventgridTopicKeyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetResourceGroup(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetSubscription(this AzureEventgridTopicKeyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetSubscription(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetDebug(this AzureEventgridTopicKeyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetDebug(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetHelp(this AzureEventgridTopicKeyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetHelp(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetOutput(this AzureEventgridTopicKeyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetOutput(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetQuery(this AzureEventgridTopicKeyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetQuery(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetVerbose(this AzureEventgridTopicKeyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetVerbose(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicKeyRegenerateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicKeyRegenerateSettingsExtensions
    {
        #region KeyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.KeyName"/></em></p>
        ///   <p>Key name to regenerate key1 or key2.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetKeyName(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string keyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = keyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.KeyName"/></em></p>
        ///   <p>Key name to regenerate key1 or key2.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetKeyName(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetName(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Name"/></em></p>
        ///   <p>Name of the topic.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetName(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetResourceGroup(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetResourceGroup(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetSubscription(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetSubscription(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetDebug(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetDebug(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetHelp(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetHelp(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetOutput(this AzureEventgridTopicKeyRegenerateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetOutput(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetQuery(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetQuery(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetVerbose(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetVerbose(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region EventgridEventSubscriptionEndpointType
    /// <summary>
    ///   Used within <see cref="AzureEventgridTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<EventgridEventSubscriptionEndpointType>))]
    public partial class EventgridEventSubscriptionEndpointType : Enumeration
    {
        public static EventgridEventSubscriptionEndpointType eventhub = new EventgridEventSubscriptionEndpointType { Value = "eventhub" };
        public static EventgridEventSubscriptionEndpointType hybridconnection = new EventgridEventSubscriptionEndpointType { Value = "hybridconnection" };
        public static EventgridEventSubscriptionEndpointType servicebusqueue = new EventgridEventSubscriptionEndpointType { Value = "servicebusqueue" };
        public static EventgridEventSubscriptionEndpointType storagequeue = new EventgridEventSubscriptionEndpointType { Value = "storagequeue" };
        public static EventgridEventSubscriptionEndpointType webhook = new EventgridEventSubscriptionEndpointType { Value = "webhook" };
    }
    #endregion
}
