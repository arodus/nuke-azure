// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureConsumption.json.

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
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public static string AzureConsumptionPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage consumption of Azure resources.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumption(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureConsumptionPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumption(Configure<AzureConsumptionSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetCreate(Configure<AzureConsumptionBudgetCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionBudgetCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetDelete(Configure<AzureConsumptionBudgetDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionBudgetDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetList(Configure<AzureConsumptionBudgetListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionBudgetListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionBudgetShow(Configure<AzureConsumptionBudgetShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionBudgetShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionPricesheetShow(Configure<AzureConsumptionPricesheetShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionPricesheetShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionMarketplaceList(Configure<AzureConsumptionMarketplaceListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionMarketplaceListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionReservation(Configure<AzureConsumptionReservationSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionReservationSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionUsageList(Configure<AzureConsumptionUsageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionUsageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionReservationSummaryList(Configure<AzureConsumptionReservationSummaryListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionReservationSummaryListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage consumption of Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/consumption?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureConsumptionReservationDetailList(Configure<AzureConsumptionReservationDetailListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConsumptionReservationDetailListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureConsumptionSettings
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Amount of a budget.</p></summary>
        public virtual string Amount { get; internal set; }
        /// <summary><p>Name of a budget.</p></summary>
        public virtual string BudgetName { get; internal set; }
        /// <summary><p>Category of the budget can be cost or usage.</p></summary>
        public virtual ConsumptionBudgetCreateCategory Category { get; internal set; }
        /// <summary><p>End date (YYYY-MM-DD in UTC) of time period of a budget.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>Start date (YYYY-MM-DD in UTC) of time period of a budget.</p></summary>
        public virtual string StartDate { get; internal set; }
        /// <summary><p>Time grain of the budget can be monthly, quarterly, or annually.</p></summary>
        public virtual ConsumptionBudgetCreateTimeGrain TimeGrain { get; internal set; }
        /// <summary><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        public virtual IReadOnlyList<string> MeterFilter => MeterFilterInternal.AsReadOnly();
        internal List<string> MeterFilterInternal { get; set; } = new List<string>();
        /// <summary><p>Space-separated list of resource instances to filter on.</p></summary>
        public virtual IReadOnlyList<string> ResourceFilter => ResourceFilterInternal.AsReadOnly();
        internal List<string> ResourceFilterInternal { get; set; } = new List<string>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated list of resource groups to filter on.</p></summary>
        public virtual IReadOnlyList<string> ResourceGroupFilter => ResourceGroupFilterInternal.AsReadOnly();
        internal List<string> ResourceGroupFilterInternal { get; set; } = new List<string>();
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Name of a budget.</p></summary>
        public virtual string BudgetName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionBudgetShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Name of a budget.</p></summary>
        public virtual string BudgetName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionPricesheetShowSettings
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionPricesheetShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Name of the billing period to get the price sheet.</p></summary>
        public virtual string BillingPeriodName { get; internal set; }
        /// <summary><p>Include meter details in the price sheet.</p></summary>
        public virtual string IncludeMeterDetails { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionMarketplaceListSettings
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionMarketplaceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Name of the billing period to get the marketplace.</p></summary>
        public virtual string BillingPeriodName { get; internal set; }
        /// <summary><p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p></summary>
        public virtual string StartDate { get; internal set; }
        /// <summary><p>Maximum number of items to return. Value range: 1-1000.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionReservationSettings
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionReservationSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionUsageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Name of the billing period to get the usage details that associate with.</p></summary>
        public virtual string BillingPeriodName { get; internal set; }
        /// <summary><p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>Include additional properties in the usages.</p></summary>
        public virtual string IncludeAdditionalProperties { get; internal set; }
        /// <summary><p>Include meter details in the usages.</p></summary>
        public virtual string IncludeMeterDetails { get; internal set; }
        /// <summary><p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p></summary>
        public virtual string StartDate { get; internal set; }
        /// <summary><p>Maximum number of items to return. Value range: 1-1000.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionReservationSummaryListSettings
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionReservationSummaryListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>Reservation summary grain. Possible values are daily or monthly.</p></summary>
        public virtual string Grain { get; internal set; }
        /// <summary><p>Reservation order id.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
        /// <summary><p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>Reservation id.</p></summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary><p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p></summary>
        public virtual string StartDate { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionReservationDetailListSettings
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConsumptionReservationDetailListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureConsumption executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureConsumptionTasks.AzureConsumptionPath;
        /// <summary><p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>Reservation order id.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
        /// <summary><p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p></summary>
        public virtual string StartDate { get; internal set; }
        /// <summary><p>Reservation id.</p></summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionSettingsExtensions
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionSettings SetDebug(this AzureConsumptionSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionSettings ResetDebug(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionSettings SetHelp(this AzureConsumptionSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionSettings ResetHelp(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionSettings SetOutput(this AzureConsumptionSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionSettings ResetOutput(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionSettings SetQuery(this AzureConsumptionSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionSettings ResetQuery(this AzureConsumptionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionSettings SetVerbose(this AzureConsumptionSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetCreateSettingsExtensions
    {
        #region Amount
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Amount"/>.</em></p><p>Amount of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetAmount(this AzureConsumptionBudgetCreateSettings toolSettings, string amount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Amount = amount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Amount"/>.</em></p><p>Amount of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetAmount(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Amount = null;
            return toolSettings;
        }
        #endregion
        #region BudgetName
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.BudgetName"/>.</em></p><p>Name of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetBudgetName(this AzureConsumptionBudgetCreateSettings toolSettings, string budgetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = budgetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.BudgetName"/>.</em></p><p>Name of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetBudgetName(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = null;
            return toolSettings;
        }
        #endregion
        #region Category
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Category"/>.</em></p><p>Category of the budget can be cost or usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetCategory(this AzureConsumptionBudgetCreateSettings toolSettings, ConsumptionBudgetCreateCategory category)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Category = category;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Category"/>.</em></p><p>Category of the budget can be cost or usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetCategory(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Category = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC) of time period of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetEndDate(this AzureConsumptionBudgetCreateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC) of time period of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetEndDate(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC) of time period of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetStartDate(this AzureConsumptionBudgetCreateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC) of time period of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetStartDate(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region TimeGrain
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.TimeGrain"/>.</em></p><p>Time grain of the budget can be monthly, quarterly, or annually.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetTimeGrain(this AzureConsumptionBudgetCreateSettings toolSettings, ConsumptionBudgetCreateTimeGrain timeGrain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TimeGrain = timeGrain;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.TimeGrain"/>.</em></p><p>Time grain of the budget can be monthly, quarterly, or annually.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetTimeGrain(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TimeGrain = null;
            return toolSettings;
        }
        #endregion
        #region MeterFilter
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/> to a new list.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal = meterFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/> to a new list.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal = meterFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/>.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal.AddRange(meterFilter);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/>.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal.AddRange(meterFilter);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/>.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ClearMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MeterFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/>.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveMeterFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] meterFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(meterFilter);
            toolSettings.MeterFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.MeterFilter"/>.</em></p><p>Space-separated list of meters to filter on. Required if category is usage.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/> to a new list.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal = resourceFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/> to a new list.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal = resourceFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/>.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal.AddRange(resourceFilter);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/>.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal.AddRange(resourceFilter);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/>.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ClearResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/>.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveResourceFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(resourceFilter);
            toolSettings.ResourceFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceFilter"/>.</em></p><p>Space-separated list of resource instances to filter on.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceGroup(this AzureConsumptionBudgetCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetResourceGroup(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupFilter
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/> to a new list.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal = resourceGroupFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/> to a new list.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal = resourceGroupFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/>.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal.AddRange(resourceGroupFilter);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/>.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings AddResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, IEnumerable<string> resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal.AddRange(resourceGroupFilter);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/>.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ClearResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/>.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings RemoveResourceGroupFilter(this AzureConsumptionBudgetCreateSettings toolSettings, params string[] resourceGroupFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(resourceGroupFilter);
            toolSettings.ResourceGroupFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureConsumptionBudgetCreateSettings.ResourceGroupFilter"/>.</em></p><p>Space-separated list of resource groups to filter on.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetSubscription(this AzureConsumptionBudgetCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetSubscription(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetDebug(this AzureConsumptionBudgetCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetDebug(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetHelp(this AzureConsumptionBudgetCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetHelp(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetOutput(this AzureConsumptionBudgetCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetOutput(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetQuery(this AzureConsumptionBudgetCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings ResetQuery(this AzureConsumptionBudgetCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetCreateSettings SetVerbose(this AzureConsumptionBudgetCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetDeleteSettingsExtensions
    {
        #region BudgetName
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.BudgetName"/>.</em></p><p>Name of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetBudgetName(this AzureConsumptionBudgetDeleteSettings toolSettings, string budgetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = budgetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.BudgetName"/>.</em></p><p>Name of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetBudgetName(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetResourceGroup(this AzureConsumptionBudgetDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetResourceGroup(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetSubscription(this AzureConsumptionBudgetDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetSubscription(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetDebug(this AzureConsumptionBudgetDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetDebug(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetHelp(this AzureConsumptionBudgetDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetHelp(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetOutput(this AzureConsumptionBudgetDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetOutput(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetQuery(this AzureConsumptionBudgetDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings ResetQuery(this AzureConsumptionBudgetDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetDeleteSettings SetVerbose(this AzureConsumptionBudgetDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetResourceGroup(this AzureConsumptionBudgetListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetResourceGroup(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetSubscription(this AzureConsumptionBudgetListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetSubscription(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetDebug(this AzureConsumptionBudgetListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetDebug(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetHelp(this AzureConsumptionBudgetListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetHelp(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetOutput(this AzureConsumptionBudgetListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetOutput(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetQuery(this AzureConsumptionBudgetListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings ResetQuery(this AzureConsumptionBudgetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetListSettings SetVerbose(this AzureConsumptionBudgetListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionBudgetShowSettingsExtensions
    {
        #region BudgetName
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.BudgetName"/>.</em></p><p>Name of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetBudgetName(this AzureConsumptionBudgetShowSettings toolSettings, string budgetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = budgetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.BudgetName"/>.</em></p><p>Name of a budget.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetBudgetName(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BudgetName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetResourceGroup(this AzureConsumptionBudgetShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetResourceGroup(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetSubscription(this AzureConsumptionBudgetShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetSubscription(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetDebug(this AzureConsumptionBudgetShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetDebug(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetHelp(this AzureConsumptionBudgetShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetHelp(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetOutput(this AzureConsumptionBudgetShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetOutput(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetQuery(this AzureConsumptionBudgetShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings ResetQuery(this AzureConsumptionBudgetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionBudgetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionBudgetShowSettings SetVerbose(this AzureConsumptionBudgetShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionBudgetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionPricesheetShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionPricesheetShowSettingsExtensions
    {
        #region BillingPeriodName
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.BillingPeriodName"/>.</em></p><p>Name of the billing period to get the price sheet.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetBillingPeriodName(this AzureConsumptionPricesheetShowSettings toolSettings, string billingPeriodName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = billingPeriodName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.BillingPeriodName"/>.</em></p><p>Name of the billing period to get the price sheet.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetBillingPeriodName(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = null;
            return toolSettings;
        }
        #endregion
        #region IncludeMeterDetails
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.IncludeMeterDetails"/>.</em></p><p>Include meter details in the price sheet.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetIncludeMeterDetails(this AzureConsumptionPricesheetShowSettings toolSettings, string includeMeterDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = includeMeterDetails;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.IncludeMeterDetails"/>.</em></p><p>Include meter details in the price sheet.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetIncludeMeterDetails(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetSubscription(this AzureConsumptionPricesheetShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetSubscription(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetDebug(this AzureConsumptionPricesheetShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetDebug(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetHelp(this AzureConsumptionPricesheetShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetHelp(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetOutput(this AzureConsumptionPricesheetShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetOutput(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetQuery(this AzureConsumptionPricesheetShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings ResetQuery(this AzureConsumptionPricesheetShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionPricesheetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionPricesheetShowSettings SetVerbose(this AzureConsumptionPricesheetShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionPricesheetShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionMarketplaceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionMarketplaceListSettingsExtensions
    {
        #region BillingPeriodName
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.BillingPeriodName"/>.</em></p><p>Name of the billing period to get the marketplace.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetBillingPeriodName(this AzureConsumptionMarketplaceListSettings toolSettings, string billingPeriodName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = billingPeriodName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.BillingPeriodName"/>.</em></p><p>Name of the billing period to get the marketplace.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetBillingPeriodName(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetEndDate(this AzureConsumptionMarketplaceListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetEndDate(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetStartDate(this AzureConsumptionMarketplaceListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetStartDate(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Top"/>.</em></p><p>Maximum number of items to return. Value range: 1-1000.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetTop(this AzureConsumptionMarketplaceListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Top"/>.</em></p><p>Maximum number of items to return. Value range: 1-1000.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetTop(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetSubscription(this AzureConsumptionMarketplaceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetSubscription(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetDebug(this AzureConsumptionMarketplaceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetDebug(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetHelp(this AzureConsumptionMarketplaceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetHelp(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetOutput(this AzureConsumptionMarketplaceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetOutput(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetQuery(this AzureConsumptionMarketplaceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings ResetQuery(this AzureConsumptionMarketplaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionMarketplaceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionMarketplaceListSettings SetVerbose(this AzureConsumptionMarketplaceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionMarketplaceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionReservationSettingsExtensions
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionReservationSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetDebug(this AzureConsumptionReservationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetDebug(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetHelp(this AzureConsumptionReservationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetHelp(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetOutput(this AzureConsumptionReservationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetOutput(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetQuery(this AzureConsumptionReservationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings ResetQuery(this AzureConsumptionReservationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSettings SetVerbose(this AzureConsumptionReservationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionUsageListSettingsExtensions
    {
        #region BillingPeriodName
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.BillingPeriodName"/>.</em></p><p>Name of the billing period to get the usage details that associate with.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetBillingPeriodName(this AzureConsumptionUsageListSettings toolSettings, string billingPeriodName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = billingPeriodName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.BillingPeriodName"/>.</em></p><p>Name of the billing period to get the usage details that associate with.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetBillingPeriodName(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BillingPeriodName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetEndDate(this AzureConsumptionUsageListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). If specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetEndDate(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region IncludeAdditionalProperties
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.IncludeAdditionalProperties"/>.</em></p><p>Include additional properties in the usages.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetIncludeAdditionalProperties(this AzureConsumptionUsageListSettings toolSettings, string includeAdditionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeAdditionalProperties = includeAdditionalProperties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.IncludeAdditionalProperties"/>.</em></p><p>Include additional properties in the usages.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetIncludeAdditionalProperties(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeAdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region IncludeMeterDetails
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.IncludeMeterDetails"/>.</em></p><p>Include meter details in the usages.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetIncludeMeterDetails(this AzureConsumptionUsageListSettings toolSettings, string includeMeterDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = includeMeterDetails;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.IncludeMeterDetails"/>.</em></p><p>Include meter details in the usages.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetIncludeMeterDetails(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeMeterDetails = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetStartDate(this AzureConsumptionUsageListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). If specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetStartDate(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Top"/>.</em></p><p>Maximum number of items to return. Value range: 1-1000.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetTop(this AzureConsumptionUsageListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Top"/>.</em></p><p>Maximum number of items to return. Value range: 1-1000.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetTop(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetSubscription(this AzureConsumptionUsageListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetSubscription(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetDebug(this AzureConsumptionUsageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetDebug(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetHelp(this AzureConsumptionUsageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetHelp(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetOutput(this AzureConsumptionUsageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetOutput(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetQuery(this AzureConsumptionUsageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings ResetQuery(this AzureConsumptionUsageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionUsageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionUsageListSettings SetVerbose(this AzureConsumptionUsageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionUsageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionReservationSummaryListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionReservationSummaryListSettingsExtensions
    {
        #region Grain
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Grain"/>.</em></p><p>Reservation summary grain. Possible values are daily or monthly.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetGrain(this AzureConsumptionReservationSummaryListSettings toolSettings, string grain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Grain = grain;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Grain"/>.</em></p><p>Reservation summary grain. Possible values are daily or monthly.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetGrain(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Grain = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationOrderId"/>.</em></p><p>Reservation order id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetReservationOrderId(this AzureConsumptionReservationSummaryListSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationOrderId"/>.</em></p><p>Reservation order id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetReservationOrderId(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetEndDate(this AzureConsumptionReservationSummaryListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetEndDate(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationId"/>.</em></p><p>Reservation id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetReservationId(this AzureConsumptionReservationSummaryListSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.ReservationId"/>.</em></p><p>Reservation id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetReservationId(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetStartDate(this AzureConsumptionReservationSummaryListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetStartDate(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetSubscription(this AzureConsumptionReservationSummaryListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetSubscription(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetDebug(this AzureConsumptionReservationSummaryListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetDebug(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetHelp(this AzureConsumptionReservationSummaryListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetHelp(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetOutput(this AzureConsumptionReservationSummaryListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetOutput(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetQuery(this AzureConsumptionReservationSummaryListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings ResetQuery(this AzureConsumptionReservationSummaryListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationSummaryListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationSummaryListSettings SetVerbose(this AzureConsumptionReservationSummaryListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationSummaryListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region AzureConsumptionReservationDetailListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConsumptionReservationDetailListSettingsExtensions
    {
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetEndDate(this AzureConsumptionReservationDetailListSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.EndDate"/>.</em></p><p>End date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --start-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetEndDate(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.ReservationOrderId"/>.</em></p><p>Reservation order id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetReservationOrderId(this AzureConsumptionReservationDetailListSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.ReservationOrderId"/>.</em></p><p>Reservation order id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetReservationOrderId(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetStartDate(this AzureConsumptionReservationDetailListSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.StartDate"/>.</em></p><p>Start date (YYYY-MM-DD in UTC). Only needed for daily grain and if specified, also requires --end-date.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetStartDate(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.ReservationId"/>.</em></p><p>Reservation id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetReservationId(this AzureConsumptionReservationDetailListSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.ReservationId"/>.</em></p><p>Reservation id.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetReservationId(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetSubscription(this AzureConsumptionReservationDetailListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetSubscription(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetDebug(this AzureConsumptionReservationDetailListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetDebug(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetHelp(this AzureConsumptionReservationDetailListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetHelp(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetOutput(this AzureConsumptionReservationDetailListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetOutput(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetQuery(this AzureConsumptionReservationDetailListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings ResetQuery(this AzureConsumptionReservationDetailListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConsumptionReservationDetailListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConsumptionReservationDetailListSettings SetVerbose(this AzureConsumptionReservationDetailListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConsumptionReservationDetailListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
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
    #region ConsumptionBudgetCreateCategory
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class ConsumptionBudgetCreateCategory : Enumeration
    {
        public static ConsumptionBudgetCreateCategory cost = new ConsumptionBudgetCreateCategory { Value = "cost" };
        public static ConsumptionBudgetCreateCategory usage = new ConsumptionBudgetCreateCategory { Value = "usage" };
    }
    #endregion
    #region ConsumptionBudgetCreateTimeGrain
    /// <summary><p>Used within <see cref="AzureConsumptionTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class ConsumptionBudgetCreateTimeGrain : Enumeration
    {
        public static ConsumptionBudgetCreateTimeGrain annually = new ConsumptionBudgetCreateTimeGrain { Value = "annually" };
        public static ConsumptionBudgetCreateTimeGrain monthly = new ConsumptionBudgetCreateTimeGrain { Value = "monthly" };
        public static ConsumptionBudgetCreateTimeGrain quarterly = new ConsumptionBudgetCreateTimeGrain { Value = "quarterly" };
    }
    #endregion
}
