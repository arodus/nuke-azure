// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureIotcentral.json
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
    public static partial class AzureIotcentralTasks
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public static string AzureIotcentralPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREIOTCENTRAL_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureIotcentralLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage IoT Central assets.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentral(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureIotcentralPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureIotcentralLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentral(AzureIotcentralSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIotcentralSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIotcentral(Configure<AzureIotcentralSettings> configurator)
        {
            return AzureIotcentral(configurator(new AzureIotcentralSettings()));
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIotcentralSettings Settings, IReadOnlyCollection<Output> Output)> AzureIotcentral(CombinatorialConfigure<AzureIotcentralSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIotcentral, AzureIotcentralLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentralAppCreate(AzureIotcentralAppCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIotcentralAppCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureIotcentralAppCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureIotcentralAppCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureIotcentralAppCreateSettings.Sku"/></li>
        ///     <li><c>--subdomain</c> via <see cref="AzureIotcentralAppCreateSettings.Subdomain"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppCreateSettings.Subscription"/></li>
        ///     <li><c>--template</c> via <see cref="AzureIotcentralAppCreateSettings.Template"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIotcentralAppCreate(Configure<AzureIotcentralAppCreateSettings> configurator)
        {
            return AzureIotcentralAppCreate(configurator(new AzureIotcentralAppCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppCreateSettings.Debug"/></li>
        ///     <li><c>--display-name</c> via <see cref="AzureIotcentralAppCreateSettings.DisplayName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureIotcentralAppCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureIotcentralAppCreateSettings.Sku"/></li>
        ///     <li><c>--subdomain</c> via <see cref="AzureIotcentralAppCreateSettings.Subdomain"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppCreateSettings.Subscription"/></li>
        ///     <li><c>--template</c> via <see cref="AzureIotcentralAppCreateSettings.Template"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIotcentralAppCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureIotcentralAppCreate(CombinatorialConfigure<AzureIotcentralAppCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIotcentralAppCreate, AzureIotcentralLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentralAppDelete(AzureIotcentralAppDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIotcentralAppDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIotcentralAppDelete(Configure<AzureIotcentralAppDeleteSettings> configurator)
        {
            return AzureIotcentralAppDelete(configurator(new AzureIotcentralAppDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIotcentralAppDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureIotcentralAppDelete(CombinatorialConfigure<AzureIotcentralAppDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIotcentralAppDelete, AzureIotcentralLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentralAppList(AzureIotcentralAppListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIotcentralAppListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIotcentralAppList(Configure<AzureIotcentralAppListSettings> configurator)
        {
            return AzureIotcentralAppList(configurator(new AzureIotcentralAppListSettings()));
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIotcentralAppListSettings Settings, IReadOnlyCollection<Output> Output)> AzureIotcentralAppList(CombinatorialConfigure<AzureIotcentralAppListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIotcentralAppList, AzureIotcentralLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentralAppShow(AzureIotcentralAppShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIotcentralAppShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIotcentralAppShow(Configure<AzureIotcentralAppShowSettings> configurator)
        {
            return AzureIotcentralAppShow(configurator(new AzureIotcentralAppShowSettings()));
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIotcentralAppShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureIotcentralAppShow(CombinatorialConfigure<AzureIotcentralAppShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIotcentralAppShow, AzureIotcentralLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIotcentralAppUpdate(AzureIotcentralAppUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIotcentralAppUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureIotcentralAppUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureIotcentralAppUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureIotcentralAppUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureIotcentralAppUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIotcentralAppUpdate(Configure<AzureIotcentralAppUpdateSettings> configurator)
        {
            return AzureIotcentralAppUpdate(configurator(new AzureIotcentralAppUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage IoT Central assets.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/iotcentral?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureIotcentralAppUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureIotcentralAppUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureIotcentralAppUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIotcentralAppUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIotcentralAppUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIotcentralAppUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIotcentralAppUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureIotcentralAppUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIotcentralAppUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureIotcentralAppUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIotcentralAppUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIotcentralAppUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIotcentralAppUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureIotcentralAppUpdate(CombinatorialConfigure<AzureIotcentralAppUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIotcentralAppUpdate, AzureIotcentralLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureIotcentralSettings
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotcentralSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIotcentralTasks.AzureIotcentralPath;
        public override Action<OutputType, string> CustomLogger => AzureIotcentralTasks.AzureIotcentralLogger;
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
              .Add("iotcentral")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureIotcentralAppCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotcentralAppCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIotcentralTasks.AzureIotcentralPath;
        public override Action<OutputType, string> CustomLogger => AzureIotcentralTasks.AzureIotcentralLogger;
        /// <summary>
        ///   IoT Central application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Subdomain for the IoT Central URL. Each application must have a unique subdomain.
        /// </summary>
        public virtual string Subdomain { get; internal set; }
        /// <summary>
        ///   Custom display name for the IoT Central application. Default is resource name.
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   Location of your IoT Central application. Default is the location of target resource group.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Pricing tier for IoT Central applications. Default value is S1.
        /// </summary>
        public virtual IotcentralAppCreateSku Sku { get; internal set; }
        /// <summary>
        ///   IoT Central application template name. Default is a custom application.
        /// </summary>
        public virtual string Template { get; internal set; }
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
              .Add("iotcentral app create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subdomain {value}", Subdomain)
              .Add("--display-name {value}", DisplayName)
              .Add("--location {value}", Location)
              .Add("--sku {value}", Sku)
              .Add("--template {value}", Template)
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
    #region AzureIotcentralAppDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotcentralAppDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIotcentralTasks.AzureIotcentralPath;
        public override Action<OutputType, string> CustomLogger => AzureIotcentralTasks.AzureIotcentralLogger;
        /// <summary>
        ///   IoT Central application name.
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
              .Add("iotcentral app delete")
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
    #region AzureIotcentralAppListSettings
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotcentralAppListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIotcentralTasks.AzureIotcentralPath;
        public override Action<OutputType, string> CustomLogger => AzureIotcentralTasks.AzureIotcentralLogger;
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
              .Add("iotcentral app list")
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
    #region AzureIotcentralAppShowSettings
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotcentralAppShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIotcentralTasks.AzureIotcentralPath;
        public override Action<OutputType, string> CustomLogger => AzureIotcentralTasks.AzureIotcentralLogger;
        /// <summary>
        ///   IoT Central application name.
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
              .Add("iotcentral app show")
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
    #region AzureIotcentralAppUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIotcentralAppUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIotcentral executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIotcentralTasks.AzureIotcentralPath;
        public override Action<OutputType, string> CustomLogger => AzureIotcentralTasks.AzureIotcentralLogger;
        /// <summary>
        ///   IoT Central application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("iotcentral app update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureIotcentralSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotcentralSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings SetDebug(this AzureIotcentralSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings ResetDebug(this AzureIotcentralSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings SetHelp(this AzureIotcentralSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings ResetHelp(this AzureIotcentralSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings SetOutput(this AzureIotcentralSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings ResetOutput(this AzureIotcentralSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings SetQuery(this AzureIotcentralSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings ResetQuery(this AzureIotcentralSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings SetVerbose(this AzureIotcentralSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralSettings ResetVerbose(this AzureIotcentralSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotcentralAppCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotcentralAppCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetName(this AzureIotcentralAppCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetName(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetResourceGroup(this AzureIotcentralAppCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetResourceGroup(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subdomain
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Subdomain"/></em></p>
        ///   <p>Subdomain for the IoT Central URL. Each application must have a unique subdomain.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetSubdomain(this AzureIotcentralAppCreateSettings toolSettings, string subdomain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subdomain = subdomain;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Subdomain"/></em></p>
        ///   <p>Subdomain for the IoT Central URL. Each application must have a unique subdomain.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetSubdomain(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subdomain = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.DisplayName"/></em></p>
        ///   <p>Custom display name for the IoT Central application. Default is resource name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetDisplayName(this AzureIotcentralAppCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.DisplayName"/></em></p>
        ///   <p>Custom display name for the IoT Central application. Default is resource name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetDisplayName(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Location"/></em></p>
        ///   <p>Location of your IoT Central application. Default is the location of target resource group.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetLocation(this AzureIotcentralAppCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Location"/></em></p>
        ///   <p>Location of your IoT Central application. Default is the location of target resource group.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetLocation(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Sku"/></em></p>
        ///   <p>Pricing tier for IoT Central applications. Default value is S1.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetSku(this AzureIotcentralAppCreateSettings toolSettings, IotcentralAppCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Sku"/></em></p>
        ///   <p>Pricing tier for IoT Central applications. Default value is S1.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetSku(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Template
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Template"/></em></p>
        ///   <p>IoT Central application template name. Default is a custom application.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetTemplate(this AzureIotcentralAppCreateSettings toolSettings, string template)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Template = template;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Template"/></em></p>
        ///   <p>IoT Central application template name. Default is a custom application.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetTemplate(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Template = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetSubscription(this AzureIotcentralAppCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetSubscription(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetDebug(this AzureIotcentralAppCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetDebug(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetHelp(this AzureIotcentralAppCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetHelp(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetOutput(this AzureIotcentralAppCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetOutput(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetQuery(this AzureIotcentralAppCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetQuery(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings SetVerbose(this AzureIotcentralAppCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppCreateSettings ResetVerbose(this AzureIotcentralAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotcentralAppDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotcentralAppDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetName(this AzureIotcentralAppDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetName(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetResourceGroup(this AzureIotcentralAppDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetResourceGroup(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetSubscription(this AzureIotcentralAppDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetSubscription(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetDebug(this AzureIotcentralAppDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetDebug(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetHelp(this AzureIotcentralAppDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetHelp(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetOutput(this AzureIotcentralAppDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetOutput(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetQuery(this AzureIotcentralAppDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetQuery(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings SetVerbose(this AzureIotcentralAppDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppDeleteSettings ResetVerbose(this AzureIotcentralAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotcentralAppListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotcentralAppListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetResourceGroup(this AzureIotcentralAppListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetResourceGroup(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetSubscription(this AzureIotcentralAppListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetSubscription(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetDebug(this AzureIotcentralAppListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetDebug(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetHelp(this AzureIotcentralAppListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetHelp(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetOutput(this AzureIotcentralAppListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetOutput(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetQuery(this AzureIotcentralAppListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetQuery(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings SetVerbose(this AzureIotcentralAppListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppListSettings ResetVerbose(this AzureIotcentralAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotcentralAppShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotcentralAppShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetName(this AzureIotcentralAppShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetName(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetResourceGroup(this AzureIotcentralAppShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetResourceGroup(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetSubscription(this AzureIotcentralAppShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetSubscription(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetDebug(this AzureIotcentralAppShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetDebug(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetHelp(this AzureIotcentralAppShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetHelp(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetOutput(this AzureIotcentralAppShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetOutput(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetQuery(this AzureIotcentralAppShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetQuery(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings SetVerbose(this AzureIotcentralAppShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppShowSettings ResetVerbose(this AzureIotcentralAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIotcentralAppUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIotcentralAppUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetName(this AzureIotcentralAppUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Name"/></em></p>
        ///   <p>IoT Central application name.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetName(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetResourceGroup(this AzureIotcentralAppUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetResourceGroup(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetAdd(this AzureIotcentralAppUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetAdd(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetForceString(this AzureIotcentralAppUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetForceString(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetRemove(this AzureIotcentralAppUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetRemove(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetSet(this AzureIotcentralAppUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetSet(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetSubscription(this AzureIotcentralAppUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetSubscription(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetDebug(this AzureIotcentralAppUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetDebug(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetHelp(this AzureIotcentralAppUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetHelp(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetOutput(this AzureIotcentralAppUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetOutput(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetQuery(this AzureIotcentralAppUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetQuery(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIotcentralAppUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings SetVerbose(this AzureIotcentralAppUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIotcentralAppUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIotcentralAppUpdateSettings ResetVerbose(this AzureIotcentralAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region IotcentralAppCreateSku
    /// <summary>
    ///   Used within <see cref="AzureIotcentralTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<IotcentralAppCreateSku>))]
    public partial class IotcentralAppCreateSku : Enumeration
    {
        public static IotcentralAppCreateSku f1 = new IotcentralAppCreateSku { Value = "f1" };
        public static IotcentralAppCreateSku s1 = new IotcentralAppCreateSku { Value = "s1" };
    }
    #endregion
}
