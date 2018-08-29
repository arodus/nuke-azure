// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureReservations.json.

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
    public static partial class AzureReservationsTasks
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public static string AzureReservationsPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Reservations.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservations(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureReservationsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservations(Configure<AzureReservationsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationOrderIdList(Configure<AzureReservationsReservationOrderIdListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationOrderIdListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationList(Configure<AzureReservationsReservationListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationListHistory(Configure<AzureReservationsReservationListHistorySettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationListHistorySettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationMerge(Configure<AzureReservationsReservationMergeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationMergeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationShow(Configure<AzureReservationsReservationShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationSplit(Configure<AzureReservationsReservationSplitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationSplitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationUpdate(Configure<AzureReservationsReservationUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsCatalogShow(Configure<AzureReservationsCatalogShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsCatalogShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationOrderList(Configure<AzureReservationsReservationOrderListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationOrderListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Reservations.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reservations?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureReservationsReservationOrderShow(Configure<AzureReservationsReservationOrderShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureReservationsReservationOrderShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureReservationsSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
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
              .Add("reservations")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationOrderIdListSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationOrderIdListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Id of the subscription to look up applied reservations.</p></summary>
        public virtual string SubscriptionId { get; internal set; }
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
              .Add("reservations reservation-order-id list")
              .Add("--subscription-id {value}", SubscriptionId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationListSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Id of container reservation order.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
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
              .Add("reservations reservation list")
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationListHistorySettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationListHistorySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Reservation id of the reservation.</p></summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary><p>Order id of the reservation.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
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
              .Add("reservations reservation list-history")
              .Add("--reservation-id {value}", ReservationId)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationMergeSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationMergeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Id of the first reservation to merge.</p></summary>
        public virtual string ReservationId1 { get; internal set; }
        /// <summary><p>Id of the second reservation to merge.</p></summary>
        public virtual string ReservationId2 { get; internal set; }
        /// <summary><p>Reservation order id of the reservations to merge.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
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
              .Add("reservations reservation merge")
              .Add("--reservation-id-1 {value}", ReservationId1)
              .Add("--reservation-id-2 {value}", ReservationId2)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationShowSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Reservation id of reservation to look up.</p></summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary><p>Order id of reservation to look up.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
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
              .Add("reservations reservation show")
              .Add("--reservation-id {value}", ReservationId)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationSplitSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationSplitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Quantity of the first reservation that will be created from split operation.</p></summary>
        public virtual string Quantity1 { get; internal set; }
        /// <summary><p>Quantity of the second reservation that will be created from split operation.</p></summary>
        public virtual string Quantity2 { get; internal set; }
        /// <summary><p>Reservation id of the reservation to split.</p></summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary><p>Reservation order id of the reservation to split.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
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
              .Add("reservations reservation split")
              .Add("--quantity-1 {value}", Quantity1)
              .Add("--quantity-2 {value}", Quantity2)
              .Add("--reservation-id {value}", ReservationId)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationUpdateSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Type of the Applied Scope to update the reservation with.</p></summary>
        public virtual ReservationsReservationUpdateAppliedScopeType AppliedScopeType { get; internal set; }
        /// <summary><p>Id of the reservation to update.</p></summary>
        public virtual string ReservationId { get; internal set; }
        /// <summary><p>Reservation order id of the reservation to update.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
        /// <summary><p>Subscription that the benefit will be applied. Do not specify if AppliedScopeType is Shared.</p></summary>
        public virtual string AppliedScopes { get; internal set; }
        /// <summary><p>Type of the Instance Flexibility to update the reservation with.</p></summary>
        public virtual ReservationsReservationUpdateInstanceFlexibility InstanceFlexibility { get; internal set; }
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
              .Add("reservations reservation update")
              .Add("--applied-scope-type {value}", AppliedScopeType)
              .Add("--reservation-id {value}", ReservationId)
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--applied-scopes {value}", AppliedScopes)
              .Add("--instance-flexibility {value}", InstanceFlexibility)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsCatalogShowSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsCatalogShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Type of the resource for which the skus should be provided.</p></summary>
        public virtual ReservationsCatalogShowReservedResourceType ReservedResourceType { get; internal set; }
        /// <summary><p>Id of the subscription to get the catalog for.</p></summary>
        public virtual string SubscriptionId { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("reservations catalog show")
              .Add("--reserved-resource-type {value}", ReservedResourceType)
              .Add("--subscription-id {value}", SubscriptionId)
              .Add("--location {value}", Location)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationOrderListSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationOrderListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
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
              .Add("reservations reservation-order list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsReservationOrderShowSettings
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureReservationsReservationOrderShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureReservations executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureReservationsTasks.AzureReservationsPath;
        /// <summary><p>Id of reservation order to look up.</p></summary>
        public virtual string ReservationOrderId { get; internal set; }
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
              .Add("reservations reservation-order show")
              .Add("--reservation-order-id {value}", ReservationOrderId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureReservationsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsSettings SetDebug(this AzureReservationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsSettings ResetDebug(this AzureReservationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsSettings SetHelp(this AzureReservationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsSettings ResetHelp(this AzureReservationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsSettings SetOutput(this AzureReservationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsSettings ResetOutput(this AzureReservationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsSettings SetQuery(this AzureReservationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsSettings ResetQuery(this AzureReservationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsSettings SetVerbose(this AzureReservationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsSettings ResetVerbose(this AzureReservationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationOrderIdListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationOrderIdListSettingsExtensions
    {
        #region SubscriptionId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderIdListSettings.SubscriptionId"/>.</em></p><p>Id of the subscription to look up applied reservations.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings SetSubscriptionId(this AzureReservationsReservationOrderIdListSettings toolSettings, string subscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubscriptionId = subscriptionId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderIdListSettings.SubscriptionId"/>.</em></p><p>Id of the subscription to look up applied reservations.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings ResetSubscriptionId(this AzureReservationsReservationOrderIdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderIdListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings SetDebug(this AzureReservationsReservationOrderIdListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderIdListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings ResetDebug(this AzureReservationsReservationOrderIdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderIdListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings SetHelp(this AzureReservationsReservationOrderIdListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderIdListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings ResetHelp(this AzureReservationsReservationOrderIdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderIdListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings SetOutput(this AzureReservationsReservationOrderIdListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderIdListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings ResetOutput(this AzureReservationsReservationOrderIdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderIdListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings SetQuery(this AzureReservationsReservationOrderIdListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderIdListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings ResetQuery(this AzureReservationsReservationOrderIdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderIdListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings SetVerbose(this AzureReservationsReservationOrderIdListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderIdListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderIdListSettings ResetVerbose(this AzureReservationsReservationOrderIdListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationListSettingsExtensions
    {
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListSettings.ReservationOrderId"/>.</em></p><p>Id of container reservation order.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings SetReservationOrderId(this AzureReservationsReservationListSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListSettings.ReservationOrderId"/>.</em></p><p>Id of container reservation order.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings ResetReservationOrderId(this AzureReservationsReservationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings SetDebug(this AzureReservationsReservationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings ResetDebug(this AzureReservationsReservationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings SetHelp(this AzureReservationsReservationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings ResetHelp(this AzureReservationsReservationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings SetOutput(this AzureReservationsReservationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings ResetOutput(this AzureReservationsReservationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings SetQuery(this AzureReservationsReservationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings ResetQuery(this AzureReservationsReservationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings SetVerbose(this AzureReservationsReservationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListSettings ResetVerbose(this AzureReservationsReservationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationListHistorySettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationListHistorySettingsExtensions
    {
        #region ReservationId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.ReservationId"/>.</em></p><p>Reservation id of the reservation.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetReservationId(this AzureReservationsReservationListHistorySettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.ReservationId"/>.</em></p><p>Reservation id of the reservation.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetReservationId(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.ReservationOrderId"/>.</em></p><p>Order id of the reservation.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetReservationOrderId(this AzureReservationsReservationListHistorySettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.ReservationOrderId"/>.</em></p><p>Order id of the reservation.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetReservationOrderId(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetDebug(this AzureReservationsReservationListHistorySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetDebug(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetHelp(this AzureReservationsReservationListHistorySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetHelp(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetOutput(this AzureReservationsReservationListHistorySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetOutput(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetQuery(this AzureReservationsReservationListHistorySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetQuery(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationListHistorySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings SetVerbose(this AzureReservationsReservationListHistorySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationListHistorySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationListHistorySettings ResetVerbose(this AzureReservationsReservationListHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationMergeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationMergeSettingsExtensions
    {
        #region ReservationId1
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.ReservationId1"/>.</em></p><p>Id of the first reservation to merge.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetReservationId1(this AzureReservationsReservationMergeSettings toolSettings, string reservationId1)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId1 = reservationId1;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.ReservationId1"/>.</em></p><p>Id of the first reservation to merge.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetReservationId1(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId1 = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId2
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.ReservationId2"/>.</em></p><p>Id of the second reservation to merge.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetReservationId2(this AzureReservationsReservationMergeSettings toolSettings, string reservationId2)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId2 = reservationId2;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.ReservationId2"/>.</em></p><p>Id of the second reservation to merge.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetReservationId2(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId2 = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.ReservationOrderId"/>.</em></p><p>Reservation order id of the reservations to merge.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetReservationOrderId(this AzureReservationsReservationMergeSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.ReservationOrderId"/>.</em></p><p>Reservation order id of the reservations to merge.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetReservationOrderId(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetDebug(this AzureReservationsReservationMergeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetDebug(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetHelp(this AzureReservationsReservationMergeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetHelp(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetOutput(this AzureReservationsReservationMergeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetOutput(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetQuery(this AzureReservationsReservationMergeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetQuery(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationMergeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings SetVerbose(this AzureReservationsReservationMergeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationMergeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationMergeSettings ResetVerbose(this AzureReservationsReservationMergeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationShowSettingsExtensions
    {
        #region ReservationId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.ReservationId"/>.</em></p><p>Reservation id of reservation to look up.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetReservationId(this AzureReservationsReservationShowSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.ReservationId"/>.</em></p><p>Reservation id of reservation to look up.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetReservationId(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.ReservationOrderId"/>.</em></p><p>Order id of reservation to look up.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetReservationOrderId(this AzureReservationsReservationShowSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.ReservationOrderId"/>.</em></p><p>Order id of reservation to look up.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetReservationOrderId(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetDebug(this AzureReservationsReservationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetDebug(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetHelp(this AzureReservationsReservationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetHelp(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetOutput(this AzureReservationsReservationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetOutput(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetQuery(this AzureReservationsReservationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetQuery(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings SetVerbose(this AzureReservationsReservationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationShowSettings ResetVerbose(this AzureReservationsReservationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationSplitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationSplitSettingsExtensions
    {
        #region Quantity1
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Quantity1"/>.</em></p><p>Quantity of the first reservation that will be created from split operation.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetQuantity1(this AzureReservationsReservationSplitSettings toolSettings, string quantity1)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quantity1 = quantity1;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Quantity1"/>.</em></p><p>Quantity of the first reservation that will be created from split operation.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetQuantity1(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quantity1 = null;
            return toolSettings;
        }
        #endregion
        #region Quantity2
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Quantity2"/>.</em></p><p>Quantity of the second reservation that will be created from split operation.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetQuantity2(this AzureReservationsReservationSplitSettings toolSettings, string quantity2)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quantity2 = quantity2;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Quantity2"/>.</em></p><p>Quantity of the second reservation that will be created from split operation.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetQuantity2(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quantity2 = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.ReservationId"/>.</em></p><p>Reservation id of the reservation to split.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetReservationId(this AzureReservationsReservationSplitSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.ReservationId"/>.</em></p><p>Reservation id of the reservation to split.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetReservationId(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.ReservationOrderId"/>.</em></p><p>Reservation order id of the reservation to split.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetReservationOrderId(this AzureReservationsReservationSplitSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.ReservationOrderId"/>.</em></p><p>Reservation order id of the reservation to split.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetReservationOrderId(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetDebug(this AzureReservationsReservationSplitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetDebug(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetHelp(this AzureReservationsReservationSplitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetHelp(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetOutput(this AzureReservationsReservationSplitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetOutput(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetQuery(this AzureReservationsReservationSplitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetQuery(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationSplitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings SetVerbose(this AzureReservationsReservationSplitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationSplitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationSplitSettings ResetVerbose(this AzureReservationsReservationSplitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationUpdateSettingsExtensions
    {
        #region AppliedScopeType
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.AppliedScopeType"/>.</em></p><p>Type of the Applied Scope to update the reservation with.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetAppliedScopeType(this AzureReservationsReservationUpdateSettings toolSettings, ReservationsReservationUpdateAppliedScopeType appliedScopeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppliedScopeType = appliedScopeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.AppliedScopeType"/>.</em></p><p>Type of the Applied Scope to update the reservation with.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetAppliedScopeType(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppliedScopeType = null;
            return toolSettings;
        }
        #endregion
        #region ReservationId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.ReservationId"/>.</em></p><p>Id of the reservation to update.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetReservationId(this AzureReservationsReservationUpdateSettings toolSettings, string reservationId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = reservationId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.ReservationId"/>.</em></p><p>Id of the reservation to update.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetReservationId(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationId = null;
            return toolSettings;
        }
        #endregion
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.ReservationOrderId"/>.</em></p><p>Reservation order id of the reservation to update.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetReservationOrderId(this AzureReservationsReservationUpdateSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.ReservationOrderId"/>.</em></p><p>Reservation order id of the reservation to update.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetReservationOrderId(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region AppliedScopes
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.AppliedScopes"/>.</em></p><p>Subscription that the benefit will be applied. Do not specify if AppliedScopeType is Shared.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetAppliedScopes(this AzureReservationsReservationUpdateSettings toolSettings, string appliedScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppliedScopes = appliedScopes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.AppliedScopes"/>.</em></p><p>Subscription that the benefit will be applied. Do not specify if AppliedScopeType is Shared.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetAppliedScopes(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppliedScopes = null;
            return toolSettings;
        }
        #endregion
        #region InstanceFlexibility
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.InstanceFlexibility"/>.</em></p><p>Type of the Instance Flexibility to update the reservation with.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetInstanceFlexibility(this AzureReservationsReservationUpdateSettings toolSettings, ReservationsReservationUpdateInstanceFlexibility instanceFlexibility)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceFlexibility = instanceFlexibility;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.InstanceFlexibility"/>.</em></p><p>Type of the Instance Flexibility to update the reservation with.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetInstanceFlexibility(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstanceFlexibility = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetDebug(this AzureReservationsReservationUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetDebug(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetHelp(this AzureReservationsReservationUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetHelp(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetOutput(this AzureReservationsReservationUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetOutput(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetQuery(this AzureReservationsReservationUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetQuery(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings SetVerbose(this AzureReservationsReservationUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationUpdateSettings ResetVerbose(this AzureReservationsReservationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsCatalogShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsCatalogShowSettingsExtensions
    {
        #region ReservedResourceType
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.ReservedResourceType"/>.</em></p><p>Type of the resource for which the skus should be provided.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetReservedResourceType(this AzureReservationsCatalogShowSettings toolSettings, ReservationsCatalogShowReservedResourceType reservedResourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservedResourceType = reservedResourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.ReservedResourceType"/>.</em></p><p>Type of the resource for which the skus should be provided.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetReservedResourceType(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservedResourceType = null;
            return toolSettings;
        }
        #endregion
        #region SubscriptionId
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.SubscriptionId"/>.</em></p><p>Id of the subscription to get the catalog for.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetSubscriptionId(this AzureReservationsCatalogShowSettings toolSettings, string subscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubscriptionId = subscriptionId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.SubscriptionId"/>.</em></p><p>Id of the subscription to get the catalog for.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetSubscriptionId(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetLocation(this AzureReservationsCatalogShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetLocation(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetDebug(this AzureReservationsCatalogShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetDebug(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetHelp(this AzureReservationsCatalogShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetHelp(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetOutput(this AzureReservationsCatalogShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetOutput(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetQuery(this AzureReservationsCatalogShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetQuery(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsCatalogShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings SetVerbose(this AzureReservationsCatalogShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsCatalogShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsCatalogShowSettings ResetVerbose(this AzureReservationsCatalogShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationOrderListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationOrderListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings SetDebug(this AzureReservationsReservationOrderListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings ResetDebug(this AzureReservationsReservationOrderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings SetHelp(this AzureReservationsReservationOrderListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings ResetHelp(this AzureReservationsReservationOrderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings SetOutput(this AzureReservationsReservationOrderListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings ResetOutput(this AzureReservationsReservationOrderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings SetQuery(this AzureReservationsReservationOrderListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings ResetQuery(this AzureReservationsReservationOrderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings SetVerbose(this AzureReservationsReservationOrderListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderListSettings ResetVerbose(this AzureReservationsReservationOrderListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureReservationsReservationOrderShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureReservationsReservationOrderShowSettingsExtensions
    {
        #region ReservationOrderId
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderShowSettings.ReservationOrderId"/>.</em></p><p>Id of reservation order to look up.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings SetReservationOrderId(this AzureReservationsReservationOrderShowSettings toolSettings, string reservationOrderId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = reservationOrderId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderShowSettings.ReservationOrderId"/>.</em></p><p>Id of reservation order to look up.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings ResetReservationOrderId(this AzureReservationsReservationOrderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReservationOrderId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings SetDebug(this AzureReservationsReservationOrderShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings ResetDebug(this AzureReservationsReservationOrderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings SetHelp(this AzureReservationsReservationOrderShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings ResetHelp(this AzureReservationsReservationOrderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings SetOutput(this AzureReservationsReservationOrderShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings ResetOutput(this AzureReservationsReservationOrderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings SetQuery(this AzureReservationsReservationOrderShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings ResetQuery(this AzureReservationsReservationOrderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureReservationsReservationOrderShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings SetVerbose(this AzureReservationsReservationOrderShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureReservationsReservationOrderShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureReservationsReservationOrderShowSettings ResetVerbose(this AzureReservationsReservationOrderShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ReservationsReservationUpdateAppliedScopeType
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class ReservationsReservationUpdateAppliedScopeType : Enumeration
    {
        public static ReservationsReservationUpdateAppliedScopeType shared = new ReservationsReservationUpdateAppliedScopeType { Value = "shared" };
        public static ReservationsReservationUpdateAppliedScopeType single = new ReservationsReservationUpdateAppliedScopeType { Value = "single" };
    }
    #endregion
    #region ReservationsReservationUpdateInstanceFlexibility
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class ReservationsReservationUpdateInstanceFlexibility : Enumeration
    {
        public static ReservationsReservationUpdateInstanceFlexibility notsupported = new ReservationsReservationUpdateInstanceFlexibility { Value = "notsupported" };
        public static ReservationsReservationUpdateInstanceFlexibility off = new ReservationsReservationUpdateInstanceFlexibility { Value = "off" };
        public static ReservationsReservationUpdateInstanceFlexibility on = new ReservationsReservationUpdateInstanceFlexibility { Value = "on" };
    }
    #endregion
    #region ReservationsCatalogShowReservedResourceType
    /// <summary><p>Used within <see cref="AzureReservationsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class ReservationsCatalogShowReservedResourceType : Enumeration
    {
        public static ReservationsCatalogShowReservedResourceType sqldatabases = new ReservationsCatalogShowReservedResourceType { Value = "sqldatabases" };
        public static ReservationsCatalogShowReservedResourceType suselinux = new ReservationsCatalogShowReservedResourceType { Value = "suselinux" };
        public static ReservationsCatalogShowReservedResourceType virtualmachines = new ReservationsCatalogShowReservedResourceType { Value = "virtualmachines" };
    }
    #endregion
}
