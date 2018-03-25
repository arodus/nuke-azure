// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.15 [CommitSha: 2886d896].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureBatchai.json.

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
    public static partial class AzureBatchaiTasks
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public static string AzureBatchaiPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Batch AI.</p></summary>
        public static IEnumerable<string> AzureBatchai(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureBatchaiPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureBatchaiListUsagesSettings toolSettings);
        static partial void PostProcess(AzureBatchaiListUsagesSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiListUsages(Configure<AzureBatchaiListUsagesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiListUsagesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterAutoScaleSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterAutoScaleSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterAutoScale(Configure<AzureBatchaiClusterAutoScaleSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterAutoScaleSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterCreateSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterCreateSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterCreate(Configure<AzureBatchaiClusterCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterDeleteSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterDeleteSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterDelete(Configure<AzureBatchaiClusterDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterListSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterListSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterList(Configure<AzureBatchaiClusterListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterListFilesSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterListFilesSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterListFiles(Configure<AzureBatchaiClusterListFilesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterListFilesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterListNodesSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterListNodesSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterListNodes(Configure<AzureBatchaiClusterListNodesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterListNodesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterResizeSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterResizeSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterResize(Configure<AzureBatchaiClusterResizeSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterResizeSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiClusterShowSettings toolSettings);
        static partial void PostProcess(AzureBatchaiClusterShowSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiClusterShow(Configure<AzureBatchaiClusterShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiFileServerCreateSettings toolSettings);
        static partial void PostProcess(AzureBatchaiFileServerCreateSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiFileServerCreate(Configure<AzureBatchaiFileServerCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiFileServerDeleteSettings toolSettings);
        static partial void PostProcess(AzureBatchaiFileServerDeleteSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiFileServerDelete(Configure<AzureBatchaiFileServerDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiFileServerListSettings toolSettings);
        static partial void PostProcess(AzureBatchaiFileServerListSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiFileServerList(Configure<AzureBatchaiFileServerListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiFileServerShowSettings toolSettings);
        static partial void PostProcess(AzureBatchaiFileServerShowSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiFileServerShow(Configure<AzureBatchaiFileServerShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobCreateSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobCreateSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobCreate(Configure<AzureBatchaiJobCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobDeleteSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobDeleteSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobDelete(Configure<AzureBatchaiJobDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobListSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobListSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobList(Configure<AzureBatchaiJobListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobListNodesSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobListNodesSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobListNodes(Configure<AzureBatchaiJobListNodesSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobListNodesSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobShowSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobShowSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobShow(Configure<AzureBatchaiJobShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobTerminateSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobTerminateSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobTerminate(Configure<AzureBatchaiJobTerminateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobTerminateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobWaitSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobWaitSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobWait(Configure<AzureBatchaiJobWaitSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobWaitSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobFileListSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobFileListSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobFileList(Configure<AzureBatchaiJobFileListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobFileListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureBatchaiJobFileStreamSettings toolSettings);
        static partial void PostProcess(AzureBatchaiJobFileStreamSettings toolSettings);
        /// <summary><p>Batch AI.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/batchai.yml">official website</a>.</p></summary>
        public static void AzureBatchaiJobFileStream(Configure<AzureBatchaiJobFileStreamSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobFileStreamSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureBatchaiListUsagesSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiListUsagesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("batchai list-usages")
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
    #region AzureBatchaiClusterAutoScaleSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterAutoScaleSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Maximum number of nodes.</p></summary>
        public virtual string Max { get; internal set; }
        /// <summary><p>Minimum number of nodes.</p></summary>
        public virtual string Min { get; internal set; }
        /// <summary><p>Name of the cluster.</p></summary>
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
              .Add("batchai cluster auto-scale")
              .Add("--max {value}", Max)
              .Add("--min {value}", Min)
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
    #region AzureBatchaiClusterCreateSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Location in which to create the cluster. If the location is not specified and default location is not configured, will default to the resource group's location.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Password.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>SSH public key value or path. If the value is not provided and no ssh public key or password is configured in the config file the default public ssh key (~/.ssh/id_rsa.pub) of the current user will be used (if available).</p></summary>
        public virtual string SshKey { get; internal set; }
        /// <summary><p>Name of the admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p></summary>
        public virtual string Config { get; internal set; }
        /// <summary><p>If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.</p></summary>
        public virtual string UseAutoStorage { get; internal set; }
        /// <summary><p>Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string AfsMountPath { get; internal set; }
        /// <summary><p>Name of the Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure File Share, configure them in a configuration file and use --config option.</p></summary>
        public virtual string AfsName { get; internal set; }
        /// <summary><p>Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string BfsMountPath { get; internal set; }
        /// <summary><p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure Storage Blob Container, configure them in a configuration file and use --config option.</p></summary>
        public virtual string BfsName { get; internal set; }
        /// <summary><p>Name of a file server to mount on each cluster node. If you need to mount more than one file server, configure them in a configuration file and use --config option.</p></summary>
        public virtual string Nfs { get; internal set; }
        /// <summary><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string NfsMountPath { get; internal set; }
        /// <summary><p>Resource group in which file server is created. Can be omitted if the file server and the cluster belong to the same resource group.</p></summary>
        public virtual string NfsResourceGroup { get; internal set; }
        /// <summary><p>Resource id of a virtual machine image to be used for nodes creation. Note, you need to provide --image with which this image was created.</p></summary>
        public virtual string CustomImage { get; internal set; }
        /// <summary><p>Operation system image for cluster nodes. The value may contain an alias (UbuntuDSVM, UbuntuLTS) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Max nodes count for the auto-scale cluster.</p></summary>
        public virtual string Max { get; internal set; }
        /// <summary><p>Min nodes count for the auto-scale cluster.</p></summary>
        public virtual string Min { get; internal set; }
        /// <summary><p>Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.</p></summary>
        public virtual int? Target { get; internal set; }
        /// <summary><p>VM priority. If lowpriority selected the node can get preempted while the job is running.</p></summary>
        public virtual BatchaiClusterCreateVmPriority VmPriority { get; internal set; }
        /// <summary><p>VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).</p></summary>
        public virtual string VmSize { get; internal set; }
        /// <summary><p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed under a user account added into sudoers list (so, it can use sudo). Note, if this parameter is specified, it will overwrite setup task given in the configuration file.</p></summary>
        public virtual string SetupTask { get; internal set; }
        /// <summary><p>Location of the folder where setup-task's logs will be stored. Required if setup-task argument is provided. Note, Batch AI will create create several helper folders under this location. The created folders are reported as stdOutErrPathSuffix by get cluster command.</p></summary>
        public virtual string SetupTaskOutput { get; internal set; }
        /// <summary><p>Storage account key. Must be used in conjunction with --storage-account-name. Environment variable: AZURE_BATCHAI_STORAGE_KEY. Optional if the storage account belongs to the current subscription.</p></summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Related environment variable: AZURE_BATCHAI_STORAGE_ACCOUNT. Must be used in conjunction with --storage-account-key. If the key is not provided, the command will try to query the storage account key using the authenticated Azure account.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>Resource id of a virtual network subnet to put the cluster in.</p></summary>
        public virtual string Subnet { get; internal set; }
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
              .Add("batchai cluster create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--password {value}", Password)
              .Add("--ssh-key {value}", SshKey)
              .Add("--user-name {value}", UserName)
              .Add("--config {value}", Config)
              .Add("--use-auto-storage {value}", UseAutoStorage)
              .Add("--afs-mount-path {value}", AfsMountPath)
              .Add("--afs-name {value}", AfsName)
              .Add("--bfs-mount-path {value}", BfsMountPath)
              .Add("--bfs-name {value}", BfsName)
              .Add("--nfs {value}", Nfs)
              .Add("--nfs-mount-path {value}", NfsMountPath)
              .Add("--nfs-resource-group {value}", NfsResourceGroup)
              .Add("--custom-image {value}", CustomImage)
              .Add("--image {value}", Image)
              .Add("--max {value}", Max)
              .Add("--min {value}", Min)
              .Add("--target {value}", Target)
              .Add("--vm-priority {value}", VmPriority)
              .Add("--vm-size {value}", VmSize)
              .Add("--setup-task {value}", SetupTask)
              .Add("--setup-task-output {value}", SetupTaskOutput)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--subnet {value}", Subnet)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterDeleteSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("batchai cluster delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait {value}", NoWait)
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
    #region AzureBatchaiClusterListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
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
              .Add("batchai cluster list")
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
    #region AzureBatchaiClusterListFilesSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterListFilesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Time in minutes for how long generated download URLs should remain valid.</p></summary>
        public virtual string Expiry { get; internal set; }
        /// <summary><p>Relative path of a subfolder inside of node setup task output directory.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai cluster list-files")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expiry {value}", Expiry)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterListNodesSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterListNodesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the cluster.</p></summary>
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
              .Add("batchai cluster list-nodes")
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
    #region AzureBatchaiClusterResizeSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterResizeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target number of compute nodes.</p></summary>
        public virtual string Target { get; internal set; }
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
              .Add("batchai cluster resize")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--target {value}", Target)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterShowSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the cluster.</p></summary>
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
              .Add("batchai cluster show")
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
    #region AzureBatchaiFileServerCreateSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the file server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Location in which to create the file server. If default location is not configured, will default to the resource group's location.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>VM size.</p></summary>
        public virtual string VmSize { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Password.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>SSH public key value or path. If the value is not provided and no ssh public key or password is configured in the config file the default public ssh key (~/.ssh/id_rsa.pub) of the current user will be used (if available).</p></summary>
        public virtual string SshKey { get; internal set; }
        /// <summary><p>Name of the admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p></summary>
        public virtual string Config { get; internal set; }
        /// <summary><p>Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.</p></summary>
        public virtual BatchaiFileServerCreateCachingType CachingType { get; internal set; }
        /// <summary><p>Number of disks.</p></summary>
        public virtual int? DiskCount { get; internal set; }
        /// <summary><p>Disk size in Gb.</p></summary>
        public virtual string DiskSize { get; internal set; }
        /// <summary><p>The sku of storage account to persist VM.</p></summary>
        public virtual BatchaiFileServerCreateStorageSku StorageSku { get; internal set; }
        /// <summary><p>Resource id of a virtual network subnet to put the file server in. If not provided via command line or in configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p></summary>
        public virtual string Subnet { get; internal set; }
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
              .Add("batchai file-server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--no-wait {value}", NoWait)
              .Add("--vm-size {value}", VmSize)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--password {value}", Password)
              .Add("--ssh-key {value}", SshKey)
              .Add("--user-name {value}", UserName)
              .Add("--config {value}", Config)
              .Add("--caching-type {value}", CachingType)
              .Add("--disk-count {value}", DiskCount)
              .Add("--disk-size {value}", DiskSize)
              .Add("--storage-sku {value}", StorageSku)
              .Add("--subnet {value}", Subnet)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiFileServerDeleteSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the file server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("batchai file-server delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait {value}", NoWait)
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
    #region AzureBatchaiFileServerListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
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
              .Add("batchai file-server list")
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
    #region AzureBatchaiFileServerShowSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiFileServerShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the file server.</p></summary>
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
              .Add("batchai file-server show")
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
    #region AzureBatchaiJobCreateSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p></summary>
        public virtual string Config { get; internal set; }
        /// <summary><p>Name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>If specified, the job will run on the given cluster instead of the one configured in the json file.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>Specifies a resource group for the cluster given with --cluster-name parameter. If omitted, --resource-group value will be used.</p></summary>
        public virtual string ClusterResourceGroup { get; internal set; }
        /// <summary><p>Location in which to create the job. If default location is not configured, will default to the resource group's location.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string AfsMountPath { get; internal set; }
        /// <summary><p>Name of the Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure File share, configure them in a configuration file and use --config option.</p></summary>
        public virtual string AfsName { get; internal set; }
        /// <summary><p>Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string BfsMountPath { get; internal set; }
        /// <summary><p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure Storage container, configure them in a configuration file and use --config option.</p></summary>
        public virtual string BfsName { get; internal set; }
        /// <summary><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string NfsMountPath { get; internal set; }
        /// <summary><p>Name of a file server to mount during the job execution. The NFS will be mounted only on the nodes which are executing the job. If you need to mount more than one file server, configure them in a configuration file and use --config option.</p></summary>
        public virtual string NfsName { get; internal set; }
        /// <summary><p>Resource group in which file server is created. Can be omitted if the file server and the job belong to the same resource group.</p></summary>
        public virtual string NfsResourceGroup { get; internal set; }
        /// <summary><p>Storage account key. Must be used in conjunction with --storage-account-name. Environment variable: AZURE_BATCHAI_STORAGE_KEY.</p></summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted. Related environment variable: AZURE_BATCHAI_STORAGE_ACCOUNT. Must be used in conjunction with --storage-account-key. If the key is not provided, the command will try to query the storage account key using the authenticated Azure account.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
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
              .Add("batchai job create")
              .Add("--config {value}", Config)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--cluster-name {value}", ClusterName)
              .Add("--cluster-resource-group {value}", ClusterResourceGroup)
              .Add("--location {value}", Location)
              .Add("--afs-mount-path {value}", AfsMountPath)
              .Add("--afs-name {value}", AfsName)
              .Add("--bfs-mount-path {value}", BfsMountPath)
              .Add("--bfs-name {value}", BfsName)
              .Add("--nfs-mount-path {value}", NfsMountPath)
              .Add("--nfs-name {value}", NfsName)
              .Add("--nfs-resource-group {value}", NfsResourceGroup)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobDeleteSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("batchai job delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait {value}", NoWait)
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
    #region AzureBatchaiJobListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
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
              .Add("batchai job list")
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
    #region AzureBatchaiJobListNodesSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobListNodesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the job.</p></summary>
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
              .Add("batchai job list-nodes")
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
    #region AzureBatchaiJobShowSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the job.</p></summary>
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
              .Add("batchai job show")
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
    #region AzureBatchaiJobTerminateSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobTerminateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("batchai job terminate")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait {value}", NoWait)
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
    #region AzureBatchaiJobWaitSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Polling interval in sec.</p></summary>
        public virtual string Interval { get; internal set; }
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
              .Add("batchai job wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--interval {value}", Interval)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobFileListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobFileListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Time in minutes for how long generated download URL should remain valid.</p></summary>
        public virtual string Expiry { get; internal set; }
        /// <summary><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        public virtual string OutputDirectoryId { get; internal set; }
        /// <summary><p>Relative path in the given output directory.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai job file list")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expiry {value}", Expiry)
              .Add("--output-directory-id {value}", OutputDirectoryId)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobFileStreamSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobFileStreamSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>The name of the file to stream.</p></summary>
        public virtual string FileName { get; internal set; }
        /// <summary><p>Name of the job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        public virtual string OutputDirectoryId { get; internal set; }
        /// <summary><p>Relative path in the given output directory.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai job file stream")
              .Add("--file-name {value}", FileName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--output-directory-id {value}", OutputDirectoryId)
              .Add("--path {value}", Path)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiListUsagesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiListUsagesSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetLocation(this AzureBatchaiListUsagesSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetLocation(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetDebug(this AzureBatchaiListUsagesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetDebug(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetHelp(this AzureBatchaiListUsagesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetHelp(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetOutput(this AzureBatchaiListUsagesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetOutput(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetQuery(this AzureBatchaiListUsagesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetQuery(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetVerbose(this AzureBatchaiListUsagesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings ResetVerbose(this AzureBatchaiListUsagesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterAutoScaleSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterAutoScaleSettingsExtensions
    {
        #region Max
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Max"/>.</em></p><p>Maximum number of nodes.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetMax(this AzureBatchaiClusterAutoScaleSettings toolSettings, string max)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = max;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Max"/>.</em></p><p>Maximum number of nodes.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetMax(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = null;
            return toolSettings;
        }
        #endregion
        #region Min
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Min"/>.</em></p><p>Minimum number of nodes.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetMin(this AzureBatchaiClusterAutoScaleSettings toolSettings, string min)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = min;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Min"/>.</em></p><p>Minimum number of nodes.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetMin(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetName(this AzureBatchaiClusterAutoScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetName(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetResourceGroup(this AzureBatchaiClusterAutoScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetResourceGroup(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetDebug(this AzureBatchaiClusterAutoScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetDebug(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetHelp(this AzureBatchaiClusterAutoScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetHelp(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetOutput(this AzureBatchaiClusterAutoScaleSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetOutput(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetQuery(this AzureBatchaiClusterAutoScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetQuery(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetVerbose(this AzureBatchaiClusterAutoScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetVerbose(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetName(this AzureBatchaiClusterCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetResourceGroup(this AzureBatchaiClusterCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetResourceGroup(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Location"/>.</em></p><p>Location in which to create the cluster. If the location is not specified and default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetLocation(this AzureBatchaiClusterCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Location"/>.</em></p><p>Location in which to create the cluster. If the location is not specified and default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetLocation(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetGenerateSshKeys(this AzureBatchaiClusterCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetGenerateSshKeys(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Password"/>.</em></p><p>Password.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetPassword(this AzureBatchaiClusterCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Password"/>.</em></p><p>Password.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetPassword(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SshKey"/>.</em></p><p>SSH public key value or path. If the value is not provided and no ssh public key or password is configured in the config file the default public ssh key (~/.ssh/id_rsa.pub) of the current user will be used (if available).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSshKey(this AzureBatchaiClusterCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SshKey"/>.</em></p><p>SSH public key value or path. If the value is not provided and no ssh public key or password is configured in the config file the default public ssh key (~/.ssh/id_rsa.pub) of the current user will be used (if available).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSshKey(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.UserName"/>.</em></p><p>Name of the admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetUserName(this AzureBatchaiClusterCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.UserName"/>.</em></p><p>Name of the admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetUserName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region Config
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Config"/>.</em></p><p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetConfig(this AzureBatchaiClusterCreateSettings toolSettings, string config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Config = config;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Config"/>.</em></p><p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetConfig(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Config = null;
            return toolSettings;
        }
        #endregion
        #region UseAutoStorage
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.UseAutoStorage"/>.</em></p><p>If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetUseAutoStorage(this AzureBatchaiClusterCreateSettings toolSettings, string useAutoStorage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseAutoStorage = useAutoStorage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.UseAutoStorage"/>.</em></p><p>If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetUseAutoStorage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UseAutoStorage = null;
            return toolSettings;
        }
        #endregion
        #region AfsMountPath
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.AfsMountPath"/>.</em></p><p>Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetAfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings, string afsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = afsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.AfsMountPath"/>.</em></p><p>Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetAfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AfsName
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.AfsName"/>.</em></p><p>Name of the Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure File Share, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetAfsName(this AzureBatchaiClusterCreateSettings toolSettings, string afsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = afsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.AfsName"/>.</em></p><p>Name of the Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure File Share, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetAfsName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = null;
            return toolSettings;
        }
        #endregion
        #region BfsMountPath
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.BfsMountPath"/>.</em></p><p>Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetBfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings, string bfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = bfsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.BfsMountPath"/>.</em></p><p>Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetBfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region BfsName
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure Storage Blob Container, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetBfsName(this AzureBatchaiClusterCreateSettings toolSettings, string bfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = bfsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure Storage Blob Container, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetBfsName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = null;
            return toolSettings;
        }
        #endregion
        #region Nfs
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Nfs"/>.</em></p><p>Name of a file server to mount on each cluster node. If you need to mount more than one file server, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetNfs(this AzureBatchaiClusterCreateSettings toolSettings, string nfs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = nfs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Nfs"/>.</em></p><p>Name of a file server to mount on each cluster node. If you need to mount more than one file server, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetNfs(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = null;
            return toolSettings;
        }
        #endregion
        #region NfsMountPath
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.NfsMountPath"/>.</em></p><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetNfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings, string nfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = nfsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.NfsMountPath"/>.</em></p><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetNfsMountPath(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region NfsResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.NfsResourceGroup"/>.</em></p><p>Resource group in which file server is created. Can be omitted if the file server and the cluster belong to the same resource group.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetNfsResourceGroup(this AzureBatchaiClusterCreateSettings toolSettings, string nfsResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsResourceGroup = nfsResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.NfsResourceGroup"/>.</em></p><p>Resource group in which file server is created. Can be omitted if the file server and the cluster belong to the same resource group.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetNfsResourceGroup(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CustomImage
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/>.</em></p><p>Resource id of a virtual machine image to be used for nodes creation. Note, you need to provide --image with which this image was created.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetCustomImage(this AzureBatchaiClusterCreateSettings toolSettings, string customImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomImage = customImage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/>.</em></p><p>Resource id of a virtual machine image to be used for nodes creation. Note, you need to provide --image with which this image was created.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetCustomImage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomImage = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Image"/>.</em></p><p>Operation system image for cluster nodes. The value may contain an alias (UbuntuDSVM, UbuntuLTS) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetImage(this AzureBatchaiClusterCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Image"/>.</em></p><p>Operation system image for cluster nodes. The value may contain an alias (UbuntuDSVM, UbuntuLTS) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetImage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Max
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Max"/>.</em></p><p>Max nodes count for the auto-scale cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetMax(this AzureBatchaiClusterCreateSettings toolSettings, string max)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = max;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Max"/>.</em></p><p>Max nodes count for the auto-scale cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetMax(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Max = null;
            return toolSettings;
        }
        #endregion
        #region Min
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Min"/>.</em></p><p>Min nodes count for the auto-scale cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetMin(this AzureBatchaiClusterCreateSettings toolSettings, string min)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = min;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Min"/>.</em></p><p>Min nodes count for the auto-scale cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetMin(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Min = null;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Target"/>.</em></p><p>Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetTarget(this AzureBatchaiClusterCreateSettings toolSettings, int? target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Target"/>.</em></p><p>Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetTarget(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region VmPriority
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/>.</em></p><p>VM priority. If lowpriority selected the node can get preempted while the job is running.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVmPriority(this AzureBatchaiClusterCreateSettings toolSettings, BatchaiClusterCreateVmPriority vmPriority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPriority = vmPriority;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/>.</em></p><p>VM priority. If lowpriority selected the node can get preempted while the job is running.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetVmPriority(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPriority = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.VmSize"/>.</em></p><p>VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVmSize(this AzureBatchaiClusterCreateSettings toolSettings, string vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.VmSize"/>.</em></p><p>VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetVmSize(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region SetupTask
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/>.</em></p><p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed under a user account added into sudoers list (so, it can use sudo). Note, if this parameter is specified, it will overwrite setup task given in the configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSetupTask(this AzureBatchaiClusterCreateSettings toolSettings, string setupTask)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTask = setupTask;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/>.</em></p><p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed under a user account added into sudoers list (so, it can use sudo). Note, if this parameter is specified, it will overwrite setup task given in the configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSetupTask(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTask = null;
            return toolSettings;
        }
        #endregion
        #region SetupTaskOutput
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/>.</em></p><p>Location of the folder where setup-task's logs will be stored. Required if setup-task argument is provided. Note, Batch AI will create create several helper folders under this location. The created folders are reported as stdOutErrPathSuffix by get cluster command.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSetupTaskOutput(this AzureBatchaiClusterCreateSettings toolSettings, string setupTaskOutput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTaskOutput = setupTaskOutput;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/>.</em></p><p>Location of the folder where setup-task's logs will be stored. Required if setup-task argument is provided. Note, Batch AI will create create several helper folders under this location. The created folders are reported as stdOutErrPathSuffix by get cluster command.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSetupTaskOutput(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTaskOutput = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Must be used in conjunction with --storage-account-name. Environment variable: AZURE_BATCHAI_STORAGE_KEY. Optional if the storage account belongs to the current subscription.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetStorageAccountKey(this AzureBatchaiClusterCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Must be used in conjunction with --storage-account-name. Environment variable: AZURE_BATCHAI_STORAGE_KEY. Optional if the storage account belongs to the current subscription.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetStorageAccountKey(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Related environment variable: AZURE_BATCHAI_STORAGE_ACCOUNT. Must be used in conjunction with --storage-account-key. If the key is not provided, the command will try to query the storage account key using the authenticated Azure account.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetStorageAccountName(this AzureBatchaiClusterCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Related environment variable: AZURE_BATCHAI_STORAGE_ACCOUNT. Must be used in conjunction with --storage-account-key. If the key is not provided, the command will try to query the storage account key using the authenticated Azure account.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetStorageAccountName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Subnet"/>.</em></p><p>Resource id of a virtual network subnet to put the cluster in.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSubnet(this AzureBatchaiClusterCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Subnet"/>.</em></p><p>Resource id of a virtual network subnet to put the cluster in.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSubnet(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetDebug(this AzureBatchaiClusterCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetDebug(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetHelp(this AzureBatchaiClusterCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetHelp(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetOutput(this AzureBatchaiClusterCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetOutput(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetQuery(this AzureBatchaiClusterCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetQuery(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVerbose(this AzureBatchaiClusterCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetVerbose(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetName(this AzureBatchaiClusterDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetName(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetResourceGroup(this AzureBatchaiClusterDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetResourceGroup(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetNoWait(this AzureBatchaiClusterDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetYes(this AzureBatchaiClusterDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetYes(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetDebug(this AzureBatchaiClusterDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetDebug(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetHelp(this AzureBatchaiClusterDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetHelp(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetOutput(this AzureBatchaiClusterDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetOutput(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetQuery(this AzureBatchaiClusterDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetQuery(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetVerbose(this AzureBatchaiClusterDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetVerbose(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetResourceGroup(this AzureBatchaiClusterListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetResourceGroup(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetDebug(this AzureBatchaiClusterListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetDebug(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetHelp(this AzureBatchaiClusterListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetHelp(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetOutput(this AzureBatchaiClusterListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetOutput(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetQuery(this AzureBatchaiClusterListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetQuery(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetVerbose(this AzureBatchaiClusterListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetVerbose(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterListFilesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterListFilesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetName(this AzureBatchaiClusterListFilesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetName(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetResourceGroup(this AzureBatchaiClusterListFilesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetResourceGroup(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expiry
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Expiry"/>.</em></p><p>Time in minutes for how long generated download URLs should remain valid.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetExpiry(this AzureBatchaiClusterListFilesSettings toolSettings, string expiry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = expiry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Expiry"/>.</em></p><p>Time in minutes for how long generated download URLs should remain valid.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetExpiry(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Path"/>.</em></p><p>Relative path of a subfolder inside of node setup task output directory.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetPath(this AzureBatchaiClusterListFilesSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Path"/>.</em></p><p>Relative path of a subfolder inside of node setup task output directory.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetPath(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetDebug(this AzureBatchaiClusterListFilesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetDebug(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetHelp(this AzureBatchaiClusterListFilesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetHelp(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetOutput(this AzureBatchaiClusterListFilesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetOutput(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetQuery(this AzureBatchaiClusterListFilesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetQuery(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListFilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings SetVerbose(this AzureBatchaiClusterListFilesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListFilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListFilesSettings ResetVerbose(this AzureBatchaiClusterListFilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterListNodesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterListNodesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetName(this AzureBatchaiClusterListNodesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetName(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetResourceGroup(this AzureBatchaiClusterListNodesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetResourceGroup(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetDebug(this AzureBatchaiClusterListNodesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetDebug(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetHelp(this AzureBatchaiClusterListNodesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetHelp(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetOutput(this AzureBatchaiClusterListNodesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetOutput(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetQuery(this AzureBatchaiClusterListNodesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetQuery(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListNodesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings SetVerbose(this AzureBatchaiClusterListNodesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListNodesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListNodesSettings ResetVerbose(this AzureBatchaiClusterListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterResizeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterResizeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetName(this AzureBatchaiClusterResizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetName(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetResourceGroup(this AzureBatchaiClusterResizeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetResourceGroup(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Target"/>.</em></p><p>Target number of compute nodes.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetTarget(this AzureBatchaiClusterResizeSettings toolSettings, string target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Target"/>.</em></p><p>Target number of compute nodes.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetTarget(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetDebug(this AzureBatchaiClusterResizeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetDebug(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetHelp(this AzureBatchaiClusterResizeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetHelp(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetOutput(this AzureBatchaiClusterResizeSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetOutput(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetQuery(this AzureBatchaiClusterResizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetQuery(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetVerbose(this AzureBatchaiClusterResizeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetVerbose(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetName(this AzureBatchaiClusterShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Name"/>.</em></p><p>Name of the cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetName(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetResourceGroup(this AzureBatchaiClusterShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetResourceGroup(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetDebug(this AzureBatchaiClusterShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetDebug(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetHelp(this AzureBatchaiClusterShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetHelp(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetOutput(this AzureBatchaiClusterShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetOutput(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetQuery(this AzureBatchaiClusterShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetQuery(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetVerbose(this AzureBatchaiClusterShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetVerbose(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Name"/>.</em></p><p>Name of the file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetName(this AzureBatchaiFileServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Name"/>.</em></p><p>Name of the file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetName(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetResourceGroup(this AzureBatchaiFileServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetResourceGroup(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Location"/>.</em></p><p>Location in which to create the file server. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetLocation(this AzureBatchaiFileServerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Location"/>.</em></p><p>Location in which to create the file server. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetLocation(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetNoWait(this AzureBatchaiFileServerCreateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region VmSize
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.VmSize"/>.</em></p><p>VM size.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetVmSize(this AzureBatchaiFileServerCreateSettings toolSettings, string vmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = vmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.VmSize"/>.</em></p><p>VM size.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetVmSize(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSize = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetGenerateSshKeys(this AzureBatchaiFileServerCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetGenerateSshKeys(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Password"/>.</em></p><p>Password.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetPassword(this AzureBatchaiFileServerCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Password"/>.</em></p><p>Password.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetPassword(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/>.</em></p><p>SSH public key value or path. If the value is not provided and no ssh public key or password is configured in the config file the default public ssh key (~/.ssh/id_rsa.pub) of the current user will be used (if available).</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSshKey(this AzureBatchaiFileServerCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/>.</em></p><p>SSH public key value or path. If the value is not provided and no ssh public key or password is configured in the config file the default public ssh key (~/.ssh/id_rsa.pub) of the current user will be used (if available).</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetSshKey(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.UserName"/>.</em></p><p>Name of the admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetUserName(this AzureBatchaiFileServerCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.UserName"/>.</em></p><p>Name of the admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetUserName(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region Config
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Config"/>.</em></p><p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetConfig(this AzureBatchaiFileServerCreateSettings toolSettings, string config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Config = config;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Config"/>.</em></p><p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetConfig(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Config = null;
            return toolSettings;
        }
        #endregion
        #region CachingType
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.CachingType"/>.</em></p><p>Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetCachingType(this AzureBatchaiFileServerCreateSettings toolSettings, BatchaiFileServerCreateCachingType cachingType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CachingType = cachingType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.CachingType"/>.</em></p><p>Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetCachingType(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CachingType = null;
            return toolSettings;
        }
        #endregion
        #region DiskCount
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.DiskCount"/>.</em></p><p>Number of disks.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetDiskCount(this AzureBatchaiFileServerCreateSettings toolSettings, int? diskCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCount = diskCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.DiskCount"/>.</em></p><p>Number of disks.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetDiskCount(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskCount = null;
            return toolSettings;
        }
        #endregion
        #region DiskSize
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.DiskSize"/>.</em></p><p>Disk size in Gb.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetDiskSize(this AzureBatchaiFileServerCreateSettings toolSettings, string diskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskSize = diskSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.DiskSize"/>.</em></p><p>Disk size in Gb.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetDiskSize(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskSize = null;
            return toolSettings;
        }
        #endregion
        #region StorageSku
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.StorageSku"/>.</em></p><p>The sku of storage account to persist VM.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetStorageSku(this AzureBatchaiFileServerCreateSettings toolSettings, BatchaiFileServerCreateStorageSku storageSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = storageSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.StorageSku"/>.</em></p><p>The sku of storage account to persist VM.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetStorageSku(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSku = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/>.</em></p><p>Resource id of a virtual network subnet to put the file server in. If not provided via command line or in configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSubnet(this AzureBatchaiFileServerCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/>.</em></p><p>Resource id of a virtual network subnet to put the file server in. If not provided via command line or in configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetSubnet(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetDebug(this AzureBatchaiFileServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetDebug(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetHelp(this AzureBatchaiFileServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetHelp(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetOutput(this AzureBatchaiFileServerCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetOutput(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetQuery(this AzureBatchaiFileServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetQuery(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetVerbose(this AzureBatchaiFileServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetVerbose(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Name"/>.</em></p><p>Name of the file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetName(this AzureBatchaiFileServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Name"/>.</em></p><p>Name of the file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetName(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetResourceGroup(this AzureBatchaiFileServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetResourceGroup(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetYes(this AzureBatchaiFileServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetYes(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetDebug(this AzureBatchaiFileServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetDebug(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetHelp(this AzureBatchaiFileServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetHelp(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetOutput(this AzureBatchaiFileServerDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetOutput(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetQuery(this AzureBatchaiFileServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetQuery(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetVerbose(this AzureBatchaiFileServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetVerbose(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetResourceGroup(this AzureBatchaiFileServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetResourceGroup(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetDebug(this AzureBatchaiFileServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetDebug(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetHelp(this AzureBatchaiFileServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetHelp(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetOutput(this AzureBatchaiFileServerListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetOutput(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetQuery(this AzureBatchaiFileServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetQuery(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetVerbose(this AzureBatchaiFileServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetVerbose(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiFileServerShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiFileServerShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Name"/>.</em></p><p>Name of the file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetName(this AzureBatchaiFileServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Name"/>.</em></p><p>Name of the file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetName(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetResourceGroup(this AzureBatchaiFileServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetResourceGroup(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetDebug(this AzureBatchaiFileServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetDebug(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetHelp(this AzureBatchaiFileServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetHelp(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetOutput(this AzureBatchaiFileServerShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetOutput(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetQuery(this AzureBatchaiFileServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetQuery(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetVerbose(this AzureBatchaiFileServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetVerbose(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobCreateSettingsExtensions
    {
        #region Config
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Config"/>.</em></p><p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetConfig(this AzureBatchaiJobCreateSettings toolSettings, string config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Config = config;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Config"/>.</em></p><p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetConfig(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Config = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetName(this AzureBatchaiJobCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetResourceGroup(this AzureBatchaiJobCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetResourceGroup(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.ClusterName"/>.</em></p><p>If specified, the job will run on the given cluster instead of the one configured in the json file.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetClusterName(this AzureBatchaiJobCreateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.ClusterName"/>.</em></p><p>If specified, the job will run on the given cluster instead of the one configured in the json file.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetClusterName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ClusterResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.ClusterResourceGroup"/>.</em></p><p>Specifies a resource group for the cluster given with --cluster-name parameter. If omitted, --resource-group value will be used.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetClusterResourceGroup(this AzureBatchaiJobCreateSettings toolSettings, string clusterResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterResourceGroup = clusterResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.ClusterResourceGroup"/>.</em></p><p>Specifies a resource group for the cluster given with --cluster-name parameter. If omitted, --resource-group value will be used.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetClusterResourceGroup(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Location"/>.</em></p><p>Location in which to create the job. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetLocation(this AzureBatchaiJobCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Location"/>.</em></p><p>Location in which to create the job. If default location is not configured, will default to the resource group's location.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetLocation(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region AfsMountPath
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.AfsMountPath"/>.</em></p><p>Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetAfsMountPath(this AzureBatchaiJobCreateSettings toolSettings, string afsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = afsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.AfsMountPath"/>.</em></p><p>Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetAfsMountPath(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AfsName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.AfsName"/>.</em></p><p>Name of the Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure File share, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetAfsName(this AzureBatchaiJobCreateSettings toolSettings, string afsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = afsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.AfsName"/>.</em></p><p>Name of the Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure File share, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetAfsName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = null;
            return toolSettings;
        }
        #endregion
        #region BfsMountPath
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.BfsMountPath"/>.</em></p><p>Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetBfsMountPath(this AzureBatchaiJobCreateSettings toolSettings, string bfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = bfsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.BfsMountPath"/>.</em></p><p>Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetBfsMountPath(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region BfsName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure Storage container, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetBfsName(this AzureBatchaiJobCreateSettings toolSettings, string bfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = bfsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name and --storage-account-key arguments or AZURE_BATCHAI_STORAGE_ACCOUNT and AZURE_BATCHAI_STORAGE_KEY environment variables. If you need to mount more than one Azure Storage container, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetBfsName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = null;
            return toolSettings;
        }
        #endregion
        #region NfsMountPath
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.NfsMountPath"/>.</em></p><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetNfsMountPath(this AzureBatchaiJobCreateSettings toolSettings, string nfsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = nfsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.NfsMountPath"/>.</em></p><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetNfsMountPath(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region NfsName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.NfsName"/>.</em></p><p>Name of a file server to mount during the job execution. The NFS will be mounted only on the nodes which are executing the job. If you need to mount more than one file server, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetNfsName(this AzureBatchaiJobCreateSettings toolSettings, string nfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsName = nfsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.NfsName"/>.</em></p><p>Name of a file server to mount during the job execution. The NFS will be mounted only on the nodes which are executing the job. If you need to mount more than one file server, configure them in a configuration file and use --config option.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetNfsName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsName = null;
            return toolSettings;
        }
        #endregion
        #region NfsResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.NfsResourceGroup"/>.</em></p><p>Resource group in which file server is created. Can be omitted if the file server and the job belong to the same resource group.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetNfsResourceGroup(this AzureBatchaiJobCreateSettings toolSettings, string nfsResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsResourceGroup = nfsResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.NfsResourceGroup"/>.</em></p><p>Resource group in which file server is created. Can be omitted if the file server and the job belong to the same resource group.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetNfsResourceGroup(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NfsResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Must be used in conjunction with --storage-account-name. Environment variable: AZURE_BATCHAI_STORAGE_KEY.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetStorageAccountKey(this AzureBatchaiJobCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Must be used in conjunction with --storage-account-name. Environment variable: AZURE_BATCHAI_STORAGE_KEY.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetStorageAccountKey(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted. Related environment variable: AZURE_BATCHAI_STORAGE_ACCOUNT. Must be used in conjunction with --storage-account-key. If the key is not provided, the command will try to query the storage account key using the authenticated Azure account.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetStorageAccountName(this AzureBatchaiJobCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted. Related environment variable: AZURE_BATCHAI_STORAGE_ACCOUNT. Must be used in conjunction with --storage-account-key. If the key is not provided, the command will try to query the storage account key using the authenticated Azure account.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetStorageAccountName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetDebug(this AzureBatchaiJobCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetDebug(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetHelp(this AzureBatchaiJobCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetHelp(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetOutput(this AzureBatchaiJobCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetOutput(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetQuery(this AzureBatchaiJobCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetQuery(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetVerbose(this AzureBatchaiJobCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetVerbose(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetName(this AzureBatchaiJobDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetName(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetResourceGroup(this AzureBatchaiJobDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetResourceGroup(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetNoWait(this AzureBatchaiJobDeleteSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetYes(this AzureBatchaiJobDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetYes(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetDebug(this AzureBatchaiJobDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetDebug(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetHelp(this AzureBatchaiJobDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetHelp(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetOutput(this AzureBatchaiJobDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetOutput(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetQuery(this AzureBatchaiJobDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetQuery(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetVerbose(this AzureBatchaiJobDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetVerbose(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetResourceGroup(this AzureBatchaiJobListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetResourceGroup(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetDebug(this AzureBatchaiJobListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetDebug(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetHelp(this AzureBatchaiJobListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetHelp(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetOutput(this AzureBatchaiJobListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetOutput(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetQuery(this AzureBatchaiJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetQuery(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetVerbose(this AzureBatchaiJobListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetVerbose(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobListNodesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobListNodesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetName(this AzureBatchaiJobListNodesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetName(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetResourceGroup(this AzureBatchaiJobListNodesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetResourceGroup(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetDebug(this AzureBatchaiJobListNodesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetDebug(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetHelp(this AzureBatchaiJobListNodesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetHelp(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetOutput(this AzureBatchaiJobListNodesSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetOutput(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetQuery(this AzureBatchaiJobListNodesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetQuery(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListNodesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings SetVerbose(this AzureBatchaiJobListNodesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListNodesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobListNodesSettings ResetVerbose(this AzureBatchaiJobListNodesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetName(this AzureBatchaiJobShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetName(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetResourceGroup(this AzureBatchaiJobShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetResourceGroup(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetDebug(this AzureBatchaiJobShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetDebug(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetHelp(this AzureBatchaiJobShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetHelp(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetOutput(this AzureBatchaiJobShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetOutput(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetQuery(this AzureBatchaiJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetQuery(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetVerbose(this AzureBatchaiJobShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetVerbose(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobTerminateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobTerminateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetName(this AzureBatchaiJobTerminateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetName(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetResourceGroup(this AzureBatchaiJobTerminateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetResourceGroup(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetNoWait(this AzureBatchaiJobTerminateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetYes(this AzureBatchaiJobTerminateSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetYes(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetDebug(this AzureBatchaiJobTerminateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetDebug(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetHelp(this AzureBatchaiJobTerminateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetHelp(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetOutput(this AzureBatchaiJobTerminateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetOutput(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetQuery(this AzureBatchaiJobTerminateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetQuery(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetVerbose(this AzureBatchaiJobTerminateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetVerbose(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetName(this AzureBatchaiJobWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetName(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetResourceGroup(this AzureBatchaiJobWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetResourceGroup(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Interval"/>.</em></p><p>Polling interval in sec.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetInterval(this AzureBatchaiJobWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Interval"/>.</em></p><p>Polling interval in sec.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetInterval(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetDebug(this AzureBatchaiJobWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetDebug(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetHelp(this AzureBatchaiJobWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetHelp(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetOutput(this AzureBatchaiJobWaitSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetOutput(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetQuery(this AzureBatchaiJobWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetQuery(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetVerbose(this AzureBatchaiJobWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetVerbose(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobFileListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobFileListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetName(this AzureBatchaiJobFileListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetName(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetResourceGroup(this AzureBatchaiJobFileListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetResourceGroup(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expiry
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Expiry"/>.</em></p><p>Time in minutes for how long generated download URL should remain valid.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetExpiry(this AzureBatchaiJobFileListSettings toolSettings, string expiry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = expiry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Expiry"/>.</em></p><p>Time in minutes for how long generated download URL should remain valid.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetExpiry(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = null;
            return toolSettings;
        }
        #endregion
        #region OutputDirectoryId
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.OutputDirectoryId"/>.</em></p><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetOutputDirectoryId(this AzureBatchaiJobFileListSettings toolSettings, string outputDirectoryId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = outputDirectoryId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.OutputDirectoryId"/>.</em></p><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetOutputDirectoryId(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Path"/>.</em></p><p>Relative path in the given output directory.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetPath(this AzureBatchaiJobFileListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Path"/>.</em></p><p>Relative path in the given output directory.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetPath(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetDebug(this AzureBatchaiJobFileListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetDebug(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetHelp(this AzureBatchaiJobFileListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetHelp(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetOutput(this AzureBatchaiJobFileListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetOutput(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetQuery(this AzureBatchaiJobFileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetQuery(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetVerbose(this AzureBatchaiJobFileListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetVerbose(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobFileStreamSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobFileStreamSettingsExtensions
    {
        #region FileName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.FileName"/>.</em></p><p>The name of the file to stream.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetFileName(this AzureBatchaiJobFileStreamSettings toolSettings, string fileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileName = fileName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.FileName"/>.</em></p><p>The name of the file to stream.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetFileName(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetName(this AzureBatchaiJobFileStreamSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Name"/>.</em></p><p>Name of the job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetName(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetResourceGroup(this AzureBatchaiJobFileStreamSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetResourceGroup(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region OutputDirectoryId
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.OutputDirectoryId"/>.</em></p><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetOutputDirectoryId(this AzureBatchaiJobFileStreamSettings toolSettings, string outputDirectoryId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = outputDirectoryId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.OutputDirectoryId"/>.</em></p><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetOutputDirectoryId(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectoryId = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Path"/>.</em></p><p>Relative path in the given output directory.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetPath(this AzureBatchaiJobFileStreamSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Path"/>.</em></p><p>Relative path in the given output directory.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetPath(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetDebug(this AzureBatchaiJobFileStreamSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetDebug(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetHelp(this AzureBatchaiJobFileStreamSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetHelp(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetOutput(this AzureBatchaiJobFileStreamSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetOutput(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetQuery(this AzureBatchaiJobFileStreamSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetQuery(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetVerbose(this AzureBatchaiJobFileStreamSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetVerbose(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region BatchaiClusterCreateVmPriority
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class BatchaiClusterCreateVmPriority : Enumeration
    {
        public static BatchaiClusterCreateVmPriority dedicated = new BatchaiClusterCreateVmPriority { Value = "dedicated" };
        public static BatchaiClusterCreateVmPriority lowpriority = new BatchaiClusterCreateVmPriority { Value = "lowpriority" };
    }
    #endregion
    #region BatchaiFileServerCreateCachingType
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class BatchaiFileServerCreateCachingType : Enumeration
    {
        public static BatchaiFileServerCreateCachingType none = new BatchaiFileServerCreateCachingType { Value = "none" };
        public static BatchaiFileServerCreateCachingType readonly_ = new BatchaiFileServerCreateCachingType { Value = "readonly" };
        public static BatchaiFileServerCreateCachingType readwrite = new BatchaiFileServerCreateCachingType { Value = "readwrite" };
    }
    #endregion
    #region BatchaiFileServerCreateStorageSku
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class BatchaiFileServerCreateStorageSku : Enumeration
    {
        public static BatchaiFileServerCreateStorageSku premium_lrs = new BatchaiFileServerCreateStorageSku { Value = "premium_lrs" };
        public static BatchaiFileServerCreateStorageSku standard_lrs = new BatchaiFileServerCreateStorageSku { Value = "standard_lrs" };
    }
    #endregion
}
