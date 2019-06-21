// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureProvider.json
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
    public static partial class AzureProviderTasks
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public static string AzureProviderPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREPROVIDER_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureProviderLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage resource providers.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProvider(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureProviderPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureProviderLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProviderList(AzureProviderListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureProviderListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderListSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureProviderListSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureProviderList(Configure<AzureProviderListSettings> configurator)
        {
            return AzureProviderList(configurator(new AzureProviderListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderListSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureProviderListSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureProviderListSettings Settings, IReadOnlyCollection<Output> Output)> AzureProviderList(CombinatorialConfigure<AzureProviderListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureProviderList, AzureProviderLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProviderRegister(AzureProviderRegisterSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureProviderRegisterSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderRegisterSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderRegisterSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderRegisterSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderRegisterSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderRegisterSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderRegisterSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderRegisterSettings.Verbose"/></li>
        ///     <li><c>--wait</c> via <see cref="AzureProviderRegisterSettings.Wait"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureProviderRegister(Configure<AzureProviderRegisterSettings> configurator)
        {
            return AzureProviderRegister(configurator(new AzureProviderRegisterSettings()));
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderRegisterSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderRegisterSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderRegisterSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderRegisterSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderRegisterSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderRegisterSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderRegisterSettings.Verbose"/></li>
        ///     <li><c>--wait</c> via <see cref="AzureProviderRegisterSettings.Wait"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureProviderRegisterSettings Settings, IReadOnlyCollection<Output> Output)> AzureProviderRegister(CombinatorialConfigure<AzureProviderRegisterSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureProviderRegister, AzureProviderLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProviderShow(AzureProviderShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureProviderShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureProviderShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderShowSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureProviderShow(Configure<AzureProviderShowSettings> configurator)
        {
            return AzureProviderShow(configurator(new AzureProviderShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderShowSettings.Debug"/></li>
        ///     <li><c>--expand</c> via <see cref="AzureProviderShowSettings.Expand"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderShowSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureProviderShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureProviderShow(CombinatorialConfigure<AzureProviderShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureProviderShow, AzureProviderLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProviderUnregister(AzureProviderUnregisterSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureProviderUnregisterSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderUnregisterSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderUnregisterSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderUnregisterSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderUnregisterSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderUnregisterSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderUnregisterSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderUnregisterSettings.Verbose"/></li>
        ///     <li><c>--wait</c> via <see cref="AzureProviderUnregisterSettings.Wait"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureProviderUnregister(Configure<AzureProviderUnregisterSettings> configurator)
        {
            return AzureProviderUnregister(configurator(new AzureProviderUnregisterSettings()));
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderUnregisterSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderUnregisterSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderUnregisterSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderUnregisterSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderUnregisterSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderUnregisterSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderUnregisterSettings.Verbose"/></li>
        ///     <li><c>--wait</c> via <see cref="AzureProviderUnregisterSettings.Wait"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureProviderUnregisterSettings Settings, IReadOnlyCollection<Output> Output)> AzureProviderUnregister(CombinatorialConfigure<AzureProviderUnregisterSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureProviderUnregister, AzureProviderLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProviderOperationList(AzureProviderOperationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureProviderOperationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderOperationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderOperationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderOperationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderOperationListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderOperationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderOperationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureProviderOperationList(Configure<AzureProviderOperationListSettings> configurator)
        {
            return AzureProviderOperationList(configurator(new AzureProviderOperationListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderOperationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderOperationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderOperationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderOperationListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderOperationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderOperationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureProviderOperationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureProviderOperationList(CombinatorialConfigure<AzureProviderOperationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureProviderOperationList, AzureProviderLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureProviderOperationShow(AzureProviderOperationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureProviderOperationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderOperationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderOperationShowSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderOperationShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderOperationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderOperationShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderOperationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderOperationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureProviderOperationShow(Configure<AzureProviderOperationShowSettings> configurator)
        {
            return AzureProviderOperationShow(configurator(new AzureProviderOperationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource providers.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/provider?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureProviderOperationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureProviderOperationShowSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureProviderOperationShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureProviderOperationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureProviderOperationShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureProviderOperationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureProviderOperationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureProviderOperationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureProviderOperationShow(CombinatorialConfigure<AzureProviderOperationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureProviderOperationShow, AzureProviderLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureProviderListSettings
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureProviderListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureProviderTasks.AzureProviderPath;
        public override Action<OutputType, string> CustomLogger => AzureProviderTasks.AzureProviderLogger;
        /// <summary>
        ///   The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases.
        /// </summary>
        public virtual string Expand { get; internal set; }
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
              .Add("provider list")
              .Add("--expand {value}", Expand)
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
    #region AzureProviderRegisterSettings
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureProviderRegisterSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureProviderTasks.AzureProviderPath;
        public override Action<OutputType, string> CustomLogger => AzureProviderTasks.AzureProviderLogger;
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   Wait for the registration to finish.
        /// </summary>
        public virtual string Wait { get; internal set; }
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
              .Add("provider register")
              .Add("--namespace {value}", Namespace)
              .Add("--wait {value}", Wait)
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
    #region AzureProviderShowSettings
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureProviderShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureProviderTasks.AzureProviderPath;
        public override Action<OutputType, string> CustomLogger => AzureProviderTasks.AzureProviderLogger;
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases.
        /// </summary>
        public virtual string Expand { get; internal set; }
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
              .Add("provider show")
              .Add("--namespace {value}", Namespace)
              .Add("--expand {value}", Expand)
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
    #region AzureProviderUnregisterSettings
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureProviderUnregisterSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureProviderTasks.AzureProviderPath;
        public override Action<OutputType, string> CustomLogger => AzureProviderTasks.AzureProviderLogger;
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   Wait for unregistration to finish.
        /// </summary>
        public virtual string Wait { get; internal set; }
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
              .Add("provider unregister")
              .Add("--namespace {value}", Namespace)
              .Add("--wait {value}", Wait)
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
    #region AzureProviderOperationListSettings
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureProviderOperationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureProviderTasks.AzureProviderPath;
        public override Action<OutputType, string> CustomLogger => AzureProviderTasks.AzureProviderLogger;
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
              .Add("provider operation list")
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
    #region AzureProviderOperationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureProviderOperationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureProvider executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureProviderTasks.AzureProviderPath;
        public override Action<OutputType, string> CustomLogger => AzureProviderTasks.AzureProviderLogger;
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("provider operation show")
              .Add("--namespace {value}", Namespace)
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
    #region AzureProviderListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureProviderListSettingsExtensions
    {
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Expand"/></em></p>
        ///   <p>The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetExpand(this AzureProviderListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Expand"/></em></p>
        ///   <p>The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetExpand(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetSubscription(this AzureProviderListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetSubscription(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetDebug(this AzureProviderListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetDebug(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetHelp(this AzureProviderListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetHelp(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetOutput(this AzureProviderListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetOutput(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetQuery(this AzureProviderListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetQuery(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings SetVerbose(this AzureProviderListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderListSettings ResetVerbose(this AzureProviderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureProviderRegisterSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureProviderRegisterSettingsExtensions
    {
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetNamespace(this AzureProviderRegisterSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetNamespace(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Wait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Wait"/></em></p>
        ///   <p>Wait for the registration to finish.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetWait(this AzureProviderRegisterSettings toolSettings, string wait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = wait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Wait"/></em></p>
        ///   <p>Wait for the registration to finish.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetWait(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetSubscription(this AzureProviderRegisterSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetSubscription(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetDebug(this AzureProviderRegisterSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetDebug(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetHelp(this AzureProviderRegisterSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetHelp(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetOutput(this AzureProviderRegisterSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetOutput(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetQuery(this AzureProviderRegisterSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetQuery(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderRegisterSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings SetVerbose(this AzureProviderRegisterSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderRegisterSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderRegisterSettings ResetVerbose(this AzureProviderRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureProviderShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureProviderShowSettingsExtensions
    {
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetNamespace(this AzureProviderShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetNamespace(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Expand"/></em></p>
        ///   <p>The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetExpand(this AzureProviderShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Expand"/></em></p>
        ///   <p>The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetExpand(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetSubscription(this AzureProviderShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetSubscription(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetDebug(this AzureProviderShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetDebug(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetHelp(this AzureProviderShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetHelp(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetOutput(this AzureProviderShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetOutput(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetQuery(this AzureProviderShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetQuery(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings SetVerbose(this AzureProviderShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderShowSettings ResetVerbose(this AzureProviderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureProviderUnregisterSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureProviderUnregisterSettingsExtensions
    {
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetNamespace(this AzureProviderUnregisterSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetNamespace(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Wait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Wait"/></em></p>
        ///   <p>Wait for unregistration to finish.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetWait(this AzureProviderUnregisterSettings toolSettings, string wait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = wait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Wait"/></em></p>
        ///   <p>Wait for unregistration to finish.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetWait(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Wait = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetSubscription(this AzureProviderUnregisterSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetSubscription(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetDebug(this AzureProviderUnregisterSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetDebug(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetHelp(this AzureProviderUnregisterSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetHelp(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetOutput(this AzureProviderUnregisterSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetOutput(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetQuery(this AzureProviderUnregisterSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetQuery(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderUnregisterSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings SetVerbose(this AzureProviderUnregisterSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderUnregisterSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderUnregisterSettings ResetVerbose(this AzureProviderUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureProviderOperationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureProviderOperationListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings SetSubscription(this AzureProviderOperationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings ResetSubscription(this AzureProviderOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings SetDebug(this AzureProviderOperationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings ResetDebug(this AzureProviderOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings SetHelp(this AzureProviderOperationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings ResetHelp(this AzureProviderOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings SetOutput(this AzureProviderOperationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings ResetOutput(this AzureProviderOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings SetQuery(this AzureProviderOperationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings ResetQuery(this AzureProviderOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings SetVerbose(this AzureProviderOperationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationListSettings ResetVerbose(this AzureProviderOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureProviderOperationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureProviderTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureProviderOperationShowSettingsExtensions
    {
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetNamespace(this AzureProviderOperationShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetNamespace(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetSubscription(this AzureProviderOperationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetSubscription(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetDebug(this AzureProviderOperationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetDebug(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetHelp(this AzureProviderOperationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetHelp(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetOutput(this AzureProviderOperationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetOutput(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetQuery(this AzureProviderOperationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetQuery(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureProviderOperationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings SetVerbose(this AzureProviderOperationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureProviderOperationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureProviderOperationShowSettings ResetVerbose(this AzureProviderOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
