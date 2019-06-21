// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureResource.json
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
    public static partial class AzureResourceTasks
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public static string AzureResourcePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURERESOURCE_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureResourceLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure resources.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResource(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureResourcePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureResourceLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceCreate(AzureResourceCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceCreateSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceCreateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureResourceCreateSettings.Id"/></li>
        ///     <li><c>--is-full-object</c> via <see cref="AzureResourceCreateSettings.IsFullObject"/></li>
        ///     <li><c>--location</c> via <see cref="AzureResourceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceCreateSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceCreateSettings.Parent"/></li>
        ///     <li><c>--properties</c> via <see cref="AzureResourceCreateSettings.Properties"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceCreate(Configure<AzureResourceCreateSettings> configurator)
        {
            return AzureResourceCreate(configurator(new AzureResourceCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceCreateSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceCreateSettings.Help"/></li>
        ///     <li><c>--id</c> via <see cref="AzureResourceCreateSettings.Id"/></li>
        ///     <li><c>--is-full-object</c> via <see cref="AzureResourceCreateSettings.IsFullObject"/></li>
        ///     <li><c>--location</c> via <see cref="AzureResourceCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceCreateSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceCreateSettings.Parent"/></li>
        ///     <li><c>--properties</c> via <see cref="AzureResourceCreateSettings.Properties"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceCreate(CombinatorialConfigure<AzureResourceCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceCreate, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceDelete(AzureResourceDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceDeleteSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceDelete(Configure<AzureResourceDeleteSettings> configurator)
        {
            return AzureResourceDelete(configurator(new AzureResourceDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceDeleteSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceDelete(CombinatorialConfigure<AzureResourceDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceDelete, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceInvokeAction(AzureResourceInvokeActionSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceInvokeActionSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--action</c> via <see cref="AzureResourceInvokeActionSettings.Action"/></li>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceInvokeActionSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceInvokeActionSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceInvokeActionSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceInvokeActionSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceInvokeActionSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceInvokeActionSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceInvokeActionSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceInvokeActionSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceInvokeActionSettings.Query"/></li>
        ///     <li><c>--request-body</c> via <see cref="AzureResourceInvokeActionSettings.RequestBody"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceInvokeActionSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceInvokeActionSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceInvokeActionSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceInvokeActionSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceInvokeAction(Configure<AzureResourceInvokeActionSettings> configurator)
        {
            return AzureResourceInvokeAction(configurator(new AzureResourceInvokeActionSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--action</c> via <see cref="AzureResourceInvokeActionSettings.Action"/></li>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceInvokeActionSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceInvokeActionSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceInvokeActionSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceInvokeActionSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceInvokeActionSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceInvokeActionSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceInvokeActionSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceInvokeActionSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceInvokeActionSettings.Query"/></li>
        ///     <li><c>--request-body</c> via <see cref="AzureResourceInvokeActionSettings.RequestBody"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceInvokeActionSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceInvokeActionSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceInvokeActionSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceInvokeActionSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceInvokeActionSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceInvokeAction(CombinatorialConfigure<AzureResourceInvokeActionSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceInvokeAction, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceList(AzureResourceListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureResourceListSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceListSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceListSettings.Subscription"/></li>
        ///     <li><c>--tag</c> via <see cref="AzureResourceListSettings.Tag"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceList(Configure<AzureResourceListSettings> configurator)
        {
            return AzureResourceList(configurator(new AzureResourceListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureResourceListSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceListSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceListSettings.Subscription"/></li>
        ///     <li><c>--tag</c> via <see cref="AzureResourceListSettings.Tag"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceListSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceList(CombinatorialConfigure<AzureResourceListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceList, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceMove(AzureResourceMoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceMoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceMoveSettings.Debug"/></li>
        ///     <li><c>--destination-group</c> via <see cref="AzureResourceMoveSettings.DestinationGroup"/></li>
        ///     <li><c>--destination-subscription-id</c> via <see cref="AzureResourceMoveSettings.DestinationSubscriptionId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceMoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceMoveSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceMoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceMoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceMoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceMoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceMove(Configure<AzureResourceMoveSettings> configurator)
        {
            return AzureResourceMove(configurator(new AzureResourceMoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceMoveSettings.Debug"/></li>
        ///     <li><c>--destination-group</c> via <see cref="AzureResourceMoveSettings.DestinationGroup"/></li>
        ///     <li><c>--destination-subscription-id</c> via <see cref="AzureResourceMoveSettings.DestinationSubscriptionId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceMoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceMoveSettings.Ids"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceMoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceMoveSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceMoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceMoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceMoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceMove(CombinatorialConfigure<AzureResourceMoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceMove, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceShow(AzureResourceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceShowSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceShowSettings.Ids"/></li>
        ///     <li><c>--include-response-body</c> via <see cref="AzureResourceShowSettings.IncludeResponseBody"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceShow(Configure<AzureResourceShowSettings> configurator)
        {
            return AzureResourceShow(configurator(new AzureResourceShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceShowSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceShowSettings.Ids"/></li>
        ///     <li><c>--include-response-body</c> via <see cref="AzureResourceShowSettings.IncludeResponseBody"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceShow(CombinatorialConfigure<AzureResourceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceShow, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceTag(AzureResourceTagSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceTagSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceTagSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceTagSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceTagSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceTagSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceTagSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceTagSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceTagSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceTagSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceTagSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceTagSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceTagSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceTagSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureResourceTagSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceTagSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceTag(Configure<AzureResourceTagSettings> configurator)
        {
            return AzureResourceTag(configurator(new AzureResourceTagSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceTagSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceTagSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceTagSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceTagSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceTagSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceTagSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceTagSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceTagSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceTagSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceTagSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceTagSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceTagSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureResourceTagSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceTagSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceTagSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceTag(CombinatorialConfigure<AzureResourceTagSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceTag, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceUpdate(AzureResourceUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureResourceUpdateSettings.Add"/></li>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceUpdateSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureResourceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceUpdateSettings.Ids"/></li>
        ///     <li><c>--include-response-body</c> via <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceUpdateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceUpdateSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureResourceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceUpdateSettings.ResourceType"/></li>
        ///     <li><c>--set</c> via <see cref="AzureResourceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceUpdate(Configure<AzureResourceUpdateSettings> configurator)
        {
            return AzureResourceUpdate(configurator(new AzureResourceUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureResourceUpdateSettings.Add"/></li>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceUpdateSettings.ApiVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureResourceUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceUpdateSettings.Ids"/></li>
        ///     <li><c>--include-response-body</c> via <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceUpdateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceUpdateSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureResourceUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceUpdateSettings.ResourceType"/></li>
        ///     <li><c>--set</c> via <see cref="AzureResourceUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceUpdate(CombinatorialConfigure<AzureResourceUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceUpdate, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceWait(AzureResourceWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceWaitSettings.ApiVersion"/></li>
        ///     <li><c>--created</c> via <see cref="AzureResourceWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureResourceWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureResourceWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureResourceWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceWaitSettings.Ids"/></li>
        ///     <li><c>--include-response-body</c> via <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureResourceWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceWaitSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceWaitSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceWaitSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceWaitSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceWaitSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureResourceWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureResourceWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceWait(Configure<AzureResourceWaitSettings> configurator)
        {
            return AzureResourceWait(configurator(new AzureResourceWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--api-version</c> via <see cref="AzureResourceWaitSettings.ApiVersion"/></li>
        ///     <li><c>--created</c> via <see cref="AzureResourceWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureResourceWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureResourceWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureResourceWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureResourceWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceWaitSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceWaitSettings.Ids"/></li>
        ///     <li><c>--include-response-body</c> via <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureResourceWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceWaitSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceWaitSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceWaitSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceWaitSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceWaitSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureResourceWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureResourceWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceWait(CombinatorialConfigure<AzureResourceWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceWait, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLinkCreate(AzureResourceLinkCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLinkCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkCreateSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkCreateSettings.Link"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLinkCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkCreateSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureResourceLinkCreateSettings.Target"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLinkCreate(Configure<AzureResourceLinkCreateSettings> configurator)
        {
            return AzureResourceLinkCreate(configurator(new AzureResourceLinkCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkCreateSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkCreateSettings.Link"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLinkCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkCreateSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureResourceLinkCreateSettings.Target"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLinkCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLinkCreate(CombinatorialConfigure<AzureResourceLinkCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLinkCreate, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLinkDelete(AzureResourceLinkDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLinkDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkDeleteSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkDeleteSettings.Link"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLinkDelete(Configure<AzureResourceLinkDeleteSettings> configurator)
        {
            return AzureResourceLinkDelete(configurator(new AzureResourceLinkDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkDeleteSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkDeleteSettings.Link"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLinkDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLinkDelete(CombinatorialConfigure<AzureResourceLinkDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLinkDelete, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLinkList(AzureResourceLinkListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLinkListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureResourceLinkListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkListSettings.Query"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureResourceLinkListSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLinkList(Configure<AzureResourceLinkListSettings> configurator)
        {
            return AzureResourceLinkList(configurator(new AzureResourceLinkListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureResourceLinkListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkListSettings.Query"/></li>
        ///     <li><c>--scope</c> via <see cref="AzureResourceLinkListSettings.Scope"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLinkListSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLinkList(CombinatorialConfigure<AzureResourceLinkListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLinkList, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLinkShow(AzureResourceLinkShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLinkShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkShowSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkShowSettings.Link"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLinkShow(Configure<AzureResourceLinkShowSettings> configurator)
        {
            return AzureResourceLinkShow(configurator(new AzureResourceLinkShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkShowSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkShowSettings.Link"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLinkShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLinkShow(CombinatorialConfigure<AzureResourceLinkShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLinkShow, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLinkUpdate(AzureResourceLinkUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLinkUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkUpdateSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkUpdateSettings.Link"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLinkUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkUpdateSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureResourceLinkUpdateSettings.Target"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLinkUpdate(Configure<AzureResourceLinkUpdateSettings> configurator)
        {
            return AzureResourceLinkUpdate(configurator(new AzureResourceLinkUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLinkUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLinkUpdateSettings.Help"/></li>
        ///     <li><c>--link</c> via <see cref="AzureResourceLinkUpdateSettings.Link"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLinkUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLinkUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLinkUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLinkUpdateSettings.Subscription"/></li>
        ///     <li><c>--target</c> via <see cref="AzureResourceLinkUpdateSettings.Target"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLinkUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLinkUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLinkUpdate(CombinatorialConfigure<AzureResourceLinkUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLinkUpdate, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLockCreate(AzureResourceLockCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLockCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureResourceLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockCreateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockCreateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockCreateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockCreateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLockCreate(Configure<AzureResourceLockCreateSettings> configurator)
        {
            return AzureResourceLockCreate(configurator(new AzureResourceLockCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockCreateSettings.Help"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureResourceLockCreateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockCreateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockCreateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLockCreateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockCreateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockCreateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockCreateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockCreateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockCreateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLockCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLockCreate(CombinatorialConfigure<AzureResourceLockCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLockCreate, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLockDelete(AzureResourceLockDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLockDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockDeleteSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockDeleteSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLockDelete(Configure<AzureResourceLockDeleteSettings> configurator)
        {
            return AzureResourceLockDelete(configurator(new AzureResourceLockDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceLockDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockDeleteSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockDeleteSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockDeleteSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockDeleteSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockDeleteSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockDeleteSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockDeleteSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLockDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLockDelete(CombinatorialConfigure<AzureResourceLockDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLockDelete, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLockList(AzureResourceLockListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLockListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureResourceLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockListSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLockList(Configure<AzureResourceLockListSettings> configurator)
        {
            return AzureResourceLockList(configurator(new AzureResourceLockListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockListSettings.Debug"/></li>
        ///     <li><c>--filter-string</c> via <see cref="AzureResourceLockListSettings.FilterString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockListSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockListSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockListSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockListSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockListSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockListSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockListSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLockListSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLockList(CombinatorialConfigure<AzureResourceLockListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLockList, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLockShow(AzureResourceLockShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLockShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockShowSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockShowSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLockShow(Configure<AzureResourceLockShowSettings> configurator)
        {
            return AzureResourceLockShow(configurator(new AzureResourceLockShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceLockShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockShowSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockShowSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockShowSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockShowSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockShowSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockShowSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLockShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLockShow(CombinatorialConfigure<AzureResourceLockShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLockShow, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureResourceLockUpdate(AzureResourceLockUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureResourceLockUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureResourceLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockUpdateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockUpdateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockUpdateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockUpdateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockUpdateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureResourceLockUpdate(Configure<AzureResourceLockUpdateSettings> configurator)
        {
            return AzureResourceLockUpdate(configurator(new AzureResourceLockUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureResourceLockUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureResourceLockUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureResourceLockUpdateSettings.Ids"/></li>
        ///     <li><c>--lock-type</c> via <see cref="AzureResourceLockUpdateSettings.LockType"/></li>
        ///     <li><c>--name</c> via <see cref="AzureResourceLockUpdateSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureResourceLockUpdateSettings.Namespace"/></li>
        ///     <li><c>--notes</c> via <see cref="AzureResourceLockUpdateSettings.Notes"/></li>
        ///     <li><c>--output</c> via <see cref="AzureResourceLockUpdateSettings.Output"/></li>
        ///     <li><c>--parent</c> via <see cref="AzureResourceLockUpdateSettings.Parent"/></li>
        ///     <li><c>--query</c> via <see cref="AzureResourceLockUpdateSettings.Query"/></li>
        ///     <li><c>--resource</c> via <see cref="AzureResourceLockUpdateSettings.Resource"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureResourceLockUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-type</c> via <see cref="AzureResourceLockUpdateSettings.ResourceType"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureResourceLockUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureResourceLockUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureResourceLockUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureResourceLockUpdate(CombinatorialConfigure<AzureResourceLockUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureResourceLockUpdate, AzureResourceLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureResourceCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   A JSON-formatted string containing resource properties.
        /// </summary>
        public virtual string Properties { get; internal set; }
        /// <summary>
        ///   Resource ID.
        /// </summary>
        public virtual string Id { get; internal set; }
        /// <summary>
        ///   Indicates that the properties object includes other options such as location, tags, sku, and/or plan.
        /// </summary>
        public virtual string IsFullObject { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource create")
              .Add("--properties {value}", Properties)
              .Add("--id {value}", Id)
              .Add("--is-full-object {value}", IsFullObject)
              .Add("--location {value}", Location)
              .Add("--api-version {value}", ApiVersion)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
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
    #region AzureResourceDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource delete")
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
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
    #region AzureResourceInvokeActionSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceInvokeActionSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   The action that will be invoked on the specified resource.
        /// </summary>
        public virtual string Action { get; internal set; }
        /// <summary>
        ///   JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.
        /// </summary>
        public virtual string RequestBody { get; internal set; }
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource invoke-action")
              .Add("--action {value}", Action)
              .Add("--request-body {value}", RequestBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
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
    #region AzureResourceListSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   A single tag in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tag { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource list")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--tag {value}", Tag)
              .Add("--namespace {value}", Namespace)
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
    #region AzureResourceMoveSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceMoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   The destination resource group name.
        /// </summary>
        public virtual string DestinationGroup { get; internal set; }
        /// <summary>
        ///   The space-separated resource ids to be moved.
        /// </summary>
        public virtual string Ids { get; internal set; }
        /// <summary>
        ///   The destination subscription identifier.
        /// </summary>
        public virtual string DestinationSubscriptionId { get; internal set; }
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
              .Add("resource move")
              .Add("--destination-group {value}", DestinationGroup)
              .Add("--ids {value}", Ids)
              .Add("--destination-subscription-id {value}", DestinationSubscriptionId)
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
    #region AzureResourceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Use if the default command output doesn't capture all of the property data.
        /// </summary>
        public virtual bool? IncludeResponseBody { get; internal set; }
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource show")
              .Add("--include-response-body", IncludeResponseBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
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
    #region AzureResourceTagSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceTagSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource tag")
              .Add("--tags {value}", Tags)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
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
    #region AzureResourceUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Use if the default command output doesn't capture all of the property data.
        /// </summary>
        public virtual bool? IncludeResponseBody { get; internal set; }
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource update")
              .Add("--include-response-body", IncludeResponseBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
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
    #region AzureResourceWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Use if the default command output doesn't capture all of the property data.
        /// </summary>
        public virtual bool? IncludeResponseBody { get; internal set; }
        /// <summary>
        ///   The api version of the resource (omit for latest).
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name. (Ex: myC).
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource wait")
              .Add("--include-response-body", IncludeResponseBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
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
    #region AzureResourceLinkCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Fully-qualified resource ID of the resource link.
        /// </summary>
        public virtual string Link { get; internal set; }
        /// <summary>
        ///   Fully-qualified resource ID of the resource link target.
        /// </summary>
        public virtual string Target { get; internal set; }
        /// <summary>
        ///   Notes for the link.
        /// </summary>
        public virtual string Notes { get; internal set; }
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
              .Add("resource link create")
              .Add("--link {value}", Link)
              .Add("--target {value}", Target)
              .Add("--notes {value}", Notes)
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
    #region AzureResourceLinkDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Fully-qualified resource ID of the resource link.
        /// </summary>
        public virtual string Link { get; internal set; }
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
              .Add("resource link delete")
              .Add("--link {value}", Link)
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
    #region AzureResourceLinkListSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Filter string for limiting results.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   Fully-qualified scope for retrieving links.
        /// </summary>
        public virtual string Scope { get; internal set; }
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
              .Add("resource link list")
              .Add("--filter {value}", Filter)
              .Add("--scope {value}", Scope)
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
    #region AzureResourceLinkShowSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Fully-qualified resource ID of the resource link.
        /// </summary>
        public virtual string Link { get; internal set; }
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
              .Add("resource link show")
              .Add("--link {value}", Link)
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
    #region AzureResourceLinkUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   Fully-qualified resource ID of the resource link.
        /// </summary>
        public virtual string Link { get; internal set; }
        /// <summary>
        ///   Notes for the link.
        /// </summary>
        public virtual string Notes { get; internal set; }
        /// <summary>
        ///   Fully-qualified resource ID of the resource link target.
        /// </summary>
        public virtual string Target { get; internal set; }
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
              .Add("resource link update")
              .Add("--link {value}", Link)
              .Add("--notes {value}", Notes)
              .Add("--target {value}", Target)
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
    #region AzureResourceLockCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual ResourceLockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
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
    #region AzureResourceLockDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource lock delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
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
    #region AzureResourceLockListSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   A query filter to use to restrict the results.
        /// </summary>
        public virtual string FilterString { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource lock list")
              .Add("--filter-string {value}", FilterString)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
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
    #region AzureResourceLockShowSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource lock show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
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
    #region AzureResourceLockUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureResource executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        public override Action<OutputType, string> CustomLogger => AzureResourceTasks.AzureResourceLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of lock restriction.
        /// </summary>
        public virtual ResourceLockLockType LockType { get; internal set; }
        /// <summary>
        ///   Name of the lock.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Notes about this lock.
        /// </summary>
        public virtual string Notes { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public virtual string Parent { get; internal set; }
        /// <summary>
        ///   If an ID is given, other resource arguments should not be given.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
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
              .Add("resource lock update")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
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
    #region AzureResourceCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceCreateSettingsExtensions
    {
        #region Properties
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Properties"/></em></p>
        ///   <p>A JSON-formatted string containing resource properties.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetProperties(this AzureResourceCreateSettings toolSettings, string properties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Properties = properties;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Properties"/></em></p>
        ///   <p>A JSON-formatted string containing resource properties.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetProperties(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Properties = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Id"/></em></p>
        ///   <p>Resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetId(this AzureResourceCreateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Id"/></em></p>
        ///   <p>Resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetId(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region IsFullObject
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.IsFullObject"/></em></p>
        ///   <p>Indicates that the properties object includes other options such as location, tags, sku, and/or plan.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetIsFullObject(this AzureResourceCreateSettings toolSettings, string isFullObject)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsFullObject = isFullObject;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.IsFullObject"/></em></p>
        ///   <p>Indicates that the properties object includes other options such as location, tags, sku, and/or plan.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetIsFullObject(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsFullObject = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetLocation(this AzureResourceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetLocation(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetApiVersion(this AzureResourceCreateSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetApiVersion(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetName(this AzureResourceCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetName(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetNamespace(this AzureResourceCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetNamespace(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetParent(this AzureResourceCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetParent(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetResourceGroup(this AzureResourceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetResourceGroup(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetResourceType(this AzureResourceCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetResourceType(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetSubscription(this AzureResourceCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetSubscription(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetDebug(this AzureResourceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetDebug(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetHelp(this AzureResourceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetHelp(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetOutput(this AzureResourceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetOutput(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetQuery(this AzureResourceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetQuery(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings SetVerbose(this AzureResourceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceCreateSettings ResetVerbose(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceDeleteSettingsExtensions
    {
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetApiVersion(this AzureResourceDeleteSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetApiVersion(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetIds(this AzureResourceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetIds(this AzureResourceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings AddIds(this AzureResourceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings AddIds(this AzureResourceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ClearIds(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings RemoveIds(this AzureResourceDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings RemoveIds(this AzureResourceDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetName(this AzureResourceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetName(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetNamespace(this AzureResourceDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetNamespace(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetParent(this AzureResourceDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetParent(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetResourceGroup(this AzureResourceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetResourceGroup(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetResourceType(this AzureResourceDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetResourceType(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetSubscription(this AzureResourceDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetSubscription(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetDebug(this AzureResourceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetDebug(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetHelp(this AzureResourceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetHelp(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetOutput(this AzureResourceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetOutput(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetQuery(this AzureResourceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetQuery(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings SetVerbose(this AzureResourceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetVerbose(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceInvokeActionSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceInvokeActionSettingsExtensions
    {
        #region Action
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Action"/></em></p>
        ///   <p>The action that will be invoked on the specified resource.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetAction(this AzureResourceInvokeActionSettings toolSettings, string action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Action"/></em></p>
        ///   <p>The action that will be invoked on the specified resource.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetAction(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region RequestBody
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.RequestBody"/></em></p>
        ///   <p>JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetRequestBody(this AzureResourceInvokeActionSettings toolSettings, string requestBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequestBody = requestBody;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.RequestBody"/></em></p>
        ///   <p>JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetRequestBody(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequestBody = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetApiVersion(this AzureResourceInvokeActionSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetApiVersion(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetIds(this AzureResourceInvokeActionSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetIds(this AzureResourceInvokeActionSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceInvokeActionSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings AddIds(this AzureResourceInvokeActionSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceInvokeActionSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings AddIds(this AzureResourceInvokeActionSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceInvokeActionSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ClearIds(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceInvokeActionSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings RemoveIds(this AzureResourceInvokeActionSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceInvokeActionSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings RemoveIds(this AzureResourceInvokeActionSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetName(this AzureResourceInvokeActionSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetName(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetNamespace(this AzureResourceInvokeActionSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetNamespace(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetParent(this AzureResourceInvokeActionSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetParent(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetResourceGroup(this AzureResourceInvokeActionSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetResourceGroup(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetResourceType(this AzureResourceInvokeActionSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetResourceType(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetSubscription(this AzureResourceInvokeActionSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetSubscription(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetDebug(this AzureResourceInvokeActionSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetDebug(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetHelp(this AzureResourceInvokeActionSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetHelp(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetOutput(this AzureResourceInvokeActionSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetOutput(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetQuery(this AzureResourceInvokeActionSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetQuery(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceInvokeActionSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetVerbose(this AzureResourceInvokeActionSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceInvokeActionSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetVerbose(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceListSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetLocation(this AzureResourceListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetLocation(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetName(this AzureResourceListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetName(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Tag
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Tag"/></em></p>
        ///   <p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetTag(this AzureResourceListSettings toolSettings, string tag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tag = tag;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Tag"/></em></p>
        ///   <p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetTag(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tag = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetNamespace(this AzureResourceListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetNamespace(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetResourceGroup(this AzureResourceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetResourceGroup(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetResourceType(this AzureResourceListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetResourceType(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetSubscription(this AzureResourceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetSubscription(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetDebug(this AzureResourceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetDebug(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetHelp(this AzureResourceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetHelp(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetOutput(this AzureResourceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetOutput(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetQuery(this AzureResourceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetQuery(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings SetVerbose(this AzureResourceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceListSettings ResetVerbose(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceMoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceMoveSettingsExtensions
    {
        #region DestinationGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.DestinationGroup"/></em></p>
        ///   <p>The destination resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetDestinationGroup(this AzureResourceMoveSettings toolSettings, string destinationGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationGroup = destinationGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.DestinationGroup"/></em></p>
        ///   <p>The destination resource group name.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetDestinationGroup(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationGroup = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Ids"/></em></p>
        ///   <p>The space-separated resource ids to be moved.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetIds(this AzureResourceMoveSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Ids"/></em></p>
        ///   <p>The space-separated resource ids to be moved.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetIds(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region DestinationSubscriptionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.DestinationSubscriptionId"/></em></p>
        ///   <p>The destination subscription identifier.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetDestinationSubscriptionId(this AzureResourceMoveSettings toolSettings, string destinationSubscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationSubscriptionId = destinationSubscriptionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.DestinationSubscriptionId"/></em></p>
        ///   <p>The destination subscription identifier.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetDestinationSubscriptionId(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationSubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetSubscription(this AzureResourceMoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetSubscription(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetDebug(this AzureResourceMoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetDebug(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetHelp(this AzureResourceMoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetHelp(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetOutput(this AzureResourceMoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetOutput(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetQuery(this AzureResourceMoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetQuery(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceMoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings SetVerbose(this AzureResourceMoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceMoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceMoveSettings ResetVerbose(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceShowSettingsExtensions
    {
        #region IncludeResponseBody
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetIncludeResponseBody(this AzureResourceShowSettings toolSettings, bool? includeResponseBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = includeResponseBody;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureResourceShowSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings EnableIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureResourceShowSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings DisableIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureResourceShowSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ToggleIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = !toolSettings.IncludeResponseBody;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetApiVersion(this AzureResourceShowSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetApiVersion(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetIds(this AzureResourceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetIds(this AzureResourceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings AddIds(this AzureResourceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings AddIds(this AzureResourceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ClearIds(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings RemoveIds(this AzureResourceShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings RemoveIds(this AzureResourceShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetName(this AzureResourceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetName(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetNamespace(this AzureResourceShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetNamespace(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetParent(this AzureResourceShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetParent(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetResourceGroup(this AzureResourceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetResourceGroup(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetResourceType(this AzureResourceShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetResourceType(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetSubscription(this AzureResourceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetSubscription(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetDebug(this AzureResourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetDebug(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetHelp(this AzureResourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetHelp(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetOutput(this AzureResourceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetOutput(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetQuery(this AzureResourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetQuery(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings SetVerbose(this AzureResourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceShowSettings ResetVerbose(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceTagSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceTagSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetTags(this AzureResourceTagSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetTags(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetApiVersion(this AzureResourceTagSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetApiVersion(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetIds(this AzureResourceTagSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetIds(this AzureResourceTagSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceTagSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings AddIds(this AzureResourceTagSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceTagSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings AddIds(this AzureResourceTagSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceTagSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ClearIds(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceTagSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings RemoveIds(this AzureResourceTagSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceTagSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings RemoveIds(this AzureResourceTagSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetName(this AzureResourceTagSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetName(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetNamespace(this AzureResourceTagSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetNamespace(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetParent(this AzureResourceTagSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetParent(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetResourceGroup(this AzureResourceTagSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetResourceGroup(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetResourceType(this AzureResourceTagSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetResourceType(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetSubscription(this AzureResourceTagSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetSubscription(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetDebug(this AzureResourceTagSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetDebug(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetHelp(this AzureResourceTagSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetHelp(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetOutput(this AzureResourceTagSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetOutput(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetQuery(this AzureResourceTagSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetQuery(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceTagSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings SetVerbose(this AzureResourceTagSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceTagSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceTagSettings ResetVerbose(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceUpdateSettingsExtensions
    {
        #region IncludeResponseBody
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetIncludeResponseBody(this AzureResourceUpdateSettings toolSettings, bool? includeResponseBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = includeResponseBody;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings EnableIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings DisableIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ToggleIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = !toolSettings.IncludeResponseBody;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetApiVersion(this AzureResourceUpdateSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetApiVersion(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetIds(this AzureResourceUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetIds(this AzureResourceUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings AddIds(this AzureResourceUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings AddIds(this AzureResourceUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ClearIds(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings RemoveIds(this AzureResourceUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings RemoveIds(this AzureResourceUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetName(this AzureResourceUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetName(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetNamespace(this AzureResourceUpdateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetNamespace(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetParent(this AzureResourceUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetParent(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetResourceGroup(this AzureResourceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetResourceGroup(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetResourceType(this AzureResourceUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetResourceType(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetAdd(this AzureResourceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetAdd(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetForceString(this AzureResourceUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetForceString(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetRemove(this AzureResourceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetRemove(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetSet(this AzureResourceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetSet(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetSubscription(this AzureResourceUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetSubscription(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetDebug(this AzureResourceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetDebug(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetHelp(this AzureResourceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetHelp(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetOutput(this AzureResourceUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetOutput(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetQuery(this AzureResourceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetQuery(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings SetVerbose(this AzureResourceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetVerbose(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceWaitSettingsExtensions
    {
        #region IncludeResponseBody
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetIncludeResponseBody(this AzureResourceWaitSettings toolSettings, bool? includeResponseBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = includeResponseBody;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetIncludeResponseBody(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings EnableIncludeResponseBody(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings DisableIncludeResponseBody(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureResourceWaitSettings.IncludeResponseBody"/></em></p>
        ///   <p>Use if the default command output doesn't capture all of the property data.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ToggleIncludeResponseBody(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = !toolSettings.IncludeResponseBody;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetApiVersion(this AzureResourceWaitSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.ApiVersion"/></em></p>
        ///   <p>The api version of the resource (omit for latest).</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetApiVersion(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetIds(this AzureResourceWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetIds(this AzureResourceWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings AddIds(this AzureResourceWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings AddIds(this AzureResourceWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ClearIds(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings RemoveIds(this AzureResourceWaitSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceWaitSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings RemoveIds(this AzureResourceWaitSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetName(this AzureResourceWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Name"/></em></p>
        ///   <p>The resource name. (Ex: myC).</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetName(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetNamespace(this AzureResourceWaitSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetNamespace(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetParent(this AzureResourceWaitSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetParent(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetResourceGroup(this AzureResourceWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetResourceGroup(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetResourceType(this AzureResourceWaitSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetResourceType(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetCreated(this AzureResourceWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetCreated(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetCustom(this AzureResourceWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetCustom(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetDeleted(this AzureResourceWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetDeleted(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetExists(this AzureResourceWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetExists(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetInterval(this AzureResourceWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetInterval(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetTimeout(this AzureResourceWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetTimeout(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetUpdated(this AzureResourceWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetUpdated(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetSubscription(this AzureResourceWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetSubscription(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetDebug(this AzureResourceWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetDebug(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetHelp(this AzureResourceWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetHelp(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetOutput(this AzureResourceWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetOutput(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetQuery(this AzureResourceWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetQuery(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings SetVerbose(this AzureResourceWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceWaitSettings ResetVerbose(this AzureResourceWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkCreateSettingsExtensions
    {
        #region Link
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetLink(this AzureResourceLinkCreateSettings toolSettings, string link)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = link;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetLink(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = null;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Target"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link target.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetTarget(this AzureResourceLinkCreateSettings toolSettings, string target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Target"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link target.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetTarget(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Notes"/></em></p>
        ///   <p>Notes for the link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetNotes(this AzureResourceLinkCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Notes"/></em></p>
        ///   <p>Notes for the link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetNotes(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetSubscription(this AzureResourceLinkCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetSubscription(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetDebug(this AzureResourceLinkCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetDebug(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetHelp(this AzureResourceLinkCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetHelp(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetOutput(this AzureResourceLinkCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetOutput(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetQuery(this AzureResourceLinkCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetQuery(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetVerbose(this AzureResourceLinkCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetVerbose(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkDeleteSettingsExtensions
    {
        #region Link
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetLink(this AzureResourceLinkDeleteSettings toolSettings, string link)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = link;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetLink(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetSubscription(this AzureResourceLinkDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetSubscription(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetDebug(this AzureResourceLinkDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetDebug(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetHelp(this AzureResourceLinkDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetHelp(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetOutput(this AzureResourceLinkDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetOutput(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetQuery(this AzureResourceLinkDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetQuery(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetVerbose(this AzureResourceLinkDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetVerbose(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkListSettingsExtensions
    {
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Filter"/></em></p>
        ///   <p>Filter string for limiting results.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetFilter(this AzureResourceLinkListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Filter"/></em></p>
        ///   <p>Filter string for limiting results.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetFilter(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Scope"/></em></p>
        ///   <p>Fully-qualified scope for retrieving links.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetScope(this AzureResourceLinkListSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Scope"/></em></p>
        ///   <p>Fully-qualified scope for retrieving links.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetScope(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetSubscription(this AzureResourceLinkListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetSubscription(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetDebug(this AzureResourceLinkListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetDebug(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetHelp(this AzureResourceLinkListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetHelp(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetOutput(this AzureResourceLinkListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetOutput(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetQuery(this AzureResourceLinkListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetQuery(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings SetVerbose(this AzureResourceLinkListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetVerbose(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkShowSettingsExtensions
    {
        #region Link
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetLink(this AzureResourceLinkShowSettings toolSettings, string link)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = link;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetLink(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetSubscription(this AzureResourceLinkShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetSubscription(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetDebug(this AzureResourceLinkShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetDebug(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetHelp(this AzureResourceLinkShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetHelp(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetOutput(this AzureResourceLinkShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetOutput(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetQuery(this AzureResourceLinkShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetQuery(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetVerbose(this AzureResourceLinkShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetVerbose(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkUpdateSettingsExtensions
    {
        #region Link
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetLink(this AzureResourceLinkUpdateSettings toolSettings, string link)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = link;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Link"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetLink(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Link = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Notes"/></em></p>
        ///   <p>Notes for the link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetNotes(this AzureResourceLinkUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Notes"/></em></p>
        ///   <p>Notes for the link.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetNotes(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Target"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link target.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetTarget(this AzureResourceLinkUpdateSettings toolSettings, string target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Target"/></em></p>
        ///   <p>Fully-qualified resource ID of the resource link target.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetTarget(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetSubscription(this AzureResourceLinkUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetSubscription(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetDebug(this AzureResourceLinkUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetDebug(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetHelp(this AzureResourceLinkUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetHelp(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetOutput(this AzureResourceLinkUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetOutput(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetQuery(this AzureResourceLinkUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetQuery(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetVerbose(this AzureResourceLinkUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetVerbose(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetLockType(this AzureResourceLockCreateSettings toolSettings, ResourceLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetLockType(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetName(this AzureResourceLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetName(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetNotes(this AzureResourceLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetNotes(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetResourceGroup(this AzureResourceLockCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetResourceGroup(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetNamespace(this AzureResourceLockCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetNamespace(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetParent(this AzureResourceLockCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetParent(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetResource(this AzureResourceLockCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetResource(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetResourceType(this AzureResourceLockCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetResourceType(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetSubscription(this AzureResourceLockCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetSubscription(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetDebug(this AzureResourceLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetDebug(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetHelp(this AzureResourceLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetHelp(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetOutput(this AzureResourceLockCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetOutput(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetQuery(this AzureResourceLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetQuery(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetVerbose(this AzureResourceLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetVerbose(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetIds(this AzureResourceLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetIds(this AzureResourceLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings AddIds(this AzureResourceLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings AddIds(this AzureResourceLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ClearIds(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings RemoveIds(this AzureResourceLockDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceLockDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings RemoveIds(this AzureResourceLockDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetName(this AzureResourceLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetName(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetResourceGroup(this AzureResourceLockDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetResourceGroup(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetNamespace(this AzureResourceLockDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetNamespace(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetParent(this AzureResourceLockDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetParent(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetResource(this AzureResourceLockDeleteSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetResource(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetResourceType(this AzureResourceLockDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetResourceType(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetSubscription(this AzureResourceLockDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetSubscription(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetDebug(this AzureResourceLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetDebug(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetHelp(this AzureResourceLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetHelp(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetOutput(this AzureResourceLockDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetOutput(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetQuery(this AzureResourceLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetQuery(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetVerbose(this AzureResourceLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetVerbose(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockListSettingsExtensions
    {
        #region FilterString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetFilterString(this AzureResourceLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.FilterString"/></em></p>
        ///   <p>A query filter to use to restrict the results.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetFilterString(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetResourceGroup(this AzureResourceLockListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetResourceGroup(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetNamespace(this AzureResourceLockListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetNamespace(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetParent(this AzureResourceLockListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetParent(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetResource(this AzureResourceLockListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetResource(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetResourceType(this AzureResourceLockListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetResourceType(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetSubscription(this AzureResourceLockListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetSubscription(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetDebug(this AzureResourceLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetDebug(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetHelp(this AzureResourceLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetHelp(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetOutput(this AzureResourceLockListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetOutput(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetQuery(this AzureResourceLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetQuery(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings SetVerbose(this AzureResourceLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockListSettings ResetVerbose(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetIds(this AzureResourceLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetIds(this AzureResourceLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings AddIds(this AzureResourceLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings AddIds(this AzureResourceLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ClearIds(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings RemoveIds(this AzureResourceLockShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceLockShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings RemoveIds(this AzureResourceLockShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetName(this AzureResourceLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetName(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetResourceGroup(this AzureResourceLockShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetResourceGroup(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetNamespace(this AzureResourceLockShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetNamespace(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetParent(this AzureResourceLockShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetParent(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetResource(this AzureResourceLockShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetResource(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetResourceType(this AzureResourceLockShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetResourceType(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetSubscription(this AzureResourceLockShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetSubscription(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetDebug(this AzureResourceLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetDebug(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetHelp(this AzureResourceLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetHelp(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetOutput(this AzureResourceLockShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetOutput(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetQuery(this AzureResourceLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetQuery(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings SetVerbose(this AzureResourceLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetVerbose(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetIds(this AzureResourceLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetIds(this AzureResourceLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings AddIds(this AzureResourceLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureResourceLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings AddIds(this AzureResourceLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureResourceLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ClearIds(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings RemoveIds(this AzureResourceLockUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureResourceLockUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings RemoveIds(this AzureResourceLockUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetLockType(this AzureResourceLockUpdateSettings toolSettings, ResourceLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.LockType"/></em></p>
        ///   <p>The type of lock restriction.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetLockType(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetName(this AzureResourceLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Name"/></em></p>
        ///   <p>Name of the lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetName(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetNotes(this AzureResourceLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Notes"/></em></p>
        ///   <p>Notes about this lock.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetNotes(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetResourceGroup(this AzureResourceLockUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetResourceGroup(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetNamespace(this AzureResourceLockUpdateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Namespace"/></em></p>
        ///   <p>Provider namespace (Ex: 'Microsoft.Provider').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetNamespace(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetParent(this AzureResourceLockUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Parent"/></em></p>
        ///   <p>The parent path (Ex: 'resA/myA/resB/myB').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetParent(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetResource(this AzureResourceLockUpdateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Resource"/></em></p>
        ///   <p>If an ID is given, other resource arguments should not be given.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetResource(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetResourceType(this AzureResourceLockUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.ResourceType"/></em></p>
        ///   <p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetResourceType(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetSubscription(this AzureResourceLockUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetSubscription(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetDebug(this AzureResourceLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetDebug(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetHelp(this AzureResourceLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetHelp(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetOutput(this AzureResourceLockUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetOutput(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetQuery(this AzureResourceLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetQuery(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureResourceLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetVerbose(this AzureResourceLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureResourceLockUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetVerbose(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ResourceLockLockType
    /// <summary>
    ///   Used within <see cref="AzureResourceTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ResourceLockLockType>))]
    public partial class ResourceLockLockType : Enumeration
    {
        public static ResourceLockLockType cannotdelete = new ResourceLockLockType { Value = "cannotdelete" };
        public static ResourceLockLockType readonly_ = new ResourceLockLockType { Value = "readonly" };
    }
    #endregion
}
