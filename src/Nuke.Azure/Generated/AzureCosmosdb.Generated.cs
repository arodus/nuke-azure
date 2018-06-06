// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0 [CommitSha: 3eaf2b72].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCosmosdb.json.

using JetBrains.Annotations;
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
    public static partial class AzureCosmosdbTasks
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public static string AzureCosmosdbPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p></summary>
        public static IEnumerable<string> AzureCosmosdb(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureCosmosdbPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureCosmosdbCheckNameExistsSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCheckNameExistsSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCheckNameExists(Configure<AzureCosmosdbCheckNameExistsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCheckNameExistsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCreateSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCreateSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCreate(Configure<AzureCosmosdbCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbDeleteSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbDelete(Configure<AzureCosmosdbDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbFailoverPriorityChangeSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbFailoverPriorityChangeSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbFailoverPriorityChange(Configure<AzureCosmosdbFailoverPriorityChangeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbFailoverPriorityChangeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbListSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbListSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbList(Configure<AzureCosmosdbListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbListConnectionStringsSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbListConnectionStringsSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbListConnectionStrings(Configure<AzureCosmosdbListConnectionStringsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbListConnectionStringsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbListKeysSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbListKeysSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbListKeys(Configure<AzureCosmosdbListKeysSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbListKeysSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbListReadOnlyKeysSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbListReadOnlyKeysSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbListReadOnlyKeys(Configure<AzureCosmosdbListReadOnlyKeysSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbListReadOnlyKeysSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbRegenerateKeySettings toolSettings);
        static partial void PostProcess(AzureCosmosdbRegenerateKeySettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbRegenerateKey(Configure<AzureCosmosdbRegenerateKeySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbRegenerateKeySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbShowSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbShowSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbShow(Configure<AzureCosmosdbShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbUpdateSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbUpdate(Configure<AzureCosmosdbUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCollectionCreateSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCollectionCreateSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCollectionCreate(Configure<AzureCosmosdbCollectionCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCollectionCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCollectionDeleteSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCollectionDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCollectionDelete(Configure<AzureCosmosdbCollectionDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCollectionDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCollectionExistsSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCollectionExistsSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCollectionExists(Configure<AzureCosmosdbCollectionExistsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCollectionExistsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCollectionListSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCollectionListSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCollectionList(Configure<AzureCosmosdbCollectionListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCollectionListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCollectionShowSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCollectionShowSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCollectionShow(Configure<AzureCosmosdbCollectionShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCollectionShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbCollectionUpdateSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbCollectionUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbCollectionUpdate(Configure<AzureCosmosdbCollectionUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbCollectionUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbDatabaseCreateSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbDatabaseCreateSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbDatabaseCreate(Configure<AzureCosmosdbDatabaseCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbDatabaseCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbDatabaseDeleteSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbDatabaseDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbDatabaseDelete(Configure<AzureCosmosdbDatabaseDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbDatabaseDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbDatabaseExistsSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbDatabaseExistsSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbDatabaseExists(Configure<AzureCosmosdbDatabaseExistsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbDatabaseExistsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbDatabaseListSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbDatabaseListSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbDatabaseList(Configure<AzureCosmosdbDatabaseListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbDatabaseListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCosmosdbDatabaseShowSettings toolSettings);
        static partial void PostProcess(AzureCosmosdbDatabaseShowSettings toolSettings);
        /// <summary><p>Manage Azure Cosmos DB database accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCosmosdbDatabaseShow(Configure<AzureCosmosdbDatabaseShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCosmosdbDatabaseShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureCosmosdbCheckNameExistsSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCheckNameExistsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb check-name-exists")
              .Add("--name {value}", Name)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCreateSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Set custom capabilities on the Cosmos DB database account.</p></summary>
        public virtual string Capabilities { get; internal set; }
        /// <summary><p>Default consistency level of the Cosmos DB database account.</p></summary>
        public virtual CosmosdbDefaultConsistencyLevel DefaultConsistencyLevel { get; internal set; }
        /// <summary><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        public virtual bool? EnableAutomaticFailover { get; internal set; }
        /// <summary><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        public virtual bool? EnableVirtualNetwork { get; internal set; }
        /// <summary><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        public virtual IReadOnlyList<string> IpRangeFilter => IpRangeFilterInternal.AsReadOnly();
        internal List<string> IpRangeFilterInternal { get; set; } = new List<string>();
        /// <summary><p>The type of Cosmos DB database account to create.</p></summary>
        public virtual CosmosdbCreateKind Kind { get; internal set; }
        /// <summary><p>Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.</p></summary>
        public virtual string Locations { get; internal set; }
        /// <summary><p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p></summary>
        public virtual string MaxInterval { get; internal set; }
        /// <summary><p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p></summary>
        public virtual string MaxStalenessPrefix { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>ACL's for virtual network.</p></summary>
        public virtual string VirtualNetworkRules { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--capabilities {value}", Capabilities)
              .Add("--default-consistency-level {value}", DefaultConsistencyLevel)
              .Add("--enable-automatic-failover", EnableAutomaticFailover)
              .Add("--enable-virtual-network", EnableVirtualNetwork)
              .Add("--ip-range-filter {value}", IpRangeFilter, separator: ',')
              .Add("--kind {value}", Kind)
              .Add("--locations {value}", Locations)
              .Add("--max-interval {value}", MaxInterval)
              .Add("--max-staleness-prefix {value}", MaxStalenessPrefix)
              .Add("--tags {value}", Tags)
              .Add("--virtual-network-rules {value}", VirtualNetworkRules)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbDeleteSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbFailoverPriorityChangeSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbFailoverPriorityChangeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p></summary>
        public virtual string FailoverPolicies { get; internal set; }
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb failover-priority-change")
              .Add("--failover-policies {value}", FailoverPolicies)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbListSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbListConnectionStringsSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListConnectionStringsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb list-connection-strings")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbListKeysSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListKeysSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb list-keys")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbListReadOnlyKeysSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListReadOnlyKeysSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb list-read-only-keys")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbRegenerateKeySettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbRegenerateKeySettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>The access key to regenerate.</p></summary>
        public virtual CosmosdbRegenerateKeyKeyKind KeyKind { get; internal set; }
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb regenerate-key")
              .Add("--key-kind {value}", KeyKind)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbShowSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbUpdateSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Name of the Cosmos DB database account.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Set custom capabilities on the Cosmos DB database account.</p></summary>
        public virtual string Capabilities { get; internal set; }
        /// <summary><p>Default consistency level of the Cosmos DB database account.</p></summary>
        public virtual CosmosdbDefaultConsistencyLevel DefaultConsistencyLevel { get; internal set; }
        /// <summary><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        public virtual bool? EnableAutomaticFailover { get; internal set; }
        /// <summary><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        public virtual bool? EnableVirtualNetwork { get; internal set; }
        /// <summary><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        public virtual IReadOnlyList<string> IpRangeFilter => IpRangeFilterInternal.AsReadOnly();
        internal List<string> IpRangeFilterInternal { get; set; } = new List<string>();
        /// <summary><p>Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.</p></summary>
        public virtual string Locations { get; internal set; }
        /// <summary><p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p></summary>
        public virtual string MaxInterval { get; internal set; }
        /// <summary><p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p></summary>
        public virtual string MaxStalenessPrefix { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>ACL's for virtual network.</p></summary>
        public virtual string VirtualNetworkRules { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--capabilities {value}", Capabilities)
              .Add("--default-consistency-level {value}", DefaultConsistencyLevel)
              .Add("--enable-automatic-failover", EnableAutomaticFailover)
              .Add("--enable-virtual-network", EnableVirtualNetwork)
              .Add("--ip-range-filter {value}", IpRangeFilter, separator: ',')
              .Add("--locations {value}", Locations)
              .Add("--max-interval {value}", MaxInterval)
              .Add("--max-staleness-prefix {value}", MaxStalenessPrefix)
              .Add("--tags {value}", Tags)
              .Add("--virtual-network-rules {value}", VirtualNetworkRules)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCollectionCreateSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Collection Name.</p></summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Default TTL.</p></summary>
        public virtual string DefaultTtl { get; internal set; }
        /// <summary><p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p></summary>
        public virtual string IndexingPolicy { get; internal set; }
        /// <summary><p>Partition Key Path, e.g., '/properties/name'.</p></summary>
        public virtual string PartitionKeyPath { get; internal set; }
        /// <summary><p>Offer Throughput.</p></summary>
        public virtual string Throughput { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb collection create")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--default-ttl {value}", DefaultTtl)
              .Add("--indexing-policy {value}", IndexingPolicy)
              .Add("--partition-key-path {value}", PartitionKeyPath)
              .Add("--throughput {value}", Throughput)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCollectionDeleteSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Collection Name.</p></summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb collection delete")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCollectionExistsSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionExistsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Collection Name.</p></summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb collection exists")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCollectionListSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb collection list")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCollectionShowSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Collection Name.</p></summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb collection show")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCollectionUpdateSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Collection Name.</p></summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Default TTL.</p></summary>
        public virtual string DefaultTtl { get; internal set; }
        /// <summary><p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p></summary>
        public virtual string IndexingPolicy { get; internal set; }
        /// <summary><p>Offer Throughput.</p></summary>
        public virtual string Throughput { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb collection update")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--default-ttl {value}", DefaultTtl)
              .Add("--indexing-policy {value}", IndexingPolicy)
              .Add("--throughput {value}", Throughput)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbDatabaseCreateSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb database create")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbDatabaseDeleteSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb database delete")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbDatabaseExistsSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseExistsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb database exists")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbDatabaseListSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb database list")
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbDatabaseShowSettings
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCosmosdb executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        /// <summary><p>Database Name.</p></summary>
        public virtual string DbName { get; internal set; }
        /// <summary><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        public virtual string UrlConnection { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cosmosdb database show")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCosmosdbCheckNameExistsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCheckNameExistsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetName(this AzureCosmosdbCheckNameExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetName(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetDebug(this AzureCosmosdbCheckNameExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetDebug(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetHelp(this AzureCosmosdbCheckNameExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetHelp(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetOutput(this AzureCosmosdbCheckNameExistsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetOutput(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetQuery(this AzureCosmosdbCheckNameExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetQuery(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetVerbose(this AzureCosmosdbCheckNameExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetVerbose(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetName(this AzureCosmosdbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetName(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetResourceGroup(this AzureCosmosdbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetResourceGroup(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Capabilities
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Capabilities"/>.</em></p><p>Set custom capabilities on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetCapabilities(this AzureCosmosdbCreateSettings toolSettings, string capabilities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = capabilities;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Capabilities"/>.</em></p><p>Set custom capabilities on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetCapabilities(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = null;
            return toolSettings;
        }
        #endregion
        #region DefaultConsistencyLevel
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.DefaultConsistencyLevel"/>.</em></p><p>Default consistency level of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetDefaultConsistencyLevel(this AzureCosmosdbCreateSettings toolSettings, CosmosdbDefaultConsistencyLevel defaultConsistencyLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = defaultConsistencyLevel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.DefaultConsistencyLevel"/>.</em></p><p>Default consistency level of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetDefaultConsistencyLevel(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = null;
            return toolSettings;
        }
        #endregion
        #region EnableAutomaticFailover
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings, bool? enableAutomaticFailover)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = enableAutomaticFailover;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings EnableEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings DisableEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ToggleEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = !toolSettings.EnableAutomaticFailover;
            return toolSettings;
        }
        #endregion
        #region EnableVirtualNetwork
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings, bool? enableVirtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = enableVirtualNetwork;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings EnableEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings DisableEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ToggleEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = !toolSettings.EnableVirtualNetwork;
            return toolSettings;
        }
        #endregion
        #region IpRangeFilter
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/> to a new list.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/> to a new list.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings AddIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings AddIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ClearIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings RemoveIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings RemoveIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Kind
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Kind"/>.</em></p><p>The type of Cosmos DB database account to create.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetKind(this AzureCosmosdbCreateSettings toolSettings, CosmosdbCreateKind kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Kind"/>.</em></p><p>The type of Cosmos DB database account to create.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetKind(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Locations
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Locations"/>.</em></p><p>Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetLocations(this AzureCosmosdbCreateSettings toolSettings, string locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = locations;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Locations"/>.</em></p><p>Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetLocations(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = null;
            return toolSettings;
        }
        #endregion
        #region MaxInterval
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.MaxInterval"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetMaxInterval(this AzureCosmosdbCreateSettings toolSettings, string maxInterval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = maxInterval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.MaxInterval"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetMaxInterval(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = null;
            return toolSettings;
        }
        #endregion
        #region MaxStalenessPrefix
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.MaxStalenessPrefix"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetMaxStalenessPrefix(this AzureCosmosdbCreateSettings toolSettings, string maxStalenessPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = maxStalenessPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.MaxStalenessPrefix"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetMaxStalenessPrefix(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetTags(this AzureCosmosdbCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetTags(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetworkRules
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.VirtualNetworkRules"/>.</em></p><p>ACL's for virtual network.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetVirtualNetworkRules(this AzureCosmosdbCreateSettings toolSettings, string virtualNetworkRules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = virtualNetworkRules;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.VirtualNetworkRules"/>.</em></p><p>ACL's for virtual network.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetVirtualNetworkRules(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetDebug(this AzureCosmosdbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetDebug(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetHelp(this AzureCosmosdbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetHelp(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetOutput(this AzureCosmosdbCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetOutput(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetQuery(this AzureCosmosdbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetQuery(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetVerbose(this AzureCosmosdbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetVerbose(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetName(this AzureCosmosdbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetName(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetResourceGroup(this AzureCosmosdbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetResourceGroup(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetDebug(this AzureCosmosdbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetDebug(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetHelp(this AzureCosmosdbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetHelp(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetOutput(this AzureCosmosdbDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetOutput(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetQuery(this AzureCosmosdbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetQuery(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetVerbose(this AzureCosmosdbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetVerbose(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbFailoverPriorityChangeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbFailoverPriorityChangeSettingsExtensions
    {
        #region FailoverPolicies
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/>.</em></p><p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPolicies = failoverPolicies;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/>.</em></p><p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPolicies = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetName(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetName(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetResourceGroup(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetResourceGroup(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetDebug(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetDebug(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetHelp(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetHelp(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetOutput(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetOutput(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetQuery(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetQuery(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetVerbose(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetVerbose(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings SetResourceGroup(this AzureCosmosdbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetResourceGroup(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings SetDebug(this AzureCosmosdbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetDebug(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings SetHelp(this AzureCosmosdbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetHelp(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings SetOutput(this AzureCosmosdbListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetOutput(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings SetQuery(this AzureCosmosdbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetQuery(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings SetVerbose(this AzureCosmosdbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetVerbose(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListConnectionStringsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListConnectionStringsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetName(this AzureCosmosdbListConnectionStringsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetName(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetResourceGroup(this AzureCosmosdbListConnectionStringsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetResourceGroup(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetDebug(this AzureCosmosdbListConnectionStringsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetDebug(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetHelp(this AzureCosmosdbListConnectionStringsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetHelp(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetOutput(this AzureCosmosdbListConnectionStringsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetOutput(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetQuery(this AzureCosmosdbListConnectionStringsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetQuery(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetVerbose(this AzureCosmosdbListConnectionStringsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetVerbose(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListKeysSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListKeysSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetName(this AzureCosmosdbListKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetName(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetResourceGroup(this AzureCosmosdbListKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetResourceGroup(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetDebug(this AzureCosmosdbListKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetDebug(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetHelp(this AzureCosmosdbListKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetHelp(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetOutput(this AzureCosmosdbListKeysSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetOutput(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetQuery(this AzureCosmosdbListKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetQuery(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetVerbose(this AzureCosmosdbListKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetVerbose(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListReadOnlyKeysSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListReadOnlyKeysSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetName(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetName(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetResourceGroup(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetResourceGroup(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetDebug(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetDebug(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetHelp(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetHelp(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetOutput(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetOutput(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetQuery(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetQuery(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetVerbose(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetVerbose(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbRegenerateKeySettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbRegenerateKeySettingsExtensions
    {
        #region KeyKind
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.KeyKind"/>.</em></p><p>The access key to regenerate.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetKeyKind(this AzureCosmosdbRegenerateKeySettings toolSettings, CosmosdbRegenerateKeyKeyKind keyKind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyKind = keyKind;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.KeyKind"/>.</em></p><p>The access key to regenerate.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetKeyKind(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyKind = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetName(this AzureCosmosdbRegenerateKeySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetName(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetResourceGroup(this AzureCosmosdbRegenerateKeySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetResourceGroup(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetDebug(this AzureCosmosdbRegenerateKeySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetDebug(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetHelp(this AzureCosmosdbRegenerateKeySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetHelp(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetOutput(this AzureCosmosdbRegenerateKeySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetOutput(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetQuery(this AzureCosmosdbRegenerateKeySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetQuery(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetVerbose(this AzureCosmosdbRegenerateKeySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetVerbose(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetName(this AzureCosmosdbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetName(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetResourceGroup(this AzureCosmosdbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetResourceGroup(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetDebug(this AzureCosmosdbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetDebug(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetHelp(this AzureCosmosdbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetHelp(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetOutput(this AzureCosmosdbShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetOutput(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetQuery(this AzureCosmosdbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetQuery(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetVerbose(this AzureCosmosdbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetVerbose(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetName(this AzureCosmosdbUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Name"/>.</em></p><p>Name of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetName(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetResourceGroup(this AzureCosmosdbUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetResourceGroup(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Capabilities
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Capabilities"/>.</em></p><p>Set custom capabilities on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetCapabilities(this AzureCosmosdbUpdateSettings toolSettings, string capabilities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = capabilities;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Capabilities"/>.</em></p><p>Set custom capabilities on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetCapabilities(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = null;
            return toolSettings;
        }
        #endregion
        #region DefaultConsistencyLevel
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.DefaultConsistencyLevel"/>.</em></p><p>Default consistency level of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetDefaultConsistencyLevel(this AzureCosmosdbUpdateSettings toolSettings, CosmosdbDefaultConsistencyLevel defaultConsistencyLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = defaultConsistencyLevel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.DefaultConsistencyLevel"/>.</em></p><p>Default consistency level of the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetDefaultConsistencyLevel(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = null;
            return toolSettings;
        }
        #endregion
        #region EnableAutomaticFailover
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings, bool? enableAutomaticFailover)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = enableAutomaticFailover;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings EnableEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings DisableEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/>.</em></p><p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ToggleEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = !toolSettings.EnableAutomaticFailover;
            return toolSettings;
        }
        #endregion
        #region EnableVirtualNetwork
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings, bool? enableVirtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = enableVirtualNetwork;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings EnableEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings DisableEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/>.</em></p><p>Enables virtual network on the Cosmos DB database account.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ToggleEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = !toolSettings.EnableVirtualNetwork;
            return toolSettings;
        }
        #endregion
        #region IpRangeFilter
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/> to a new list.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/> to a new list.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings AddIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings AddIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ClearIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings RemoveIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/>.</em></p><p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings RemoveIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Locations
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Locations"/>.</em></p><p>Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetLocations(this AzureCosmosdbUpdateSettings toolSettings, string locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = locations;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Locations"/>.</em></p><p>Space-separated locations in 'regionName=failoverPriority' format. E.g eastus=0 westus=1. Failover priority values are 0 for write regions and greater than 0 for read regions. A failover priority value must be unique and less than the total number of regions. Default: single region account in the location of the specified resource group.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetLocations(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = null;
            return toolSettings;
        }
        #endregion
        #region MaxInterval
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.MaxInterval"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetMaxInterval(this AzureCosmosdbUpdateSettings toolSettings, string maxInterval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = maxInterval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.MaxInterval"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetMaxInterval(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = null;
            return toolSettings;
        }
        #endregion
        #region MaxStalenessPrefix
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.MaxStalenessPrefix"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetMaxStalenessPrefix(this AzureCosmosdbUpdateSettings toolSettings, string maxStalenessPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = maxStalenessPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.MaxStalenessPrefix"/>.</em></p><p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetMaxStalenessPrefix(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetTags(this AzureCosmosdbUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetTags(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetworkRules
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.VirtualNetworkRules"/>.</em></p><p>ACL's for virtual network.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetVirtualNetworkRules(this AzureCosmosdbUpdateSettings toolSettings, string virtualNetworkRules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = virtualNetworkRules;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.VirtualNetworkRules"/>.</em></p><p>ACL's for virtual network.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetVirtualNetworkRules(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetDebug(this AzureCosmosdbUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetDebug(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetHelp(this AzureCosmosdbUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetHelp(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetOutput(this AzureCosmosdbUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetOutput(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetQuery(this AzureCosmosdbUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetQuery(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetVerbose(this AzureCosmosdbUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetVerbose(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionCreateSettingsExtensions
    {
        #region CollectionName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetCollectionName(this AzureCosmosdbCollectionCreateSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetCollectionName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetDbName(this AzureCosmosdbCollectionCreateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetDbName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DefaultTtl
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.DefaultTtl"/>.</em></p><p>Default TTL.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetDefaultTtl(this AzureCosmosdbCollectionCreateSettings toolSettings, string defaultTtl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = defaultTtl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.DefaultTtl"/>.</em></p><p>Default TTL.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetDefaultTtl(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = null;
            return toolSettings;
        }
        #endregion
        #region IndexingPolicy
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.IndexingPolicy"/>.</em></p><p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetIndexingPolicy(this AzureCosmosdbCollectionCreateSettings toolSettings, string indexingPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = indexingPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.IndexingPolicy"/>.</em></p><p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetIndexingPolicy(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = null;
            return toolSettings;
        }
        #endregion
        #region PartitionKeyPath
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.PartitionKeyPath"/>.</em></p><p>Partition Key Path, e.g., '/properties/name'.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetPartitionKeyPath(this AzureCosmosdbCollectionCreateSettings toolSettings, string partitionKeyPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionKeyPath = partitionKeyPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.PartitionKeyPath"/>.</em></p><p>Partition Key Path, e.g., '/properties/name'.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetPartitionKeyPath(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionKeyPath = null;
            return toolSettings;
        }
        #endregion
        #region Throughput
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Throughput"/>.</em></p><p>Offer Throughput.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetThroughput(this AzureCosmosdbCollectionCreateSettings toolSettings, string throughput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = throughput;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Throughput"/>.</em></p><p>Offer Throughput.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetThroughput(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetKey(this AzureCosmosdbCollectionCreateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetKey(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetName(this AzureCosmosdbCollectionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetResourceGroupName(this AzureCosmosdbCollectionCreateSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetResourceGroupName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetUrlConnection(this AzureCosmosdbCollectionCreateSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetUrlConnection(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetDebug(this AzureCosmosdbCollectionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetDebug(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetHelp(this AzureCosmosdbCollectionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetHelp(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetOutput(this AzureCosmosdbCollectionCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetOutput(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetQuery(this AzureCosmosdbCollectionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetQuery(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetVerbose(this AzureCosmosdbCollectionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetVerbose(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionDeleteSettingsExtensions
    {
        #region CollectionName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetCollectionName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetCollectionName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetDbName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetDbName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetKey(this AzureCosmosdbCollectionDeleteSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetKey(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetResourceGroupName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetResourceGroupName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetUrlConnection(this AzureCosmosdbCollectionDeleteSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetUrlConnection(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetDebug(this AzureCosmosdbCollectionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetDebug(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetHelp(this AzureCosmosdbCollectionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetHelp(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetOutput(this AzureCosmosdbCollectionDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetOutput(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetQuery(this AzureCosmosdbCollectionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetQuery(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetVerbose(this AzureCosmosdbCollectionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetVerbose(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionExistsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionExistsSettingsExtensions
    {
        #region CollectionName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetCollectionName(this AzureCosmosdbCollectionExistsSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetCollectionName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetDbName(this AzureCosmosdbCollectionExistsSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetDbName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetKey(this AzureCosmosdbCollectionExistsSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetKey(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetName(this AzureCosmosdbCollectionExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetResourceGroupName(this AzureCosmosdbCollectionExistsSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetResourceGroupName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetUrlConnection(this AzureCosmosdbCollectionExistsSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetUrlConnection(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetDebug(this AzureCosmosdbCollectionExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetDebug(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetHelp(this AzureCosmosdbCollectionExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetHelp(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetOutput(this AzureCosmosdbCollectionExistsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetOutput(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetQuery(this AzureCosmosdbCollectionExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetQuery(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetVerbose(this AzureCosmosdbCollectionExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetVerbose(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionListSettingsExtensions
    {
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetDbName(this AzureCosmosdbCollectionListSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetDbName(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetKey(this AzureCosmosdbCollectionListSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetKey(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetName(this AzureCosmosdbCollectionListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetName(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetResourceGroupName(this AzureCosmosdbCollectionListSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetResourceGroupName(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetUrlConnection(this AzureCosmosdbCollectionListSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetUrlConnection(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetDebug(this AzureCosmosdbCollectionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetDebug(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetHelp(this AzureCosmosdbCollectionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetHelp(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetOutput(this AzureCosmosdbCollectionListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetOutput(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetQuery(this AzureCosmosdbCollectionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetQuery(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetVerbose(this AzureCosmosdbCollectionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetVerbose(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionShowSettingsExtensions
    {
        #region CollectionName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetCollectionName(this AzureCosmosdbCollectionShowSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetCollectionName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetDbName(this AzureCosmosdbCollectionShowSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetDbName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetKey(this AzureCosmosdbCollectionShowSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetKey(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetName(this AzureCosmosdbCollectionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetResourceGroupName(this AzureCosmosdbCollectionShowSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetResourceGroupName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetUrlConnection(this AzureCosmosdbCollectionShowSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetUrlConnection(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetDebug(this AzureCosmosdbCollectionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetDebug(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetHelp(this AzureCosmosdbCollectionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetHelp(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetOutput(this AzureCosmosdbCollectionShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetOutput(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetQuery(this AzureCosmosdbCollectionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetQuery(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetVerbose(this AzureCosmosdbCollectionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetVerbose(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionUpdateSettingsExtensions
    {
        #region CollectionName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetCollectionName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.CollectionName"/>.</em></p><p>Collection Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetCollectionName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetDbName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetDbName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DefaultTtl
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.DefaultTtl"/>.</em></p><p>Default TTL.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetDefaultTtl(this AzureCosmosdbCollectionUpdateSettings toolSettings, string defaultTtl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = defaultTtl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.DefaultTtl"/>.</em></p><p>Default TTL.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetDefaultTtl(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = null;
            return toolSettings;
        }
        #endregion
        #region IndexingPolicy
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.IndexingPolicy"/>.</em></p><p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetIndexingPolicy(this AzureCosmosdbCollectionUpdateSettings toolSettings, string indexingPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = indexingPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.IndexingPolicy"/>.</em></p><p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetIndexingPolicy(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = null;
            return toolSettings;
        }
        #endregion
        #region Throughput
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Throughput"/>.</em></p><p>Offer Throughput.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetThroughput(this AzureCosmosdbCollectionUpdateSettings toolSettings, string throughput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = throughput;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Throughput"/>.</em></p><p>Offer Throughput.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetThroughput(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetKey(this AzureCosmosdbCollectionUpdateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetKey(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetResourceGroupName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetResourceGroupName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetUrlConnection(this AzureCosmosdbCollectionUpdateSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetUrlConnection(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetDebug(this AzureCosmosdbCollectionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetDebug(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetHelp(this AzureCosmosdbCollectionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetHelp(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetOutput(this AzureCosmosdbCollectionUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetOutput(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetQuery(this AzureCosmosdbCollectionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetQuery(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetVerbose(this AzureCosmosdbCollectionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetVerbose(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseCreateSettingsExtensions
    {
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetDbName(this AzureCosmosdbDatabaseCreateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetDbName(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetKey(this AzureCosmosdbDatabaseCreateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetKey(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetName(this AzureCosmosdbDatabaseCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetName(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetResourceGroupName(this AzureCosmosdbDatabaseCreateSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetResourceGroupName(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetUrlConnection(this AzureCosmosdbDatabaseCreateSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetUrlConnection(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetDebug(this AzureCosmosdbDatabaseCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetDebug(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetHelp(this AzureCosmosdbDatabaseCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetHelp(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetOutput(this AzureCosmosdbDatabaseCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetOutput(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetQuery(this AzureCosmosdbDatabaseCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetQuery(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetVerbose(this AzureCosmosdbDatabaseCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetVerbose(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseDeleteSettingsExtensions
    {
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetDbName(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetDbName(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetKey(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetKey(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetName(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetName(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetResourceGroupName(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetResourceGroupName(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetUrlConnection(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetUrlConnection(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetDebug(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetDebug(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetHelp(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetHelp(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetOutput(this AzureCosmosdbDatabaseDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetOutput(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetQuery(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetQuery(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetVerbose(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetVerbose(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseExistsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseExistsSettingsExtensions
    {
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetDbName(this AzureCosmosdbDatabaseExistsSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetDbName(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetKey(this AzureCosmosdbDatabaseExistsSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetKey(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetName(this AzureCosmosdbDatabaseExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetName(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetResourceGroupName(this AzureCosmosdbDatabaseExistsSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetResourceGroupName(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetUrlConnection(this AzureCosmosdbDatabaseExistsSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetUrlConnection(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetDebug(this AzureCosmosdbDatabaseExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetDebug(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetHelp(this AzureCosmosdbDatabaseExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetHelp(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetOutput(this AzureCosmosdbDatabaseExistsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetOutput(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetQuery(this AzureCosmosdbDatabaseExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetQuery(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetVerbose(this AzureCosmosdbDatabaseExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetVerbose(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseListSettingsExtensions
    {
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetKey(this AzureCosmosdbDatabaseListSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetKey(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetName(this AzureCosmosdbDatabaseListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetName(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetResourceGroupName(this AzureCosmosdbDatabaseListSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetResourceGroupName(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetUrlConnection(this AzureCosmosdbDatabaseListSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetUrlConnection(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetDebug(this AzureCosmosdbDatabaseListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetDebug(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetHelp(this AzureCosmosdbDatabaseListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetHelp(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetOutput(this AzureCosmosdbDatabaseListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetOutput(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetQuery(this AzureCosmosdbDatabaseListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetQuery(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetVerbose(this AzureCosmosdbDatabaseListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetVerbose(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseShowSettingsExtensions
    {
        #region DbName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetDbName(this AzureCosmosdbDatabaseShowSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.DbName"/>.</em></p><p>Database Name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetDbName(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetKey(this AzureCosmosdbDatabaseShowSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Key"/>.</em></p><p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetKey(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetName(this AzureCosmosdbDatabaseShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Name"/>.</em></p><p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetName(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetResourceGroupName(this AzureCosmosdbDatabaseShowSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.ResourceGroupName"/>.</em></p><p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetResourceGroupName(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetUrlConnection(this AzureCosmosdbDatabaseShowSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.UrlConnection"/>.</em></p><p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetUrlConnection(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetDebug(this AzureCosmosdbDatabaseShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetDebug(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetHelp(this AzureCosmosdbDatabaseShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetHelp(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetOutput(this AzureCosmosdbDatabaseShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetOutput(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetQuery(this AzureCosmosdbDatabaseShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetQuery(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetVerbose(this AzureCosmosdbDatabaseShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetVerbose(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region CosmosdbDefaultConsistencyLevel
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class CosmosdbDefaultConsistencyLevel : Enumeration
    {
        public static CosmosdbDefaultConsistencyLevel boundedstaleness = new CosmosdbDefaultConsistencyLevel { Value = "boundedstaleness" };
        public static CosmosdbDefaultConsistencyLevel consistentprefix = new CosmosdbDefaultConsistencyLevel { Value = "consistentprefix" };
        public static CosmosdbDefaultConsistencyLevel eventual = new CosmosdbDefaultConsistencyLevel { Value = "eventual" };
        public static CosmosdbDefaultConsistencyLevel session = new CosmosdbDefaultConsistencyLevel { Value = "session" };
        public static CosmosdbDefaultConsistencyLevel strong = new CosmosdbDefaultConsistencyLevel { Value = "strong" };
    }
    #endregion
    #region CosmosdbCreateKind
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class CosmosdbCreateKind : Enumeration
    {
        public static CosmosdbCreateKind globaldocumentdb = new CosmosdbCreateKind { Value = "globaldocumentdb" };
        public static CosmosdbCreateKind mongodb = new CosmosdbCreateKind { Value = "mongodb" };
        public static CosmosdbCreateKind parse = new CosmosdbCreateKind { Value = "parse" };
    }
    #endregion
    #region CosmosdbRegenerateKeyKeyKind
    /// <summary><p>Used within <see cref="AzureCosmosdbTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class CosmosdbRegenerateKeyKeyKind : Enumeration
    {
        public static CosmosdbRegenerateKeyKeyKind primary = new CosmosdbRegenerateKeyKeyKind { Value = "primary" };
        public static CosmosdbRegenerateKeyKeyKind primaryreadonly = new CosmosdbRegenerateKeyKeyKind { Value = "primaryreadonly" };
        public static CosmosdbRegenerateKeyKeyKind secondary = new CosmosdbRegenerateKeyKeyKind { Value = "secondary" };
        public static CosmosdbRegenerateKeyKeyKind secondaryreadonly = new CosmosdbRegenerateKeyKeyKind { Value = "secondaryreadonly" };
    }
    #endregion
}
