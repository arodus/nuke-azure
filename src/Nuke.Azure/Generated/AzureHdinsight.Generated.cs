// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureHdinsight.json.

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
    public static partial class AzureHdinsightTasks
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public static string AzureHdinsightPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage HDInsight clusters.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsight(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureHdinsightPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage HDInsight clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsightCreate(Configure<AzureHdinsightCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureHdinsightCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage HDInsight clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsightDelete(Configure<AzureHdinsightDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureHdinsightDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage HDInsight clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsightList(Configure<AzureHdinsightListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureHdinsightListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage HDInsight clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsightResize(Configure<AzureHdinsightResizeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureHdinsightResizeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage HDInsight clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsightShow(Configure<AzureHdinsightShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureHdinsightShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage HDInsight clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureHdinsightWait(Configure<AzureHdinsightWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureHdinsightWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureHdinsightCreateSettings
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        /// <summary><p>The name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Extra configurations of various components, in JSON.</p></summary>
        public virtual string ClusterConfigurations { get; internal set; }
        /// <summary><p>The tier of the cluster: standard or premium.</p></summary>
        public virtual HdinsightCreateClusterTier ClusterTier { get; internal set; }
        /// <summary><p>The versions of various Hadoop components, in space-separated versions in 'component=version' format. Example: Spark=2.0 Hadoop=2.7.3 See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions</a>.</p></summary>
        public virtual string ComponentVersion { get; internal set; }
        /// <summary><p>The number of worker nodes in the cluster.</p></summary>
        public virtual string Size { get; internal set; }
        /// <summary><p>Type of HDInsight cluster, like: hadoop, interactivehive, hbase, kafka, storm, spark, rserver, mlservices. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types</a>.</p></summary>
        public virtual string Type { get; internal set; }
        /// <summary><p>The HDInsight cluster version. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions</a>.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>HTTP password for the cluster.</p></summary>
        public virtual string HttpPassword { get; internal set; }
        /// <summary><p>HTTP username for the cluster.  Default: admin.</p></summary>
        public virtual string HttpUser { get; internal set; }
        /// <summary><p>The name of the subnet in the specified virtual network.</p></summary>
        public virtual string SubnetName { get; internal set; }
        /// <summary><p>The virtual network resource ID of an existing virtual network.</p></summary>
        public virtual string VirtualNetwork { get; internal set; }
        /// <summary><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        public virtual string EdgenodeSize { get; internal set; }
        /// <summary><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        public virtual string HeadnodeSize { get; internal set; }
        /// <summary><p>The size of the data disk in GB, e.g. 1023.</p></summary>
        public virtual string WorkernodeDataDiskSize { get; internal set; }
        /// <summary><p>The type of storage account that will be used for the data disks: standard_lrs or premium_lrs.</p></summary>
        public virtual HdinsightCreateWorkernodeDataDiskStorageAccountType WorkernodeDataDiskStorageAccountType { get; internal set; }
        /// <summary><p>The number of data disks to use per worker node.</p></summary>
        public virtual string WorkernodeDataDisksPerNode { get; internal set; }
        /// <summary><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        public virtual string WorkernodeSize { get; internal set; }
        /// <summary><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        public virtual string ZookeepernodeSize { get; internal set; }
        /// <summary><p>SSH password for the cluster nodes. If none specified, uses the HTTP password.</p></summary>
        public virtual string SshPassword { get; internal set; }
        /// <summary><p>SSH public key for the cluster nodes.</p></summary>
        public virtual string SshPublicKey { get; internal set; }
        /// <summary><p>SSH username for the cluster nodes.</p></summary>
        public virtual string SshUser { get; internal set; }
        /// <summary><p>The storage account, e.g. "&lt;name&gt;.blob.core.windows.net".</p></summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary><p>The storage account key. A key can be retrieved automatically if the user has access to the storage account.</p></summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary><p>The storage container the cluster will use. Uses the cluster name if none was specified. (WASB only).</p></summary>
        public virtual string StorageDefaultContainer { get; internal set; }
        /// <summary><p>The storage filesystem the cluster will use. (DFS only).</p></summary>
        public virtual string StorageDefaultFilesystem { get; internal set; }
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
              .Add("hdinsight create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--tags {value}", Tags)
              .Add("--cluster-configurations {value}", ClusterConfigurations)
              .Add("--cluster-tier {value}", ClusterTier)
              .Add("--component-version {value}", ComponentVersion)
              .Add("--size {value}", Size)
              .Add("--type {value}", Type)
              .Add("--version {value}", Version)
              .Add("--http-password {value}", HttpPassword, secret: true)
              .Add("--http-user {value}", HttpUser)
              .Add("--subnet-name {value}", SubnetName)
              .Add("--virtual-network {value}", VirtualNetwork)
              .Add("--edgenode-size {value}", EdgenodeSize)
              .Add("--headnode-size {value}", HeadnodeSize)
              .Add("--workernode-data-disk-size {value}", WorkernodeDataDiskSize)
              .Add("--workernode-data-disk-storage-account-type {value}", WorkernodeDataDiskStorageAccountType)
              .Add("--workernode-data-disks-per-node {value}", WorkernodeDataDisksPerNode)
              .Add("--workernode-size {value}", WorkernodeSize)
              .Add("--zookeepernode-size {value}", ZookeepernodeSize)
              .Add("--ssh-password {value}", SshPassword, secret: true)
              .Add("--ssh-public-key {value}", SshPublicKey)
              .Add("--ssh-user {value}", SshUser)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-default-container {value}", StorageDefaultContainer)
              .Add("--storage-default-filesystem {value}", StorageDefaultFilesystem)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureHdinsightDeleteSettings
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        /// <summary><p>The name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("hdinsight delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureHdinsightListSettings
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
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
              .Add("hdinsight list")
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
    #region AzureHdinsightResizeSettings
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightResizeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        /// <summary><p>The name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>The target instance count for the operation.</p></summary>
        public virtual string TargetInstanceCount { get; internal set; }
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
              .Add("hdinsight resize")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--target-instance-count {value}", TargetInstanceCount)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureHdinsightShowSettings
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        /// <summary><p>The name of the cluster.</p></summary>
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
              .Add("hdinsight show")
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
    #region AzureHdinsightWaitSettings
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureHdinsight executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        /// <summary><p>The name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        public virtual string Created { get; internal set; }
        /// <summary><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        public virtual string Custom { get; internal set; }
        /// <summary><p>Wait until deleted.</p></summary>
        public virtual string Deleted { get; internal set; }
        /// <summary><p>Wait until the resource exists.</p></summary>
        public virtual string Exists { get; internal set; }
        /// <summary><p>Polling interval in seconds.</p></summary>
        public virtual string Interval { get; internal set; }
        /// <summary><p>Maximum wait in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
        /// <summary><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        public virtual string Updated { get; internal set; }
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
              .Add("hdinsight wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureHdinsightCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetName(this AzureHdinsightCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetName(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetResourceGroup(this AzureHdinsightCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetResourceGroup(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetLocation(this AzureHdinsightCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetLocation(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetNoWait(this AzureHdinsightCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureHdinsightCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings EnableNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureHdinsightCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings DisableNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureHdinsightCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ToggleNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetTags(this AzureHdinsightCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetTags(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region ClusterConfigurations
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterConfigurations"/>.</em></p><p>Extra configurations of various components, in JSON.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterConfigurations(this AzureHdinsightCreateSettings toolSettings, string clusterConfigurations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterConfigurations = clusterConfigurations;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterConfigurations"/>.</em></p><p>Extra configurations of various components, in JSON.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterConfigurations(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterConfigurations = null;
            return toolSettings;
        }
        #endregion
        #region ClusterTier
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterTier"/>.</em></p><p>The tier of the cluster: standard or premium.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterTier(this AzureHdinsightCreateSettings toolSettings, HdinsightCreateClusterTier clusterTier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterTier = clusterTier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterTier"/>.</em></p><p>The tier of the cluster: standard or premium.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterTier(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterTier = null;
            return toolSettings;
        }
        #endregion
        #region ComponentVersion
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.ComponentVersion"/>.</em></p><p>The versions of various Hadoop components, in space-separated versions in 'component=version' format. Example: Spark=2.0 Hadoop=2.7.3 See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetComponentVersion(this AzureHdinsightCreateSettings toolSettings, string componentVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComponentVersion = componentVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.ComponentVersion"/>.</em></p><p>The versions of various Hadoop components, in space-separated versions in 'component=version' format. Example: Spark=2.0 Hadoop=2.7.3 See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetComponentVersion(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComponentVersion = null;
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Size"/>.</em></p><p>The number of worker nodes in the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSize(this AzureHdinsightCreateSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Size"/>.</em></p><p>The number of worker nodes in the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region Type
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Type"/>.</em></p><p>Type of HDInsight cluster, like: hadoop, interactivehive, hbase, kafka, storm, spark, rserver, mlservices. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetType(this AzureHdinsightCreateSettings toolSettings, string type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Type"/>.</em></p><p>Type of HDInsight cluster, like: hadoop, interactivehive, hbase, kafka, storm, spark, rserver, mlservices. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetType(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Version"/>.</em></p><p>The HDInsight cluster version. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetVersion(this AzureHdinsightCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Version"/>.</em></p><p>The HDInsight cluster version. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetVersion(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region HttpPassword
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.HttpPassword"/>.</em></p><p>HTTP password for the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHttpPassword(this AzureHdinsightCreateSettings toolSettings, string httpPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpPassword = httpPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.HttpPassword"/>.</em></p><p>HTTP password for the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHttpPassword(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpPassword = null;
            return toolSettings;
        }
        #endregion
        #region HttpUser
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.HttpUser"/>.</em></p><p>HTTP username for the cluster.  Default: admin.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHttpUser(this AzureHdinsightCreateSettings toolSettings, string httpUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpUser = httpUser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.HttpUser"/>.</em></p><p>HTTP username for the cluster.  Default: admin.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHttpUser(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpUser = null;
            return toolSettings;
        }
        #endregion
        #region SubnetName
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.SubnetName"/>.</em></p><p>The name of the subnet in the specified virtual network.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSubnetName(this AzureHdinsightCreateSettings toolSettings, string subnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetName = subnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.SubnetName"/>.</em></p><p>The name of the subnet in the specified virtual network.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSubnetName(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetName = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetwork
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.VirtualNetwork"/>.</em></p><p>The virtual network resource ID of an existing virtual network.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetVirtualNetwork(this AzureHdinsightCreateSettings toolSettings, string virtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = virtualNetwork;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.VirtualNetwork"/>.</em></p><p>The virtual network resource ID of an existing virtual network.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetVirtualNetwork(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = null;
            return toolSettings;
        }
        #endregion
        #region EdgenodeSize
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.EdgenodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEdgenodeSize(this AzureHdinsightCreateSettings toolSettings, string edgenodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EdgenodeSize = edgenodeSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.EdgenodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEdgenodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EdgenodeSize = null;
            return toolSettings;
        }
        #endregion
        #region HeadnodeSize
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.HeadnodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHeadnodeSize(this AzureHdinsightCreateSettings toolSettings, string headnodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadnodeSize = headnodeSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.HeadnodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHeadnodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadnodeSize = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeDataDiskSize
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskSize"/>.</em></p><p>The size of the data disk in GB, e.g. 1023.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeDataDiskSize(this AzureHdinsightCreateSettings toolSettings, string workernodeDataDiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskSize = workernodeDataDiskSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskSize"/>.</em></p><p>The size of the data disk in GB, e.g. 1023.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeDataDiskSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskSize = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeDataDiskStorageAccountType
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskStorageAccountType"/>.</em></p><p>The type of storage account that will be used for the data disks: standard_lrs or premium_lrs.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeDataDiskStorageAccountType(this AzureHdinsightCreateSettings toolSettings, HdinsightCreateWorkernodeDataDiskStorageAccountType workernodeDataDiskStorageAccountType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskStorageAccountType = workernodeDataDiskStorageAccountType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskStorageAccountType"/>.</em></p><p>The type of storage account that will be used for the data disks: standard_lrs or premium_lrs.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeDataDiskStorageAccountType(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskStorageAccountType = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeDataDisksPerNode
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDisksPerNode"/>.</em></p><p>The number of data disks to use per worker node.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeDataDisksPerNode(this AzureHdinsightCreateSettings toolSettings, string workernodeDataDisksPerNode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDisksPerNode = workernodeDataDisksPerNode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDisksPerNode"/>.</em></p><p>The number of data disks to use per worker node.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeDataDisksPerNode(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDisksPerNode = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeSize
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeSize(this AzureHdinsightCreateSettings toolSettings, string workernodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeSize = workernodeSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeSize = null;
            return toolSettings;
        }
        #endregion
        #region ZookeepernodeSize
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.ZookeepernodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetZookeepernodeSize(this AzureHdinsightCreateSettings toolSettings, string zookeepernodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZookeepernodeSize = zookeepernodeSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.ZookeepernodeSize"/>.</em></p><p>The size of the node. See also: <a href="https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/en-us/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetZookeepernodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZookeepernodeSize = null;
            return toolSettings;
        }
        #endregion
        #region SshPassword
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.SshPassword"/>.</em></p><p>SSH password for the cluster nodes. If none specified, uses the HTTP password.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSshPassword(this AzureHdinsightCreateSettings toolSettings, string sshPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPassword = sshPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.SshPassword"/>.</em></p><p>SSH password for the cluster nodes. If none specified, uses the HTTP password.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSshPassword(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPassword = null;
            return toolSettings;
        }
        #endregion
        #region SshPublicKey
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.SshPublicKey"/>.</em></p><p>SSH public key for the cluster nodes.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSshPublicKey(this AzureHdinsightCreateSettings toolSettings, string sshPublicKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPublicKey = sshPublicKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.SshPublicKey"/>.</em></p><p>SSH public key for the cluster nodes.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSshPublicKey(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPublicKey = null;
            return toolSettings;
        }
        #endregion
        #region SshUser
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.SshUser"/>.</em></p><p>SSH username for the cluster nodes.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSshUser(this AzureHdinsightCreateSettings toolSettings, string sshUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshUser = sshUser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.SshUser"/>.</em></p><p>SSH username for the cluster nodes.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSshUser(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshUser = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageAccount"/>.</em></p><p>The storage account, e.g. "&lt;name&gt;.blob.core.windows.net".</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageAccount(this AzureHdinsightCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageAccount"/>.</em></p><p>The storage account, e.g. "&lt;name&gt;.blob.core.windows.net".</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageAccount(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageAccountKey"/>.</em></p><p>The storage account key. A key can be retrieved automatically if the user has access to the storage account.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageAccountKey(this AzureHdinsightCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageAccountKey"/>.</em></p><p>The storage account key. A key can be retrieved automatically if the user has access to the storage account.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageAccountKey(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageDefaultContainer
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageDefaultContainer"/>.</em></p><p>The storage container the cluster will use. Uses the cluster name if none was specified. (WASB only).</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageDefaultContainer(this AzureHdinsightCreateSettings toolSettings, string storageDefaultContainer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageDefaultContainer = storageDefaultContainer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageDefaultContainer"/>.</em></p><p>The storage container the cluster will use. Uses the cluster name if none was specified. (WASB only).</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageDefaultContainer(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageDefaultContainer = null;
            return toolSettings;
        }
        #endregion
        #region StorageDefaultFilesystem
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageDefaultFilesystem"/>.</em></p><p>The storage filesystem the cluster will use. (DFS only).</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageDefaultFilesystem(this AzureHdinsightCreateSettings toolSettings, string storageDefaultFilesystem)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageDefaultFilesystem = storageDefaultFilesystem;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageDefaultFilesystem"/>.</em></p><p>The storage filesystem the cluster will use. (DFS only).</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageDefaultFilesystem(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageDefaultFilesystem = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetDebug(this AzureHdinsightCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetDebug(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHelp(this AzureHdinsightCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHelp(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetOutput(this AzureHdinsightCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetOutput(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetQuery(this AzureHdinsightCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetQuery(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureHdinsightCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetVerbose(this AzureHdinsightCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetVerbose(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetName(this AzureHdinsightDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetName(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetResourceGroup(this AzureHdinsightDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetResourceGroup(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetNoWait(this AzureHdinsightDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureHdinsightDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings EnableNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureHdinsightDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings DisableNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureHdinsightDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ToggleNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetYes(this AzureHdinsightDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetYes(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetDebug(this AzureHdinsightDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetDebug(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetHelp(this AzureHdinsightDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetHelp(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetOutput(this AzureHdinsightDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetOutput(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetQuery(this AzureHdinsightDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetQuery(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureHdinsightDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetVerbose(this AzureHdinsightDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetVerbose(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureHdinsightListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings SetResourceGroup(this AzureHdinsightListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings ResetResourceGroup(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureHdinsightListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings SetDebug(this AzureHdinsightListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings ResetDebug(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureHdinsightListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings SetHelp(this AzureHdinsightListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings ResetHelp(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureHdinsightListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings SetOutput(this AzureHdinsightListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings ResetOutput(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureHdinsightListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings SetQuery(this AzureHdinsightListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings ResetQuery(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureHdinsightListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings SetVerbose(this AzureHdinsightListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightListSettings ResetVerbose(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightResizeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightResizeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetName(this AzureHdinsightResizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetName(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetResourceGroup(this AzureHdinsightResizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetResourceGroup(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetNoWait(this AzureHdinsightResizeSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureHdinsightResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings EnableNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureHdinsightResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings DisableNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureHdinsightResizeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ToggleNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region TargetInstanceCount
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.TargetInstanceCount"/>.</em></p><p>The target instance count for the operation.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetTargetInstanceCount(this AzureHdinsightResizeSettings toolSettings, string targetInstanceCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInstanceCount = targetInstanceCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.TargetInstanceCount"/>.</em></p><p>The target instance count for the operation.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetTargetInstanceCount(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInstanceCount = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetDebug(this AzureHdinsightResizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetDebug(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetHelp(this AzureHdinsightResizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetHelp(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetOutput(this AzureHdinsightResizeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetOutput(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetQuery(this AzureHdinsightResizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetQuery(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureHdinsightResizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetVerbose(this AzureHdinsightResizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightResizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetVerbose(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetName(this AzureHdinsightShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetName(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetResourceGroup(this AzureHdinsightShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetResourceGroup(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetDebug(this AzureHdinsightShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetDebug(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetHelp(this AzureHdinsightShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetHelp(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetOutput(this AzureHdinsightShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetOutput(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetQuery(this AzureHdinsightShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetQuery(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureHdinsightShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings SetVerbose(this AzureHdinsightShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetVerbose(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetName(this AzureHdinsightWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Name"/>.</em></p><p>The name of the cluster.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetName(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetResourceGroup(this AzureHdinsightWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetResourceGroup(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetCreated(this AzureHdinsightWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetCreated(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetCustom(this AzureHdinsightWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetCustom(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetDeleted(this AzureHdinsightWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetDeleted(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetExists(this AzureHdinsightWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetExists(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetInterval(this AzureHdinsightWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetInterval(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetTimeout(this AzureHdinsightWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetTimeout(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetUpdated(this AzureHdinsightWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetUpdated(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetDebug(this AzureHdinsightWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetDebug(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetHelp(this AzureHdinsightWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetHelp(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetOutput(this AzureHdinsightWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetOutput(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetQuery(this AzureHdinsightWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetQuery(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureHdinsightWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetVerbose(this AzureHdinsightWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureHdinsightWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetVerbose(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HdinsightCreateClusterTier
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class HdinsightCreateClusterTier : Enumeration
    {
        public static HdinsightCreateClusterTier premium = new HdinsightCreateClusterTier { Value = "premium" };
        public static HdinsightCreateClusterTier standard = new HdinsightCreateClusterTier { Value = "standard" };
    }
    #endregion
    #region HdinsightCreateWorkernodeDataDiskStorageAccountType
    /// <summary><p>Used within <see cref="AzureHdinsightTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class HdinsightCreateWorkernodeDataDiskStorageAccountType : Enumeration
    {
        public static HdinsightCreateWorkernodeDataDiskStorageAccountType premium_lrs = new HdinsightCreateWorkernodeDataDiskStorageAccountType { Value = "premium_lrs" };
        public static HdinsightCreateWorkernodeDataDiskStorageAccountType standard_lrs = new HdinsightCreateWorkernodeDataDiskStorageAccountType { Value = "standard_lrs" };
    }
    #endregion
}
