// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureBatchai.json.

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
    public static partial class AzureBatchaiTasks
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public static string AzureBatchaiPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Batch AI resources.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchai(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureBatchaiPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiListUsages(Configure<AzureBatchaiListUsagesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiListUsagesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterAutoScale(Configure<AzureBatchaiClusterAutoScaleSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterAutoScaleSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterCreate(Configure<AzureBatchaiClusterCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterDelete(Configure<AzureBatchaiClusterDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterList(Configure<AzureBatchaiClusterListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterResize(Configure<AzureBatchaiClusterResizeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterResizeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterShow(Configure<AzureBatchaiClusterShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentCreate(Configure<AzureBatchaiExperimentCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiExperimentCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentDelete(Configure<AzureBatchaiExperimentDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiExperimentDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentList(Configure<AzureBatchaiExperimentListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiExperimentListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiExperimentShow(Configure<AzureBatchaiExperimentShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiExperimentShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerCreate(Configure<AzureBatchaiFileServerCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerDelete(Configure<AzureBatchaiFileServerDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerList(Configure<AzureBatchaiFileServerListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiFileServerShow(Configure<AzureBatchaiFileServerShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiFileServerShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobCreate(Configure<AzureBatchaiJobCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobDelete(Configure<AzureBatchaiJobDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobList(Configure<AzureBatchaiJobListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobShow(Configure<AzureBatchaiJobShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobTerminate(Configure<AzureBatchaiJobTerminateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobTerminateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobWait(Configure<AzureBatchaiJobWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceCreate(Configure<AzureBatchaiWorkspaceCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiWorkspaceCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceDelete(Configure<AzureBatchaiWorkspaceDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiWorkspaceDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceList(Configure<AzureBatchaiWorkspaceListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiWorkspaceListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiWorkspaceShow(Configure<AzureBatchaiWorkspaceShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiWorkspaceShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterFileList(Configure<AzureBatchaiClusterFileListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterFileListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterNodeExec(Configure<AzureBatchaiClusterNodeExecSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterNodeExecSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiClusterNodeList(Configure<AzureBatchaiClusterNodeListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiClusterNodeListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobFileList(Configure<AzureBatchaiJobFileListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobFileListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobFileStream(Configure<AzureBatchaiJobFileStreamSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobFileStreamSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobNodeExec(Configure<AzureBatchaiJobNodeExecSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobNodeExecSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Batch AI resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/batchai?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBatchaiJobNodeList(Configure<AzureBatchaiJobNodeListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBatchaiJobNodeListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
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
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public virtual int? Max { get; internal set; }
        /// <summary><p>Minimum number of nodes.</p></summary>
        public virtual int? Min { get; internal set; }
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster auto-scale")
              .Add("--max {value}", Max)
              .Add("--min {value}", Min)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Optional password for the admin user account to be created on each compute node.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p></summary>
        public virtual string SshKey { get; internal set; }
        /// <summary><p>Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p></summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary><p>If provided, the command will create a storage account in a new or existing resource group named "batchaiautostorage". It will also create Azure File Share with name "batchaishare", Azure Blob Container with name "batchaicontainer". The File Share and Blob Container will be mounted on each cluster node at $AZ_BATCHAI_MOUNT_ROOT/autoafs and $AZ_BATCHAI_MOUNT_ROOT/autobfs. If the resource group already exists and contains an approapriate storage account belonging to the same region as cluster, this command will reuse existing storage account.</p></summary>
        public virtual string UseAutoStorage { get; internal set; }
        /// <summary><p>Relative mount path for Azure File share. The file share will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string AfsMountPath { get; internal set; }
        /// <summary><p>Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).</p></summary>
        public virtual string AfsName { get; internal set; }
        /// <summary><p>Relative mount path for Azure Storage container. The container will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string BfsMountPath { get; internal set; }
        /// <summary><p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p></summary>
        public virtual string BfsName { get; internal set; }
        /// <summary><p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p></summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).</p></summary>
        public virtual string Nfs { get; internal set; }
        /// <summary><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string NfsMountPath { get; internal set; }
        /// <summary><p>ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.</p></summary>
        public virtual string CustomImage { get; internal set; }
        /// <summary><p>Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Max nodes count for the auto-scale cluster.</p></summary>
        public virtual string Max { get; internal set; }
        /// <summary><p>Min nodes count for the auto-scale cluster.</p></summary>
        public virtual string Min { get; internal set; }
        /// <summary><p>Number of nodes which should be allocated immediately after cluster creation. If the cluster is in auto-scale mode, BatchAI can change the number of nodes later based on number of running and queued jobs.</p></summary>
        public virtual int? Target { get; internal set; }
        /// <summary><p>VM priority.</p></summary>
        public virtual BatchaiClusterCreateVmPriority VmPriority { get; internal set; }
        /// <summary><p>VM size for cluster nodes (e.g. Standard_NC6 for 1 GPU node).</p></summary>
        public virtual string VmSize { get; internal set; }
        /// <summary><p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.</p></summary>
        public virtual string SetupTask { get; internal set; }
        /// <summary><p>Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.</p></summary>
        public virtual string SetupTaskOutput { get; internal set; }
        /// <summary><p>ARM ID of a virtual network subnet to put the cluster in.</p></summary>
        public virtual string Subnet { get; internal set; }
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
              .Add("batchai cluster create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-key {value}", SshKey)
              .Add("--user-name {value}", UserName)
              .Add("--config-file {value}", ConfigFile)
              .Add("--use-auto-storage {value}", UseAutoStorage)
              .Add("--afs-mount-path {value}", AfsMountPath)
              .Add("--afs-name {value}", AfsName)
              .Add("--bfs-mount-path {value}", BfsMountPath)
              .Add("--bfs-name {value}", BfsName)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--nfs {value}", Nfs)
              .Add("--nfs-mount-path {value}", NfsMountPath)
              .Add("--custom-image {value}", CustomImage)
              .Add("--image {value}", Image)
              .Add("--max {value}", Max)
              .Add("--min {value}", Min)
              .Add("--target {value}", Target)
              .Add("--vm-priority {value}", VmPriority)
              .Add("--vm-size {value}", VmSize)
              .Add("--setup-task {value}", SetupTask)
              .Add("--setup-task-output {value}", SetupTaskOutput)
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
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Target number of compute nodes.</p></summary>
        public virtual string Target { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster resize")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--target {value}", Target)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiExperimentCreateSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiExperimentDeleteSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiExperimentListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiExperimentShowSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiExperimentShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai experiment show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of file server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure a default value by setting up default workspace using `az batchai workspace set-default`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ARM ID of the workspace. You can configure default workspace using `az batchai workspace set-default`.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>VM size.</p></summary>
        public virtual string VmSize { get; internal set; }
        /// <summary><p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Optional password for the admin user created on the NFS node.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p></summary>
        public virtual string SshKey { get; internal set; }
        /// <summary><p>Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p></summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary><p>Caching type for premium disks. If not provided via command line or in configuration file, no caching will be used.</p></summary>
        public virtual BatchaiFileServerCreateCachingType CachingType { get; internal set; }
        /// <summary><p>Number of disks.</p></summary>
        public virtual int? DiskCount { get; internal set; }
        /// <summary><p>Disk size in Gb.</p></summary>
        public virtual string DiskSize { get; internal set; }
        /// <summary><p>The sku of storage account to persist VM.</p></summary>
        public virtual BatchaiFileServerCreateStorageSku StorageSku { get; internal set; }
        /// <summary><p>ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p></summary>
        public virtual string Subnet { get; internal set; }
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
              .Add("batchai file-server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--no-wait", NoWait)
              .Add("--vm-size {value}", VmSize)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-key {value}", SshKey)
              .Add("--user-name {value}", UserName)
              .Add("--config-file {value}", ConfigFile)
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
        /// <summary><p>Name of file server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai file-server delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai file-server list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of file server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai file-server show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name or ARM ID of the cluster to run the job. You need to provide ARM ID if the cluster belongs to a different workspace.</p></summary>
        public virtual string Cluster { get; internal set; }
        /// <summary><p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p></summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Relative mount path for Azure File Share. The File Share will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string AfsMountPath { get; internal set; }
        /// <summary><p>Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).</p></summary>
        public virtual string AfsName { get; internal set; }
        /// <summary><p>Relative mount path for Azure Storage Blob Container. The container will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string BfsMountPath { get; internal set; }
        /// <summary><p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p></summary>
        public virtual string BfsName { get; internal set; }
        /// <summary><p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p></summary>
        public virtual string StorageAccountKey { get; internal set; }
        /// <summary><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p></summary>
        public virtual string StorageAccountName { get; internal set; }
        /// <summary><p>Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.</p></summary>
        public virtual string Nfs { get; internal set; }
        /// <summary><p>Relative mount path for NFS. The NFS will be available at $AZ_BATCHAI_JOB_MOUNT_ROOT/&lt;relative_mount_path&gt; folder.</p></summary>
        public virtual string NfsMountPath { get; internal set; }
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
              .Add("batchai job create")
              .Add("--cluster {value}", Cluster)
              .Add("--config-file {value}", ConfigFile)
              .Add("--experiment {value}", Experiment)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--afs-mount-path {value}", AfsMountPath)
              .Add("--afs-name {value}", AfsName)
              .Add("--bfs-mount-path {value}", BfsMountPath)
              .Add("--bfs-name {value}", BfsName)
              .Add("--storage-account-key {value}", StorageAccountKey)
              .Add("--storage-account-name {value}", StorageAccountName)
              .Add("--nfs {value}", Nfs)
              .Add("--nfs-mount-path {value}", NfsMountPath)
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
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job delete")
              .Add("--experiment {value}", Experiment)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiJobListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job list")
              .Add("--experiment {value}", Experiment)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job show")
              .Add("--experiment {value}", Experiment)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job terminate")
              .Add("--experiment {value}", Experiment)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiJobWaitSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Polling interval in sec.</p></summary>
        public virtual string Interval { get; internal set; }
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
              .Add("batchai job wait")
              .Add("--experiment {value}", Experiment)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiWorkspaceCreateSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Location of the workspace. If omitted, the location of the resource group will be used.</p></summary>
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
              .Add("batchai workspace create")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiWorkspaceDeleteSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai workspace delete")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiWorkspaceListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceListSettings : ToolSettings
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
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("batchai workspace list")
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
    #region AzureBatchaiWorkspaceShowSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiWorkspaceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai workspace show")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterFileListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterFileListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Cluster { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Time in minutes for how long generated download URLs should remain valid.</p></summary>
        public virtual string Expiry { get; internal set; }
        /// <summary><p>Relative path of a subfolder inside of the node setup task output directory.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai cluster file list")
              .Add("--cluster {value}", Cluster)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiClusterNodeExecSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterNodeExecSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Cluster { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p></summary>
        public virtual string Address { get; internal set; }
        /// <summary><p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p></summary>
        public virtual string Exec { get; internal set; }
        /// <summary><p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p></summary>
        public virtual string NodeId { get; internal set; }
        /// <summary><p>Optional password to establish SSH connection.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p></summary>
        public virtual string SshPrivateKey { get; internal set; }
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
              .Add("batchai cluster node exec")
              .Add("--cluster {value}", Cluster)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--address {value}", Address)
              .Add("--exec {value}", Exec)
              .Add("--node-id {value}", NodeId)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-private-key {value}", SshPrivateKey)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiClusterNodeListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiClusterNodeListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of cluster.</p></summary>
        public virtual string Cluster { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai cluster node list")
              .Add("--cluster {value}", Cluster)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Job { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("batchai job file list")
              .Add("--experiment {value}", Experiment)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>The name of the file to stream.</p></summary>
        public virtual string FileName { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Job { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>The Id of the job's output directory (as specified by "id" element in outputDirectories collection in the job create parameters).</p></summary>
        public virtual string OutputDirectoryId { get; internal set; }
        /// <summary><p>Relative path in the given output directory.</p></summary>
        public virtual string Path { get; internal set; }
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
              .Add("batchai job file stream")
              .Add("--experiment {value}", Experiment)
              .Add("--file-name {value}", FileName)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
    #region AzureBatchaiJobNodeExecSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobNodeExecSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Job { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
        /// <summary><p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p></summary>
        public virtual string Address { get; internal set; }
        /// <summary><p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p></summary>
        public virtual string Exec { get; internal set; }
        /// <summary><p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p></summary>
        public virtual string NodeId { get; internal set; }
        /// <summary><p>Optional password to establish SSH connection.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p></summary>
        public virtual string SshPrivateKey { get; internal set; }
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
              .Add("batchai job node exec")
              .Add("--experiment {value}", Experiment)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
              .Add("--address {value}", Address)
              .Add("--exec {value}", Exec)
              .Add("--node-id {value}", NodeId)
              .Add("--password {value}", Password, secret: true)
              .Add("--ssh-private-key {value}", SshPrivateKey)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBatchaiJobNodeListSettings
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBatchaiJobNodeListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBatchai executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBatchaiTasks.AzureBatchaiPath;
        /// <summary><p>Name of experiment.</p></summary>
        public virtual string Experiment { get; internal set; }
        /// <summary><p>Name of job.</p></summary>
        public virtual string Job { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of workspace.</p></summary>
        public virtual string Workspace { get; internal set; }
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
              .Add("batchai job node list")
              .Add("--experiment {value}", Experiment)
              .Add("--job {value}", Job)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--workspace {value}", Workspace)
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
        public static AzureBatchaiListUsagesSettings SetOutput(this AzureBatchaiListUsagesSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiListUsagesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiListUsagesSettings SetQuery(this AzureBatchaiListUsagesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiListUsagesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        public static AzureBatchaiClusterAutoScaleSettings SetMax(this AzureBatchaiClusterAutoScaleSettings toolSettings, int? max)
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
        public static AzureBatchaiClusterAutoScaleSettings SetMin(this AzureBatchaiClusterAutoScaleSettings toolSettings, int? min)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetName(this AzureBatchaiClusterAutoScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetWorkspace(this AzureBatchaiClusterAutoScaleSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings ResetWorkspace(this AzureBatchaiClusterAutoScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiClusterAutoScaleSettings SetOutput(this AzureBatchaiClusterAutoScaleSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterAutoScaleSettings SetQuery(this AzureBatchaiClusterAutoScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterAutoScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetName(this AzureBatchaiClusterCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetWorkspace(this AzureBatchaiClusterCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetWorkspace(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetGenerateSshKeys(this AzureBatchaiClusterCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetGenerateSshKeys(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Password"/>.</em></p><p>Optional password for the admin user account to be created on each compute node.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetPassword(this AzureBatchaiClusterCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Password"/>.</em></p><p>Optional password for the admin user account to be created on each compute node.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetPassword(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SshKey"/>.</em></p><p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSshKey(this AzureBatchaiClusterCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SshKey"/>.</em></p><p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSshKey(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.UserName"/>.</em></p><p>Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetUserName(this AzureBatchaiClusterCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.UserName"/>.</em></p><p>Name of admin user account to be created on each compute node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetUserName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.ConfigFile"/>.</em></p><p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetConfigFile(this AzureBatchaiClusterCreateSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.ConfigFile"/>.</em></p><p>A path to a json file containing cluster create parameters (json representation of azure.mgmt.batchai.models.ClusterCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetConfigFile(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.AfsName"/>.</em></p><p>Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetAfsName(this AzureBatchaiClusterCreateSettings toolSettings, string afsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = afsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.AfsName"/>.</em></p><p>Name of Azure File Share to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple shares can be mounted using configuration file (see --config-file option).</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetBfsName(this AzureBatchaiClusterCreateSettings toolSettings, string bfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = bfsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage container to be mounted on each cluster node. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetBfsName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetStorageAccountKey(this AzureBatchaiClusterCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetStorageAccountKey(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetStorageAccountName(this AzureBatchaiClusterCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetStorageAccountName(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Nfs
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Nfs"/>.</em></p><p>Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetNfs(this AzureBatchaiClusterCreateSettings toolSettings, string nfs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = nfs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Nfs"/>.</em></p><p>Name or ARM ID of a file server to be mounted on each cluster node. You need to provide full ARM ID if the file server belongs to a different workspace. Multiple NFS can be mounted using configuration file (see --config-file option).</p></summary>
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
        #region CustomImage
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/>.</em></p><p>ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetCustomImage(this AzureBatchaiClusterCreateSettings toolSettings, string customImage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomImage = customImage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.CustomImage"/>.</em></p><p>ARM ID of a virtual machine image to be used for nodes creation. Note, you need to provide --image containing information about the base image used for this image creation.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetCustomImage(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomImage = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Image"/>.</em></p><p>Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetImage(this AzureBatchaiClusterCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Image"/>.</em></p><p>Operation system image for cluster nodes. The value may contain an alias (UbuntuLTS, UbuntuDSVM) or specify image details in the form "publisher:offer:sku:version". If image configuration is not provided via command line or configuration file, Batch AI will choose default OS image.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/>.</em></p><p>VM priority.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetVmPriority(this AzureBatchaiClusterCreateSettings toolSettings, BatchaiClusterCreateVmPriority vmPriority)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPriority = vmPriority;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.VmPriority"/>.</em></p><p>VM priority.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/>.</em></p><p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSetupTask(this AzureBatchaiClusterCreateSettings toolSettings, string setupTask)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTask = setupTask;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SetupTask"/>.</em></p><p>A command line which should be executed on each compute node when it's got allocated or rebooted. The task is executed in a bash subshell under root account.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSetupTask(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTask = null;
            return toolSettings;
        }
        #endregion
        #region SetupTaskOutput
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/>.</em></p><p>Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSetupTaskOutput(this AzureBatchaiClusterCreateSettings toolSettings, string setupTaskOutput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTaskOutput = setupTaskOutput;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.SetupTaskOutput"/>.</em></p><p>Directory path to store where setup-task's logs. Note, Batch AI will create several helper directories under this path. The created directories are reported as stdOutErrPathSuffix by 'az cluster show' command.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings ResetSetupTaskOutput(this AzureBatchaiClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SetupTaskOutput = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Subnet"/>.</em></p><p>ARM ID of a virtual network subnet to put the cluster in.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetSubnet(this AzureBatchaiClusterCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Subnet"/>.</em></p><p>ARM ID of a virtual network subnet to put the cluster in.</p></summary>
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
        public static AzureBatchaiClusterCreateSettings SetOutput(this AzureBatchaiClusterCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterCreateSettings SetQuery(this AzureBatchaiClusterCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetName(this AzureBatchaiClusterDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetWorkspace(this AzureBatchaiClusterDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ResetWorkspace(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetNoWait(this AzureBatchaiClusterDeleteSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings EnableNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings DisableNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiClusterDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings ToggleNoWait(this AzureBatchaiClusterDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        public static AzureBatchaiClusterDeleteSettings SetOutput(this AzureBatchaiClusterDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterDeleteSettings SetQuery(this AzureBatchaiClusterDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetWorkspace(this AzureBatchaiClusterListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings ResetWorkspace(this AzureBatchaiClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiClusterListSettings SetOutput(this AzureBatchaiClusterListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterListSettings SetQuery(this AzureBatchaiClusterListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region AzureBatchaiClusterResizeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterResizeSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetName(this AzureBatchaiClusterResizeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetWorkspace(this AzureBatchaiClusterResizeSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings ResetWorkspace(this AzureBatchaiClusterResizeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiClusterResizeSettings SetOutput(this AzureBatchaiClusterResizeSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterResizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterResizeSettings SetQuery(this AzureBatchaiClusterResizeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterResizeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetName(this AzureBatchaiClusterShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Name"/>.</em></p><p>Name of cluster.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetWorkspace(this AzureBatchaiClusterShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings ResetWorkspace(this AzureBatchaiClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiClusterShowSettings SetOutput(this AzureBatchaiClusterShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterShowSettings SetQuery(this AzureBatchaiClusterShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region AzureBatchaiExperimentCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Name"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetName(this AzureBatchaiExperimentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Name"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetName(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetResourceGroup(this AzureBatchaiExperimentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetResourceGroup(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetWorkspace(this AzureBatchaiExperimentCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetWorkspace(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetDebug(this AzureBatchaiExperimentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetDebug(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetHelp(this AzureBatchaiExperimentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetHelp(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetOutput(this AzureBatchaiExperimentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetOutput(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetQuery(this AzureBatchaiExperimentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetQuery(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings SetVerbose(this AzureBatchaiExperimentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentCreateSettings ResetVerbose(this AzureBatchaiExperimentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Name"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetName(this AzureBatchaiExperimentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Name"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetName(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetResourceGroup(this AzureBatchaiExperimentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetResourceGroup(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetWorkspace(this AzureBatchaiExperimentDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetWorkspace(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings EnableNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings DisableNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiExperimentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ToggleNoWait(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetYes(this AzureBatchaiExperimentDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetYes(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetDebug(this AzureBatchaiExperimentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetDebug(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetHelp(this AzureBatchaiExperimentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetHelp(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetOutput(this AzureBatchaiExperimentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetOutput(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetQuery(this AzureBatchaiExperimentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetQuery(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings SetVerbose(this AzureBatchaiExperimentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentDeleteSettings ResetVerbose(this AzureBatchaiExperimentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetResourceGroup(this AzureBatchaiExperimentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetResourceGroup(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetWorkspace(this AzureBatchaiExperimentListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetWorkspace(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetDebug(this AzureBatchaiExperimentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetDebug(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetHelp(this AzureBatchaiExperimentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetHelp(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetOutput(this AzureBatchaiExperimentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetOutput(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetQuery(this AzureBatchaiExperimentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetQuery(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings SetVerbose(this AzureBatchaiExperimentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentListSettings ResetVerbose(this AzureBatchaiExperimentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiExperimentShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiExperimentShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Name"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetName(this AzureBatchaiExperimentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Name"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetName(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetResourceGroup(this AzureBatchaiExperimentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetResourceGroup(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetWorkspace(this AzureBatchaiExperimentShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetWorkspace(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetDebug(this AzureBatchaiExperimentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetDebug(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetHelp(this AzureBatchaiExperimentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetHelp(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetOutput(this AzureBatchaiExperimentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetOutput(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetQuery(this AzureBatchaiExperimentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetQuery(this AzureBatchaiExperimentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiExperimentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings SetVerbose(this AzureBatchaiExperimentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiExperimentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiExperimentShowSettings ResetVerbose(this AzureBatchaiExperimentShowSettings toolSettings)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Name"/>.</em></p><p>Name of file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetName(this AzureBatchaiFileServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Name"/>.</em></p><p>Name of file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetName(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure a default value by setting up default workspace using `az batchai workspace set-default`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetResourceGroup(this AzureBatchaiFileServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure a default value by setting up default workspace using `az batchai workspace set-default`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetResourceGroup(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Workspace"/>.</em></p><p>Name or ARM ID of the workspace. You can configure default workspace using `az batchai workspace set-default`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetWorkspace(this AzureBatchaiFileServerCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Workspace"/>.</em></p><p>Name or ARM ID of the workspace. You can configure default workspace using `az batchai workspace set-default`.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetWorkspace(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetNoWait(this AzureBatchaiFileServerCreateSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings EnableNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings DisableNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiFileServerCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ToggleNoWait(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetGenerateSshKeys(this AzureBatchaiFileServerCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files in ~/.ssh directory (if missing).</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetGenerateSshKeys(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Password"/>.</em></p><p>Optional password for the admin user created on the NFS node.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetPassword(this AzureBatchaiFileServerCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Password"/>.</em></p><p>Optional password for the admin user created on the NFS node.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetPassword(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/>.</em></p><p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSshKey(this AzureBatchaiFileServerCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.SshKey"/>.</em></p><p>Optional SSH public key value or path. If ommited and no password specified, default SSH key (~/.ssh/id_rsa.pub) will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetSshKey(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.UserName"/>.</em></p><p>Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetUserName(this AzureBatchaiFileServerCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.UserName"/>.</em></p><p>Name of admin user account to be created on NFS node. If the value is not provided and no user configuration is provided in the config file, current user's name will be used.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetUserName(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.ConfigFile"/>.</em></p><p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetConfigFile(this AzureBatchaiFileServerCreateSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.ConfigFile"/>.</em></p><p>A path to a json file containing file server create parameters (json representation of azure.mgmt.batchai.models.FileServerCreateParameters). Note, parameters given via command line will overwrite parameters specified in the configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings ResetConfigFile(this AzureBatchaiFileServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/>.</em></p><p>ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetSubnet(this AzureBatchaiFileServerCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Subnet"/>.</em></p><p>ARM ID of a virtual network subnet to put the file server in. If not provided via command line or in the configuration file, Batch AI will create a new virtual network and subnet under your subscription.</p></summary>
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
        public static AzureBatchaiFileServerCreateSettings SetOutput(this AzureBatchaiFileServerCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerCreateSettings SetQuery(this AzureBatchaiFileServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Name"/>.</em></p><p>Name of file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetName(this AzureBatchaiFileServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Name"/>.</em></p><p>Name of file server.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetWorkspace(this AzureBatchaiFileServerDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ResetWorkspace(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings EnableNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings DisableNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiFileServerDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings ToggleNoWait(this AzureBatchaiFileServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        public static AzureBatchaiFileServerDeleteSettings SetOutput(this AzureBatchaiFileServerDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerDeleteSettings SetQuery(this AzureBatchaiFileServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetWorkspace(this AzureBatchaiFileServerListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings ResetWorkspace(this AzureBatchaiFileServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiFileServerListSettings SetOutput(this AzureBatchaiFileServerListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerListSettings SetQuery(this AzureBatchaiFileServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Name"/>.</em></p><p>Name of file server.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetName(this AzureBatchaiFileServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Name"/>.</em></p><p>Name of file server.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetWorkspace(this AzureBatchaiFileServerShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings ResetWorkspace(this AzureBatchaiFileServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiFileServerShowSettings SetOutput(this AzureBatchaiFileServerShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiFileServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiFileServerShowSettings SetQuery(this AzureBatchaiFileServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiFileServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Cluster
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Cluster"/>.</em></p><p>Name or ARM ID of the cluster to run the job. You need to provide ARM ID if the cluster belongs to a different workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetCluster(this AzureBatchaiJobCreateSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Cluster"/>.</em></p><p>Name or ARM ID of the cluster to run the job. You need to provide ARM ID if the cluster belongs to a different workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetCluster(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.ConfigFile"/>.</em></p><p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetConfigFile(this AzureBatchaiJobCreateSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.ConfigFile"/>.</em></p><p>A path to a json file containing job create parameters (json representation of azure.mgmt.batchai.models.JobCreateParameters).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetConfigFile(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetExperiment(this AzureBatchaiJobCreateSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetExperiment(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Name"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetName(this AzureBatchaiJobCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Name"/>.</em></p><p>Name of job.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetWorkspace(this AzureBatchaiJobCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetWorkspace(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.AfsName"/>.</em></p><p>Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetAfsName(this AzureBatchaiJobCreateSettings toolSettings, string afsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AfsName = afsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.AfsName"/>.</em></p><p>Name of Azure File Share to mount during the job execution. The File Share will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name.  Multiple shares can be mounted using configuration file (see --config-file option).</p></summary>
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetBfsName(this AzureBatchaiJobCreateSettings toolSettings, string bfsName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = bfsName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.BfsName"/>.</em></p><p>Name of Azure Storage Blob Container to mount during the job execution. The container will be mounted only on the nodes which are executing the job. Must be used in conjunction with --storage-account-name. Multiple containers can be mounted using configuration file (see --config-file option).</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetBfsName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BfsName = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetStorageAccountKey(this AzureBatchaiJobCreateSettings toolSettings, string storageAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = storageAccountKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.StorageAccountKey"/>.</em></p><p>Storage account key. Required if the storage account belongs to a different subscription. Can be specified using AZURE_BATCHAI_STORAGE_KEY environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetStorageAccountKey(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccountName
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetStorageAccountName(this AzureBatchaiJobCreateSettings toolSettings, string storageAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = storageAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.StorageAccountName"/>.</em></p><p>Storage account name for Azure File Shares and/or Azure Storage Containers to be mounted on each cluster node. Can be specified using AZURE_BATCHAI_STORAGE_ACCOUNT environment variable.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetStorageAccountName(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccountName = null;
            return toolSettings;
        }
        #endregion
        #region Nfs
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Nfs"/>.</em></p><p>Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetNfs(this AzureBatchaiJobCreateSettings toolSettings, string nfs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = nfs;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Nfs"/>.</em></p><p>Name or ARM ID of the file server to be mounted during the job execution. You need to provide ARM ID if the file server belongs to a different workspace. You can configure multiple file servers using job's  configuration file.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings ResetNfs(this AzureBatchaiJobCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Nfs = null;
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
        public static AzureBatchaiJobCreateSettings SetOutput(this AzureBatchaiJobCreateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobCreateSettings SetQuery(this AzureBatchaiJobCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetExperiment(this AzureBatchaiJobDeleteSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetExperiment(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Name"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetName(this AzureBatchaiJobDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Name"/>.</em></p><p>Name of job.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetWorkspace(this AzureBatchaiJobDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ResetWorkspace(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetNoWait(this AzureBatchaiJobDeleteSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureBatchaiJobDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings EnableNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiJobDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings DisableNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiJobDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings ToggleNoWait(this AzureBatchaiJobDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        public static AzureBatchaiJobDeleteSettings SetOutput(this AzureBatchaiJobDeleteSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobDeleteSettings SetQuery(this AzureBatchaiJobDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetExperiment(this AzureBatchaiJobListSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetExperiment(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetWorkspace(this AzureBatchaiJobListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings ResetWorkspace(this AzureBatchaiJobListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiJobListSettings SetOutput(this AzureBatchaiJobListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobListSettings SetQuery(this AzureBatchaiJobListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region AzureBatchaiJobShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobShowSettingsExtensions
    {
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetExperiment(this AzureBatchaiJobShowSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetExperiment(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Name"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetName(this AzureBatchaiJobShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Name"/>.</em></p><p>Name of job.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetWorkspace(this AzureBatchaiJobShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings ResetWorkspace(this AzureBatchaiJobShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiJobShowSettings SetOutput(this AzureBatchaiJobShowSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobShowSettings SetQuery(this AzureBatchaiJobShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetExperiment(this AzureBatchaiJobTerminateSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetExperiment(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Name"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetName(this AzureBatchaiJobTerminateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Name"/>.</em></p><p>Name of job.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetWorkspace(this AzureBatchaiJobTerminateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ResetWorkspace(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetNoWait(this AzureBatchaiJobTerminateSettings toolSettings, bool? noWait)
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
        /// <summary><p><em>Enables <see cref="AzureBatchaiJobTerminateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings EnableNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiJobTerminateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings DisableNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiJobTerminateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings ToggleNoWait(this AzureBatchaiJobTerminateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
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
        public static AzureBatchaiJobTerminateSettings SetOutput(this AzureBatchaiJobTerminateSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobTerminateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobTerminateSettings SetQuery(this AzureBatchaiJobTerminateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobTerminateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetExperiment(this AzureBatchaiJobWaitSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetExperiment(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Name"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetName(this AzureBatchaiJobWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Name"/>.</em></p><p>Name of job.</p></summary>
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetWorkspace(this AzureBatchaiJobWaitSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings ResetWorkspace(this AzureBatchaiJobWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiJobWaitSettings SetOutput(this AzureBatchaiJobWaitSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobWaitSettings SetQuery(this AzureBatchaiJobWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region AzureBatchaiWorkspaceCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceCreateSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetResourceGroup(this AzureBatchaiWorkspaceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetResourceGroup(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetWorkspace(this AzureBatchaiWorkspaceCreateSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetWorkspace(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Location"/>.</em></p><p>Location of the workspace. If omitted, the location of the resource group will be used.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetLocation(this AzureBatchaiWorkspaceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Location"/>.</em></p><p>Location of the workspace. If omitted, the location of the resource group will be used.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetLocation(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetDebug(this AzureBatchaiWorkspaceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetDebug(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetHelp(this AzureBatchaiWorkspaceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetHelp(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetOutput(this AzureBatchaiWorkspaceCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetOutput(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetQuery(this AzureBatchaiWorkspaceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetQuery(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings SetVerbose(this AzureBatchaiWorkspaceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceCreateSettings ResetVerbose(this AzureBatchaiWorkspaceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceDeleteSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetResourceGroup(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetResourceGroup(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetWorkspace(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetWorkspace(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings EnableNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings DisableNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBatchaiWorkspaceDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ToggleNoWait(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetYes(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetYes(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetDebug(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetDebug(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetHelp(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetHelp(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetOutput(this AzureBatchaiWorkspaceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetOutput(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetQuery(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetQuery(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings SetVerbose(this AzureBatchaiWorkspaceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceDeleteSettings ResetVerbose(this AzureBatchaiWorkspaceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetResourceGroup(this AzureBatchaiWorkspaceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetResourceGroup(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetDebug(this AzureBatchaiWorkspaceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetDebug(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetHelp(this AzureBatchaiWorkspaceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetHelp(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetOutput(this AzureBatchaiWorkspaceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetOutput(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetQuery(this AzureBatchaiWorkspaceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetQuery(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings SetVerbose(this AzureBatchaiWorkspaceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceListSettings ResetVerbose(this AzureBatchaiWorkspaceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiWorkspaceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiWorkspaceShowSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetResourceGroup(this AzureBatchaiWorkspaceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetResourceGroup(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetWorkspace(this AzureBatchaiWorkspaceShowSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetWorkspace(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetDebug(this AzureBatchaiWorkspaceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetDebug(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetHelp(this AzureBatchaiWorkspaceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetHelp(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetOutput(this AzureBatchaiWorkspaceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetOutput(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetQuery(this AzureBatchaiWorkspaceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetQuery(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiWorkspaceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings SetVerbose(this AzureBatchaiWorkspaceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiWorkspaceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiWorkspaceShowSettings ResetVerbose(this AzureBatchaiWorkspaceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterFileListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterFileListSettingsExtensions
    {
        #region Cluster
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Cluster"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetCluster(this AzureBatchaiClusterFileListSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Cluster"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetCluster(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetResourceGroup(this AzureBatchaiClusterFileListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetResourceGroup(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetWorkspace(this AzureBatchaiClusterFileListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetWorkspace(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Expiry
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Expiry"/>.</em></p><p>Time in minutes for how long generated download URLs should remain valid.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetExpiry(this AzureBatchaiClusterFileListSettings toolSettings, string expiry)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = expiry;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Expiry"/>.</em></p><p>Time in minutes for how long generated download URLs should remain valid.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetExpiry(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expiry = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Path"/>.</em></p><p>Relative path of a subfolder inside of the node setup task output directory.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetPath(this AzureBatchaiClusterFileListSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Path"/>.</em></p><p>Relative path of a subfolder inside of the node setup task output directory.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetPath(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetDebug(this AzureBatchaiClusterFileListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetDebug(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetHelp(this AzureBatchaiClusterFileListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetHelp(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetOutput(this AzureBatchaiClusterFileListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetOutput(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetQuery(this AzureBatchaiClusterFileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetQuery(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterFileListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings SetVerbose(this AzureBatchaiClusterFileListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterFileListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterFileListSettings ResetVerbose(this AzureBatchaiClusterFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterNodeExecSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterNodeExecSettingsExtensions
    {
        #region Cluster
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Cluster"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetCluster(this AzureBatchaiClusterNodeExecSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Cluster"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetCluster(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetResourceGroup(this AzureBatchaiClusterNodeExecSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetResourceGroup(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetWorkspace(this AzureBatchaiClusterNodeExecSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetWorkspace(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Address
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Address"/>.</em></p><p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetAddress(this AzureBatchaiClusterNodeExecSettings toolSettings, string address)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = address;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Address"/>.</em></p><p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetAddress(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = null;
            return toolSettings;
        }
        #endregion
        #region Exec
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Exec"/>.</em></p><p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetExec(this AzureBatchaiClusterNodeExecSettings toolSettings, string exec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = exec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Exec"/>.</em></p><p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetExec(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = null;
            return toolSettings;
        }
        #endregion
        #region NodeId
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.NodeId"/>.</em></p><p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetNodeId(this AzureBatchaiClusterNodeExecSettings toolSettings, string nodeId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = nodeId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.NodeId"/>.</em></p><p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetNodeId(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Password"/>.</em></p><p>Optional password to establish SSH connection.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetPassword(this AzureBatchaiClusterNodeExecSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Password"/>.</em></p><p>Optional password to establish SSH connection.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetPassword(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshPrivateKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.SshPrivateKey"/>.</em></p><p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetSshPrivateKey(this AzureBatchaiClusterNodeExecSettings toolSettings, string sshPrivateKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = sshPrivateKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.SshPrivateKey"/>.</em></p><p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetSshPrivateKey(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetDebug(this AzureBatchaiClusterNodeExecSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetDebug(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetHelp(this AzureBatchaiClusterNodeExecSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetHelp(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetOutput(this AzureBatchaiClusterNodeExecSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetOutput(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetQuery(this AzureBatchaiClusterNodeExecSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetQuery(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeExecSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings SetVerbose(this AzureBatchaiClusterNodeExecSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeExecSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeExecSettings ResetVerbose(this AzureBatchaiClusterNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiClusterNodeListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiClusterNodeListSettingsExtensions
    {
        #region Cluster
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Cluster"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetCluster(this AzureBatchaiClusterNodeListSettings toolSettings, string cluster)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = cluster;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Cluster"/>.</em></p><p>Name of cluster.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetCluster(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cluster = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetResourceGroup(this AzureBatchaiClusterNodeListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetResourceGroup(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetWorkspace(this AzureBatchaiClusterNodeListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetWorkspace(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetDebug(this AzureBatchaiClusterNodeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetDebug(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetHelp(this AzureBatchaiClusterNodeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetHelp(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetOutput(this AzureBatchaiClusterNodeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetOutput(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetQuery(this AzureBatchaiClusterNodeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetQuery(this AzureBatchaiClusterNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiClusterNodeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings SetVerbose(this AzureBatchaiClusterNodeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiClusterNodeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiClusterNodeListSettings ResetVerbose(this AzureBatchaiClusterNodeListSettings toolSettings)
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
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetExperiment(this AzureBatchaiJobFileListSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetExperiment(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetJob(this AzureBatchaiJobFileListSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetJob(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetWorkspace(this AzureBatchaiJobFileListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings ResetWorkspace(this AzureBatchaiJobFileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiJobFileListSettings SetOutput(this AzureBatchaiJobFileListSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileListSettings SetQuery(this AzureBatchaiJobFileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetExperiment(this AzureBatchaiJobFileStreamSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetExperiment(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
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
        #region Job
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetJob(this AzureBatchaiJobFileStreamSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetJob(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
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
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetWorkspace(this AzureBatchaiJobFileStreamSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings ResetWorkspace(this AzureBatchaiJobFileStreamSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
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
        public static AzureBatchaiJobFileStreamSettings SetOutput(this AzureBatchaiJobFileStreamSettings toolSettings, AzureOutput output)
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
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobFileStreamSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobFileStreamSettings SetQuery(this AzureBatchaiJobFileStreamSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobFileStreamSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
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
    #region AzureBatchaiJobNodeExecSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobNodeExecSettingsExtensions
    {
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetExperiment(this AzureBatchaiJobNodeExecSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetExperiment(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetJob(this AzureBatchaiJobNodeExecSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetJob(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetResourceGroup(this AzureBatchaiJobNodeExecSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetResourceGroup(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetWorkspace(this AzureBatchaiJobNodeExecSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetWorkspace(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Address
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Address"/>.</em></p><p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetAddress(this AzureBatchaiJobNodeExecSettings toolSettings, string address)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = address;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Address"/>.</em></p><p>Specifies that connections to the given TCP port or Unix socket on the local (client) host are to be forwarded to the given host and port, or Unix socket, on the remote side. e.g. -L 8080:localhost:8080.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetAddress(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Address = null;
            return toolSettings;
        }
        #endregion
        #region Exec
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Exec"/>.</em></p><p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetExec(this AzureBatchaiJobNodeExecSettings toolSettings, string exec)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = exec;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Exec"/>.</em></p><p>Optional command line to be executed on the node. If not provided, the command will perform ports forwarding only.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetExec(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exec = null;
            return toolSettings;
        }
        #endregion
        #region NodeId
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.NodeId"/>.</em></p><p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetNodeId(this AzureBatchaiJobNodeExecSettings toolSettings, string nodeId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = nodeId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.NodeId"/>.</em></p><p>ID of the node to forward the ports to. If not provided, the command will be executed on the first available node.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetNodeId(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeId = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Password"/>.</em></p><p>Optional password to establish SSH connection.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetPassword(this AzureBatchaiJobNodeExecSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Password"/>.</em></p><p>Optional password to establish SSH connection.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetPassword(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region SshPrivateKey
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.SshPrivateKey"/>.</em></p><p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetSshPrivateKey(this AzureBatchaiJobNodeExecSettings toolSettings, string sshPrivateKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = sshPrivateKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.SshPrivateKey"/>.</em></p><p>Optional SSH private key path to establish SSH connection. If omitted, the default SSH private key will be used.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetSshPrivateKey(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshPrivateKey = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetDebug(this AzureBatchaiJobNodeExecSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetDebug(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetHelp(this AzureBatchaiJobNodeExecSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetHelp(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetOutput(this AzureBatchaiJobNodeExecSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetOutput(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetQuery(this AzureBatchaiJobNodeExecSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetQuery(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeExecSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings SetVerbose(this AzureBatchaiJobNodeExecSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeExecSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeExecSettings ResetVerbose(this AzureBatchaiJobNodeExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBatchaiJobNodeListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBatchaiTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBatchaiJobNodeListSettingsExtensions
    {
        #region Experiment
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetExperiment(this AzureBatchaiJobNodeListSettings toolSettings, string experiment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = experiment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Experiment"/>.</em></p><p>Name of experiment.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetExperiment(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Experiment = null;
            return toolSettings;
        }
        #endregion
        #region Job
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetJob(this AzureBatchaiJobNodeListSettings toolSettings, string job)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = job;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Job"/>.</em></p><p>Name of job.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetJob(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Job = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetResourceGroup(this AzureBatchaiJobNodeListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetResourceGroup(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Workspace
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetWorkspace(this AzureBatchaiJobNodeListSettings toolSettings, string workspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = workspace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Workspace"/>.</em></p><p>Name of workspace.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetWorkspace(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Workspace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetDebug(this AzureBatchaiJobNodeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetDebug(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetHelp(this AzureBatchaiJobNodeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetHelp(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetOutput(this AzureBatchaiJobNodeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetOutput(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetQuery(this AzureBatchaiJobNodeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetQuery(this AzureBatchaiJobNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBatchaiJobNodeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings SetVerbose(this AzureBatchaiJobNodeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBatchaiJobNodeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBatchaiJobNodeListSettings ResetVerbose(this AzureBatchaiJobNodeListSettings toolSettings)
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
    [ExcludeFromCodeCoverage]
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
    [ExcludeFromCodeCoverage]
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
    [ExcludeFromCodeCoverage]
    public partial class BatchaiFileServerCreateStorageSku : Enumeration
    {
        public static BatchaiFileServerCreateStorageSku premium_lrs = new BatchaiFileServerCreateStorageSku { Value = "premium_lrs" };
        public static BatchaiFileServerCreateStorageSku standard_lrs = new BatchaiFileServerCreateStorageSku { Value = "standard_lrs" };
    }
    #endregion
}
