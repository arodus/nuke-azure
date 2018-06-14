// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureRedis.json.

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
    public static partial class AzureRedisTasks
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public static string AzureRedisPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p></summary>
        public static IEnumerable<string> AzureRedis(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureRedisPath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureRedisCreateSettings toolSettings);
        static partial void PostProcess(AzureRedisCreateSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisCreate(Configure<AzureRedisCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisDeleteSettings toolSettings);
        static partial void PostProcess(AzureRedisDeleteSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisDelete(Configure<AzureRedisDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisExportSettings toolSettings);
        static partial void PostProcess(AzureRedisExportSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisExport(Configure<AzureRedisExportSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisExportSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisForceRebootSettings toolSettings);
        static partial void PostProcess(AzureRedisForceRebootSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisForceReboot(Configure<AzureRedisForceRebootSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisForceRebootSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisImportSettings toolSettings);
        static partial void PostProcess(AzureRedisImportSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisImport(Configure<AzureRedisImportSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisImportSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisImportMethodSettings toolSettings);
        static partial void PostProcess(AzureRedisImportMethodSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisImportMethod(Configure<AzureRedisImportMethodSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisImportMethodSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisListSettings toolSettings);
        static partial void PostProcess(AzureRedisListSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisList(Configure<AzureRedisListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisListAllSettings toolSettings);
        static partial void PostProcess(AzureRedisListAllSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisListAll(Configure<AzureRedisListAllSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisListAllSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisListKeysSettings toolSettings);
        static partial void PostProcess(AzureRedisListKeysSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisListKeys(Configure<AzureRedisListKeysSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisListKeysSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisRegenerateKeysSettings toolSettings);
        static partial void PostProcess(AzureRedisRegenerateKeysSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisRegenerateKeys(Configure<AzureRedisRegenerateKeysSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisRegenerateKeysSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisShowSettings toolSettings);
        static partial void PostProcess(AzureRedisShowSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisShow(Configure<AzureRedisShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisUpdateSettings toolSettings);
        static partial void PostProcess(AzureRedisUpdateSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisUpdate(Configure<AzureRedisUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisUpdateSettingsSettings toolSettings);
        static partial void PostProcess(AzureRedisUpdateSettingsSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisUpdateSettings(Configure<AzureRedisUpdateSettingsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisUpdateSettingsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisPatchScheduleDeleteSettings toolSettings);
        static partial void PostProcess(AzureRedisPatchScheduleDeleteSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisPatchScheduleDelete(Configure<AzureRedisPatchScheduleDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisPatchScheduleDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisPatchScheduleSetSettings toolSettings);
        static partial void PostProcess(AzureRedisPatchScheduleSetSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisPatchScheduleSet(Configure<AzureRedisPatchScheduleSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisPatchScheduleSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisPatchScheduleShowSettings toolSettings);
        static partial void PostProcess(AzureRedisPatchScheduleShowSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisPatchScheduleShow(Configure<AzureRedisPatchScheduleShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisPatchScheduleShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings);
        static partial void PostProcess(AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings);
        /// <summary><p>Access to a secure, dedicated Redis cache for your Azure applications.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/redis?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureRedisPatchSchedulePatchScheduleShow(Configure<AzureRedisPatchSchedulePatchScheduleShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRedisPatchSchedulePatchScheduleShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureRedisCreateSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The primary resource name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Type of Redis cache.</p></summary>
        public virtual RedisSku Sku { get; internal set; }
        /// <summary><p>Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).</p></summary>
        public virtual string VmSize { get; internal set; }
        /// <summary><p>If the value is true, then the non-ssl redis server port (6379) will be enabled.</p></summary>
        public virtual string EnableNonSslPort { get; internal set; }
        /// <summary><p>JSON encoded configuration settings. Use @{file} to load from a file.</p></summary>
        public virtual string RedisConfiguration { get; internal set; }
        /// <summary><p>The number of shards to be created on a Premium Cluster Cache.</p></summary>
        public virtual string ShardCount { get; internal set; }
        /// <summary><p>Required when deploying a redis cache inside an existing Azure Virtual Network.</p></summary>
        public virtual string StaticIp { get; internal set; }
        /// <summary><p>The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.</p></summary>
        public virtual string SubnetId { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Json dictionary with tenant settings.</p></summary>
        public virtual string TenantSettings { get; internal set; }
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
              .Add("redis create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--vm-size {value}", VmSize)
              .Add("--enable-non-ssl-port {value}", EnableNonSslPort)
              .Add("--redis-configuration {value}", RedisConfiguration)
              .Add("--shard-count {value}", ShardCount)
              .Add("--static-ip {value}", StaticIp)
              .Add("--subnet-id {value}", SubnetId)
              .Add("--tags {value}", Tags)
              .Add("--tenant-settings {value}", TenantSettings)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRedisDeleteSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis delete")
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
    #region AzureRedisExportSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisExportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Container name to export to.</p></summary>
        public virtual string Container { get; internal set; }
        /// <summary><p>Name of the Redis cache.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Prefix to use for exported files.</p></summary>
        public virtual string Prefix { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>File format to export.</p></summary>
        public virtual string FileFormat { get; internal set; }
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
              .Add("redis export")
              .Add("--container {value}", Container)
              .Add("--name {value}", Name)
              .Add("--prefix {value}", Prefix)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--file-format {value}", FileFormat)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRedisForceRebootSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisForceRebootSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Which Redis node(s) to reboot. Depending on this value data loss is possible.</p></summary>
        public virtual RedisForceRebootRebootType RebootType { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>If clustering is enabled, the ID of the shard to be rebooted.</p></summary>
        public virtual string ShardId { get; internal set; }
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
              .Add("redis force-reboot")
              .Add("--name {value}", Name)
              .Add("--reboot-type {value}", RebootType)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--shard-id {value}", ShardId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRedisImportSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisImportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>File format to import.</p></summary>
        public virtual string FileFormat { get; internal set; }
        /// <summary><p>Space-separated list of files to import.</p></summary>
        public virtual IReadOnlyList<string> Files => FilesInternal.AsReadOnly();
        internal List<string> FilesInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis import")
              .Add("--file-format {value}", FileFormat)
              .Add("--files {value}", Files, separator: ' ')
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
    #region AzureRedisImportMethodSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisImportMethodSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>File format to import.</p></summary>
        public virtual string FileFormat { get; internal set; }
        /// <summary><p>Space-separated list of files to import.</p></summary>
        public virtual IReadOnlyList<string> Files => FilesInternal.AsReadOnly();
        internal List<string> FilesInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis import-method")
              .Add("--file-format {value}", FileFormat)
              .Add("--files {value}", Files, separator: ' ')
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
    #region AzureRedisListSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
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
              .Add("redis list")
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
    #region AzureRedisListAllSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisListAllSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
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
              .Add("redis list-all")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRedisListKeysSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisListKeysSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis list-keys")
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
    #region AzureRedisRegenerateKeysSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisRegenerateKeysSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>The Redis access key to regenerate.</p></summary>
        public virtual RedisRegenerateKeysKeyType KeyType { get; internal set; }
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis regenerate-keys")
              .Add("--key-type {value}", KeyType)
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
    #region AzureRedisShowSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis show")
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
    #region AzureRedisUpdateSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Type of Redis cache.</p></summary>
        public virtual RedisSku Sku { get; internal set; }
        /// <summary><p>Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).</p></summary>
        public virtual string VmSize { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
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
              .Add("redis update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--vm-size {value}", VmSize)
              .Add("--add {value}", Add)
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
    #region AzureRedisUpdateSettingsSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisUpdateSettingsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>JSON encoded configuration settings. Use @{file} to load from a file.</p></summary>
        public virtual string RedisConfiguration { get; internal set; }
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
              .Add("redis update-settings")
              .Add("--name {value}", Name)
              .Add("--redis-configuration {value}", RedisConfiguration)
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
    #region AzureRedisPatchScheduleDeleteSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis patch-schedule delete")
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
    #region AzureRedisPatchScheduleSetSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>List of patch schedules for a Redis cache.</p></summary>
        public virtual string ScheduleEntries { get; internal set; }
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
              .Add("redis patch-schedule set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--schedule-entries {value}", ScheduleEntries)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRedisPatchScheduleShowSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchScheduleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis patch-schedule show")
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
    #region AzureRedisPatchSchedulePatchScheduleShowSettings
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRedisPatchSchedulePatchScheduleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRedis executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRedisTasks.AzureRedisPath;
        /// <summary><p>Name of the Redis cache.</p></summary>
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
              .Add("redis patch-schedule patch-schedule show")
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
    #region AzureRedisCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisCreateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetLocation(this AzureRedisCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetLocation(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Name"/>.</em></p><p>The primary resource name.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetName(this AzureRedisCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Name"/>.</em></p><p>The primary resource name.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetName(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetResourceGroup(this AzureRedisCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetResourceGroup(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Sku"/>.</em></p><p>Type of Redis cache.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetSku(this AzureRedisCreateSettings toolSettings, RedisSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Sku"/>.</em></p><p>Type of Redis cache.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetSku(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.VmSize"/>.</em></p><p>Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetVmSize(this AzureRedisCreateSettings toolSettings, string vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.VmSize"/>.</em></p><p>Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetVmSize(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region EnableNonSslPort
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.EnableNonSslPort"/>.</em></p><p>If the value is true, then the non-ssl redis server port (6379) will be enabled.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetEnableNonSslPort(this AzureRedisCreateSettings toolSettings, string enableNonSslPort)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableNonSslPort = enableNonSslPort;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.EnableNonSslPort"/>.</em></p><p>If the value is true, then the non-ssl redis server port (6379) will be enabled.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetEnableNonSslPort(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableNonSslPort = null;
            return toolSettings;
        }
        #endregion
        #region RedisConfiguration
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.RedisConfiguration"/>.</em></p><p>JSON encoded configuration settings. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetRedisConfiguration(this AzureRedisCreateSettings toolSettings, string redisConfiguration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RedisConfiguration = redisConfiguration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.RedisConfiguration"/>.</em></p><p>JSON encoded configuration settings. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetRedisConfiguration(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RedisConfiguration = null;
            return toolSettings;
        }
        #endregion
        #region ShardCount
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.ShardCount"/>.</em></p><p>The number of shards to be created on a Premium Cluster Cache.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetShardCount(this AzureRedisCreateSettings toolSettings, string shardCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardCount = shardCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.ShardCount"/>.</em></p><p>The number of shards to be created on a Premium Cluster Cache.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetShardCount(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardCount = null;
            return toolSettings;
        }
        #endregion
        #region StaticIp
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.StaticIp"/>.</em></p><p>Required when deploying a redis cache inside an existing Azure Virtual Network.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetStaticIp(this AzureRedisCreateSettings toolSettings, string staticIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StaticIp = staticIp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.StaticIp"/>.</em></p><p>Required when deploying a redis cache inside an existing Azure Virtual Network.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetStaticIp(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StaticIp = null;
            return toolSettings;
        }
        #endregion
        #region SubnetId
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.SubnetId"/>.</em></p><p>The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetSubnetId(this AzureRedisCreateSettings toolSettings, string subnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetId = subnetId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.SubnetId"/>.</em></p><p>The full resource ID of a subnet in a virtual network to deploy the redis cache in. Example format /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetSubnetId(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetId = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetTags(this AzureRedisCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetTags(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region TenantSettings
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.TenantSettings"/>.</em></p><p>Json dictionary with tenant settings.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetTenantSettings(this AzureRedisCreateSettings toolSettings, string tenantSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettings = tenantSettings;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.TenantSettings"/>.</em></p><p>Json dictionary with tenant settings.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetTenantSettings(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TenantSettings = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetDebug(this AzureRedisCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetDebug(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetHelp(this AzureRedisCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetHelp(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetOutput(this AzureRedisCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetOutput(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetQuery(this AzureRedisCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetQuery(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings SetVerbose(this AzureRedisCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisCreateSettings ResetVerbose(this AzureRedisCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetName(this AzureRedisDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetName(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetResourceGroup(this AzureRedisDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetResourceGroup(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetDebug(this AzureRedisDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetDebug(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetHelp(this AzureRedisDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetHelp(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetOutput(this AzureRedisDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetOutput(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetQuery(this AzureRedisDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetQuery(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings SetVerbose(this AzureRedisDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisDeleteSettings ResetVerbose(this AzureRedisDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisExportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisExportSettingsExtensions
    {
        #region Container
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Container"/>.</em></p><p>Container name to export to.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetContainer(this AzureRedisExportSettings toolSettings, string container)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Container = container;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Container"/>.</em></p><p>Container name to export to.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetContainer(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Container = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetName(this AzureRedisExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetName(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Prefix
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Prefix"/>.</em></p><p>Prefix to use for exported files.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetPrefix(this AzureRedisExportSettings toolSettings, string prefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prefix = prefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Prefix"/>.</em></p><p>Prefix to use for exported files.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetPrefix(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Prefix = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetResourceGroup(this AzureRedisExportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetResourceGroup(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region FileFormat
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.FileFormat"/>.</em></p><p>File format to export.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetFileFormat(this AzureRedisExportSettings toolSettings, string fileFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = fileFormat;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.FileFormat"/>.</em></p><p>File format to export.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetFileFormat(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetDebug(this AzureRedisExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetDebug(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetHelp(this AzureRedisExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetHelp(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetOutput(this AzureRedisExportSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetOutput(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetQuery(this AzureRedisExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetQuery(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisExportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisExportSettings SetVerbose(this AzureRedisExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisExportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisExportSettings ResetVerbose(this AzureRedisExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisForceRebootSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisForceRebootSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetName(this AzureRedisForceRebootSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetName(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region RebootType
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.RebootType"/>.</em></p><p>Which Redis node(s) to reboot. Depending on this value data loss is possible.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetRebootType(this AzureRedisForceRebootSettings toolSettings, RedisForceRebootRebootType rebootType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RebootType = rebootType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.RebootType"/>.</em></p><p>Which Redis node(s) to reboot. Depending on this value data loss is possible.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetRebootType(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RebootType = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetResourceGroup(this AzureRedisForceRebootSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetResourceGroup(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ShardId
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.ShardId"/>.</em></p><p>If clustering is enabled, the ID of the shard to be rebooted.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetShardId(this AzureRedisForceRebootSettings toolSettings, string shardId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardId = shardId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.ShardId"/>.</em></p><p>If clustering is enabled, the ID of the shard to be rebooted.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetShardId(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShardId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetDebug(this AzureRedisForceRebootSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetDebug(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetHelp(this AzureRedisForceRebootSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetHelp(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetOutput(this AzureRedisForceRebootSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetOutput(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetQuery(this AzureRedisForceRebootSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetQuery(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisForceRebootSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings SetVerbose(this AzureRedisForceRebootSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisForceRebootSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisForceRebootSettings ResetVerbose(this AzureRedisForceRebootSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisImportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisImportSettingsExtensions
    {
        #region FileFormat
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.FileFormat"/>.</em></p><p>File format to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetFileFormat(this AzureRedisImportSettings toolSettings, string fileFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = fileFormat;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.FileFormat"/>.</em></p><p>File format to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetFileFormat(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = null;
            return toolSettings;
        }
        #endregion
        #region Files
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Files"/> to a new list.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetFiles(this AzureRedisImportSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal = files.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Files"/> to a new list.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetFiles(this AzureRedisImportSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal = files.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureRedisImportSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings AddFiles(this AzureRedisImportSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.AddRange(files);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureRedisImportSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings AddFiles(this AzureRedisImportSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.AddRange(files);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureRedisImportSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ClearFiles(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureRedisImportSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings RemoveFiles(this AzureRedisImportSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(files);
            toolSettings.FilesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureRedisImportSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportSettings RemoveFiles(this AzureRedisImportSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(files);
            toolSettings.FilesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetName(this AzureRedisImportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetName(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetResourceGroup(this AzureRedisImportSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetResourceGroup(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetDebug(this AzureRedisImportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetDebug(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetHelp(this AzureRedisImportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetHelp(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetOutput(this AzureRedisImportSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetOutput(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetQuery(this AzureRedisImportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetQuery(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportSettings SetVerbose(this AzureRedisImportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportSettings ResetVerbose(this AzureRedisImportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisImportMethodSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisImportMethodSettingsExtensions
    {
        #region FileFormat
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.FileFormat"/>.</em></p><p>File format to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetFileFormat(this AzureRedisImportMethodSettings toolSettings, string fileFormat)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = fileFormat;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.FileFormat"/>.</em></p><p>File format to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetFileFormat(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileFormat = null;
            return toolSettings;
        }
        #endregion
        #region Files
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Files"/> to a new list.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetFiles(this AzureRedisImportMethodSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal = files.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Files"/> to a new list.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetFiles(this AzureRedisImportMethodSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal = files.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureRedisImportMethodSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings AddFiles(this AzureRedisImportMethodSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.AddRange(files);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureRedisImportMethodSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings AddFiles(this AzureRedisImportMethodSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.AddRange(files);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureRedisImportMethodSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ClearFiles(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureRedisImportMethodSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings RemoveFiles(this AzureRedisImportMethodSettings toolSettings, params string[] files)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(files);
            toolSettings.FilesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureRedisImportMethodSettings.Files"/>.</em></p><p>Space-separated list of files to import.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings RemoveFiles(this AzureRedisImportMethodSettings toolSettings, IEnumerable<string> files)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(files);
            toolSettings.FilesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetName(this AzureRedisImportMethodSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetName(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetResourceGroup(this AzureRedisImportMethodSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetResourceGroup(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetDebug(this AzureRedisImportMethodSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetDebug(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetHelp(this AzureRedisImportMethodSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetHelp(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetOutput(this AzureRedisImportMethodSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetOutput(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetQuery(this AzureRedisImportMethodSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetQuery(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisImportMethodSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings SetVerbose(this AzureRedisImportMethodSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisImportMethodSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisImportMethodSettings ResetVerbose(this AzureRedisImportMethodSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisListSettings SetResourceGroup(this AzureRedisListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisListSettings ResetResourceGroup(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisListSettings SetDebug(this AzureRedisListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisListSettings ResetDebug(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisListSettings SetHelp(this AzureRedisListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisListSettings ResetHelp(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisListSettings SetOutput(this AzureRedisListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisListSettings ResetOutput(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisListSettings SetQuery(this AzureRedisListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisListSettings ResetQuery(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisListSettings SetVerbose(this AzureRedisListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisListSettings ResetVerbose(this AzureRedisListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisListAllSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisListAllSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisListAllSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings SetDebug(this AzureRedisListAllSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListAllSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings ResetDebug(this AzureRedisListAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisListAllSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings SetHelp(this AzureRedisListAllSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListAllSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings ResetHelp(this AzureRedisListAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisListAllSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings SetOutput(this AzureRedisListAllSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListAllSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings ResetOutput(this AzureRedisListAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisListAllSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings SetQuery(this AzureRedisListAllSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListAllSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings ResetQuery(this AzureRedisListAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisListAllSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings SetVerbose(this AzureRedisListAllSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListAllSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisListAllSettings ResetVerbose(this AzureRedisListAllSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisListKeysSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisListKeysSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetName(this AzureRedisListKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetName(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetResourceGroup(this AzureRedisListKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetResourceGroup(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetDebug(this AzureRedisListKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetDebug(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetHelp(this AzureRedisListKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetHelp(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetOutput(this AzureRedisListKeysSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetOutput(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetQuery(this AzureRedisListKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetQuery(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisListKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings SetVerbose(this AzureRedisListKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisListKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisListKeysSettings ResetVerbose(this AzureRedisListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisRegenerateKeysSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisRegenerateKeysSettingsExtensions
    {
        #region KeyType
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.KeyType"/>.</em></p><p>The Redis access key to regenerate.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetKeyType(this AzureRedisRegenerateKeysSettings toolSettings, RedisRegenerateKeysKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.KeyType"/>.</em></p><p>The Redis access key to regenerate.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetKeyType(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetName(this AzureRedisRegenerateKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetName(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetResourceGroup(this AzureRedisRegenerateKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetResourceGroup(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetDebug(this AzureRedisRegenerateKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetDebug(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetHelp(this AzureRedisRegenerateKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetHelp(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetOutput(this AzureRedisRegenerateKeysSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetOutput(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetQuery(this AzureRedisRegenerateKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetQuery(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisRegenerateKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings SetVerbose(this AzureRedisRegenerateKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisRegenerateKeysSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisRegenerateKeysSettings ResetVerbose(this AzureRedisRegenerateKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetName(this AzureRedisShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetName(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetResourceGroup(this AzureRedisShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetResourceGroup(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetDebug(this AzureRedisShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetDebug(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetHelp(this AzureRedisShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetHelp(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetOutput(this AzureRedisShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetOutput(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetQuery(this AzureRedisShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetQuery(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisShowSettings SetVerbose(this AzureRedisShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisShowSettings ResetVerbose(this AzureRedisShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetName(this AzureRedisUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetName(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetResourceGroup(this AzureRedisUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetResourceGroup(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Sku"/>.</em></p><p>Type of Redis cache.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetSku(this AzureRedisUpdateSettings toolSettings, RedisSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Sku"/>.</em></p><p>Type of Redis cache.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetSku(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.VmSize"/>.</em></p><p>Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetVmSize(this AzureRedisUpdateSettings toolSettings, string vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.VmSize"/>.</em></p><p>Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetVmSize(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetAdd(this AzureRedisUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetAdd(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetRemove(this AzureRedisUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetRemove(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetSet(this AzureRedisUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetSet(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetDebug(this AzureRedisUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetDebug(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetHelp(this AzureRedisUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetHelp(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetOutput(this AzureRedisUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetOutput(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetQuery(this AzureRedisUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetQuery(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings SetVerbose(this AzureRedisUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettings ResetVerbose(this AzureRedisUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisUpdateSettingsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisUpdateSettingsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetName(this AzureRedisUpdateSettingsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetName(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region RedisConfiguration
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.RedisConfiguration"/>.</em></p><p>JSON encoded configuration settings. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetRedisConfiguration(this AzureRedisUpdateSettingsSettings toolSettings, string redisConfiguration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RedisConfiguration = redisConfiguration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.RedisConfiguration"/>.</em></p><p>JSON encoded configuration settings. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetRedisConfiguration(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RedisConfiguration = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetResourceGroup(this AzureRedisUpdateSettingsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetResourceGroup(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetDebug(this AzureRedisUpdateSettingsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetDebug(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetHelp(this AzureRedisUpdateSettingsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetHelp(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetOutput(this AzureRedisUpdateSettingsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetOutput(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetQuery(this AzureRedisUpdateSettingsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetQuery(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisUpdateSettingsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings SetVerbose(this AzureRedisUpdateSettingsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisUpdateSettingsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisUpdateSettingsSettings ResetVerbose(this AzureRedisUpdateSettingsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetName(this AzureRedisPatchScheduleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetName(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetResourceGroup(this AzureRedisPatchScheduleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetResourceGroup(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetDebug(this AzureRedisPatchScheduleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetDebug(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetHelp(this AzureRedisPatchScheduleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetHelp(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetOutput(this AzureRedisPatchScheduleDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetOutput(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetQuery(this AzureRedisPatchScheduleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetQuery(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings SetVerbose(this AzureRedisPatchScheduleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleDeleteSettings ResetVerbose(this AzureRedisPatchScheduleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetName(this AzureRedisPatchScheduleSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetName(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetResourceGroup(this AzureRedisPatchScheduleSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetResourceGroup(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ScheduleEntries
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.ScheduleEntries"/>.</em></p><p>List of patch schedules for a Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetScheduleEntries(this AzureRedisPatchScheduleSetSettings toolSettings, string scheduleEntries)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScheduleEntries = scheduleEntries;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.ScheduleEntries"/>.</em></p><p>List of patch schedules for a Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetScheduleEntries(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScheduleEntries = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetDebug(this AzureRedisPatchScheduleSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetDebug(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetHelp(this AzureRedisPatchScheduleSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetHelp(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetOutput(this AzureRedisPatchScheduleSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetOutput(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetQuery(this AzureRedisPatchScheduleSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetQuery(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings SetVerbose(this AzureRedisPatchScheduleSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleSetSettings ResetVerbose(this AzureRedisPatchScheduleSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchScheduleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchScheduleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetName(this AzureRedisPatchScheduleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetName(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetResourceGroup(this AzureRedisPatchScheduleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetResourceGroup(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetDebug(this AzureRedisPatchScheduleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetDebug(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetHelp(this AzureRedisPatchScheduleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetHelp(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetOutput(this AzureRedisPatchScheduleShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetOutput(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetQuery(this AzureRedisPatchScheduleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetQuery(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisPatchScheduleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings SetVerbose(this AzureRedisPatchScheduleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchScheduleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchScheduleShowSettings ResetVerbose(this AzureRedisPatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRedisPatchSchedulePatchScheduleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRedisPatchSchedulePatchScheduleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetName(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Name"/>.</em></p><p>Name of the Redis cache.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetName(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetResourceGroup(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetResourceGroup(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetDebug(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetDebug(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetHelp(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetHelp(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetOutput(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetOutput(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetQuery(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetQuery(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings SetVerbose(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRedisPatchSchedulePatchScheduleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRedisPatchSchedulePatchScheduleShowSettings ResetVerbose(this AzureRedisPatchSchedulePatchScheduleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region RedisSku
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class RedisSku : Enumeration
    {
        public static RedisSku basic = new RedisSku { Value = "basic" };
        public static RedisSku premium = new RedisSku { Value = "premium" };
        public static RedisSku standard = new RedisSku { Value = "standard" };
    }
    #endregion
    #region RedisForceRebootRebootType
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class RedisForceRebootRebootType : Enumeration
    {
        public static RedisForceRebootRebootType allnodes = new RedisForceRebootRebootType { Value = "allnodes" };
        public static RedisForceRebootRebootType primarynode = new RedisForceRebootRebootType { Value = "primarynode" };
        public static RedisForceRebootRebootType secondarynode = new RedisForceRebootRebootType { Value = "secondarynode" };
    }
    #endregion
    #region RedisRegenerateKeysKeyType
    /// <summary><p>Used within <see cref="AzureRedisTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class RedisRegenerateKeysKeyType : Enumeration
    {
        public static RedisRegenerateKeysKeyType primary = new RedisRegenerateKeysKeyType { Value = "primary" };
        public static RedisRegenerateKeysKeyType secondary = new RedisRegenerateKeysKeyType { Value = "secondary" };
    }
    #endregion
}
