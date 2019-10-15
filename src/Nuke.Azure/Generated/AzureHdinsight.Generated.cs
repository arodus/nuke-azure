// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureHdinsight.json
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
    public static partial class AzureHdinsightTasks
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public static string AzureHdinsightPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREHDINSIGHT_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureHdinsightLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage HDInsight resources.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsight(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureHdinsightPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureHdinsightLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightCreate(AzureHdinsightCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assign-identity</c> via <see cref="AzureHdinsightCreateSettings.AssignIdentity"/></li>
        ///     <li><c>--cluster-admin-account</c> via <see cref="AzureHdinsightCreateSettings.ClusterAdminAccount"/></li>
        ///     <li><c>--cluster-admin-password</c> via <see cref="AzureHdinsightCreateSettings.ClusterAdminPassword"/></li>
        ///     <li><c>--cluster-configurations</c> via <see cref="AzureHdinsightCreateSettings.ClusterConfigurations"/></li>
        ///     <li><c>--cluster-tier</c> via <see cref="AzureHdinsightCreateSettings.ClusterTier"/></li>
        ///     <li><c>--cluster-users-group-dns</c> via <see cref="AzureHdinsightCreateSettings.ClusterUsersGroupDns"/></li>
        ///     <li><c>--component-version</c> via <see cref="AzureHdinsightCreateSettings.ComponentVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightCreateSettings.Debug"/></li>
        ///     <li><c>--domain</c> via <see cref="AzureHdinsightCreateSettings.Domain"/></li>
        ///     <li><c>--edgenode-size</c> via <see cref="AzureHdinsightCreateSettings.EdgenodeSize"/></li>
        ///     <li><c>--encryption-algorithm</c> via <see cref="AzureHdinsightCreateSettings.EncryptionAlgorithm"/></li>
        ///     <li><c>--encryption-key-name</c> via <see cref="AzureHdinsightCreateSettings.EncryptionKeyName"/></li>
        ///     <li><c>--encryption-key-version</c> via <see cref="AzureHdinsightCreateSettings.EncryptionKeyVersion"/></li>
        ///     <li><c>--encryption-vault-uri</c> via <see cref="AzureHdinsightCreateSettings.EncryptionVaultUri"/></li>
        ///     <li><c>--esp</c> via <see cref="AzureHdinsightCreateSettings.Esp"/></li>
        ///     <li><c>--headnode-size</c> via <see cref="AzureHdinsightCreateSettings.HeadnodeSize"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightCreateSettings.Help"/></li>
        ///     <li><c>--http-password</c> via <see cref="AzureHdinsightCreateSettings.HttpPassword"/></li>
        ///     <li><c>--http-user</c> via <see cref="AzureHdinsightCreateSettings.HttpUser"/></li>
        ///     <li><c>--ldaps-urls</c> via <see cref="AzureHdinsightCreateSettings.LdapsUrls"/></li>
        ///     <li><c>--location</c> via <see cref="AzureHdinsightCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightCreateSettings.Name"/></li>
        ///     <li><c>--no-validation-timeout</c> via <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-password</c> via <see cref="AzureHdinsightCreateSettings.SshPassword"/></li>
        ///     <li><c>--ssh-public-key</c> via <see cref="AzureHdinsightCreateSettings.SshPublicKey"/></li>
        ///     <li><c>--ssh-user</c> via <see cref="AzureHdinsightCreateSettings.SshUser"/></li>
        ///     <li><c>--storage-account</c> via <see cref="AzureHdinsightCreateSettings.StorageAccount"/></li>
        ///     <li><c>--storage-account-key</c> via <see cref="AzureHdinsightCreateSettings.StorageAccountKey"/></li>
        ///     <li><c>--storage-account-managed-identity</c> via <see cref="AzureHdinsightCreateSettings.StorageAccountManagedIdentity"/></li>
        ///     <li><c>--storage-container</c> via <see cref="AzureHdinsightCreateSettings.StorageContainer"/></li>
        ///     <li><c>--storage-filesystem</c> via <see cref="AzureHdinsightCreateSettings.StorageFilesystem"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureHdinsightCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureHdinsightCreateSettings.Tags"/></li>
        ///     <li><c>--type</c> via <see cref="AzureHdinsightCreateSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureHdinsightCreateSettings.Version"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureHdinsightCreateSettings.VnetName"/></li>
        ///     <li><c>--workernode-count</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeCount"/></li>
        ///     <li><c>--workernode-data-disk-size</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskSize"/></li>
        ///     <li><c>--workernode-data-disk-storage-account-type</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskStorageAccountType"/></li>
        ///     <li><c>--workernode-data-disks-per-node</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeDataDisksPerNode"/></li>
        ///     <li><c>--workernode-size</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeSize"/></li>
        ///     <li><c>--zookeepernode-size</c> via <see cref="AzureHdinsightCreateSettings.ZookeepernodeSize"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightCreate(Configure<AzureHdinsightCreateSettings> configurator)
        {
            return AzureHdinsightCreate(configurator(new AzureHdinsightCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--assign-identity</c> via <see cref="AzureHdinsightCreateSettings.AssignIdentity"/></li>
        ///     <li><c>--cluster-admin-account</c> via <see cref="AzureHdinsightCreateSettings.ClusterAdminAccount"/></li>
        ///     <li><c>--cluster-admin-password</c> via <see cref="AzureHdinsightCreateSettings.ClusterAdminPassword"/></li>
        ///     <li><c>--cluster-configurations</c> via <see cref="AzureHdinsightCreateSettings.ClusterConfigurations"/></li>
        ///     <li><c>--cluster-tier</c> via <see cref="AzureHdinsightCreateSettings.ClusterTier"/></li>
        ///     <li><c>--cluster-users-group-dns</c> via <see cref="AzureHdinsightCreateSettings.ClusterUsersGroupDns"/></li>
        ///     <li><c>--component-version</c> via <see cref="AzureHdinsightCreateSettings.ComponentVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightCreateSettings.Debug"/></li>
        ///     <li><c>--domain</c> via <see cref="AzureHdinsightCreateSettings.Domain"/></li>
        ///     <li><c>--edgenode-size</c> via <see cref="AzureHdinsightCreateSettings.EdgenodeSize"/></li>
        ///     <li><c>--encryption-algorithm</c> via <see cref="AzureHdinsightCreateSettings.EncryptionAlgorithm"/></li>
        ///     <li><c>--encryption-key-name</c> via <see cref="AzureHdinsightCreateSettings.EncryptionKeyName"/></li>
        ///     <li><c>--encryption-key-version</c> via <see cref="AzureHdinsightCreateSettings.EncryptionKeyVersion"/></li>
        ///     <li><c>--encryption-vault-uri</c> via <see cref="AzureHdinsightCreateSettings.EncryptionVaultUri"/></li>
        ///     <li><c>--esp</c> via <see cref="AzureHdinsightCreateSettings.Esp"/></li>
        ///     <li><c>--headnode-size</c> via <see cref="AzureHdinsightCreateSettings.HeadnodeSize"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightCreateSettings.Help"/></li>
        ///     <li><c>--http-password</c> via <see cref="AzureHdinsightCreateSettings.HttpPassword"/></li>
        ///     <li><c>--http-user</c> via <see cref="AzureHdinsightCreateSettings.HttpUser"/></li>
        ///     <li><c>--ldaps-urls</c> via <see cref="AzureHdinsightCreateSettings.LdapsUrls"/></li>
        ///     <li><c>--location</c> via <see cref="AzureHdinsightCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightCreateSettings.Name"/></li>
        ///     <li><c>--no-validation-timeout</c> via <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-password</c> via <see cref="AzureHdinsightCreateSettings.SshPassword"/></li>
        ///     <li><c>--ssh-public-key</c> via <see cref="AzureHdinsightCreateSettings.SshPublicKey"/></li>
        ///     <li><c>--ssh-user</c> via <see cref="AzureHdinsightCreateSettings.SshUser"/></li>
        ///     <li><c>--storage-account</c> via <see cref="AzureHdinsightCreateSettings.StorageAccount"/></li>
        ///     <li><c>--storage-account-key</c> via <see cref="AzureHdinsightCreateSettings.StorageAccountKey"/></li>
        ///     <li><c>--storage-account-managed-identity</c> via <see cref="AzureHdinsightCreateSettings.StorageAccountManagedIdentity"/></li>
        ///     <li><c>--storage-container</c> via <see cref="AzureHdinsightCreateSettings.StorageContainer"/></li>
        ///     <li><c>--storage-filesystem</c> via <see cref="AzureHdinsightCreateSettings.StorageFilesystem"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureHdinsightCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureHdinsightCreateSettings.Tags"/></li>
        ///     <li><c>--type</c> via <see cref="AzureHdinsightCreateSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightCreateSettings.Verbose"/></li>
        ///     <li><c>--version</c> via <see cref="AzureHdinsightCreateSettings.Version"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureHdinsightCreateSettings.VnetName"/></li>
        ///     <li><c>--workernode-count</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeCount"/></li>
        ///     <li><c>--workernode-data-disk-size</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskSize"/></li>
        ///     <li><c>--workernode-data-disk-storage-account-type</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskStorageAccountType"/></li>
        ///     <li><c>--workernode-data-disks-per-node</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeDataDisksPerNode"/></li>
        ///     <li><c>--workernode-size</c> via <see cref="AzureHdinsightCreateSettings.WorkernodeSize"/></li>
        ///     <li><c>--zookeepernode-size</c> via <see cref="AzureHdinsightCreateSettings.ZookeepernodeSize"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightCreate(CombinatorialConfigure<AzureHdinsightCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightCreate, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightDelete(AzureHdinsightDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureHdinsightDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightDelete(Configure<AzureHdinsightDeleteSettings> configurator)
        {
            return AzureHdinsightDelete(configurator(new AzureHdinsightDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureHdinsightDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightDelete(CombinatorialConfigure<AzureHdinsightDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightDelete, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightList(AzureHdinsightListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightList(Configure<AzureHdinsightListSettings> configurator)
        {
            return AzureHdinsightList(configurator(new AzureHdinsightListSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightListSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightList(CombinatorialConfigure<AzureHdinsightListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightList, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightListUsage(AzureHdinsightListUsageSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightListUsageSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightListUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightListUsageSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureHdinsightListUsageSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightListUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightListUsageSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightListUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightListUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightListUsage(Configure<AzureHdinsightListUsageSettings> configurator)
        {
            return AzureHdinsightListUsage(configurator(new AzureHdinsightListUsageSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightListUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightListUsageSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureHdinsightListUsageSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightListUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightListUsageSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightListUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightListUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightListUsageSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightListUsage(CombinatorialConfigure<AzureHdinsightListUsageSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightListUsage, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightResize(AzureHdinsightResizeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightResizeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightResizeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightResizeSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightResizeSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightResizeSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightResizeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightResizeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightResizeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightResizeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightResizeSettings.Verbose"/></li>
        ///     <li><c>--workernode-count</c> via <see cref="AzureHdinsightResizeSettings.WorkernodeCount"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightResize(Configure<AzureHdinsightResizeSettings> configurator)
        {
            return AzureHdinsightResize(configurator(new AzureHdinsightResizeSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightResizeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightResizeSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightResizeSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightResizeSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightResizeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightResizeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightResizeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightResizeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightResizeSettings.Verbose"/></li>
        ///     <li><c>--workernode-count</c> via <see cref="AzureHdinsightResizeSettings.WorkernodeCount"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightResizeSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightResize(CombinatorialConfigure<AzureHdinsightResizeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightResize, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightRotateDiskEncryptionKey(AzureHdinsightRotateDiskEncryptionKeySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightRotateDiskEncryptionKeySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Debug"/></li>
        ///     <li><c>--encryption-key-name</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyName"/></li>
        ///     <li><c>--encryption-key-version</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyVersion"/></li>
        ///     <li><c>--encryption-vault-uri</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionVaultUri"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightRotateDiskEncryptionKey(Configure<AzureHdinsightRotateDiskEncryptionKeySettings> configurator)
        {
            return AzureHdinsightRotateDiskEncryptionKey(configurator(new AzureHdinsightRotateDiskEncryptionKeySettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Debug"/></li>
        ///     <li><c>--encryption-key-name</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyName"/></li>
        ///     <li><c>--encryption-key-version</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyVersion"/></li>
        ///     <li><c>--encryption-vault-uri</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionVaultUri"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightRotateDiskEncryptionKeySettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightRotateDiskEncryptionKey(CombinatorialConfigure<AzureHdinsightRotateDiskEncryptionKeySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightRotateDiskEncryptionKey, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightShow(AzureHdinsightShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightShow(Configure<AzureHdinsightShowSettings> configurator)
        {
            return AzureHdinsightShow(configurator(new AzureHdinsightShowSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightShow(CombinatorialConfigure<AzureHdinsightShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightShow, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightUpdate(AzureHdinsightUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureHdinsightUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightUpdate(Configure<AzureHdinsightUpdateSettings> configurator)
        {
            return AzureHdinsightUpdate(configurator(new AzureHdinsightUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureHdinsightUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightUpdate(CombinatorialConfigure<AzureHdinsightUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightUpdate, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightWait(AzureHdinsightWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureHdinsightWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureHdinsightWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureHdinsightWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureHdinsightWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureHdinsightWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureHdinsightWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureHdinsightWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightWait(Configure<AzureHdinsightWaitSettings> configurator)
        {
            return AzureHdinsightWait(configurator(new AzureHdinsightWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureHdinsightWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureHdinsightWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureHdinsightWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureHdinsightWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureHdinsightWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureHdinsightWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureHdinsightWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightWait(CombinatorialConfigure<AzureHdinsightWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightWait, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionDelete(AzureHdinsightScriptActionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightScriptActionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionDelete(Configure<AzureHdinsightScriptActionDeleteSettings> configurator)
        {
            return AzureHdinsightScriptActionDelete(configurator(new AzureHdinsightScriptActionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightScriptActionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightScriptActionDelete(CombinatorialConfigure<AzureHdinsightScriptActionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightScriptActionDelete, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionExecute(AzureHdinsightScriptActionExecuteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightScriptActionExecuteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Output"/></li>
        ///     <li><c>--persist-on-success</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.PersistOnSuccess"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ResourceGroup"/></li>
        ///     <li><c>--roles</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Roles"/></li>
        ///     <li><c>--script-parameters</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptParameters"/></li>
        ///     <li><c>--script-uri</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptUri"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionExecute(Configure<AzureHdinsightScriptActionExecuteSettings> configurator)
        {
            return AzureHdinsightScriptActionExecute(configurator(new AzureHdinsightScriptActionExecuteSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Output"/></li>
        ///     <li><c>--persist-on-success</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.PersistOnSuccess"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ResourceGroup"/></li>
        ///     <li><c>--roles</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Roles"/></li>
        ///     <li><c>--script-parameters</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptParameters"/></li>
        ///     <li><c>--script-uri</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptUri"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionExecuteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightScriptActionExecuteSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightScriptActionExecute(CombinatorialConfigure<AzureHdinsightScriptActionExecuteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightScriptActionExecute, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionList(AzureHdinsightScriptActionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightScriptActionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionListSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionList(Configure<AzureHdinsightScriptActionListSettings> configurator)
        {
            return AzureHdinsightScriptActionList(configurator(new AzureHdinsightScriptActionListSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionListSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightScriptActionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightScriptActionList(CombinatorialConfigure<AzureHdinsightScriptActionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightScriptActionList, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionListExecutionHistory(AzureHdinsightScriptActionListExecutionHistorySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightScriptActionListExecutionHistorySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionListExecutionHistory(Configure<AzureHdinsightScriptActionListExecutionHistorySettings> configurator)
        {
            return AzureHdinsightScriptActionListExecutionHistory(configurator(new AzureHdinsightScriptActionListExecutionHistorySettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightScriptActionListExecutionHistorySettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightScriptActionListExecutionHistory(CombinatorialConfigure<AzureHdinsightScriptActionListExecutionHistorySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightScriptActionListExecutionHistory, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionPromote(AzureHdinsightScriptActionPromoteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightScriptActionPromoteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Debug"/></li>
        ///     <li><c>--execution-id</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.ExecutionId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionPromote(Configure<AzureHdinsightScriptActionPromoteSettings> configurator)
        {
            return AzureHdinsightScriptActionPromote(configurator(new AzureHdinsightScriptActionPromoteSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Debug"/></li>
        ///     <li><c>--execution-id</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.ExecutionId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionPromoteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightScriptActionPromoteSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightScriptActionPromote(CombinatorialConfigure<AzureHdinsightScriptActionPromoteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightScriptActionPromote, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionShowExecutionDetails(AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightScriptActionShowExecutionDetailsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Debug"/></li>
        ///     <li><c>--execution-id</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ExecutionId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightScriptActionShowExecutionDetails(Configure<AzureHdinsightScriptActionShowExecutionDetailsSettings> configurator)
        {
            return AzureHdinsightScriptActionShowExecutionDetails(configurator(new AzureHdinsightScriptActionShowExecutionDetailsSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Debug"/></li>
        ///     <li><c>--execution-id</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ExecutionId"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightScriptActionShowExecutionDetailsSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightScriptActionShowExecutionDetails(CombinatorialConfigure<AzureHdinsightScriptActionShowExecutionDetailsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightScriptActionShowExecutionDetails, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightMonitorDisable(AzureHdinsightMonitorDisableSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightMonitorDisableSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightMonitorDisableSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightMonitorDisableSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightMonitorDisableSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightMonitorDisableSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightMonitorDisableSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightMonitorDisableSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightMonitorDisableSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightMonitorDisableSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightMonitorDisable(Configure<AzureHdinsightMonitorDisableSettings> configurator)
        {
            return AzureHdinsightMonitorDisable(configurator(new AzureHdinsightMonitorDisableSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightMonitorDisableSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightMonitorDisableSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightMonitorDisableSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightMonitorDisableSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightMonitorDisableSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightMonitorDisableSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightMonitorDisableSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightMonitorDisableSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightMonitorDisableSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightMonitorDisable(CombinatorialConfigure<AzureHdinsightMonitorDisableSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightMonitorDisable, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightMonitorEnable(AzureHdinsightMonitorEnableSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightMonitorEnableSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightMonitorEnableSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightMonitorEnableSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightMonitorEnableSettings.Name"/></li>
        ///     <li><c>--no-validation-timeout</c> via <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightMonitorEnableSettings.Output"/></li>
        ///     <li><c>--primary-key</c> via <see cref="AzureHdinsightMonitorEnableSettings.PrimaryKey"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightMonitorEnableSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightMonitorEnableSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightMonitorEnableSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightMonitorEnableSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureHdinsightMonitorEnableSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightMonitorEnable(Configure<AzureHdinsightMonitorEnableSettings> configurator)
        {
            return AzureHdinsightMonitorEnable(configurator(new AzureHdinsightMonitorEnableSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightMonitorEnableSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightMonitorEnableSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightMonitorEnableSettings.Name"/></li>
        ///     <li><c>--no-validation-timeout</c> via <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightMonitorEnableSettings.Output"/></li>
        ///     <li><c>--primary-key</c> via <see cref="AzureHdinsightMonitorEnableSettings.PrimaryKey"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightMonitorEnableSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightMonitorEnableSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightMonitorEnableSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightMonitorEnableSettings.Verbose"/></li>
        ///     <li><c>--workspace</c> via <see cref="AzureHdinsightMonitorEnableSettings.Workspace"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightMonitorEnableSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightMonitorEnable(CombinatorialConfigure<AzureHdinsightMonitorEnableSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightMonitorEnable, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightMonitorShow(AzureHdinsightMonitorShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightMonitorShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightMonitorShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightMonitorShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightMonitorShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightMonitorShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightMonitorShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightMonitorShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightMonitorShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightMonitorShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightMonitorShow(Configure<AzureHdinsightMonitorShowSettings> configurator)
        {
            return AzureHdinsightMonitorShow(configurator(new AzureHdinsightMonitorShowSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightMonitorShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightMonitorShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightMonitorShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightMonitorShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightMonitorShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightMonitorShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightMonitorShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightMonitorShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightMonitorShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightMonitorShow(CombinatorialConfigure<AzureHdinsightMonitorShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightMonitorShow, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationCreate(AzureHdinsightApplicationCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightApplicationCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--access-mode</c> via <see cref="AzureHdinsightApplicationCreateSettings.AccessMode"/></li>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationCreateSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationCreateSettings.Debug"/></li>
        ///     <li><c>--destination-port</c> via <see cref="AzureHdinsightApplicationCreateSettings.DestinationPort"/></li>
        ///     <li><c>--disable-gateway-auth</c> via <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></li>
        ///     <li><c>--edgenode-size</c> via <see cref="AzureHdinsightApplicationCreateSettings.EdgenodeSize"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationCreateSettings.Help"/></li>
        ///     <li><c>--marketplace-id</c> via <see cref="AzureHdinsightApplicationCreateSettings.MarketplaceId"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationCreateSettings.Name"/></li>
        ///     <li><c>--no-validation-timeout</c> via <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--script-action-name</c> via <see cref="AzureHdinsightApplicationCreateSettings.ScriptActionName"/></li>
        ///     <li><c>--script-parameters</c> via <see cref="AzureHdinsightApplicationCreateSettings.ScriptParameters"/></li>
        ///     <li><c>--script-uri</c> via <see cref="AzureHdinsightApplicationCreateSettings.ScriptUri"/></li>
        ///     <li><c>--ssh-password</c> via <see cref="AzureHdinsightApplicationCreateSettings.SshPassword"/></li>
        ///     <li><c>--ssh-public-key</c> via <see cref="AzureHdinsightApplicationCreateSettings.SshPublicKey"/></li>
        ///     <li><c>--ssh-user</c> via <see cref="AzureHdinsightApplicationCreateSettings.SshUser"/></li>
        ///     <li><c>--sub-domain-suffix</c> via <see cref="AzureHdinsightApplicationCreateSettings.SubDomainSuffix"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureHdinsightApplicationCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureHdinsightApplicationCreateSettings.Tags"/></li>
        ///     <li><c>--type</c> via <see cref="AzureHdinsightApplicationCreateSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureHdinsightApplicationCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationCreate(Configure<AzureHdinsightApplicationCreateSettings> configurator)
        {
            return AzureHdinsightApplicationCreate(configurator(new AzureHdinsightApplicationCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--access-mode</c> via <see cref="AzureHdinsightApplicationCreateSettings.AccessMode"/></li>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationCreateSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationCreateSettings.Debug"/></li>
        ///     <li><c>--destination-port</c> via <see cref="AzureHdinsightApplicationCreateSettings.DestinationPort"/></li>
        ///     <li><c>--disable-gateway-auth</c> via <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></li>
        ///     <li><c>--edgenode-size</c> via <see cref="AzureHdinsightApplicationCreateSettings.EdgenodeSize"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationCreateSettings.Help"/></li>
        ///     <li><c>--marketplace-id</c> via <see cref="AzureHdinsightApplicationCreateSettings.MarketplaceId"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationCreateSettings.Name"/></li>
        ///     <li><c>--no-validation-timeout</c> via <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--script-action-name</c> via <see cref="AzureHdinsightApplicationCreateSettings.ScriptActionName"/></li>
        ///     <li><c>--script-parameters</c> via <see cref="AzureHdinsightApplicationCreateSettings.ScriptParameters"/></li>
        ///     <li><c>--script-uri</c> via <see cref="AzureHdinsightApplicationCreateSettings.ScriptUri"/></li>
        ///     <li><c>--ssh-password</c> via <see cref="AzureHdinsightApplicationCreateSettings.SshPassword"/></li>
        ///     <li><c>--ssh-public-key</c> via <see cref="AzureHdinsightApplicationCreateSettings.SshPublicKey"/></li>
        ///     <li><c>--ssh-user</c> via <see cref="AzureHdinsightApplicationCreateSettings.SshUser"/></li>
        ///     <li><c>--sub-domain-suffix</c> via <see cref="AzureHdinsightApplicationCreateSettings.SubDomainSuffix"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureHdinsightApplicationCreateSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureHdinsightApplicationCreateSettings.Tags"/></li>
        ///     <li><c>--type</c> via <see cref="AzureHdinsightApplicationCreateSettings.Type"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-name</c> via <see cref="AzureHdinsightApplicationCreateSettings.VnetName"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightApplicationCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightApplicationCreate(CombinatorialConfigure<AzureHdinsightApplicationCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightApplicationCreate, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationDelete(AzureHdinsightApplicationDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightApplicationDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationDeleteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationDelete(Configure<AzureHdinsightApplicationDeleteSettings> configurator)
        {
            return AzureHdinsightApplicationDelete(configurator(new AzureHdinsightApplicationDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationDeleteSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureHdinsightApplicationDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightApplicationDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightApplicationDelete(CombinatorialConfigure<AzureHdinsightApplicationDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightApplicationDelete, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationList(AzureHdinsightApplicationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightApplicationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationListSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationList(Configure<AzureHdinsightApplicationListSettings> configurator)
        {
            return AzureHdinsightApplicationList(configurator(new AzureHdinsightApplicationListSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationListSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightApplicationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightApplicationList(CombinatorialConfigure<AzureHdinsightApplicationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightApplicationList, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationShow(AzureHdinsightApplicationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightApplicationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationShowSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationShow(Configure<AzureHdinsightApplicationShowSettings> configurator)
        {
            return AzureHdinsightApplicationShow(configurator(new AzureHdinsightApplicationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationShowSettings.ClusterName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightApplicationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightApplicationShow(CombinatorialConfigure<AzureHdinsightApplicationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightApplicationShow, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationWait(AzureHdinsightApplicationWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureHdinsightApplicationWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationWaitSettings.ClusterName"/></li>
        ///     <li><c>--created</c> via <see cref="AzureHdinsightApplicationWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureHdinsightApplicationWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureHdinsightApplicationWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureHdinsightApplicationWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureHdinsightApplicationWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureHdinsightApplicationWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureHdinsightApplicationWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureHdinsightApplicationWait(Configure<AzureHdinsightApplicationWaitSettings> configurator)
        {
            return AzureHdinsightApplicationWait(configurator(new AzureHdinsightApplicationWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage HDInsight resources.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/hdinsight?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--cluster-name</c> via <see cref="AzureHdinsightApplicationWaitSettings.ClusterName"/></li>
        ///     <li><c>--created</c> via <see cref="AzureHdinsightApplicationWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureHdinsightApplicationWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureHdinsightApplicationWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureHdinsightApplicationWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureHdinsightApplicationWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureHdinsightApplicationWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureHdinsightApplicationWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureHdinsightApplicationWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureHdinsightApplicationWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureHdinsightApplicationWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureHdinsightApplicationWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureHdinsightApplicationWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureHdinsightApplicationWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureHdinsightApplicationWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureHdinsightApplicationWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureHdinsightApplicationWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureHdinsightApplicationWait(CombinatorialConfigure<AzureHdinsightApplicationWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureHdinsightApplicationWait, AzureHdinsightLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureHdinsightCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.
        /// </summary>
        public virtual bool? NoValidationTimeout { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Type of HDInsight cluster, like: hadoop, interactivehive, hbase, kafka, storm, spark, rserver, mlservices. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types</a>.
        /// </summary>
        public virtual string Type { get; internal set; }
        /// <summary>
        ///   Extra configurations of various components. Configurations may be supplied from a file using the `@{path}` syntax or a JSON string. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-customize-cluster-bootstrap">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-customize-cluster-bootstrap</a>.
        /// </summary>
        public virtual string ClusterConfigurations { get; internal set; }
        /// <summary>
        ///   The tier of the cluster.
        /// </summary>
        public virtual HdinsightCreateClusterTier ClusterTier { get; internal set; }
        /// <summary>
        ///   The versions of various Hadoop components, in space-separated versions in 'component=version' format. Example: Spark=2.0 Hadoop=2.7.3 See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions">https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions</a>.
        /// </summary>
        public virtual string ComponentVersion { get; internal set; }
        /// <summary>
        ///   Specify to create cluster with Enterprise Security Package. If omitted, creating cluster with Enterprise Security Package will not not allowed.
        /// </summary>
        public virtual string Esp { get; internal set; }
        /// <summary>
        ///   The HDInsight cluster version. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions">https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions</a>.
        /// </summary>
        public virtual string Version { get; internal set; }
        /// <summary>
        ///   Algorithm identifier for encryption.
        /// </summary>
        public virtual HdinsightCreateEncryptionAlgorithm EncryptionAlgorithm { get; internal set; }
        /// <summary>
        ///   Key name that is used for enabling disk encryption.
        /// </summary>
        public virtual string EncryptionKeyName { get; internal set; }
        /// <summary>
        ///   Key version that is used for enabling disk encryption.
        /// </summary>
        public virtual string EncryptionKeyVersion { get; internal set; }
        /// <summary>
        ///   Base key vault URI where the customers key is located eg. <a href="https://myvault.vault.azure.net">https://myvault.vault.azure.net</a>.
        /// </summary>
        public virtual string EncryptionVaultUri { get; internal set; }
        /// <summary>
        ///   The domain user account that will have admin privileges on the cluster. Required only when create cluster with Enterprise Security Package.
        /// </summary>
        public virtual string ClusterAdminAccount { get; internal set; }
        /// <summary>
        ///   The domain admin password. Required only when create cluster with Enterprise Security Package.
        /// </summary>
        public virtual string ClusterAdminPassword { get; internal set; }
        /// <summary>
        ///   A space-delimited list of Distinguished Names for cluster user groups. Required only when create cluster with Enterprise Security Package.
        /// </summary>
        public virtual string ClusterUsersGroupDns { get; internal set; }
        /// <summary>
        ///   The name or resource ID of the user's Azure Active Directory Domain Service. Required only when create cluster with Enterprise Security Package.
        /// </summary>
        public virtual string Domain { get; internal set; }
        /// <summary>
        ///   A space-delimited list of LDAPS protocol URLs to communicate with the Active Directory. Required only when create cluster with Enterprise Security Package.
        /// </summary>
        public virtual string LdapsUrls { get; internal set; }
        /// <summary>
        ///   HTTP password for the cluster. Will prompt if not given.
        /// </summary>
        public virtual string HttpPassword { get; internal set; }
        /// <summary>
        ///   HTTP username for the cluster.  Default: admin.
        /// </summary>
        public virtual string HttpUser { get; internal set; }
        /// <summary>
        ///   The name or ID of user assigned identity.
        /// </summary>
        public virtual string AssignIdentity { get; internal set; }
        /// <summary>
        ///   The name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   The name of a virtual network.
        /// </summary>
        public virtual string VnetName { get; internal set; }
        /// <summary>
        ///   The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.
        /// </summary>
        public virtual string EdgenodeSize { get; internal set; }
        /// <summary>
        ///   The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.
        /// </summary>
        public virtual string HeadnodeSize { get; internal set; }
        /// <summary>
        ///   The number of worker nodes in the cluster.
        /// </summary>
        public virtual string WorkernodeCount { get; internal set; }
        /// <summary>
        ///   The size of the data disk in GB, e.g. 1023.
        /// </summary>
        public virtual string WorkernodeDataDiskSize { get; internal set; }
        /// <summary>
        ///   The type of storage account that will be used for the data disks: standard_lrs or premium_lrs.
        /// </summary>
        public virtual HdinsightCreateWorkernodeDataDiskStorageAccountType WorkernodeDataDiskStorageAccountType { get; internal set; }
        /// <summary>
        ///   The number of data disks to use per worker node.
        /// </summary>
        public virtual string WorkernodeDataDisksPerNode { get; internal set; }
        /// <summary>
        ///   The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.
        /// </summary>
        public virtual string WorkernodeSize { get; internal set; }
        /// <summary>
        ///   The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.
        /// </summary>
        public virtual string ZookeepernodeSize { get; internal set; }
        /// <summary>
        ///   SSH password for the cluster nodes. If none specified, uses the HTTP password.
        /// </summary>
        public virtual string SshPassword { get; internal set; }
        /// <summary>
        ///   SSH public key for the cluster nodes.
        /// </summary>
        public virtual string SshPublicKey { get; internal set; }
        /// <summary>
        ///   SSH username for the cluster nodes.
        /// </summary>
        public virtual string SshUser { get; internal set; }
        /// <summary>
        ///   The name or ID of the storage account.
        /// </summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary>
        ///   The storage account key. A key can be retrieved automatically if the user has access to the storage account.
        /// </summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary>
        ///   User-assigned managed identity with access to the storage account filesystem. Only required when storage account type is Azure Data Lake Storage Gen2.
        /// </summary>
        public virtual string StorageAccountManagedIdentity { get; internal set; }
        /// <summary>
        ///   The storage container the cluster will use. Uses the cluster name if none was specified. (WASB only).
        /// </summary>
        public virtual string StorageContainer { get; internal set; }
        /// <summary>
        ///   The storage filesystem the cluster will use. Uses the cluster name if none was specified. (DFS only).
        /// </summary>
        public virtual string StorageFilesystem { get; internal set; }
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
              .Add("hdinsight create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--no-validation-timeout", NoValidationTimeout)
              .Add("--no-wait", NoWait)
              .Add("--tags {value}", Tags)
              .Add("--type {value}", Type)
              .Add("--cluster-configurations {value}", ClusterConfigurations)
              .Add("--cluster-tier {value}", ClusterTier)
              .Add("--component-version {value}", ComponentVersion)
              .Add("--esp {value}", Esp)
              .Add("--version {value}", Version)
              .Add("--encryption-algorithm {value}", EncryptionAlgorithm)
              .Add("--encryption-key-name {value}", EncryptionKeyName)
              .Add("--encryption-key-version {value}", EncryptionKeyVersion)
              .Add("--encryption-vault-uri {value}", EncryptionVaultUri)
              .Add("--cluster-admin-account {value}", ClusterAdminAccount)
              .Add("--cluster-admin-password {value}", ClusterAdminPassword, secret: true)
              .Add("--cluster-users-group-dns {value}", ClusterUsersGroupDns)
              .Add("--domain {value}", Domain)
              .Add("--ldaps-urls {value}", LdapsUrls)
              .Add("--http-password {value}", HttpPassword, secret: true)
              .Add("--http-user {value}", HttpUser)
              .Add("--assign-identity {value}", AssignIdentity)
              .Add("--subnet {value}", Subnet)
              .Add("--vnet-name {value}", VnetName)
              .Add("--edgenode-size {value}", EdgenodeSize)
              .Add("--headnode-size {value}", HeadnodeSize)
              .Add("--workernode-count {value}", WorkernodeCount)
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
              .Add("--storage-account-managed-identity {value}", StorageAccountManagedIdentity)
              .Add("--storage-container {value}", StorageContainer)
              .Add("--storage-filesystem {value}", StorageFilesystem)
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
    #region AzureHdinsightDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("hdinsight delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
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
    #region AzureHdinsightListSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
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
              .Add("hdinsight list")
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
    #region AzureHdinsightListUsageSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightListUsageSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("hdinsight list-usage")
              .Add("--location {value}", Location)
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
    #region AzureHdinsightResizeSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightResizeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The target worker node instance count for the operation.
        /// </summary>
        public virtual string WorkernodeCount { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("hdinsight resize")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workernode-count {value}", WorkernodeCount)
              .Add("--no-wait", NoWait)
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
    #region AzureHdinsightRotateDiskEncryptionKeySettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightRotateDiskEncryptionKeySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Key name that is used for enabling disk encryption.
        /// </summary>
        public virtual string EncryptionKeyName { get; internal set; }
        /// <summary>
        ///   Key version that is used for enabling disk encryption.
        /// </summary>
        public virtual string EncryptionKeyVersion { get; internal set; }
        /// <summary>
        ///   Base key vault URI where the customers key is located eg. <a href="https://myvault.vault.azure.net">https://myvault.vault.azure.net</a>.
        /// </summary>
        public virtual string EncryptionVaultUri { get; internal set; }
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
              .Add("hdinsight rotate-disk-encryption-key")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--encryption-key-name {value}", EncryptionKeyName)
              .Add("--encryption-key-version {value}", EncryptionKeyVersion)
              .Add("--encryption-vault-uri {value}", EncryptionVaultUri)
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
    #region AzureHdinsightShowSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
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
              .Add("hdinsight show")
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
    #region AzureHdinsightUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("hdinsight update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureHdinsightWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
        /// <summary>
        ///   Wait until the resource exists.
        /// </summary>
        public virtual string Exists { get; internal set; }
        /// <summary>
        ///   Polling interval in seconds.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Maximum wait in seconds.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
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
    #region AzureHdinsightScriptActionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightScriptActionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The name of the script.
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
              .Add("hdinsight script-action delete")
              .Add("--cluster-name {value}", ClusterName)
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
    #region AzureHdinsightScriptActionExecuteSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightScriptActionExecuteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The name of the script action.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   A space-delimited list of roles (nodes) where the script will be executed. Valid roles are headnode, workernode, zookeepernode, edgenode.
        /// </summary>
        public virtual string Roles { get; internal set; }
        /// <summary>
        ///   The URI to the script.
        /// </summary>
        public virtual string ScriptUri { get; internal set; }
        /// <summary>
        ///   If the scripts needs to be persisted.
        /// </summary>
        public virtual string PersistOnSuccess { get; internal set; }
        /// <summary>
        ///   The parameters for the script.
        /// </summary>
        public virtual string ScriptParameters { get; internal set; }
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
              .Add("hdinsight script-action execute")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--roles {value}", Roles)
              .Add("--script-uri {value}", ScriptUri)
              .Add("--persist-on-success {value}", PersistOnSuccess)
              .Add("--script-parameters {value}", ScriptParameters)
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
    #region AzureHdinsightScriptActionListSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightScriptActionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
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
              .Add("hdinsight script-action list")
              .Add("--cluster-name {value}", ClusterName)
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
    #region AzureHdinsightScriptActionListExecutionHistorySettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightScriptActionListExecutionHistorySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
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
              .Add("hdinsight script-action list-execution-history")
              .Add("--cluster-name {value}", ClusterName)
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
    #region AzureHdinsightScriptActionPromoteSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightScriptActionPromoteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The script execution id.
        /// </summary>
        public virtual string ExecutionId { get; internal set; }
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
              .Add("hdinsight script-action promote")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--execution-id {value}", ExecutionId)
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
    #region AzureHdinsightScriptActionShowExecutionDetailsSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightScriptActionShowExecutionDetailsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The script execution id.
        /// </summary>
        public virtual string ExecutionId { get; internal set; }
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
              .Add("hdinsight script-action show-execution-details")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--execution-id {value}", ExecutionId)
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
    #region AzureHdinsightMonitorDisableSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightMonitorDisableSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
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
              .Add("hdinsight monitor disable")
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
    #region AzureHdinsightMonitorEnableSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightMonitorEnableSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The name, resource ID or workspace ID of Log Analytics workspace.
        /// </summary>
        public virtual string Workspace { get; internal set; }
        /// <summary>
        ///   Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.
        /// </summary>
        public virtual bool? NoValidationTimeout { get; internal set; }
        /// <summary>
        ///   The certificate for the Log Analytics workspace. Required when workspace ID is provided.
        /// </summary>
        public virtual string PrimaryKey { get; internal set; }
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
              .Add("hdinsight monitor enable")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--no-validation-timeout", NoValidationTimeout)
              .Add("--primary-key {value}", PrimaryKey)
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
    #region AzureHdinsightMonitorShowSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightMonitorShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
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
              .Add("hdinsight monitor show")
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
    #region AzureHdinsightApplicationCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightApplicationCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The constant value for the application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The marketplace identifier.
        /// </summary>
        public virtual string MarketplaceId { get; internal set; }
        /// <summary>
        ///   Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.
        /// </summary>
        public virtual bool? NoValidationTimeout { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The application type.
        /// </summary>
        public virtual HdinsightApplicationCreateType Type { get; internal set; }
        /// <summary>
        ///   The access mode for the application.
        /// </summary>
        public virtual string AccessMode { get; internal set; }
        /// <summary>
        ///   The destination port to connect to.
        /// </summary>
        public virtual string DestinationPort { get; internal set; }
        /// <summary>
        ///   Indicates whether to disable gateway authentication. Default is to enable gateway authentication. Default: false.
        /// </summary>
        public virtual bool? DisableGatewayAuth { get; internal set; }
        /// <summary>
        ///   The subdomain suffix of the application.
        /// </summary>
        public virtual string SubDomainSuffix { get; internal set; }
        /// <summary>
        ///   The name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   The name of a virtual network.
        /// </summary>
        public virtual string VnetName { get; internal set; }
        /// <summary>
        ///   The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.
        /// </summary>
        public virtual string EdgenodeSize { get; internal set; }
        /// <summary>
        ///   SSH password for the cluster nodes.
        /// </summary>
        public virtual string SshPassword { get; internal set; }
        /// <summary>
        ///   SSH public key for the cluster nodes.
        /// </summary>
        public virtual string SshPublicKey { get; internal set; }
        /// <summary>
        ///   SSH username for the cluster nodes.
        /// </summary>
        public virtual string SshUser { get; internal set; }
        /// <summary>
        ///   The name of the script action.
        /// </summary>
        public virtual string ScriptActionName { get; internal set; }
        /// <summary>
        ///   The URI to the script.
        /// </summary>
        public virtual string ScriptUri { get; internal set; }
        /// <summary>
        ///   The parameters for the script.
        /// </summary>
        public virtual string ScriptParameters { get; internal set; }
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
              .Add("hdinsight application create")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--marketplace-id {value}", MarketplaceId)
              .Add("--no-validation-timeout", NoValidationTimeout)
              .Add("--tags {value}", Tags)
              .Add("--type {value}", Type)
              .Add("--access-mode {value}", AccessMode)
              .Add("--destination-port {value}", DestinationPort)
              .Add("--disable-gateway-auth", DisableGatewayAuth)
              .Add("--sub-domain-suffix {value}", SubDomainSuffix)
              .Add("--subnet {value}", Subnet)
              .Add("--vnet-name {value}", VnetName)
              .Add("--edgenode-size {value}", EdgenodeSize)
              .Add("--ssh-password {value}", SshPassword, secret: true)
              .Add("--ssh-public-key {value}", SshPublicKey)
              .Add("--ssh-user {value}", SshUser)
              .Add("--script-action-name {value}", ScriptActionName)
              .Add("--script-uri {value}", ScriptUri)
              .Add("--script-parameters {value}", ScriptParameters)
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
    #region AzureHdinsightApplicationDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightApplicationDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The constant value for the application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation.
        /// </summary>
        public virtual string Yes { get; internal set; }
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
              .Add("hdinsight application delete")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--yes {value}", Yes)
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
    #region AzureHdinsightApplicationListSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightApplicationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
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
              .Add("hdinsight application list")
              .Add("--cluster-name {value}", ClusterName)
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
    #region AzureHdinsightApplicationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightApplicationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The constant value for the application name.
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
              .Add("hdinsight application show")
              .Add("--cluster-name {value}", ClusterName)
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
    #region AzureHdinsightApplicationWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureHdinsightApplicationWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureHdinsight executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureHdinsightTasks.AzureHdinsightPath;
        public override Action<OutputType, string> CustomLogger => AzureHdinsightTasks.AzureHdinsightLogger;
        /// <summary>
        ///   The name of the cluster.
        /// </summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary>
        ///   The constant value for the application name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Wait until created with 'provisioningState' at 'Succeeded'.
        /// </summary>
        public virtual string Created { get; internal set; }
        /// <summary>
        ///   Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].
        /// </summary>
        public virtual string Custom { get; internal set; }
        /// <summary>
        ///   Wait until deleted.
        /// </summary>
        public virtual string Deleted { get; internal set; }
        /// <summary>
        ///   Wait until the resource exists.
        /// </summary>
        public virtual string Exists { get; internal set; }
        /// <summary>
        ///   Polling interval in seconds.
        /// </summary>
        public virtual string Interval { get; internal set; }
        /// <summary>
        ///   Maximum wait in seconds.
        /// </summary>
        public virtual string Timeout { get; internal set; }
        /// <summary>
        ///   Wait until updated with provisioningState at 'Succeeded'.
        /// </summary>
        public virtual string Updated { get; internal set; }
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
              .Add("hdinsight application wait")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
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
    #region AzureHdinsightCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetName(this AzureHdinsightCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetName(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetResourceGroup(this AzureHdinsightCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetResourceGroup(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetLocation(this AzureHdinsightCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetLocation(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoValidationTimeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetNoValidationTimeout(this AzureHdinsightCreateSettings toolSettings, bool? noValidationTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = noValidationTimeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetNoValidationTimeout(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings EnableNoValidationTimeout(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings DisableNoValidationTimeout(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ToggleNoValidationTimeout(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = !toolSettings.NoValidationTimeout;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetNoWait(this AzureHdinsightCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings EnableNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings DisableNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ToggleNoWait(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetTags(this AzureHdinsightCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetTags(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Type
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Type"/></em></p>
        ///   <p>Type of HDInsight cluster, like: hadoop, interactivehive, hbase, kafka, storm, spark, rserver, mlservices. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetType(this AzureHdinsightCreateSettings toolSettings, string type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Type"/></em></p>
        ///   <p>Type of HDInsight cluster, like: hadoop, interactivehive, hbase, kafka, storm, spark, rserver, mlservices. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#cluster-types</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetType(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region ClusterConfigurations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterConfigurations"/></em></p>
        ///   <p>Extra configurations of various components. Configurations may be supplied from a file using the `@{path}` syntax or a JSON string. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-customize-cluster-bootstrap">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-customize-cluster-bootstrap</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterConfigurations(this AzureHdinsightCreateSettings toolSettings, string clusterConfigurations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterConfigurations = clusterConfigurations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterConfigurations"/></em></p>
        ///   <p>Extra configurations of various components. Configurations may be supplied from a file using the `@{path}` syntax or a JSON string. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-customize-cluster-bootstrap">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-customize-cluster-bootstrap</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterConfigurations(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterConfigurations = null;
            return toolSettings;
        }
        #endregion
        #region ClusterTier
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterTier"/></em></p>
        ///   <p>The tier of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterTier(this AzureHdinsightCreateSettings toolSettings, HdinsightCreateClusterTier clusterTier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterTier = clusterTier;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterTier"/></em></p>
        ///   <p>The tier of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterTier(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterTier = null;
            return toolSettings;
        }
        #endregion
        #region ComponentVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ComponentVersion"/></em></p>
        ///   <p>The versions of various Hadoop components, in space-separated versions in 'component=version' format. Example: Spark=2.0 Hadoop=2.7.3 See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions">https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetComponentVersion(this AzureHdinsightCreateSettings toolSettings, string componentVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComponentVersion = componentVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ComponentVersion"/></em></p>
        ///   <p>The versions of various Hadoop components, in space-separated versions in 'component=version' format. Example: Spark=2.0 Hadoop=2.7.3 See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions">https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#hadoop-components-available-with-different-hdinsight-versions</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetComponentVersion(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComponentVersion = null;
            return toolSettings;
        }
        #endregion
        #region Esp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Esp"/></em></p>
        ///   <p>Specify to create cluster with Enterprise Security Package. If omitted, creating cluster with Enterprise Security Package will not not allowed.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEsp(this AzureHdinsightCreateSettings toolSettings, string esp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Esp = esp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Esp"/></em></p>
        ///   <p>Specify to create cluster with Enterprise Security Package. If omitted, creating cluster with Enterprise Security Package will not not allowed.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEsp(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Esp = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Version"/></em></p>
        ///   <p>The HDInsight cluster version. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions">https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetVersion(this AzureHdinsightCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Version"/></em></p>
        ///   <p>The HDInsight cluster version. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions">https://docs.microsoft.com/azure/hdinsight/hdinsight-component-versioning#supported-hdinsight-versions</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetVersion(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionAlgorithm
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.EncryptionAlgorithm"/></em></p>
        ///   <p>Algorithm identifier for encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEncryptionAlgorithm(this AzureHdinsightCreateSettings toolSettings, HdinsightCreateEncryptionAlgorithm encryptionAlgorithm)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionAlgorithm = encryptionAlgorithm;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.EncryptionAlgorithm"/></em></p>
        ///   <p>Algorithm identifier for encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEncryptionAlgorithm(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionAlgorithm = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionKeyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.EncryptionKeyName"/></em></p>
        ///   <p>Key name that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEncryptionKeyName(this AzureHdinsightCreateSettings toolSettings, string encryptionKeyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyName = encryptionKeyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.EncryptionKeyName"/></em></p>
        ///   <p>Key name that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEncryptionKeyName(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyName = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionKeyVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.EncryptionKeyVersion"/></em></p>
        ///   <p>Key version that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEncryptionKeyVersion(this AzureHdinsightCreateSettings toolSettings, string encryptionKeyVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyVersion = encryptionKeyVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.EncryptionKeyVersion"/></em></p>
        ///   <p>Key version that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEncryptionKeyVersion(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyVersion = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionVaultUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.EncryptionVaultUri"/></em></p>
        ///   <p>Base key vault URI where the customers key is located eg. <a href="https://myvault.vault.azure.net">https://myvault.vault.azure.net</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEncryptionVaultUri(this AzureHdinsightCreateSettings toolSettings, string encryptionVaultUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionVaultUri = encryptionVaultUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.EncryptionVaultUri"/></em></p>
        ///   <p>Base key vault URI where the customers key is located eg. <a href="https://myvault.vault.azure.net">https://myvault.vault.azure.net</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEncryptionVaultUri(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionVaultUri = null;
            return toolSettings;
        }
        #endregion
        #region ClusterAdminAccount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterAdminAccount"/></em></p>
        ///   <p>The domain user account that will have admin privileges on the cluster. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterAdminAccount(this AzureHdinsightCreateSettings toolSettings, string clusterAdminAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterAdminAccount = clusterAdminAccount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterAdminAccount"/></em></p>
        ///   <p>The domain user account that will have admin privileges on the cluster. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterAdminAccount(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterAdminAccount = null;
            return toolSettings;
        }
        #endregion
        #region ClusterAdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterAdminPassword"/></em></p>
        ///   <p>The domain admin password. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterAdminPassword(this AzureHdinsightCreateSettings toolSettings, string clusterAdminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterAdminPassword = clusterAdminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterAdminPassword"/></em></p>
        ///   <p>The domain admin password. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterAdminPassword(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterAdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region ClusterUsersGroupDns
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ClusterUsersGroupDns"/></em></p>
        ///   <p>A space-delimited list of Distinguished Names for cluster user groups. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetClusterUsersGroupDns(this AzureHdinsightCreateSettings toolSettings, string clusterUsersGroupDns)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterUsersGroupDns = clusterUsersGroupDns;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ClusterUsersGroupDns"/></em></p>
        ///   <p>A space-delimited list of Distinguished Names for cluster user groups. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetClusterUsersGroupDns(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterUsersGroupDns = null;
            return toolSettings;
        }
        #endregion
        #region Domain
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Domain"/></em></p>
        ///   <p>The name or resource ID of the user's Azure Active Directory Domain Service. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetDomain(this AzureHdinsightCreateSettings toolSettings, string domain)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Domain = domain;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Domain"/></em></p>
        ///   <p>The name or resource ID of the user's Azure Active Directory Domain Service. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetDomain(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Domain = null;
            return toolSettings;
        }
        #endregion
        #region LdapsUrls
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.LdapsUrls"/></em></p>
        ///   <p>A space-delimited list of LDAPS protocol URLs to communicate with the Active Directory. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetLdapsUrls(this AzureHdinsightCreateSettings toolSettings, string ldapsUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LdapsUrls = ldapsUrls;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.LdapsUrls"/></em></p>
        ///   <p>A space-delimited list of LDAPS protocol URLs to communicate with the Active Directory. Required only when create cluster with Enterprise Security Package.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetLdapsUrls(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LdapsUrls = null;
            return toolSettings;
        }
        #endregion
        #region HttpPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.HttpPassword"/></em></p>
        ///   <p>HTTP password for the cluster. Will prompt if not given.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHttpPassword(this AzureHdinsightCreateSettings toolSettings, string httpPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpPassword = httpPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.HttpPassword"/></em></p>
        ///   <p>HTTP password for the cluster. Will prompt if not given.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHttpPassword(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpPassword = null;
            return toolSettings;
        }
        #endregion
        #region HttpUser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.HttpUser"/></em></p>
        ///   <p>HTTP username for the cluster.  Default: admin.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHttpUser(this AzureHdinsightCreateSettings toolSettings, string httpUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpUser = httpUser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.HttpUser"/></em></p>
        ///   <p>HTTP username for the cluster.  Default: admin.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHttpUser(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HttpUser = null;
            return toolSettings;
        }
        #endregion
        #region AssignIdentity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.AssignIdentity"/></em></p>
        ///   <p>The name or ID of user assigned identity.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetAssignIdentity(this AzureHdinsightCreateSettings toolSettings, string assignIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = assignIdentity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.AssignIdentity"/></em></p>
        ///   <p>The name or ID of user assigned identity.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetAssignIdentity(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssignIdentity = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Subnet"/></em></p>
        ///   <p>The name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSubnet(this AzureHdinsightCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Subnet"/></em></p>
        ///   <p>The name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSubnet(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.VnetName"/></em></p>
        ///   <p>The name of a virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetVnetName(this AzureHdinsightCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.VnetName"/></em></p>
        ///   <p>The name of a virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetVnetName(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region EdgenodeSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.EdgenodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetEdgenodeSize(this AzureHdinsightCreateSettings toolSettings, string edgenodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EdgenodeSize = edgenodeSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.EdgenodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetEdgenodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EdgenodeSize = null;
            return toolSettings;
        }
        #endregion
        #region HeadnodeSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.HeadnodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHeadnodeSize(this AzureHdinsightCreateSettings toolSettings, string headnodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadnodeSize = headnodeSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.HeadnodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHeadnodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HeadnodeSize = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeCount"/></em></p>
        ///   <p>The number of worker nodes in the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeCount(this AzureHdinsightCreateSettings toolSettings, string workernodeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeCount = workernodeCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeCount"/></em></p>
        ///   <p>The number of worker nodes in the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeCount(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeCount = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeDataDiskSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskSize"/></em></p>
        ///   <p>The size of the data disk in GB, e.g. 1023.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeDataDiskSize(this AzureHdinsightCreateSettings toolSettings, string workernodeDataDiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskSize = workernodeDataDiskSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskSize"/></em></p>
        ///   <p>The size of the data disk in GB, e.g. 1023.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeDataDiskSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskSize = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeDataDiskStorageAccountType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskStorageAccountType"/></em></p>
        ///   <p>The type of storage account that will be used for the data disks: standard_lrs or premium_lrs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeDataDiskStorageAccountType(this AzureHdinsightCreateSettings toolSettings, HdinsightCreateWorkernodeDataDiskStorageAccountType workernodeDataDiskStorageAccountType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskStorageAccountType = workernodeDataDiskStorageAccountType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDiskStorageAccountType"/></em></p>
        ///   <p>The type of storage account that will be used for the data disks: standard_lrs or premium_lrs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeDataDiskStorageAccountType(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDiskStorageAccountType = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeDataDisksPerNode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDisksPerNode"/></em></p>
        ///   <p>The number of data disks to use per worker node.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeDataDisksPerNode(this AzureHdinsightCreateSettings toolSettings, string workernodeDataDisksPerNode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDisksPerNode = workernodeDataDisksPerNode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeDataDisksPerNode"/></em></p>
        ///   <p>The number of data disks to use per worker node.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeDataDisksPerNode(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeDataDisksPerNode = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.WorkernodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetWorkernodeSize(this AzureHdinsightCreateSettings toolSettings, string workernodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeSize = workernodeSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.WorkernodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetWorkernodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeSize = null;
            return toolSettings;
        }
        #endregion
        #region ZookeepernodeSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.ZookeepernodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetZookeepernodeSize(this AzureHdinsightCreateSettings toolSettings, string zookeepernodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZookeepernodeSize = zookeepernodeSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.ZookeepernodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetZookeepernodeSize(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZookeepernodeSize = null;
            return toolSettings;
        }
        #endregion
        #region SshPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.SshPassword"/></em></p>
        ///   <p>SSH password for the cluster nodes. If none specified, uses the HTTP password.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSshPassword(this AzureHdinsightCreateSettings toolSettings, string sshPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPassword = sshPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.SshPassword"/></em></p>
        ///   <p>SSH password for the cluster nodes. If none specified, uses the HTTP password.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSshPassword(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPassword = null;
            return toolSettings;
        }
        #endregion
        #region SshPublicKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.SshPublicKey"/></em></p>
        ///   <p>SSH public key for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSshPublicKey(this AzureHdinsightCreateSettings toolSettings, string sshPublicKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPublicKey = sshPublicKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.SshPublicKey"/></em></p>
        ///   <p>SSH public key for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSshPublicKey(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPublicKey = null;
            return toolSettings;
        }
        #endregion
        #region SshUser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.SshUser"/></em></p>
        ///   <p>SSH username for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSshUser(this AzureHdinsightCreateSettings toolSettings, string sshUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshUser = sshUser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.SshUser"/></em></p>
        ///   <p>SSH username for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSshUser(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshUser = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageAccount"/></em></p>
        ///   <p>The name or ID of the storage account.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageAccount(this AzureHdinsightCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageAccount"/></em></p>
        ///   <p>The name or ID of the storage account.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageAccount(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageAccountKey"/></em></p>
        ///   <p>The storage account key. A key can be retrieved automatically if the user has access to the storage account.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageAccountKey(this AzureHdinsightCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageAccountKey"/></em></p>
        ///   <p>The storage account key. A key can be retrieved automatically if the user has access to the storage account.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageAccountKey(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountManagedIdentity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageAccountManagedIdentity"/></em></p>
        ///   <p>User-assigned managed identity with access to the storage account filesystem. Only required when storage account type is Azure Data Lake Storage Gen2.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageAccountManagedIdentity(this AzureHdinsightCreateSettings toolSettings, string storageAccountManagedIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountManagedIdentity = storageAccountManagedIdentity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageAccountManagedIdentity"/></em></p>
        ///   <p>User-assigned managed identity with access to the storage account filesystem. Only required when storage account type is Azure Data Lake Storage Gen2.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageAccountManagedIdentity(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountManagedIdentity = null;
            return toolSettings;
        }
        #endregion
        #region StorageContainer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageContainer"/></em></p>
        ///   <p>The storage container the cluster will use. Uses the cluster name if none was specified. (WASB only).</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageContainer(this AzureHdinsightCreateSettings toolSettings, string storageContainer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainer = storageContainer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageContainer"/></em></p>
        ///   <p>The storage container the cluster will use. Uses the cluster name if none was specified. (WASB only).</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageContainer(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageContainer = null;
            return toolSettings;
        }
        #endregion
        #region StorageFilesystem
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.StorageFilesystem"/></em></p>
        ///   <p>The storage filesystem the cluster will use. Uses the cluster name if none was specified. (DFS only).</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetStorageFilesystem(this AzureHdinsightCreateSettings toolSettings, string storageFilesystem)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageFilesystem = storageFilesystem;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.StorageFilesystem"/></em></p>
        ///   <p>The storage filesystem the cluster will use. Uses the cluster name if none was specified. (DFS only).</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetStorageFilesystem(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageFilesystem = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetSubscription(this AzureHdinsightCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetSubscription(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetDebug(this AzureHdinsightCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetDebug(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetHelp(this AzureHdinsightCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetHelp(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetOutput(this AzureHdinsightCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetOutput(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetQuery(this AzureHdinsightCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings ResetQuery(this AzureHdinsightCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightCreateSettings SetVerbose(this AzureHdinsightCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
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
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetName(this AzureHdinsightDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetName(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetResourceGroup(this AzureHdinsightDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetResourceGroup(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetNoWait(this AzureHdinsightDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings EnableNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings DisableNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ToggleNoWait(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetYes(this AzureHdinsightDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetYes(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetSubscription(this AzureHdinsightDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetSubscription(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetDebug(this AzureHdinsightDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetDebug(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetHelp(this AzureHdinsightDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetHelp(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetOutput(this AzureHdinsightDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetOutput(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetQuery(this AzureHdinsightDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings ResetQuery(this AzureHdinsightDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightDeleteSettings SetVerbose(this AzureHdinsightDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
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
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetResourceGroup(this AzureHdinsightListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings ResetResourceGroup(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetSubscription(this AzureHdinsightListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings ResetSubscription(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetDebug(this AzureHdinsightListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings ResetDebug(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetHelp(this AzureHdinsightListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings ResetHelp(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetOutput(this AzureHdinsightListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings ResetOutput(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetQuery(this AzureHdinsightListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings ResetQuery(this AzureHdinsightListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListSettings SetVerbose(this AzureHdinsightListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
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
    #region AzureHdinsightListUsageSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightListUsageSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetLocation(this AzureHdinsightListUsageSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetLocation(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetSubscription(this AzureHdinsightListUsageSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetSubscription(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetDebug(this AzureHdinsightListUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetDebug(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetHelp(this AzureHdinsightListUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetHelp(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetOutput(this AzureHdinsightListUsageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetOutput(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetQuery(this AzureHdinsightListUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetQuery(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightListUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings SetVerbose(this AzureHdinsightListUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightListUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightListUsageSettings ResetVerbose(this AzureHdinsightListUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightResizeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightResizeSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetName(this AzureHdinsightResizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetName(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetResourceGroup(this AzureHdinsightResizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetResourceGroup(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WorkernodeCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.WorkernodeCount"/></em></p>
        ///   <p>The target worker node instance count for the operation.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetWorkernodeCount(this AzureHdinsightResizeSettings toolSettings, string workernodeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeCount = workernodeCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.WorkernodeCount"/></em></p>
        ///   <p>The target worker node instance count for the operation.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetWorkernodeCount(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkernodeCount = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetNoWait(this AzureHdinsightResizeSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightResizeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings EnableNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightResizeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings DisableNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightResizeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ToggleNoWait(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetSubscription(this AzureHdinsightResizeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetSubscription(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetDebug(this AzureHdinsightResizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetDebug(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetHelp(this AzureHdinsightResizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetHelp(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetOutput(this AzureHdinsightResizeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetOutput(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetQuery(this AzureHdinsightResizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings ResetQuery(this AzureHdinsightResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightResizeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightResizeSettings SetVerbose(this AzureHdinsightResizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightResizeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
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
    #region AzureHdinsightRotateDiskEncryptionKeySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightRotateDiskEncryptionKeySettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetName(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetName(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetResourceGroup(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetResourceGroup(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetNoWait(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetNoWait(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings EnableNoWait(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings DisableNoWait(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ToggleNoWait(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region EncryptionKeyName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyName"/></em></p>
        ///   <p>Key name that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetEncryptionKeyName(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string encryptionKeyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyName = encryptionKeyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyName"/></em></p>
        ///   <p>Key name that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetEncryptionKeyName(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyName = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionKeyVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyVersion"/></em></p>
        ///   <p>Key version that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetEncryptionKeyVersion(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string encryptionKeyVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyVersion = encryptionKeyVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionKeyVersion"/></em></p>
        ///   <p>Key version that is used for enabling disk encryption.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetEncryptionKeyVersion(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionKeyVersion = null;
            return toolSettings;
        }
        #endregion
        #region EncryptionVaultUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionVaultUri"/></em></p>
        ///   <p>Base key vault URI where the customers key is located eg. <a href="https://myvault.vault.azure.net">https://myvault.vault.azure.net</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetEncryptionVaultUri(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string encryptionVaultUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionVaultUri = encryptionVaultUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.EncryptionVaultUri"/></em></p>
        ///   <p>Base key vault URI where the customers key is located eg. <a href="https://myvault.vault.azure.net">https://myvault.vault.azure.net</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetEncryptionVaultUri(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EncryptionVaultUri = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetSubscription(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetSubscription(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetDebug(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetDebug(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetHelp(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetHelp(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetOutput(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetOutput(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetQuery(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetQuery(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings SetVerbose(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightRotateDiskEncryptionKeySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightRotateDiskEncryptionKeySettings ResetVerbose(this AzureHdinsightRotateDiskEncryptionKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetName(this AzureHdinsightShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetName(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetResourceGroup(this AzureHdinsightShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetResourceGroup(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetSubscription(this AzureHdinsightShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetSubscription(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetDebug(this AzureHdinsightShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetDebug(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetHelp(this AzureHdinsightShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetHelp(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetOutput(this AzureHdinsightShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetOutput(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetQuery(this AzureHdinsightShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings ResetQuery(this AzureHdinsightShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightShowSettings SetVerbose(this AzureHdinsightShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
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
    #region AzureHdinsightUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetName(this AzureHdinsightUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetName(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetResourceGroup(this AzureHdinsightUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetResourceGroup(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetNoWait(this AzureHdinsightUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetNoWait(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings EnableNoWait(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings DisableNoWait(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ToggleNoWait(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetTags(this AzureHdinsightUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetTags(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetSubscription(this AzureHdinsightUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetSubscription(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetDebug(this AzureHdinsightUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetDebug(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetHelp(this AzureHdinsightUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetHelp(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetOutput(this AzureHdinsightUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetOutput(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetQuery(this AzureHdinsightUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetQuery(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings SetVerbose(this AzureHdinsightUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightUpdateSettings ResetVerbose(this AzureHdinsightUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetName(this AzureHdinsightWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetName(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetResourceGroup(this AzureHdinsightWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetResourceGroup(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetCreated(this AzureHdinsightWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetCreated(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetCustom(this AzureHdinsightWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetCustom(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetDeleted(this AzureHdinsightWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetDeleted(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetExists(this AzureHdinsightWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetExists(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetInterval(this AzureHdinsightWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetInterval(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetTimeout(this AzureHdinsightWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetTimeout(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetUpdated(this AzureHdinsightWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetUpdated(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetSubscription(this AzureHdinsightWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetSubscription(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetDebug(this AzureHdinsightWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetDebug(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetHelp(this AzureHdinsightWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetHelp(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetOutput(this AzureHdinsightWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetOutput(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetQuery(this AzureHdinsightWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings ResetQuery(this AzureHdinsightWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightWaitSettings SetVerbose(this AzureHdinsightWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
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
    #region AzureHdinsightScriptActionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightScriptActionDeleteSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetClusterName(this AzureHdinsightScriptActionDeleteSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetClusterName(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Name"/></em></p>
        ///   <p>The name of the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetName(this AzureHdinsightScriptActionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Name"/></em></p>
        ///   <p>The name of the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetName(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetResourceGroup(this AzureHdinsightScriptActionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetResourceGroup(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetSubscription(this AzureHdinsightScriptActionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetSubscription(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetDebug(this AzureHdinsightScriptActionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetDebug(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetHelp(this AzureHdinsightScriptActionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetHelp(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetOutput(this AzureHdinsightScriptActionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetOutput(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetQuery(this AzureHdinsightScriptActionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetQuery(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings SetVerbose(this AzureHdinsightScriptActionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionDeleteSettings ResetVerbose(this AzureHdinsightScriptActionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightScriptActionExecuteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightScriptActionExecuteSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetClusterName(this AzureHdinsightScriptActionExecuteSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetClusterName(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Name"/></em></p>
        ///   <p>The name of the script action.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetName(this AzureHdinsightScriptActionExecuteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Name"/></em></p>
        ///   <p>The name of the script action.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetName(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetResourceGroup(this AzureHdinsightScriptActionExecuteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetResourceGroup(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Roles
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Roles"/></em></p>
        ///   <p>A space-delimited list of roles (nodes) where the script will be executed. Valid roles are headnode, workernode, zookeepernode, edgenode.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetRoles(this AzureHdinsightScriptActionExecuteSettings toolSettings, string roles)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Roles = roles;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Roles"/></em></p>
        ///   <p>A space-delimited list of roles (nodes) where the script will be executed. Valid roles are headnode, workernode, zookeepernode, edgenode.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetRoles(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Roles = null;
            return toolSettings;
        }
        #endregion
        #region ScriptUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptUri"/></em></p>
        ///   <p>The URI to the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetScriptUri(this AzureHdinsightScriptActionExecuteSettings toolSettings, string scriptUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptUri = scriptUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptUri"/></em></p>
        ///   <p>The URI to the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetScriptUri(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptUri = null;
            return toolSettings;
        }
        #endregion
        #region PersistOnSuccess
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.PersistOnSuccess"/></em></p>
        ///   <p>If the scripts needs to be persisted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetPersistOnSuccess(this AzureHdinsightScriptActionExecuteSettings toolSettings, string persistOnSuccess)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PersistOnSuccess = persistOnSuccess;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.PersistOnSuccess"/></em></p>
        ///   <p>If the scripts needs to be persisted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetPersistOnSuccess(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PersistOnSuccess = null;
            return toolSettings;
        }
        #endregion
        #region ScriptParameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptParameters"/></em></p>
        ///   <p>The parameters for the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetScriptParameters(this AzureHdinsightScriptActionExecuteSettings toolSettings, string scriptParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptParameters = scriptParameters;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.ScriptParameters"/></em></p>
        ///   <p>The parameters for the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetScriptParameters(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptParameters = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetSubscription(this AzureHdinsightScriptActionExecuteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetSubscription(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetDebug(this AzureHdinsightScriptActionExecuteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetDebug(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetHelp(this AzureHdinsightScriptActionExecuteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetHelp(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetOutput(this AzureHdinsightScriptActionExecuteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetOutput(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetQuery(this AzureHdinsightScriptActionExecuteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetQuery(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionExecuteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings SetVerbose(this AzureHdinsightScriptActionExecuteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionExecuteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionExecuteSettings ResetVerbose(this AzureHdinsightScriptActionExecuteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightScriptActionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightScriptActionListSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetClusterName(this AzureHdinsightScriptActionListSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetClusterName(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetResourceGroup(this AzureHdinsightScriptActionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetResourceGroup(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetSubscription(this AzureHdinsightScriptActionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetSubscription(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetDebug(this AzureHdinsightScriptActionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetDebug(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetHelp(this AzureHdinsightScriptActionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetHelp(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetOutput(this AzureHdinsightScriptActionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetOutput(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetQuery(this AzureHdinsightScriptActionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetQuery(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings SetVerbose(this AzureHdinsightScriptActionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListSettings ResetVerbose(this AzureHdinsightScriptActionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightScriptActionListExecutionHistorySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightScriptActionListExecutionHistorySettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetClusterName(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetClusterName(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetResourceGroup(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetResourceGroup(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetSubscription(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetSubscription(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetDebug(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetDebug(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetHelp(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetHelp(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetOutput(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetOutput(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetQuery(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetQuery(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings SetVerbose(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionListExecutionHistorySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionListExecutionHistorySettings ResetVerbose(this AzureHdinsightScriptActionListExecutionHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightScriptActionPromoteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightScriptActionPromoteSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetClusterName(this AzureHdinsightScriptActionPromoteSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetClusterName(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ExecutionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.ExecutionId"/></em></p>
        ///   <p>The script execution id.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetExecutionId(this AzureHdinsightScriptActionPromoteSettings toolSettings, string executionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecutionId = executionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.ExecutionId"/></em></p>
        ///   <p>The script execution id.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetExecutionId(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecutionId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetResourceGroup(this AzureHdinsightScriptActionPromoteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetResourceGroup(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetSubscription(this AzureHdinsightScriptActionPromoteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetSubscription(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetDebug(this AzureHdinsightScriptActionPromoteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetDebug(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetHelp(this AzureHdinsightScriptActionPromoteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetHelp(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetOutput(this AzureHdinsightScriptActionPromoteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetOutput(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetQuery(this AzureHdinsightScriptActionPromoteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetQuery(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionPromoteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings SetVerbose(this AzureHdinsightScriptActionPromoteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionPromoteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionPromoteSettings ResetVerbose(this AzureHdinsightScriptActionPromoteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightScriptActionShowExecutionDetailsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightScriptActionShowExecutionDetailsSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetClusterName(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetClusterName(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ExecutionId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ExecutionId"/></em></p>
        ///   <p>The script execution id.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetExecutionId(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string executionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecutionId = executionId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ExecutionId"/></em></p>
        ///   <p>The script execution id.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetExecutionId(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecutionId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetResourceGroup(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetResourceGroup(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetSubscription(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetSubscription(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetDebug(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetDebug(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetHelp(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetHelp(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetOutput(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetOutput(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetQuery(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetQuery(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings SetVerbose(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightScriptActionShowExecutionDetailsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightScriptActionShowExecutionDetailsSettings ResetVerbose(this AzureHdinsightScriptActionShowExecutionDetailsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightMonitorDisableSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightMonitorDisableSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetName(this AzureHdinsightMonitorDisableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetName(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetResourceGroup(this AzureHdinsightMonitorDisableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetResourceGroup(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetSubscription(this AzureHdinsightMonitorDisableSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetSubscription(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetDebug(this AzureHdinsightMonitorDisableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetDebug(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetHelp(this AzureHdinsightMonitorDisableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetHelp(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetOutput(this AzureHdinsightMonitorDisableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetOutput(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetQuery(this AzureHdinsightMonitorDisableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetQuery(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorDisableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings SetVerbose(this AzureHdinsightMonitorDisableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorDisableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorDisableSettings ResetVerbose(this AzureHdinsightMonitorDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightMonitorEnableSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightMonitorEnableSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetName(this AzureHdinsightMonitorEnableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetName(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetResourceGroup(this AzureHdinsightMonitorEnableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetResourceGroup(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Workspace"/></em></p>
        ///   <p>The name, resource ID or workspace ID of Log Analytics workspace.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetWorkspace(this AzureHdinsightMonitorEnableSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Workspace"/></em></p>
        ///   <p>The name, resource ID or workspace ID of Log Analytics workspace.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetWorkspace(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoValidationTimeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetNoValidationTimeout(this AzureHdinsightMonitorEnableSettings toolSettings, bool? noValidationTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = noValidationTimeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetNoValidationTimeout(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings EnableNoValidationTimeout(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings DisableNoValidationTimeout(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightMonitorEnableSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ToggleNoValidationTimeout(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = !toolSettings.NoValidationTimeout;
            return toolSettings;
        }
        #endregion
        #region PrimaryKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.PrimaryKey"/></em></p>
        ///   <p>The certificate for the Log Analytics workspace. Required when workspace ID is provided.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetPrimaryKey(this AzureHdinsightMonitorEnableSettings toolSettings, string primaryKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryKey = primaryKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.PrimaryKey"/></em></p>
        ///   <p>The certificate for the Log Analytics workspace. Required when workspace ID is provided.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetPrimaryKey(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrimaryKey = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetSubscription(this AzureHdinsightMonitorEnableSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetSubscription(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetDebug(this AzureHdinsightMonitorEnableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetDebug(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetHelp(this AzureHdinsightMonitorEnableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetHelp(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetOutput(this AzureHdinsightMonitorEnableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetOutput(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetQuery(this AzureHdinsightMonitorEnableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetQuery(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorEnableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings SetVerbose(this AzureHdinsightMonitorEnableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorEnableSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorEnableSettings ResetVerbose(this AzureHdinsightMonitorEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightMonitorShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightMonitorShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetName(this AzureHdinsightMonitorShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Name"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetName(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetResourceGroup(this AzureHdinsightMonitorShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetResourceGroup(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetSubscription(this AzureHdinsightMonitorShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetSubscription(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetDebug(this AzureHdinsightMonitorShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetDebug(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetHelp(this AzureHdinsightMonitorShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetHelp(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetOutput(this AzureHdinsightMonitorShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetOutput(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetQuery(this AzureHdinsightMonitorShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetQuery(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightMonitorShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings SetVerbose(this AzureHdinsightMonitorShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightMonitorShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightMonitorShowSettings ResetVerbose(this AzureHdinsightMonitorShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightApplicationCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightApplicationCreateSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetClusterName(this AzureHdinsightApplicationCreateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetClusterName(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetName(this AzureHdinsightApplicationCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetName(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetResourceGroup(this AzureHdinsightApplicationCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetResourceGroup(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region MarketplaceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.MarketplaceId"/></em></p>
        ///   <p>The marketplace identifier.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetMarketplaceId(this AzureHdinsightApplicationCreateSettings toolSettings, string marketplaceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarketplaceId = marketplaceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.MarketplaceId"/></em></p>
        ///   <p>The marketplace identifier.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetMarketplaceId(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarketplaceId = null;
            return toolSettings;
        }
        #endregion
        #region NoValidationTimeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetNoValidationTimeout(this AzureHdinsightApplicationCreateSettings toolSettings, bool? noValidationTimeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = noValidationTimeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetNoValidationTimeout(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings EnableNoValidationTimeout(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings DisableNoValidationTimeout(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightApplicationCreateSettings.NoValidationTimeout"/></em></p>
        ///   <p>Permit timeout error during argument validation phase. If omitted, validation timeout error will be permitted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ToggleNoValidationTimeout(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoValidationTimeout = !toolSettings.NoValidationTimeout;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetTags(this AzureHdinsightApplicationCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetTags(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Type
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Type"/></em></p>
        ///   <p>The application type.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetType(this AzureHdinsightApplicationCreateSettings toolSettings, HdinsightApplicationCreateType type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Type"/></em></p>
        ///   <p>The application type.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetType(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region AccessMode
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.AccessMode"/></em></p>
        ///   <p>The access mode for the application.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetAccessMode(this AzureHdinsightApplicationCreateSettings toolSettings, string accessMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessMode = accessMode;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.AccessMode"/></em></p>
        ///   <p>The access mode for the application.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetAccessMode(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessMode = null;
            return toolSettings;
        }
        #endregion
        #region DestinationPort
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.DestinationPort"/></em></p>
        ///   <p>The destination port to connect to.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetDestinationPort(this AzureHdinsightApplicationCreateSettings toolSettings, string destinationPort)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPort = destinationPort;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.DestinationPort"/></em></p>
        ///   <p>The destination port to connect to.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetDestinationPort(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationPort = null;
            return toolSettings;
        }
        #endregion
        #region DisableGatewayAuth
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></em></p>
        ///   <p>Indicates whether to disable gateway authentication. Default is to enable gateway authentication. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetDisableGatewayAuth(this AzureHdinsightApplicationCreateSettings toolSettings, bool? disableGatewayAuth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableGatewayAuth = disableGatewayAuth;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></em></p>
        ///   <p>Indicates whether to disable gateway authentication. Default is to enable gateway authentication. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetDisableGatewayAuth(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableGatewayAuth = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></em></p>
        ///   <p>Indicates whether to disable gateway authentication. Default is to enable gateway authentication. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings EnableDisableGatewayAuth(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableGatewayAuth = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></em></p>
        ///   <p>Indicates whether to disable gateway authentication. Default is to enable gateway authentication. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings DisableDisableGatewayAuth(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableGatewayAuth = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightApplicationCreateSettings.DisableGatewayAuth"/></em></p>
        ///   <p>Indicates whether to disable gateway authentication. Default is to enable gateway authentication. Default: false.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ToggleDisableGatewayAuth(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableGatewayAuth = !toolSettings.DisableGatewayAuth;
            return toolSettings;
        }
        #endregion
        #region SubDomainSuffix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.SubDomainSuffix"/></em></p>
        ///   <p>The subdomain suffix of the application.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetSubDomainSuffix(this AzureHdinsightApplicationCreateSettings toolSettings, string subDomainSuffix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubDomainSuffix = subDomainSuffix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.SubDomainSuffix"/></em></p>
        ///   <p>The subdomain suffix of the application.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetSubDomainSuffix(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubDomainSuffix = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Subnet"/></em></p>
        ///   <p>The name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetSubnet(this AzureHdinsightApplicationCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Subnet"/></em></p>
        ///   <p>The name or ID of subnet. If name is supplied, `--vnet-name` must be supplied.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetSubnet(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.VnetName"/></em></p>
        ///   <p>The name of a virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetVnetName(this AzureHdinsightApplicationCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.VnetName"/></em></p>
        ///   <p>The name of a virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetVnetName(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region EdgenodeSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.EdgenodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetEdgenodeSize(this AzureHdinsightApplicationCreateSettings toolSettings, string edgenodeSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EdgenodeSize = edgenodeSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.EdgenodeSize"/></em></p>
        ///   <p>The size of the node. See also: <a href="https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size">https://docs.microsoft.com/azure/hdinsight/hdinsight-hadoop-provision-linux-clusters#configure-cluster-size</a>.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetEdgenodeSize(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EdgenodeSize = null;
            return toolSettings;
        }
        #endregion
        #region SshPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.SshPassword"/></em></p>
        ///   <p>SSH password for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetSshPassword(this AzureHdinsightApplicationCreateSettings toolSettings, string sshPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPassword = sshPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.SshPassword"/></em></p>
        ///   <p>SSH password for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetSshPassword(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPassword = null;
            return toolSettings;
        }
        #endregion
        #region SshPublicKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.SshPublicKey"/></em></p>
        ///   <p>SSH public key for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetSshPublicKey(this AzureHdinsightApplicationCreateSettings toolSettings, string sshPublicKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPublicKey = sshPublicKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.SshPublicKey"/></em></p>
        ///   <p>SSH public key for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetSshPublicKey(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPublicKey = null;
            return toolSettings;
        }
        #endregion
        #region SshUser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.SshUser"/></em></p>
        ///   <p>SSH username for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetSshUser(this AzureHdinsightApplicationCreateSettings toolSettings, string sshUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshUser = sshUser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.SshUser"/></em></p>
        ///   <p>SSH username for the cluster nodes.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetSshUser(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshUser = null;
            return toolSettings;
        }
        #endregion
        #region ScriptActionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.ScriptActionName"/></em></p>
        ///   <p>The name of the script action.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetScriptActionName(this AzureHdinsightApplicationCreateSettings toolSettings, string scriptActionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptActionName = scriptActionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.ScriptActionName"/></em></p>
        ///   <p>The name of the script action.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetScriptActionName(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptActionName = null;
            return toolSettings;
        }
        #endregion
        #region ScriptUri
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.ScriptUri"/></em></p>
        ///   <p>The URI to the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetScriptUri(this AzureHdinsightApplicationCreateSettings toolSettings, string scriptUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptUri = scriptUri;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.ScriptUri"/></em></p>
        ///   <p>The URI to the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetScriptUri(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptUri = null;
            return toolSettings;
        }
        #endregion
        #region ScriptParameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.ScriptParameters"/></em></p>
        ///   <p>The parameters for the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetScriptParameters(this AzureHdinsightApplicationCreateSettings toolSettings, string scriptParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptParameters = scriptParameters;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.ScriptParameters"/></em></p>
        ///   <p>The parameters for the script.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetScriptParameters(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScriptParameters = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetSubscription(this AzureHdinsightApplicationCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetSubscription(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetDebug(this AzureHdinsightApplicationCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetDebug(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetHelp(this AzureHdinsightApplicationCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetHelp(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetOutput(this AzureHdinsightApplicationCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetOutput(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetQuery(this AzureHdinsightApplicationCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetQuery(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings SetVerbose(this AzureHdinsightApplicationCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationCreateSettings ResetVerbose(this AzureHdinsightApplicationCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightApplicationDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightApplicationDeleteSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetClusterName(this AzureHdinsightApplicationDeleteSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetClusterName(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetName(this AzureHdinsightApplicationDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetName(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetResourceGroup(this AzureHdinsightApplicationDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetResourceGroup(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetNoWait(this AzureHdinsightApplicationDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetNoWait(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings EnableNoWait(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings DisableNoWait(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureHdinsightApplicationDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ToggleNoWait(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetYes(this AzureHdinsightApplicationDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetYes(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetSubscription(this AzureHdinsightApplicationDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetSubscription(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetDebug(this AzureHdinsightApplicationDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetDebug(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetHelp(this AzureHdinsightApplicationDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetHelp(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetOutput(this AzureHdinsightApplicationDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetOutput(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetQuery(this AzureHdinsightApplicationDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetQuery(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings SetVerbose(this AzureHdinsightApplicationDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationDeleteSettings ResetVerbose(this AzureHdinsightApplicationDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightApplicationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightApplicationListSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetClusterName(this AzureHdinsightApplicationListSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetClusterName(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetResourceGroup(this AzureHdinsightApplicationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetResourceGroup(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetSubscription(this AzureHdinsightApplicationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetSubscription(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetDebug(this AzureHdinsightApplicationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetDebug(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetHelp(this AzureHdinsightApplicationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetHelp(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetOutput(this AzureHdinsightApplicationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetOutput(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetQuery(this AzureHdinsightApplicationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetQuery(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings SetVerbose(this AzureHdinsightApplicationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationListSettings ResetVerbose(this AzureHdinsightApplicationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightApplicationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightApplicationShowSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetClusterName(this AzureHdinsightApplicationShowSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetClusterName(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetName(this AzureHdinsightApplicationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetName(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetResourceGroup(this AzureHdinsightApplicationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetResourceGroup(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetSubscription(this AzureHdinsightApplicationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetSubscription(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetDebug(this AzureHdinsightApplicationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetDebug(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetHelp(this AzureHdinsightApplicationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetHelp(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetOutput(this AzureHdinsightApplicationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetOutput(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetQuery(this AzureHdinsightApplicationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetQuery(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings SetVerbose(this AzureHdinsightApplicationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationShowSettings ResetVerbose(this AzureHdinsightApplicationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureHdinsightApplicationWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureHdinsightApplicationWaitSettingsExtensions
    {
        #region ClusterName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetClusterName(this AzureHdinsightApplicationWaitSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.ClusterName"/></em></p>
        ///   <p>The name of the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetClusterName(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetName(this AzureHdinsightApplicationWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Name"/></em></p>
        ///   <p>The constant value for the application name.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetName(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetResourceGroup(this AzureHdinsightApplicationWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetResourceGroup(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetCreated(this AzureHdinsightApplicationWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetCreated(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetCustom(this AzureHdinsightApplicationWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetCustom(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetDeleted(this AzureHdinsightApplicationWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetDeleted(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetExists(this AzureHdinsightApplicationWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetExists(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetInterval(this AzureHdinsightApplicationWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetInterval(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetTimeout(this AzureHdinsightApplicationWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetTimeout(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetUpdated(this AzureHdinsightApplicationWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetUpdated(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetSubscription(this AzureHdinsightApplicationWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetSubscription(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetDebug(this AzureHdinsightApplicationWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetDebug(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetHelp(this AzureHdinsightApplicationWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetHelp(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetOutput(this AzureHdinsightApplicationWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetOutput(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetQuery(this AzureHdinsightApplicationWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetQuery(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureHdinsightApplicationWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings SetVerbose(this AzureHdinsightApplicationWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureHdinsightApplicationWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureHdinsightApplicationWaitSettings ResetVerbose(this AzureHdinsightApplicationWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region HdinsightCreateClusterTier
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<HdinsightCreateClusterTier>))]
    public partial class HdinsightCreateClusterTier : Enumeration
    {
        public static HdinsightCreateClusterTier premium = new HdinsightCreateClusterTier { Value = "premium" };
        public static HdinsightCreateClusterTier standard = new HdinsightCreateClusterTier { Value = "standard" };
    }
    #endregion
    #region HdinsightCreateEncryptionAlgorithm
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<HdinsightCreateEncryptionAlgorithm>))]
    public partial class HdinsightCreateEncryptionAlgorithm : Enumeration
    {
        public static HdinsightCreateEncryptionAlgorithm rsa_oaep = new HdinsightCreateEncryptionAlgorithm { Value = "rsa-oaep" };
        public static HdinsightCreateEncryptionAlgorithm rsa_oaep_256 = new HdinsightCreateEncryptionAlgorithm { Value = "rsa-oaep-256" };
        public static HdinsightCreateEncryptionAlgorithm rsa1_5 = new HdinsightCreateEncryptionAlgorithm { Value = "rsa1_5" };
    }
    #endregion
    #region HdinsightCreateWorkernodeDataDiskStorageAccountType
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<HdinsightCreateWorkernodeDataDiskStorageAccountType>))]
    public partial class HdinsightCreateWorkernodeDataDiskStorageAccountType : Enumeration
    {
        public static HdinsightCreateWorkernodeDataDiskStorageAccountType premium_lrs = new HdinsightCreateWorkernodeDataDiskStorageAccountType { Value = "premium_lrs" };
        public static HdinsightCreateWorkernodeDataDiskStorageAccountType standard_lrs = new HdinsightCreateWorkernodeDataDiskStorageAccountType { Value = "standard_lrs" };
    }
    #endregion
    #region HdinsightApplicationCreateType
    /// <summary>
    ///   Used within <see cref="AzureHdinsightTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<HdinsightApplicationCreateType>))]
    public partial class HdinsightApplicationCreateType : Enumeration
    {
        public static HdinsightApplicationCreateType customapplication = new HdinsightApplicationCreateType { Value = "customapplication" };
        public static HdinsightApplicationCreateType rserver = new HdinsightApplicationCreateType { Value = "rserver" };
    }
    #endregion
}
