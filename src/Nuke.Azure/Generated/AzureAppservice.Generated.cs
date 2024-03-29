// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAppservice.json
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
    public static partial class AzureAppserviceTasks
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public static string AzureAppservicePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREAPPSERVICE_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureAppserviceLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage App Service plans.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppservice(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAppservicePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureAppserviceLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppserviceListLocations(AzureAppserviceListLocationsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppserviceListLocationsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppserviceListLocationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppserviceListLocationsSettings.Help"/></li>
        ///     <li><c>--linux-workers-enabled</c> via <see cref="AzureAppserviceListLocationsSettings.LinuxWorkersEnabled"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppserviceListLocationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppserviceListLocationsSettings.Query"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureAppserviceListLocationsSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppserviceListLocationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppserviceListLocationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppserviceListLocations(Configure<AzureAppserviceListLocationsSettings> configurator)
        {
            return AzureAppserviceListLocations(configurator(new AzureAppserviceListLocationsSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppserviceListLocationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppserviceListLocationsSettings.Help"/></li>
        ///     <li><c>--linux-workers-enabled</c> via <see cref="AzureAppserviceListLocationsSettings.LinuxWorkersEnabled"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppserviceListLocationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppserviceListLocationsSettings.Query"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureAppserviceListLocationsSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppserviceListLocationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppserviceListLocationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppserviceListLocationsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppserviceListLocations(CombinatorialConfigure<AzureAppserviceListLocationsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppserviceListLocations, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppservicePlanCreate(AzureAppservicePlanCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppservicePlanCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v</c> via <see cref="AzureAppservicePlanCreateSettings.HyperV"/></li>
        ///     <li><c>--is-linux</c> via <see cref="AzureAppservicePlanCreateSettings.IsLinux"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAppservicePlanCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanCreateSettings.Name"/></li>
        ///     <li><c>--number-of-workers</c> via <see cref="AzureAppservicePlanCreateSettings.NumberOfWorkers"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureAppservicePlanCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAppservicePlanCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppservicePlanCreate(Configure<AzureAppservicePlanCreateSettings> configurator)
        {
            return AzureAppservicePlanCreate(configurator(new AzureAppservicePlanCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanCreateSettings.Help"/></li>
        ///     <li><c>--hyper-v</c> via <see cref="AzureAppservicePlanCreateSettings.HyperV"/></li>
        ///     <li><c>--is-linux</c> via <see cref="AzureAppservicePlanCreateSettings.IsLinux"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAppservicePlanCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanCreateSettings.Name"/></li>
        ///     <li><c>--number-of-workers</c> via <see cref="AzureAppservicePlanCreateSettings.NumberOfWorkers"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureAppservicePlanCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAppservicePlanCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppservicePlanCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppservicePlanCreate(CombinatorialConfigure<AzureAppservicePlanCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppservicePlanCreate, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppservicePlanDelete(AzureAppservicePlanDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppservicePlanDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppservicePlanDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppservicePlanDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppservicePlanDelete(Configure<AzureAppservicePlanDeleteSettings> configurator)
        {
            return AzureAppservicePlanDelete(configurator(new AzureAppservicePlanDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppservicePlanDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAppservicePlanDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppservicePlanDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppservicePlanDelete(CombinatorialConfigure<AzureAppservicePlanDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppservicePlanDelete, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppservicePlanList(AzureAppservicePlanListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppservicePlanListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppservicePlanList(Configure<AzureAppservicePlanListSettings> configurator)
        {
            return AzureAppservicePlanList(configurator(new AzureAppservicePlanListSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppservicePlanListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppservicePlanList(CombinatorialConfigure<AzureAppservicePlanListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppservicePlanList, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppservicePlanShow(AzureAppservicePlanShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppservicePlanShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppservicePlanShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppservicePlanShow(Configure<AzureAppservicePlanShowSettings> configurator)
        {
            return AzureAppservicePlanShow(configurator(new AzureAppservicePlanShowSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppservicePlanShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppservicePlanShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppservicePlanShow(CombinatorialConfigure<AzureAppservicePlanShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppservicePlanShow, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppservicePlanUpdate(AzureAppservicePlanUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppservicePlanUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAppservicePlanUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAppservicePlanUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppservicePlanUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanUpdateSettings.Name"/></li>
        ///     <li><c>--number-of-workers</c> via <see cref="AzureAppservicePlanUpdateSettings.NumberOfWorkers"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAppservicePlanUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAppservicePlanUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureAppservicePlanUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppservicePlanUpdate(Configure<AzureAppservicePlanUpdateSettings> configurator)
        {
            return AzureAppservicePlanUpdate(configurator(new AzureAppservicePlanUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureAppservicePlanUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAppservicePlanUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureAppservicePlanUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppservicePlanUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureAppservicePlanUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAppservicePlanUpdateSettings.Name"/></li>
        ///     <li><c>--number-of-workers</c> via <see cref="AzureAppservicePlanUpdateSettings.NumberOfWorkers"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppservicePlanUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppservicePlanUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureAppservicePlanUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppservicePlanUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureAppservicePlanUpdateSettings.Set"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureAppservicePlanUpdateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppservicePlanUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppservicePlanUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppservicePlanUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppservicePlanUpdate(CombinatorialConfigure<AzureAppservicePlanUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppservicePlanUpdate, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppserviceHybridConnectionSetKey(AzureAppserviceHybridConnectionSetKeySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppserviceHybridConnectionSetKeySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Help"/></li>
        ///     <li><c>--hybrid-connection</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.HybridConnection"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.KeyType"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Output"/></li>
        ///     <li><c>--plan</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Plan"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppserviceHybridConnectionSetKey(Configure<AzureAppserviceHybridConnectionSetKeySettings> configurator)
        {
            return AzureAppserviceHybridConnectionSetKey(configurator(new AzureAppserviceHybridConnectionSetKeySettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Help"/></li>
        ///     <li><c>--hybrid-connection</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.HybridConnection"/></li>
        ///     <li><c>--key-type</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.KeyType"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Output"/></li>
        ///     <li><c>--plan</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Plan"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppserviceHybridConnectionSetKeySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppserviceHybridConnectionSetKeySettings Settings, IReadOnlyCollection<Output> Output)> AzureAppserviceHybridConnectionSetKey(CombinatorialConfigure<AzureAppserviceHybridConnectionSetKeySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppserviceHybridConnectionSetKey, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAppserviceVnetIntegrationList(AzureAppserviceVnetIntegrationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAppserviceVnetIntegrationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Output"/></li>
        ///     <li><c>--plan</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Plan"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAppserviceVnetIntegrationList(Configure<AzureAppserviceVnetIntegrationListSettings> configurator)
        {
            return AzureAppserviceVnetIntegrationList(configurator(new AzureAppserviceVnetIntegrationListSettings()));
        }
        /// <summary>
        ///   <p>Manage App Service plans.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Output"/></li>
        ///     <li><c>--plan</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Plan"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAppserviceVnetIntegrationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAppserviceVnetIntegrationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAppserviceVnetIntegrationList(CombinatorialConfigure<AzureAppserviceVnetIntegrationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAppserviceVnetIntegrationList, AzureAppserviceLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureAppserviceListLocationsSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppserviceListLocationsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
        /// <summary>
        ///   The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).
        /// </summary>
        public virtual AppserviceSku Sku { get; internal set; }
        /// <summary>
        ///   Get regions which support hosting web apps on Linux workers.
        /// </summary>
        public virtual string LinuxWorkersEnabled { get; internal set; }
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
              .Add("appservice list-locations")
              .Add("--sku {value}", Sku)
              .Add("--linux-workers-enabled {value}", LinuxWorkersEnabled)
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
    #region AzureAppservicePlanCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
        /// <summary>
        ///   Name of the new app service plan.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Host web app on Windows container.
        /// </summary>
        public virtual string HyperV { get; internal set; }
        /// <summary>
        ///   Host web app on Linux worker.
        /// </summary>
        public virtual string IsLinux { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Number of workers to be allocated.
        /// </summary>
        public virtual int? NumberOfWorkers { get; internal set; }
        /// <summary>
        ///   The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).
        /// </summary>
        public virtual AppserviceSku Sku { get; internal set; }
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
              .Add("appservice plan create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--hyper-v {value}", HyperV)
              .Add("--is-linux {value}", IsLinux)
              .Add("--location {value}", Location)
              .Add("--number-of-workers {value}", NumberOfWorkers)
              .Add("--sku {value}", Sku)
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
    #region AzureAppservicePlanDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
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
        ///   The name of the app service plan.
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
              .Add("appservice plan delete")
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
    #region AzureAppservicePlanListSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
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
              .Add("appservice plan list")
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
    #region AzureAppservicePlanShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the app service plan.
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
              .Add("appservice plan show")
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
    #region AzureAppservicePlanUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
        /// <summary>
        ///   Number of workers to be allocated.
        /// </summary>
        public virtual int? NumberOfWorkers { get; internal set; }
        /// <summary>
        ///   The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).
        /// </summary>
        public virtual AppserviceSku Sku { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the app service plan.
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
              .Add("appservice plan update")
              .Add("--number-of-workers {value}", NumberOfWorkers)
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
    #region AzureAppserviceHybridConnectionSetKeySettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppserviceHybridConnectionSetKeySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
        /// <summary>
        ///   Hybrid connection name.
        /// </summary>
        public virtual string HybridConnection { get; internal set; }
        /// <summary>
        ///   Which key (primary or secondary) should be used.
        /// </summary>
        public virtual string KeyType { get; internal set; }
        /// <summary>
        ///   Hybrid connection namespace.
        /// </summary>
        public virtual string Namespace { get; internal set; }
        /// <summary>
        ///   AppService plan.
        /// </summary>
        public virtual string Plan { get; internal set; }
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
              .Add("appservice hybrid-connection set-key")
              .Add("--hybrid-connection {value}", HybridConnection)
              .Add("--key-type {value}", KeyType)
              .Add("--namespace {value}", Namespace)
              .Add("--plan {value}", Plan)
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
    #region AzureAppserviceVnetIntegrationListSettings
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppserviceVnetIntegrationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAppservice executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        public override Action<OutputType, string> CustomLogger => AzureAppserviceTasks.AzureAppserviceLogger;
        /// <summary>
        ///   AppService plan.
        /// </summary>
        public virtual string Plan { get; internal set; }
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
              .Add("appservice vnet-integration list")
              .Add("--plan {value}", Plan)
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
    #region AzureAppserviceListLocationsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppserviceListLocationsSettingsExtensions
    {
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Sku"/></em></p>
        ///   <p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetSku(this AzureAppserviceListLocationsSettings toolSettings, AppserviceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Sku"/></em></p>
        ///   <p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetSku(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region LinuxWorkersEnabled
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.LinuxWorkersEnabled"/></em></p>
        ///   <p>Get regions which support hosting web apps on Linux workers.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetLinuxWorkersEnabled(this AzureAppserviceListLocationsSettings toolSettings, string linuxWorkersEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinuxWorkersEnabled = linuxWorkersEnabled;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.LinuxWorkersEnabled"/></em></p>
        ///   <p>Get regions which support hosting web apps on Linux workers.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetLinuxWorkersEnabled(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinuxWorkersEnabled = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetSubscription(this AzureAppserviceListLocationsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetSubscription(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetDebug(this AzureAppserviceListLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetDebug(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetHelp(this AzureAppserviceListLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetHelp(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetOutput(this AzureAppserviceListLocationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetOutput(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetQuery(this AzureAppserviceListLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetQuery(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetVerbose(this AzureAppserviceListLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetVerbose(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Name"/></em></p>
        ///   <p>Name of the new app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetName(this AzureAppservicePlanCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Name"/></em></p>
        ///   <p>Name of the new app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetName(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetResourceGroup(this AzureAppservicePlanCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetResourceGroup(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region HyperV
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.HyperV"/></em></p>
        ///   <p>Host web app on Windows container.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetHyperV(this AzureAppservicePlanCreateSettings toolSettings, string hyperV)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperV = hyperV;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.HyperV"/></em></p>
        ///   <p>Host web app on Windows container.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetHyperV(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HyperV = null;
            return toolSettings;
        }
        #endregion
        #region IsLinux
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.IsLinux"/></em></p>
        ///   <p>Host web app on Linux worker.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetIsLinux(this AzureAppservicePlanCreateSettings toolSettings, string isLinux)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsLinux = isLinux;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.IsLinux"/></em></p>
        ///   <p>Host web app on Linux worker.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetIsLinux(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsLinux = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetLocation(this AzureAppservicePlanCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetLocation(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NumberOfWorkers
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.NumberOfWorkers"/></em></p>
        ///   <p>Number of workers to be allocated.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetNumberOfWorkers(this AzureAppservicePlanCreateSettings toolSettings, int? numberOfWorkers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = numberOfWorkers;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.NumberOfWorkers"/></em></p>
        ///   <p>Number of workers to be allocated.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetNumberOfWorkers(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Sku"/></em></p>
        ///   <p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetSku(this AzureAppservicePlanCreateSettings toolSettings, AppserviceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Sku"/></em></p>
        ///   <p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetSku(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetTags(this AzureAppservicePlanCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetTags(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetSubscription(this AzureAppservicePlanCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetSubscription(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetDebug(this AzureAppservicePlanCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetDebug(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetHelp(this AzureAppservicePlanCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetHelp(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetOutput(this AzureAppservicePlanCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetOutput(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetQuery(this AzureAppservicePlanCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetQuery(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetVerbose(this AzureAppservicePlanCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetVerbose(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanDeleteSettingsExtensions
    {
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetYes(this AzureAppservicePlanDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetYes(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetIds(this AzureAppservicePlanDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetIds(this AzureAppservicePlanDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppservicePlanDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings AddIds(this AzureAppservicePlanDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppservicePlanDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings AddIds(this AzureAppservicePlanDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppservicePlanDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ClearIds(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppservicePlanDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings RemoveIds(this AzureAppservicePlanDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppservicePlanDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings RemoveIds(this AzureAppservicePlanDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Name"/></em></p>
        ///   <p>The name of the app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetName(this AzureAppservicePlanDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Name"/></em></p>
        ///   <p>The name of the app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetName(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetResourceGroup(this AzureAppservicePlanDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetResourceGroup(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetSubscription(this AzureAppservicePlanDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetSubscription(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetDebug(this AzureAppservicePlanDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetDebug(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetHelp(this AzureAppservicePlanDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetHelp(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetOutput(this AzureAppservicePlanDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetOutput(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetQuery(this AzureAppservicePlanDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetQuery(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetVerbose(this AzureAppservicePlanDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetVerbose(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetResourceGroup(this AzureAppservicePlanListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetResourceGroup(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetSubscription(this AzureAppservicePlanListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetSubscription(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetDebug(this AzureAppservicePlanListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetDebug(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetHelp(this AzureAppservicePlanListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetHelp(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetOutput(this AzureAppservicePlanListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetOutput(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetQuery(this AzureAppservicePlanListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetQuery(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetVerbose(this AzureAppservicePlanListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetVerbose(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetIds(this AzureAppservicePlanShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetIds(this AzureAppservicePlanShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppservicePlanShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings AddIds(this AzureAppservicePlanShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppservicePlanShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings AddIds(this AzureAppservicePlanShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppservicePlanShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ClearIds(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppservicePlanShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings RemoveIds(this AzureAppservicePlanShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppservicePlanShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings RemoveIds(this AzureAppservicePlanShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Name"/></em></p>
        ///   <p>The name of the app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetName(this AzureAppservicePlanShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Name"/></em></p>
        ///   <p>The name of the app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetName(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetResourceGroup(this AzureAppservicePlanShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetResourceGroup(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetSubscription(this AzureAppservicePlanShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetSubscription(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetDebug(this AzureAppservicePlanShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetDebug(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetHelp(this AzureAppservicePlanShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetHelp(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetOutput(this AzureAppservicePlanShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetOutput(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetQuery(this AzureAppservicePlanShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetQuery(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetVerbose(this AzureAppservicePlanShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetVerbose(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanUpdateSettingsExtensions
    {
        #region NumberOfWorkers
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.NumberOfWorkers"/></em></p>
        ///   <p>Number of workers to be allocated.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetNumberOfWorkers(this AzureAppservicePlanUpdateSettings toolSettings, int? numberOfWorkers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = numberOfWorkers;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.NumberOfWorkers"/></em></p>
        ///   <p>Number of workers to be allocated.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetNumberOfWorkers(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Sku"/></em></p>
        ///   <p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetSku(this AzureAppservicePlanUpdateSettings toolSettings, AppserviceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Sku"/></em></p>
        ///   <p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1V2(Premium V2 Small), PC2 (Premium Container Small), PC3 (Premium Container Medium), PC4 (Premium Container Large).</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetSku(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetIds(this AzureAppservicePlanUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetIds(this AzureAppservicePlanUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppservicePlanUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings AddIds(this AzureAppservicePlanUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAppservicePlanUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings AddIds(this AzureAppservicePlanUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAppservicePlanUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ClearIds(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppservicePlanUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings RemoveIds(this AzureAppservicePlanUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAppservicePlanUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings RemoveIds(this AzureAppservicePlanUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Name"/></em></p>
        ///   <p>The name of the app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetName(this AzureAppservicePlanUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Name"/></em></p>
        ///   <p>The name of the app service plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetName(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetResourceGroup(this AzureAppservicePlanUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetResourceGroup(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetSubscription(this AzureAppservicePlanUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetSubscription(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetAdd(this AzureAppservicePlanUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetAdd(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetForceString(this AzureAppservicePlanUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetForceString(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetRemove(this AzureAppservicePlanUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetRemove(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetSet(this AzureAppservicePlanUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetSet(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetDebug(this AzureAppservicePlanUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetDebug(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetHelp(this AzureAppservicePlanUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetHelp(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetOutput(this AzureAppservicePlanUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetOutput(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetQuery(this AzureAppservicePlanUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetQuery(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetVerbose(this AzureAppservicePlanUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetVerbose(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppserviceHybridConnectionSetKeySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppserviceHybridConnectionSetKeySettingsExtensions
    {
        #region HybridConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.HybridConnection"/></em></p>
        ///   <p>Hybrid connection name.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetHybridConnection(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string hybridConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnection = hybridConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.HybridConnection"/></em></p>
        ///   <p>Hybrid connection name.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetHybridConnection(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HybridConnection = null;
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.KeyType"/></em></p>
        ///   <p>Which key (primary or secondary) should be used.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetKeyType(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.KeyType"/></em></p>
        ///   <p>Which key (primary or secondary) should be used.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetKeyType(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Namespace"/></em></p>
        ///   <p>Hybrid connection namespace.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetNamespace(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Namespace"/></em></p>
        ///   <p>Hybrid connection namespace.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetNamespace(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Plan
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Plan"/></em></p>
        ///   <p>AppService plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetPlan(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string plan)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = plan;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Plan"/></em></p>
        ///   <p>AppService plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetPlan(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetResourceGroup(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetResourceGroup(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetSubscription(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetSubscription(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetDebug(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetDebug(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetHelp(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetHelp(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetOutput(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetOutput(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetQuery(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetQuery(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings SetVerbose(this AzureAppserviceHybridConnectionSetKeySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceHybridConnectionSetKeySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceHybridConnectionSetKeySettings ResetVerbose(this AzureAppserviceHybridConnectionSetKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppserviceVnetIntegrationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppserviceVnetIntegrationListSettingsExtensions
    {
        #region Plan
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Plan"/></em></p>
        ///   <p>AppService plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetPlan(this AzureAppserviceVnetIntegrationListSettings toolSettings, string plan)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = plan;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Plan"/></em></p>
        ///   <p>AppService plan.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetPlan(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetResourceGroup(this AzureAppserviceVnetIntegrationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetResourceGroup(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetSubscription(this AzureAppserviceVnetIntegrationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetSubscription(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetDebug(this AzureAppserviceVnetIntegrationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetDebug(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetHelp(this AzureAppserviceVnetIntegrationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetHelp(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetOutput(this AzureAppserviceVnetIntegrationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetOutput(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetQuery(this AzureAppserviceVnetIntegrationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetQuery(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAppserviceVnetIntegrationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings SetVerbose(this AzureAppserviceVnetIntegrationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAppserviceVnetIntegrationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAppserviceVnetIntegrationListSettings ResetVerbose(this AzureAppserviceVnetIntegrationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppserviceSku
    /// <summary>
    ///   Used within <see cref="AzureAppserviceTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppserviceSku>))]
    public partial class AppserviceSku : Enumeration
    {
        public static AppserviceSku b1 = new AppserviceSku { Value = "b1" };
        public static AppserviceSku b2 = new AppserviceSku { Value = "b2" };
        public static AppserviceSku b3 = new AppserviceSku { Value = "b3" };
        public static AppserviceSku d1 = new AppserviceSku { Value = "d1" };
        public static AppserviceSku f1 = new AppserviceSku { Value = "f1" };
        public static AppserviceSku free = new AppserviceSku { Value = "free" };
        public static AppserviceSku p1v2 = new AppserviceSku { Value = "p1v2" };
        public static AppserviceSku p2v2 = new AppserviceSku { Value = "p2v2" };
        public static AppserviceSku p3v2 = new AppserviceSku { Value = "p3v2" };
        public static AppserviceSku pc2 = new AppserviceSku { Value = "pc2" };
        public static AppserviceSku pc3 = new AppserviceSku { Value = "pc3" };
        public static AppserviceSku pc4 = new AppserviceSku { Value = "pc4" };
        public static AppserviceSku s1 = new AppserviceSku { Value = "s1" };
        public static AppserviceSku s2 = new AppserviceSku { Value = "s2" };
        public static AppserviceSku s3 = new AppserviceSku { Value = "s3" };
        public static AppserviceSku shared = new AppserviceSku { Value = "shared" };
    }
    #endregion
}
