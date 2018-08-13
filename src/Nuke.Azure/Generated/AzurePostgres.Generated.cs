// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.1 [CommitSha: 8eca516b].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzurePostgres.json.

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
    public static partial class AzurePostgresTasks
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public static string AzurePostgresPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgres(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzurePostgresPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgres(Configure<AzurePostgresSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerCreate(Configure<AzurePostgresServerCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerDelete(Configure<AzurePostgresServerDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerGeorestore(Configure<AzurePostgresServerGeorestoreSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerGeorestoreSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerList(Configure<AzurePostgresServerListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerRestore(Configure<AzurePostgresServerRestoreSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerRestoreSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerShow(Configure<AzurePostgresServerShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerUpdate(Configure<AzurePostgresServerUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerWait(Configure<AzurePostgresServerWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbCreate(Configure<AzurePostgresDbCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresDbCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbDelete(Configure<AzurePostgresDbDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresDbDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbList(Configure<AzurePostgresDbListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresDbListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresDbShow(Configure<AzurePostgresDbShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresDbShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerLogsDownload(Configure<AzurePostgresServerLogsDownloadSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerLogsDownloadSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerLogsList(Configure<AzurePostgresServerLogsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerLogsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleCreate(Configure<AzurePostgresServerFirewallRuleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerFirewallRuleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleDelete(Configure<AzurePostgresServerFirewallRuleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerFirewallRuleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleList(Configure<AzurePostgresServerFirewallRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerFirewallRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleShow(Configure<AzurePostgresServerFirewallRuleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerFirewallRuleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerFirewallRuleUpdate(Configure<AzurePostgresServerFirewallRuleUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerFirewallRuleUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationList(Configure<AzurePostgresServerConfigurationListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerConfigurationListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationSet(Configure<AzurePostgresServerConfigurationSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerConfigurationSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerConfigurationShow(Configure<AzurePostgresServerConfigurationShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerConfigurationShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleCreate(Configure<AzurePostgresServerVnetRuleCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerVnetRuleCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleDelete(Configure<AzurePostgresServerVnetRuleDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerVnetRuleDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleList(Configure<AzurePostgresServerVnetRuleListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerVnetRuleListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleShow(Configure<AzurePostgresServerVnetRuleShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerVnetRuleShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Database for PostgreSQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/postgres?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzurePostgresServerVnetRuleUpdate(Configure<AzurePostgresServerVnetRuleUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePostgresServerVnetRuleUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzurePostgresSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
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
              .Add("postgres")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerCreateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        public virtual string SkuName { get; internal set; }
        /// <summary><p>The number of days a backup is retained.</p></summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary><p>Enable Geo-redundant or not for server backup.</p></summary>
        public virtual string GeoRedundantBackup { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Enable ssl enforcement or not when connect to server.</p></summary>
        public virtual PostgresServerSslEnforcement SslEnforcement { get; internal set; }
        /// <summary><p>The max storage size of the server. Unit is megabytes.</p></summary>
        public virtual string StorageSize { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Server version.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string AdminUser { get; internal set; }
        /// <summary><p>The password of the administrator login.</p></summary>
        public virtual string AdminPassword { get; internal set; }
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
              .Add("postgres server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku-name {value}", SkuName)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--geo-redundant-backup {value}", GeoRedundantBackup)
              .Add("--location {value}", Location)
              .Add("--ssl-enforcement {value}", SslEnforcement)
              .Add("--storage-size {value}", StorageSize)
              .Add("--tags {value}", Tags)
              .Add("--version {value}", Version)
              .Add("--admin-user {value}", AdminUser)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerDeleteSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("postgres server delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--yes {value}", Yes)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerGeorestoreSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerGeorestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name or ID of the source server to restore from.</p></summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary><p>The max days of retention, unit is days.</p></summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary><p>Enable Geo-redundant or not for server backup.</p></summary>
        public virtual string GeoRedundantBackup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        public virtual string SkuName { get; internal set; }
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
              .Add("postgres server georestore")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source-server {value}", SourceServer)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--geo-redundant-backup {value}", GeoRedundantBackup)
              .Add("--no-wait {value}", NoWait)
              .Add("--sku-name {value}", SkuName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerListSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("postgres server list")
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
    #region AzurePostgresServerRestoreSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerRestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p></summary>
        public virtual string RestorePointInTime { get; internal set; }
        /// <summary><p>The name or ID of the source server to restore from.</p></summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("postgres server restore")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--restore-point-in-time {value}", RestorePointInTime)
              .Add("--source-server {value}", SourceServer)
              .Add("--no-wait {value}", NoWait)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerShowSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("postgres server show")
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
    #region AzurePostgresServerUpdateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The password of the administrator login.</p></summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary><p>The number of days a backup is retained.</p></summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        public virtual string SkuName { get; internal set; }
        /// <summary><p>Enable ssl enforcement or not when connect to server.</p></summary>
        public virtual PostgresServerSslEnforcement SslEnforcement { get; internal set; }
        /// <summary><p>The max storage size of the server. Unit is megabytes.</p></summary>
        public virtual string StorageSize { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        public virtual string ForceString { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
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
              .Add("postgres server update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--sku-name {value}", SkuName)
              .Add("--ssl-enforcement {value}", SslEnforcement)
              .Add("--storage-size {value}", StorageSize)
              .Add("--tags {value}", Tags)
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
    #region AzurePostgresServerWaitSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        public virtual string Custom { get; internal set; }
        /// <summary><p>Wait until the resource exists.</p></summary>
        public virtual string Exists { get; internal set; }
        /// <summary><p>Polling interval in seconds.</p></summary>
        public virtual string Interval { get; internal set; }
        /// <summary><p>Maximum wait in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
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
              .Add("postgres server wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--custom {value}", Custom)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresDbCreateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the database.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>The charset of the database.</p></summary>
        public virtual string Charset { get; internal set; }
        /// <summary><p>The collation of the database.</p></summary>
        public virtual string Collation { get; internal set; }
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
              .Add("postgres db create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--charset {value}", Charset)
              .Add("--collation {value}", Collation)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresDbDeleteSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the database.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("postgres db delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--yes {value}", Yes)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresDbListSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres db list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresDbShowSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresDbShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the database.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres db show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerLogsDownloadSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerLogsDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Space-separated list of log filenames on the server to download.</p></summary>
        public virtual IReadOnlyList<string> Name => NameInternal.AsReadOnly();
        internal List<string> NameInternal { get; set; } = new List<string>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server-logs download")
              .Add("--name {value}", Name, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerLogsListSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerLogsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Integer in hours to indicate file last modify time, default value is 72.</p></summary>
        public virtual string FileLastWritten { get; internal set; }
        /// <summary><p>The pattern that file name should match.</p></summary>
        public virtual string FilenameContains { get; internal set; }
        /// <summary><p>The file size limitation to filter files.</p></summary>
        public virtual string MaxFileSize { get; internal set; }
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
              .Add("postgres server-logs list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--file-last-written {value}", FileLastWritten)
              .Add("--filename-contains {value}", FilenameContains)
              .Add("--max-file-size {value}", MaxFileSize)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerFirewallRuleCreateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
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
              .Add("postgres server firewall-rule create")
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--start-ip-address {value}", StartIpAddress)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerFirewallRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("postgres server firewall-rule delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--yes {value}", Yes)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerFirewallRuleListSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server firewall-rule list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerFirewallRuleShowSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server firewall-rule show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerFirewallRuleUpdateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerFirewallRuleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        public virtual string ForceString { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
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
              .Add("postgres server firewall-rule update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--start-ip-address {value}", StartIpAddress)
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
    #region AzurePostgresServerConfigurationListSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerConfigurationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server configuration list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerConfigurationSetSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerConfigurationSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the server configuration.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Value of the configuration. If not provided, configuration value will be set to default.</p></summary>
        public virtual string Value { get; internal set; }
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
              .Add("postgres server configuration set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--value {value}", Value)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerConfigurationShowSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerConfigurationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the server configuration.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server configuration show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerVnetRuleCreateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the vnet rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        public virtual bool? IgnoreMissingEndpoint { get; internal set; }
        /// <summary><p>The virtual network name.</p></summary>
        public virtual string VnetName { get; internal set; }
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
              .Add("postgres server vnet-rule create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--subnet {value}", Subnet)
              .Add("--ignore-missing-endpoint", IgnoreMissingEndpoint)
              .Add("--vnet-name {value}", VnetName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerVnetRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the vnet rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerVnetRuleListSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerVnetRuleShowSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the vnet rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("postgres server vnet-rule show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePostgresServerVnetRuleUpdateSettings
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePostgresServerVnetRuleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePostgres executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePostgresTasks.AzurePostgresPath;
        /// <summary><p>The name of the vnet rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        public virtual bool? IgnoreMissingEndpoint { get; internal set; }
        /// <summary><p>The virtual network name.</p></summary>
        public virtual string VnetName { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        public virtual string ForceString { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
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
              .Add("postgres server vnet-rule update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--subnet {value}", Subnet)
              .Add("--ignore-missing-endpoint", IgnoreMissingEndpoint)
              .Add("--vnet-name {value}", VnetName)
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
    #region AzurePostgresSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresSettings SetDebug(this AzurePostgresSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresSettings ResetDebug(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresSettings SetHelp(this AzurePostgresSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresSettings ResetHelp(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresSettings SetOutput(this AzurePostgresSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresSettings ResetOutput(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresSettings SetQuery(this AzurePostgresSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresSettings ResetQuery(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresSettings SetVerbose(this AzurePostgresSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresSettings ResetVerbose(this AzurePostgresSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetName(this AzurePostgresServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetName(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetResourceGroup(this AzurePostgresServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetResourceGroup(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetSkuName(this AzurePostgresServerCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetSkuName(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetBackupRetention(this AzurePostgresServerCreateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetBackupRetention(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetGeoRedundantBackup(this AzurePostgresServerCreateSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetGeoRedundantBackup(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetLocation(this AzurePostgresServerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetLocation(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetSslEnforcement(this AzurePostgresServerCreateSettings toolSettings, PostgresServerSslEnforcement sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetSslEnforcement(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetStorageSize(this AzurePostgresServerCreateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetStorageSize(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetTags(this AzurePostgresServerCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetTags(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Version"/>.</em></p><p>Server version.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetVersion(this AzurePostgresServerCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Version"/>.</em></p><p>Server version.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetVersion(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region AdminUser
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.AdminUser"/>.</em></p><p></p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetAdminUser(this AzurePostgresServerCreateSettings toolSettings, string adminUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = adminUser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.AdminUser"/>.</em></p><p></p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetAdminUser(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetAdminPassword(this AzurePostgresServerCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetAdminPassword(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetDebug(this AzurePostgresServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetDebug(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetHelp(this AzurePostgresServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetHelp(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetOutput(this AzurePostgresServerCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetOutput(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetQuery(this AzurePostgresServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetQuery(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings SetVerbose(this AzurePostgresServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerCreateSettings ResetVerbose(this AzurePostgresServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetName(this AzurePostgresServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetName(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetResourceGroup(this AzurePostgresServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetResourceGroup(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetYes(this AzurePostgresServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetYes(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetDebug(this AzurePostgresServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetDebug(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetHelp(this AzurePostgresServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetHelp(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetOutput(this AzurePostgresServerDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetOutput(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetQuery(this AzurePostgresServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetQuery(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings SetVerbose(this AzurePostgresServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerDeleteSettings ResetVerbose(this AzurePostgresServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerGeorestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerGeorestoreSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetLocation(this AzurePostgresServerGeorestoreSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetLocation(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetName(this AzurePostgresServerGeorestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetName(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetResourceGroup(this AzurePostgresServerGeorestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetResourceGroup(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetSourceServer(this AzurePostgresServerGeorestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetSourceServer(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.BackupRetention"/>.</em></p><p>The max days of retention, unit is days.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetBackupRetention(this AzurePostgresServerGeorestoreSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.BackupRetention"/>.</em></p><p>The max days of retention, unit is days.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetBackupRetention(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetGeoRedundantBackup(this AzurePostgresServerGeorestoreSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetGeoRedundantBackup(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetNoWait(this AzurePostgresServerGeorestoreSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetNoWait(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetSkuName(this AzurePostgresServerGeorestoreSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetSkuName(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetDebug(this AzurePostgresServerGeorestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetDebug(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetHelp(this AzurePostgresServerGeorestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetHelp(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetOutput(this AzurePostgresServerGeorestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetOutput(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetQuery(this AzurePostgresServerGeorestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetQuery(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerGeorestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings SetVerbose(this AzurePostgresServerGeorestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerGeorestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerGeorestoreSettings ResetVerbose(this AzurePostgresServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings SetResourceGroup(this AzurePostgresServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetResourceGroup(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings SetDebug(this AzurePostgresServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetDebug(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings SetHelp(this AzurePostgresServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetHelp(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings SetOutput(this AzurePostgresServerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetOutput(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings SetQuery(this AzurePostgresServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetQuery(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings SetVerbose(this AzurePostgresServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerListSettings ResetVerbose(this AzurePostgresServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerRestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerRestoreSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetName(this AzurePostgresServerRestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetName(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetResourceGroup(this AzurePostgresServerRestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetResourceGroup(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RestorePointInTime
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.RestorePointInTime"/>.</em></p><p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetRestorePointInTime(this AzurePostgresServerRestoreSettings toolSettings, string restorePointInTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = restorePointInTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.RestorePointInTime"/>.</em></p><p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetRestorePointInTime(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetSourceServer(this AzurePostgresServerRestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetSourceServer(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetNoWait(this AzurePostgresServerRestoreSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetNoWait(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetDebug(this AzurePostgresServerRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetDebug(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetHelp(this AzurePostgresServerRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetHelp(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetOutput(this AzurePostgresServerRestoreSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetOutput(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetQuery(this AzurePostgresServerRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetQuery(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings SetVerbose(this AzurePostgresServerRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerRestoreSettings ResetVerbose(this AzurePostgresServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetName(this AzurePostgresServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetName(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetResourceGroup(this AzurePostgresServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetResourceGroup(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetDebug(this AzurePostgresServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetDebug(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetHelp(this AzurePostgresServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetHelp(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetOutput(this AzurePostgresServerShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetOutput(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetQuery(this AzurePostgresServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetQuery(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings SetVerbose(this AzurePostgresServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerShowSettings ResetVerbose(this AzurePostgresServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetName(this AzurePostgresServerUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetName(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetResourceGroup(this AzurePostgresServerUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetResourceGroup(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetAdminPassword(this AzurePostgresServerUpdateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetAdminPassword(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetBackupRetention(this AzurePostgresServerUpdateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetBackupRetention(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSkuName(this AzurePostgresServerUpdateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSkuName(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSslEnforcement(this AzurePostgresServerUpdateSettings toolSettings, PostgresServerSslEnforcement sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSslEnforcement(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetStorageSize(this AzurePostgresServerUpdateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetStorageSize(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetTags(this AzurePostgresServerUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetTags(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetAdd(this AzurePostgresServerUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetAdd(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetForceString(this AzurePostgresServerUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetForceString(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetRemove(this AzurePostgresServerUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetRemove(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetSet(this AzurePostgresServerUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetSet(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetDebug(this AzurePostgresServerUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetDebug(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetHelp(this AzurePostgresServerUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetHelp(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetOutput(this AzurePostgresServerUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetOutput(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetQuery(this AzurePostgresServerUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetQuery(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings SetVerbose(this AzurePostgresServerUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerUpdateSettings ResetVerbose(this AzurePostgresServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetName(this AzurePostgresServerWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetName(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetResourceGroup(this AzurePostgresServerWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetResourceGroup(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetCustom(this AzurePostgresServerWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetCustom(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetExists(this AzurePostgresServerWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetExists(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetInterval(this AzurePostgresServerWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetInterval(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetTimeout(this AzurePostgresServerWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetTimeout(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetDebug(this AzurePostgresServerWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetDebug(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetHelp(this AzurePostgresServerWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetHelp(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetOutput(this AzurePostgresServerWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetOutput(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetQuery(this AzurePostgresServerWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetQuery(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings SetVerbose(this AzurePostgresServerWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerWaitSettings ResetVerbose(this AzurePostgresServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetName(this AzurePostgresDbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetName(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetResourceGroup(this AzurePostgresDbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetResourceGroup(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetServerName(this AzurePostgresDbCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetServerName(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Charset
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Charset"/>.</em></p><p>The charset of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetCharset(this AzurePostgresDbCreateSettings toolSettings, string charset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = charset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Charset"/>.</em></p><p>The charset of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetCharset(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = null;
            return toolSettings;
        }
        #endregion
        #region Collation
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Collation"/>.</em></p><p>The collation of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetCollation(this AzurePostgresDbCreateSettings toolSettings, string collation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = collation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Collation"/>.</em></p><p>The collation of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetCollation(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetDebug(this AzurePostgresDbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetDebug(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetHelp(this AzurePostgresDbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetHelp(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetOutput(this AzurePostgresDbCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetOutput(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetQuery(this AzurePostgresDbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetQuery(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresDbCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings SetVerbose(this AzurePostgresDbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbCreateSettings ResetVerbose(this AzurePostgresDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetName(this AzurePostgresDbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetName(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetResourceGroup(this AzurePostgresDbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetResourceGroup(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetServerName(this AzurePostgresDbDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetServerName(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetYes(this AzurePostgresDbDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetYes(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetDebug(this AzurePostgresDbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetDebug(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetHelp(this AzurePostgresDbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetHelp(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetOutput(this AzurePostgresDbDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetOutput(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetQuery(this AzurePostgresDbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetQuery(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresDbDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings SetVerbose(this AzurePostgresDbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbDeleteSettings ResetVerbose(this AzurePostgresDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetResourceGroup(this AzurePostgresDbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetResourceGroup(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetServerName(this AzurePostgresDbListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetServerName(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetDebug(this AzurePostgresDbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetDebug(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetHelp(this AzurePostgresDbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetHelp(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetOutput(this AzurePostgresDbListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetOutput(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetQuery(this AzurePostgresDbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetQuery(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresDbListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings SetVerbose(this AzurePostgresDbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbListSettings ResetVerbose(this AzurePostgresDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresDbShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresDbShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetName(this AzurePostgresDbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetName(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetResourceGroup(this AzurePostgresDbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetResourceGroup(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetServerName(this AzurePostgresDbShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetServerName(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetDebug(this AzurePostgresDbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetDebug(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetHelp(this AzurePostgresDbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetHelp(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetOutput(this AzurePostgresDbShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetOutput(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetQuery(this AzurePostgresDbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetQuery(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresDbShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings SetVerbose(this AzurePostgresDbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresDbShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresDbShowSettings ResetVerbose(this AzurePostgresDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerLogsDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerLogsDownloadSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Name"/> to a new list.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetName(this AzurePostgresServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Name"/> to a new list.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetName(this AzurePostgresServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzurePostgresServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings AddName(this AzurePostgresServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzurePostgresServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings AddName(this AzurePostgresServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzurePostgresServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ClearName(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzurePostgresServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings RemoveName(this AzurePostgresServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzurePostgresServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings RemoveName(this AzurePostgresServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetResourceGroup(this AzurePostgresServerLogsDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetResourceGroup(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetServerName(this AzurePostgresServerLogsDownloadSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetServerName(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetDebug(this AzurePostgresServerLogsDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetDebug(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetHelp(this AzurePostgresServerLogsDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetHelp(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetOutput(this AzurePostgresServerLogsDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetOutput(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetQuery(this AzurePostgresServerLogsDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetQuery(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings SetVerbose(this AzurePostgresServerLogsDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsDownloadSettings ResetVerbose(this AzurePostgresServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerLogsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerLogsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetResourceGroup(this AzurePostgresServerLogsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetResourceGroup(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetServerName(this AzurePostgresServerLogsListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetServerName(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region FileLastWritten
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.FileLastWritten"/>.</em></p><p>Integer in hours to indicate file last modify time, default value is 72.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetFileLastWritten(this AzurePostgresServerLogsListSettings toolSettings, string fileLastWritten)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = fileLastWritten;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.FileLastWritten"/>.</em></p><p>Integer in hours to indicate file last modify time, default value is 72.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetFileLastWritten(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = null;
            return toolSettings;
        }
        #endregion
        #region FilenameContains
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.FilenameContains"/>.</em></p><p>The pattern that file name should match.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetFilenameContains(this AzurePostgresServerLogsListSettings toolSettings, string filenameContains)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = filenameContains;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.FilenameContains"/>.</em></p><p>The pattern that file name should match.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetFilenameContains(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = null;
            return toolSettings;
        }
        #endregion
        #region MaxFileSize
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.MaxFileSize"/>.</em></p><p>The file size limitation to filter files.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetMaxFileSize(this AzurePostgresServerLogsListSettings toolSettings, string maxFileSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = maxFileSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.MaxFileSize"/>.</em></p><p>The file size limitation to filter files.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetMaxFileSize(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetDebug(this AzurePostgresServerLogsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetDebug(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetHelp(this AzurePostgresServerLogsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetHelp(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetOutput(this AzurePostgresServerLogsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetOutput(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetQuery(this AzurePostgresServerLogsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetQuery(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerLogsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings SetVerbose(this AzurePostgresServerLogsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerLogsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerLogsListSettings ResetVerbose(this AzurePostgresServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleCreateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetEndIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetEndIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetResourceGroup(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetServerName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetServerName(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetStartIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetStartIpAddress(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetDebug(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetDebug(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetHelp(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetHelp(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetOutput(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetOutput(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetQuery(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetQuery(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings SetVerbose(this AzurePostgresServerFirewallRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleCreateSettings ResetVerbose(this AzurePostgresServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetResourceGroup(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetServerName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetServerName(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetYes(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetYes(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetDebug(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetDebug(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetHelp(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetHelp(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetOutput(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetOutput(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetQuery(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetQuery(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings SetVerbose(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleDeleteSettings ResetVerbose(this AzurePostgresServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetResourceGroup(this AzurePostgresServerFirewallRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetServerName(this AzurePostgresServerFirewallRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetServerName(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetDebug(this AzurePostgresServerFirewallRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetDebug(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetHelp(this AzurePostgresServerFirewallRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetHelp(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetOutput(this AzurePostgresServerFirewallRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetOutput(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetQuery(this AzurePostgresServerFirewallRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetQuery(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings SetVerbose(this AzurePostgresServerFirewallRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleListSettings ResetVerbose(this AzurePostgresServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetName(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetName(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetResourceGroup(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetServerName(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetServerName(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetDebug(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetDebug(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetHelp(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetHelp(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetOutput(this AzurePostgresServerFirewallRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetOutput(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetQuery(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetQuery(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings SetVerbose(this AzurePostgresServerFirewallRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleShowSettings ResetVerbose(this AzurePostgresServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerFirewallRuleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerFirewallRuleUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetResourceGroup(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetResourceGroup(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetServerName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetServerName(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetEndIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetEndIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetStartIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetStartIpAddress(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetAdd(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetAdd(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetForceString(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetForceString(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetRemove(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetRemove(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetSet(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetSet(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetDebug(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetDebug(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetHelp(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetHelp(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetOutput(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetOutput(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetQuery(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetQuery(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings SetVerbose(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerFirewallRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerFirewallRuleUpdateSettings ResetVerbose(this AzurePostgresServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerConfigurationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerConfigurationListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetResourceGroup(this AzurePostgresServerConfigurationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetResourceGroup(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetServerName(this AzurePostgresServerConfigurationListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetServerName(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetDebug(this AzurePostgresServerConfigurationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetDebug(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetHelp(this AzurePostgresServerConfigurationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetHelp(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetOutput(this AzurePostgresServerConfigurationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetOutput(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetQuery(this AzurePostgresServerConfigurationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetQuery(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings SetVerbose(this AzurePostgresServerConfigurationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationListSettings ResetVerbose(this AzurePostgresServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerConfigurationSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerConfigurationSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetName(this AzurePostgresServerConfigurationSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetName(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetResourceGroup(this AzurePostgresServerConfigurationSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetResourceGroup(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetServerName(this AzurePostgresServerConfigurationSetSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetServerName(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Value"/>.</em></p><p>Value of the configuration. If not provided, configuration value will be set to default.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetValue(this AzurePostgresServerConfigurationSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Value"/>.</em></p><p>Value of the configuration. If not provided, configuration value will be set to default.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetValue(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetDebug(this AzurePostgresServerConfigurationSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetDebug(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetHelp(this AzurePostgresServerConfigurationSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetHelp(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetOutput(this AzurePostgresServerConfigurationSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetOutput(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetQuery(this AzurePostgresServerConfigurationSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetQuery(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings SetVerbose(this AzurePostgresServerConfigurationSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationSetSettings ResetVerbose(this AzurePostgresServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerConfigurationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerConfigurationShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetName(this AzurePostgresServerConfigurationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetName(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetResourceGroup(this AzurePostgresServerConfigurationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetResourceGroup(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetServerName(this AzurePostgresServerConfigurationShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetServerName(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetDebug(this AzurePostgresServerConfigurationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetDebug(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetHelp(this AzurePostgresServerConfigurationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetHelp(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetOutput(this AzurePostgresServerConfigurationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetOutput(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetQuery(this AzurePostgresServerConfigurationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetQuery(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerConfigurationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings SetVerbose(this AzurePostgresServerConfigurationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerConfigurationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerConfigurationShowSettings ResetVerbose(this AzurePostgresServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetResourceGroup(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetResourceGroup(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetServerName(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetServerName(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Subnet"/>.</em></p><p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetSubnet(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Subnet"/>.</em></p><p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetSubnet(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings EnableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings DisableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzurePostgresServerVnetRuleCreateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ToggleIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.VnetName"/>.</em></p><p>The virtual network name.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetVnetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.VnetName"/>.</em></p><p>The virtual network name.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetVnetName(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetDebug(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetDebug(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetHelp(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetHelp(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetOutput(this AzurePostgresServerVnetRuleCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetOutput(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetQuery(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetQuery(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings SetVerbose(this AzurePostgresServerVnetRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleCreateSettings ResetVerbose(this AzurePostgresServerVnetRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetResourceGroup(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetResourceGroup(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetServerName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetServerName(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetDebug(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetDebug(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetHelp(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetHelp(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetOutput(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetOutput(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetQuery(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetQuery(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings SetVerbose(this AzurePostgresServerVnetRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleDeleteSettings ResetVerbose(this AzurePostgresServerVnetRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetResourceGroup(this AzurePostgresServerVnetRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetResourceGroup(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetServerName(this AzurePostgresServerVnetRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetServerName(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetDebug(this AzurePostgresServerVnetRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetDebug(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetHelp(this AzurePostgresServerVnetRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetHelp(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetOutput(this AzurePostgresServerVnetRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetOutput(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetQuery(this AzurePostgresServerVnetRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetQuery(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings SetVerbose(this AzurePostgresServerVnetRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleListSettings ResetVerbose(this AzurePostgresServerVnetRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetName(this AzurePostgresServerVnetRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetName(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetResourceGroup(this AzurePostgresServerVnetRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetResourceGroup(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetServerName(this AzurePostgresServerVnetRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetServerName(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetDebug(this AzurePostgresServerVnetRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetDebug(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetHelp(this AzurePostgresServerVnetRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetHelp(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetOutput(this AzurePostgresServerVnetRuleShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetOutput(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetQuery(this AzurePostgresServerVnetRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetQuery(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings SetVerbose(this AzurePostgresServerVnetRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleShowSettings ResetVerbose(this AzurePostgresServerVnetRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePostgresServerVnetRuleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePostgresServerVnetRuleUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Name"/>.</em></p><p>The name of the vnet rule.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetResourceGroup(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetResourceGroup(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetServerName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetServerName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subnet"/>.</em></p><p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetSubnet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Subnet"/>.</em></p><p>Name or ID of the subnet that allows access to an Azure Postgres Server. If subnet name is provided, --vnet-name must be provided.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetSubnet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingEndpoint
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, bool? ignoreMissingEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = ignoreMissingEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings EnableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings DisableIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzurePostgresServerVnetRuleUpdateSettings.IgnoreMissingEndpoint"/>.</em></p><p>Create vnet rule before virtual network has vnet service endpoint enabled.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ToggleIgnoreMissingEndpoint(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingEndpoint = !toolSettings.IgnoreMissingEndpoint;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.VnetName"/>.</em></p><p>The virtual network name.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetVnetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.VnetName"/>.</em></p><p>The virtual network name.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetVnetName(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetAdd(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetAdd(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetForceString(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetForceString(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetRemove(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetRemove(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetSet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetSet(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetDebug(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetDebug(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetHelp(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetHelp(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetOutput(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetOutput(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetQuery(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetQuery(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings SetVerbose(this AzurePostgresServerVnetRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePostgresServerVnetRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePostgresServerVnetRuleUpdateSettings ResetVerbose(this AzurePostgresServerVnetRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PostgresServerSslEnforcement
    /// <summary><p>Used within <see cref="AzurePostgresTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class PostgresServerSslEnforcement : Enumeration
    {
        public static PostgresServerSslEnforcement disabled = new PostgresServerSslEnforcement { Value = "disabled" };
        public static PostgresServerSslEnforcement enabled = new PostgresServerSslEnforcement { Value = "enabled" };
    }
    #endregion
}
