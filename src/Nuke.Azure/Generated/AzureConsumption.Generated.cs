// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureConsumption.json
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
    public static partial class AzureConsumptionTasks
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public static string AzureConsumptionPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURECONSUMPTION_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureConsumptionLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage consumption of Azure resources.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumption(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureConsumptionPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureConsumptionLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumption(AzureConsumptionSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumption(Configure<AzureConsumptionSettings> configurator)
        {
            return AzureConsumption(configurator(new AzureConsumptionSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumption(CombinatorialConfigure<AzureConsumptionSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumption, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetCreate(AzureConsumptionBudgetCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionBudgetCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--amount</c> via <see cref="AzureConsumptionBudgetCreateSettings.Amount"/></li>
        ///     <li><c>--budget-name</c> via <see cref="AzureConsumptionBudgetCreateSettings.BudgetName"/></li>
        ///     <li><c>--category</c> via <see cref="AzureConsumptionBudgetCreateSettings.Category"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetCreateSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionBudgetCreateSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetCreateSettings.Help"/></li>
        ///     <li><c>--meter-filter</c> via <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetCreateSettings.Query"/></li>
        ///     <li><c>--resource-filter</c> via <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-group-filter</c> via <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionBudgetCreateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetCreateSettings.Subscription"/></li>
        ///     <li><c>--time-grain</c> via <see cref="AzureConsumptionBudgetCreateSettings.TimeGrain"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetCreate(Configure<AzureConsumptionBudgetCreateSettings> configurator)
        {
            return AzureConsumptionBudgetCreate(configurator(new AzureConsumptionBudgetCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--amount</c> via <see cref="AzureConsumptionBudgetCreateSettings.Amount"/></li>
        ///     <li><c>--budget-name</c> via <see cref="AzureConsumptionBudgetCreateSettings.BudgetName"/></li>
        ///     <li><c>--category</c> via <see cref="AzureConsumptionBudgetCreateSettings.Category"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetCreateSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionBudgetCreateSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetCreateSettings.Help"/></li>
        ///     <li><c>--meter-filter</c> via <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetCreateSettings.Query"/></li>
        ///     <li><c>--resource-filter</c> via <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--resource-group-filter</c> via <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionBudgetCreateSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetCreateSettings.Subscription"/></li>
        ///     <li><c>--time-grain</c> via <see cref="AzureConsumptionBudgetCreateSettings.TimeGrain"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionBudgetCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionBudgetCreate(CombinatorialConfigure<AzureConsumptionBudgetCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionBudgetCreate, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetDelete(AzureConsumptionBudgetDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionBudgetDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--budget-name</c> via <see cref="AzureConsumptionBudgetDeleteSettings.BudgetName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetDelete(Configure<AzureConsumptionBudgetDeleteSettings> configurator)
        {
            return AzureConsumptionBudgetDelete(configurator(new AzureConsumptionBudgetDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--budget-name</c> via <see cref="AzureConsumptionBudgetDeleteSettings.BudgetName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionBudgetDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionBudgetDelete(CombinatorialConfigure<AzureConsumptionBudgetDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionBudgetDelete, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetList(AzureConsumptionBudgetListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionBudgetListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetList(Configure<AzureConsumptionBudgetListSettings> configurator)
        {
            return AzureConsumptionBudgetList(configurator(new AzureConsumptionBudgetListSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionBudgetListSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionBudgetList(CombinatorialConfigure<AzureConsumptionBudgetListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionBudgetList, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetShow(AzureConsumptionBudgetShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionBudgetShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--budget-name</c> via <see cref="AzureConsumptionBudgetShowSettings.BudgetName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetShow(Configure<AzureConsumptionBudgetShowSettings> configurator)
        {
            return AzureConsumptionBudgetShow(configurator(new AzureConsumptionBudgetShowSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--budget-name</c> via <see cref="AzureConsumptionBudgetShowSettings.BudgetName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionBudgetShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionBudgetShowSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionBudgetShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionBudgetShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureConsumptionBudgetShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionBudgetShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionBudgetShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionBudgetShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionBudgetShow(CombinatorialConfigure<AzureConsumptionBudgetShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionBudgetShow, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionMarketplaceList(AzureConsumptionMarketplaceListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionMarketplaceListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--billing-period-name</c> via <see cref="AzureConsumptionMarketplaceListSettings.BillingPeriodName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionMarketplaceListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionMarketplaceListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionMarketplaceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionMarketplaceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionMarketplaceListSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionMarketplaceListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionMarketplaceListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureConsumptionMarketplaceListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionMarketplaceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionMarketplaceList(Configure<AzureConsumptionMarketplaceListSettings> configurator)
        {
            return AzureConsumptionMarketplaceList(configurator(new AzureConsumptionMarketplaceListSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--billing-period-name</c> via <see cref="AzureConsumptionMarketplaceListSettings.BillingPeriodName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionMarketplaceListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionMarketplaceListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionMarketplaceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionMarketplaceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionMarketplaceListSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionMarketplaceListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionMarketplaceListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureConsumptionMarketplaceListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionMarketplaceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionMarketplaceListSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionMarketplaceList(CombinatorialConfigure<AzureConsumptionMarketplaceListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionMarketplaceList, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionPricesheetShow(AzureConsumptionPricesheetShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionPricesheetShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--billing-period-name</c> via <see cref="AzureConsumptionPricesheetShowSettings.BillingPeriodName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionPricesheetShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionPricesheetShowSettings.Help"/></li>
        ///     <li><c>--include-meter-details</c> via <see cref="AzureConsumptionPricesheetShowSettings.IncludeMeterDetails"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionPricesheetShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionPricesheetShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionPricesheetShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionPricesheetShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionPricesheetShow(Configure<AzureConsumptionPricesheetShowSettings> configurator)
        {
            return AzureConsumptionPricesheetShow(configurator(new AzureConsumptionPricesheetShowSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--billing-period-name</c> via <see cref="AzureConsumptionPricesheetShowSettings.BillingPeriodName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionPricesheetShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionPricesheetShowSettings.Help"/></li>
        ///     <li><c>--include-meter-details</c> via <see cref="AzureConsumptionPricesheetShowSettings.IncludeMeterDetails"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionPricesheetShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionPricesheetShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionPricesheetShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionPricesheetShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionPricesheetShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionPricesheetShow(CombinatorialConfigure<AzureConsumptionPricesheetShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionPricesheetShow, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionReservation(AzureConsumptionReservationSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionReservationSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionReservationSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionReservationSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionReservationSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionReservationSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionReservationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionReservation(Configure<AzureConsumptionReservationSettings> configurator)
        {
            return AzureConsumptionReservation(configurator(new AzureConsumptionReservationSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionReservationSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionReservationSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionReservationSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionReservationSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionReservationSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionReservationSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionReservation(CombinatorialConfigure<AzureConsumptionReservationSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionReservation, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionUsageList(AzureConsumptionUsageListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionUsageListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--billing-period-name</c> via <see cref="AzureConsumptionUsageListSettings.BillingPeriodName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionUsageListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionUsageListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionUsageListSettings.Help"/></li>
        ///     <li><c>--include-additional-properties</c> via <see cref="AzureConsumptionUsageListSettings.IncludeAdditionalProperties"/></li>
        ///     <li><c>--include-meter-details</c> via <see cref="AzureConsumptionUsageListSettings.IncludeMeterDetails"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionUsageListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionUsageListSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionUsageListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionUsageListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureConsumptionUsageListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionUsageListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionUsageList(Configure<AzureConsumptionUsageListSettings> configurator)
        {
            return AzureConsumptionUsageList(configurator(new AzureConsumptionUsageListSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--billing-period-name</c> via <see cref="AzureConsumptionUsageListSettings.BillingPeriodName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionUsageListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionUsageListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionUsageListSettings.Help"/></li>
        ///     <li><c>--include-additional-properties</c> via <see cref="AzureConsumptionUsageListSettings.IncludeAdditionalProperties"/></li>
        ///     <li><c>--include-meter-details</c> via <see cref="AzureConsumptionUsageListSettings.IncludeMeterDetails"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionUsageListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionUsageListSettings.Query"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionUsageListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionUsageListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureConsumptionUsageListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionUsageListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionUsageListSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionUsageList(CombinatorialConfigure<AzureConsumptionUsageListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionUsageList, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionReservationDetailList(AzureConsumptionReservationDetailListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionReservationDetailListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionReservationDetailListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionReservationDetailListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionReservationDetailListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionReservationDetailListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionReservationDetailListSettings.Query"/></li>
        ///     <li><c>--reservation-id</c> via <see cref="AzureConsumptionReservationDetailListSettings.ReservationId"/></li>
        ///     <li><c>--reservation-order-id</c> via <see cref="AzureConsumptionReservationDetailListSettings.ReservationOrderId"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionReservationDetailListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionReservationDetailListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionReservationDetailListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionReservationDetailList(Configure<AzureConsumptionReservationDetailListSettings> configurator)
        {
            return AzureConsumptionReservationDetailList(configurator(new AzureConsumptionReservationDetailListSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionReservationDetailListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionReservationDetailListSettings.EndDate"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionReservationDetailListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionReservationDetailListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionReservationDetailListSettings.Query"/></li>
        ///     <li><c>--reservation-id</c> via <see cref="AzureConsumptionReservationDetailListSettings.ReservationId"/></li>
        ///     <li><c>--reservation-order-id</c> via <see cref="AzureConsumptionReservationDetailListSettings.ReservationOrderId"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionReservationDetailListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionReservationDetailListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionReservationDetailListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionReservationDetailListSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionReservationDetailList(CombinatorialConfigure<AzureConsumptionReservationDetailListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionReservationDetailList, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureConsumptionReservationSummaryList(AzureConsumptionReservationSummaryListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureConsumptionReservationSummaryListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionReservationSummaryListSettings.EndDate"/></li>
        ///     <li><c>--grain</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Grain"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Query"/></li>
        ///     <li><c>--reservation-id</c> via <see cref="AzureConsumptionReservationSummaryListSettings.ReservationId"/></li>
        ///     <li><c>--reservation-order-id</c> via <see cref="AzureConsumptionReservationSummaryListSettings.ReservationOrderId"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionReservationSummaryListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureConsumptionReservationSummaryList(Configure<AzureConsumptionReservationSummaryListSettings> configurator)
        {
            return AzureConsumptionReservationSummaryList(configurator(new AzureConsumptionReservationSummaryListSettings()));
        }
        /// <summary>
        ///   <p>Manage consumption of Azure resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Debug"/></li>
        ///     <li><c>--end-date</c> via <see cref="AzureConsumptionReservationSummaryListSettings.EndDate"/></li>
        ///     <li><c>--grain</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Grain"/></li>
        ///     <li><c>--help</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Query"/></li>
        ///     <li><c>--reservation-id</c> via <see cref="AzureConsumptionReservationSummaryListSettings.ReservationId"/></li>
        ///     <li><c>--reservation-order-id</c> via <see cref="AzureConsumptionReservationSummaryListSettings.ReservationOrderId"/></li>
        ///     <li><c>--start-date</c> via <see cref="AzureConsumptionReservationSummaryListSettings.StartDate"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureConsumptionReservationSummaryListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureConsumptionReservationSummaryListSettings Settings, IReadOnlyCollection<Output> Output)> AzureConsumptionReservationSummaryList(CombinatorialConfigure<AzureConsumptionReservationSummaryListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureConsumptionReservationSummaryList, AzureConsumptionLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureConsumptionSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
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
              .Add("consumption")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureConsumptionBudgetCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Amount of a budget.
        /// </summary>
        public virtual string Amount { get; internal set; }
        /// <summary>
        ///   Name of a budget.
        /// </summary>
        public virtual string BudgetName { get; internal set; }
        /// <summary>
        ///   Category of the budget can be cost or usage.
        /// </summary>
        public virtual ConsumptionBudgetCreateCategory Category { get; internal set; }
        /// <summary>
        ///   End date (YYYY-MM-DD in UTC) of time period of a budget.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Start date (YYYY-MM-DD in UTC) of time period of a budget.
        /// </summary>
        public virtual string StartDate { get; internal set; }
        /// <summary>
        ///   Time grain of the budget can be monthly, quarterly, or annually.
        /// </summary>
        public virtual ConsumptionBudgetCreateTimeGrain TimeGrain { get; internal set; }
        /// <summary>
        ///   Space-separated list of meters to filter on. Required if category is usage.
        /// </summary>
        public virtual IReadOnlyList<string> MeterFilter => MeterFilterInternal.AsReadOnly();
        internal List<string> MeterFilterInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Space-separated list of resource instances to filter on.
        /// </summary>
        public virtual IReadOnlyList<string> ResourceFilter => ResourceFilterInternal.AsReadOnly();
        internal List<string> ResourceFilterInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Space-separated list of resource groups to filter on.
        /// </summary>
        public virtual IReadOnlyList<string> ResourceGroupFilter => ResourceGroupFilterInternal.AsReadOnly();
        internal List<string> ResourceGroupFilterInternal { get; set; } = new List<string>();
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
              .Add("consumption budget create")
              .Add("--amount {value}", Amount)
              .Add("--budget-name {value}", BudgetName)
              .Add("--category {value}", Category)
              .Add("--end-date {value}", EndDate)
              .Add("--start-date {value}", StartDate)
              .Add("--time-grain {value}", TimeGrain)
              .Add("--meter-filter {value}", MeterFilter, separator: ' ')
              .Add("--resource-filter {value}", ResourceFilter, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-group-filter {value}", ResourceGroupFilter, separator: ' ')
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
    #region AzureConsumptionBudgetDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Name of a budget.
        /// </summary>
        public virtual string BudgetName { get; internal set; }
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
              .Add("consumption budget delete")
              .Add("--budget-name {value}", BudgetName)
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
    #region AzureConsumptionBudgetListSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
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
              .Add("consumption budget list")
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
    #region AzureConsumptionBudgetShowSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Name of a budget.
        /// </summary>
        public virtual string BudgetName { get; internal set; }
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
              .Add("consumption budget show")
              .Add("--budget-name {value}", BudgetName)
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
    #region AzureConsumptionMarketplaceListSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionMarketplaceListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Name of the billing period to get the marketplace.
        /// </summary>
        public virtual string BillingPeriodName { get; internal set; }
        /// <summary>
        ///   End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.
        /// </summary>
        public virtual string StartDate { get; internal set; }
        /// <summary>
        ///   Maximum number of items to return. Value range: 1-1000.
        /// </summary>
        public virtual int? Top { get; internal set; }
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
              .Add("consumption marketplace list")
              .Add("--billing-period-name {value}", BillingPeriodName)
              .Add("--end-date {value}", EndDate)
              .Add("--start-date {value}", StartDate)
              .Add("--top {value}", Top)
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
    #region AzureConsumptionPricesheetShowSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionPricesheetShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Name of the billing period to get the price sheet.
        /// </summary>
        public virtual string BillingPeriodName { get; internal set; }
        /// <summary>
        ///   Include meter details in the price sheet.
        /// </summary>
        public virtual string IncludeMeterDetails { get; internal set; }
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
              .Add("consumption pricesheet show")
              .Add("--billing-period-name {value}", BillingPeriodName)
              .Add("--include-meter-details {value}", IncludeMeterDetails)
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
    #region AzureConsumptionReservationSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionReservationSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
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
              .Add("consumption reservation")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureConsumptionUsageListSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionUsageListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Name of the billing period to get the usage details that associate with.
        /// </summary>
        public virtual string BillingPeriodName { get; internal set; }
        /// <summary>
        ///   End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Include additional properties in the usages.
        /// </summary>
        public virtual string IncludeAdditionalProperties { get; internal set; }
        /// <summary>
        ///   Include meter details in the usages.
        /// </summary>
        public virtual string IncludeMeterDetails { get; internal set; }
        /// <summary>
        ///   Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.
        /// </summary>
        public virtual string StartDate { get; internal set; }
        /// <summary>
        ///   Maximum number of items to return. Value range: 1-1000.
        /// </summary>
        public virtual int? Top { get; internal set; }
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
              .Add("consumption usage list")
              .Add("--billing-period-name {value}", BillingPeriodName)
              .Add("--end-date {value}", EndDate)
              .Add("--include-additional-properties {value}", IncludeAdditionalProperties)
              .Add("--include-meter-details {value}", IncludeMeterDetails)
              .Add("--start-date {value}", StartDate)
              .Add("--top {value}", Top)
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
    #region AzureConsumptionReservationDetailListSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionReservationDetailListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Reservation order id.
        /// </summary>
        public virtual string ReservationOrderId { get; internal set; }
        /// <summary>
        ///   Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.
        /// </summary>
        public virtual string StartDate { get; internal set; }
        /// <summary>
        ///   Reservation id.
        /// </summary>
        public virtual string ReservationId { get; internal set; }
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
              .Add("consumption reservation detail list")
              .Add("--end-date {value}", EndDate)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--start-date {value}", StartDate)
              .Add("--reservation-id {value}", ReservationId)
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
    #region AzureConsumptionReservationSummaryListSettings
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionReservationSummaryListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureConsumption executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        public override Action<OutputType, string> CustomLogger => AzureConsumptionTasks.AzureConsumptionLogger;
        /// <summary>
        ///   Reservation summary grain. Possible values are daily or monthly.
        /// </summary>
        public virtual string Grain { get; internal set; }
        /// <summary>
        ///   Reservation order id.
        /// </summary>
        public virtual string ReservationOrderId { get; internal set; }
        /// <summary>
        ///   End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.
        /// </summary>
        public virtual string EndDate { get; internal set; }
        /// <summary>
        ///   Reservation id.
        /// </summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary>
        ///   Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.
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
              .Add("consumption reservation summary list")
              .Add("--grain {value}", Grain)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--end-date {value}", EndDate)
              .Add("--reservation-id {value}", ReservationId)
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
    #region AzureConsumptionSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings SetDebug(this AzureConsumptionSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings ResetDebug(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings SetHelp(this AzureConsumptionSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings ResetHelp(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings SetOutput(this AzureConsumptionSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings ResetOutput(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings SetQuery(this AzureConsumptionSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings ResetQuery(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings SetVerbose(this AzureConsumptionSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionSettings ResetVerbose(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionBudgetCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetCreateSettingsExtensions
    {
        #region Amount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Amount"/></em></p>
        ///   <p>Amount of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetAmount(this AzureConsumptionBudgetCreateSettings toolSettings, string amount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Amount = amount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Amount"/></em></p>
        ///   <p>Amount of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetAmount(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Amount = null;
            return toolSettings;
        }
        #endregion
        #region BudgetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.BudgetName"/></em></p>
        ///   <p>Name of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetBudgetName(this AzureConsumptionBudgetCreateSettings toolSettings, string budgetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = budgetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.BudgetName"/></em></p>
        ///   <p>Name of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetBudgetName(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = null;
            return toolSettings;
        }
        #endregion
        #region Category
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Category"/></em></p>
        ///   <p>Category of the budget can be cost or usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetCategory(this AzureConsumptionBudgetCreateSettings toolSettings, ConsumptionBudgetCreateCategory category)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Category = category;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Category"/></em></p>
        ///   <p>Category of the budget can be cost or usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetCategory(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Category = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC) of time period of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetEndDate(this AzureConsumptionBudgetCreateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC) of time period of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetEndDate(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC) of time period of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetStartDate(this AzureConsumptionBudgetCreateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC) of time period of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetStartDate(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region TimeGrain
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.TimeGrain"/></em></p>
        ///   <p>Time grain of the budget can be monthly, quarterly, or annually.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetTimeGrain(this AzureConsumptionBudgetCreateSettings toolSettings, ConsumptionBudgetCreateTimeGrain timeGrain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TimeGrain = timeGrain;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.TimeGrain"/></em></p>
        ///   <p>Time grain of the budget can be monthly, quarterly, or annually.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetTimeGrain(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TimeGrain = null;
            return toolSettings;
        }
        #endregion
        #region MeterFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/> to a new list</em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal = meterFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/> to a new list</em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal = meterFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal.AddRange(meterFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal.AddRange(meterFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ClearMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(meterFilter);
            toolSettings.MeterFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/></em></p>
        ///   <p>Space-separated list of meters to filter on. Required if category is usage.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(meterFilter);
            toolSettings.MeterFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/> to a new list</em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal = resourceFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/> to a new list</em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal = resourceFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal.AddRange(resourceFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal.AddRange(resourceFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ClearResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(resourceFilter);
            toolSettings.ResourceFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/></em></p>
        ///   <p>Space-separated list of resource instances to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(resourceFilter);
            toolSettings.ResourceFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceGroup(this AzureConsumptionBudgetCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetResourceGroup(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/> to a new list</em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal = resourceGroupFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/> to a new list</em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal = resourceGroupFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal.AddRange(resourceGroupFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal.AddRange(resourceGroupFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ClearResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(resourceGroupFilter);
            toolSettings.ResourceGroupFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/></em></p>
        ///   <p>Space-separated list of resource groups to filter on.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(resourceGroupFilter);
            toolSettings.ResourceGroupFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetSubscription(this AzureConsumptionBudgetCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetSubscription(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetDebug(this AzureConsumptionBudgetCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetDebug(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetHelp(this AzureConsumptionBudgetCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetHelp(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetOutput(this AzureConsumptionBudgetCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetOutput(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetQuery(this AzureConsumptionBudgetCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetQuery(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetVerbose(this AzureConsumptionBudgetCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetVerbose(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionBudgetDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetDeleteSettingsExtensions
    {
        #region BudgetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.BudgetName"/></em></p>
        ///   <p>Name of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetBudgetName(this AzureConsumptionBudgetDeleteSettings toolSettings, string budgetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = budgetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.BudgetName"/></em></p>
        ///   <p>Name of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetBudgetName(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetResourceGroup(this AzureConsumptionBudgetDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetResourceGroup(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetSubscription(this AzureConsumptionBudgetDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetSubscription(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetDebug(this AzureConsumptionBudgetDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetDebug(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetHelp(this AzureConsumptionBudgetDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetHelp(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetOutput(this AzureConsumptionBudgetDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetOutput(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetQuery(this AzureConsumptionBudgetDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetQuery(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetVerbose(this AzureConsumptionBudgetDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetVerbose(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionBudgetListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetResourceGroup(this AzureConsumptionBudgetListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetResourceGroup(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetSubscription(this AzureConsumptionBudgetListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetSubscription(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetDebug(this AzureConsumptionBudgetListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetDebug(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetHelp(this AzureConsumptionBudgetListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetHelp(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetOutput(this AzureConsumptionBudgetListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetOutput(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetQuery(this AzureConsumptionBudgetListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetQuery(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetVerbose(this AzureConsumptionBudgetListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetVerbose(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionBudgetShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetShowSettingsExtensions
    {
        #region BudgetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.BudgetName"/></em></p>
        ///   <p>Name of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetBudgetName(this AzureConsumptionBudgetShowSettings toolSettings, string budgetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = budgetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.BudgetName"/></em></p>
        ///   <p>Name of a budget.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetBudgetName(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetResourceGroup(this AzureConsumptionBudgetShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetResourceGroup(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetSubscription(this AzureConsumptionBudgetShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetSubscription(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetDebug(this AzureConsumptionBudgetShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetDebug(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetHelp(this AzureConsumptionBudgetShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetHelp(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetOutput(this AzureConsumptionBudgetShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetOutput(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetQuery(this AzureConsumptionBudgetShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetQuery(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetVerbose(this AzureConsumptionBudgetShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetVerbose(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionMarketplaceListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionMarketplaceListSettingsExtensions
    {
        #region BillingPeriodName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.BillingPeriodName"/></em></p>
        ///   <p>Name of the billing period to get the marketplace.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetBillingPeriodName(this AzureConsumptionMarketplaceListSettings toolSettings, string billingPeriodName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = billingPeriodName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.BillingPeriodName"/></em></p>
        ///   <p>Name of the billing period to get the marketplace.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetBillingPeriodName(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetEndDate(this AzureConsumptionMarketplaceListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetEndDate(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetStartDate(this AzureConsumptionMarketplaceListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetStartDate(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Value range: 1-1000.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetTop(this AzureConsumptionMarketplaceListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Value range: 1-1000.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetTop(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetSubscription(this AzureConsumptionMarketplaceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetSubscription(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetDebug(this AzureConsumptionMarketplaceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetDebug(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetHelp(this AzureConsumptionMarketplaceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetHelp(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetOutput(this AzureConsumptionMarketplaceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetOutput(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetQuery(this AzureConsumptionMarketplaceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetQuery(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetVerbose(this AzureConsumptionMarketplaceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetVerbose(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionPricesheetShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionPricesheetShowSettingsExtensions
    {
        #region BillingPeriodName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.BillingPeriodName"/></em></p>
        ///   <p>Name of the billing period to get the price sheet.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetBillingPeriodName(this AzureConsumptionPricesheetShowSettings toolSettings, string billingPeriodName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = billingPeriodName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.BillingPeriodName"/></em></p>
        ///   <p>Name of the billing period to get the price sheet.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetBillingPeriodName(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = null;
            return toolSettings;
        }
        #endregion
        #region IncludeMeterDetails
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.IncludeMeterDetails"/></em></p>
        ///   <p>Include meter details in the price sheet.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetIncludeMeterDetails(this AzureConsumptionPricesheetShowSettings toolSettings, string includeMeterDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = includeMeterDetails;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.IncludeMeterDetails"/></em></p>
        ///   <p>Include meter details in the price sheet.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetIncludeMeterDetails(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetSubscription(this AzureConsumptionPricesheetShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetSubscription(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetDebug(this AzureConsumptionPricesheetShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetDebug(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetHelp(this AzureConsumptionPricesheetShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetHelp(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetOutput(this AzureConsumptionPricesheetShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetOutput(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetQuery(this AzureConsumptionPricesheetShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetQuery(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetVerbose(this AzureConsumptionPricesheetShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetVerbose(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionReservationSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionReservationSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetDebug(this AzureConsumptionReservationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetDebug(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetHelp(this AzureConsumptionReservationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetHelp(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetOutput(this AzureConsumptionReservationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetOutput(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetQuery(this AzureConsumptionReservationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetQuery(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetVerbose(this AzureConsumptionReservationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetVerbose(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionUsageListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionUsageListSettingsExtensions
    {
        #region BillingPeriodName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.BillingPeriodName"/></em></p>
        ///   <p>Name of the billing period to get the usage details that associate with.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetBillingPeriodName(this AzureConsumptionUsageListSettings toolSettings, string billingPeriodName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = billingPeriodName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.BillingPeriodName"/></em></p>
        ///   <p>Name of the billing period to get the usage details that associate with.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetBillingPeriodName(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetEndDate(this AzureConsumptionUsageListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetEndDate(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region IncludeAdditionalProperties
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.IncludeAdditionalProperties"/></em></p>
        ///   <p>Include additional properties in the usages.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetIncludeAdditionalProperties(this AzureConsumptionUsageListSettings toolSettings, string includeAdditionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeAdditionalProperties = includeAdditionalProperties;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.IncludeAdditionalProperties"/></em></p>
        ///   <p>Include additional properties in the usages.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetIncludeAdditionalProperties(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeAdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region IncludeMeterDetails
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.IncludeMeterDetails"/></em></p>
        ///   <p>Include meter details in the usages.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetIncludeMeterDetails(this AzureConsumptionUsageListSettings toolSettings, string includeMeterDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = includeMeterDetails;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.IncludeMeterDetails"/></em></p>
        ///   <p>Include meter details in the usages.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetIncludeMeterDetails(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetStartDate(this AzureConsumptionUsageListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetStartDate(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Value range: 1-1000.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetTop(this AzureConsumptionUsageListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Top"/></em></p>
        ///   <p>Maximum number of items to return. Value range: 1-1000.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetTop(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetSubscription(this AzureConsumptionUsageListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetSubscription(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetDebug(this AzureConsumptionUsageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetDebug(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetHelp(this AzureConsumptionUsageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetHelp(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetOutput(this AzureConsumptionUsageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetOutput(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetQuery(this AzureConsumptionUsageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetQuery(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionUsageListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetVerbose(this AzureConsumptionUsageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionUsageListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetVerbose(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionReservationDetailListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionReservationDetailListSettingsExtensions
    {
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetEndDate(this AzureConsumptionReservationDetailListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetEndDate(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.ReservationOrderId"/></em></p>
        ///   <p>Reservation order id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetReservationOrderId(this AzureConsumptionReservationDetailListSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.ReservationOrderId"/></em></p>
        ///   <p>Reservation order id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetReservationOrderId(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetStartDate(this AzureConsumptionReservationDetailListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetStartDate(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.ReservationId"/></em></p>
        ///   <p>Reservation id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetReservationId(this AzureConsumptionReservationDetailListSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.ReservationId"/></em></p>
        ///   <p>Reservation id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetReservationId(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetSubscription(this AzureConsumptionReservationDetailListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetSubscription(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetDebug(this AzureConsumptionReservationDetailListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetDebug(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetHelp(this AzureConsumptionReservationDetailListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetHelp(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetOutput(this AzureConsumptionReservationDetailListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetOutput(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetQuery(this AzureConsumptionReservationDetailListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetQuery(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetVerbose(this AzureConsumptionReservationDetailListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetVerbose(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureConsumptionReservationSummaryListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionReservationSummaryListSettingsExtensions
    {
        #region Grain
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Grain"/></em></p>
        ///   <p>Reservation summary grain. Possible values are daily or monthly.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetGrain(this AzureConsumptionReservationSummaryListSettings toolSettings, string grain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Grain = grain;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Grain"/></em></p>
        ///   <p>Reservation summary grain. Possible values are daily or monthly.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetGrain(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Grain = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationOrderId"/></em></p>
        ///   <p>Reservation order id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetReservationOrderId(this AzureConsumptionReservationSummaryListSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationOrderId"/></em></p>
        ///   <p>Reservation order id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetReservationOrderId(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetEndDate(this AzureConsumptionReservationSummaryListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.EndDate"/></em></p>
        ///   <p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetEndDate(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationId"/></em></p>
        ///   <p>Reservation id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetReservationId(this AzureConsumptionReservationSummaryListSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationId"/></em></p>
        ///   <p>Reservation id.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetReservationId(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetStartDate(this AzureConsumptionReservationSummaryListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.StartDate"/></em></p>
        ///   <p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetStartDate(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetSubscription(this AzureConsumptionReservationSummaryListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetSubscription(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetDebug(this AzureConsumptionReservationSummaryListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetDebug(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetHelp(this AzureConsumptionReservationSummaryListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetHelp(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetOutput(this AzureConsumptionReservationSummaryListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetOutput(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetQuery(this AzureConsumptionReservationSummaryListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetQuery(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetVerbose(this AzureConsumptionReservationSummaryListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetVerbose(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ConsumptionBudgetCreateCategory
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ConsumptionBudgetCreateCategory>))]
    public partial class ConsumptionBudgetCreateCategory : Enumeration
    {
        public static ConsumptionBudgetCreateCategory cost = new ConsumptionBudgetCreateCategory { Value = "cost" };
        public static ConsumptionBudgetCreateCategory usage = new ConsumptionBudgetCreateCategory { Value = "usage" };
    }
    #endregion
    #region ConsumptionBudgetCreateTimeGrain
    /// <summary>
    ///   Used within <see cref="AzureConsumptionTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ConsumptionBudgetCreateTimeGrain>))]
    public partial class ConsumptionBudgetCreateTimeGrain : Enumeration
    {
        public static ConsumptionBudgetCreateTimeGrain annually = new ConsumptionBudgetCreateTimeGrain { Value = "annually" };
        public static ConsumptionBudgetCreateTimeGrain monthly = new ConsumptionBudgetCreateTimeGrain { Value = "monthly" };
        public static ConsumptionBudgetCreateTimeGrain quarterly = new ConsumptionBudgetCreateTimeGrain { Value = "quarterly" };
    }
    #endregion
}
