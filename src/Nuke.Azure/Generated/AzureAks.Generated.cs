// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAks.json.

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
    public static partial class AzureAksTasks
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public static string AzureAksPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Kubernetes Services.</p></summary>
        public static IReadOnlyCollection<Output> AzureAks(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAksPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksBrowse(Configure<AzureAksBrowseSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksBrowseSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksCreate(Configure<AzureAksCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksDelete(Configure<AzureAksDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksDisableAddons(Configure<AzureAksDisableAddonsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksDisableAddonsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksEnableAddons(Configure<AzureAksEnableAddonsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksEnableAddonsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksGetCredentials(Configure<AzureAksGetCredentialsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksGetCredentialsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksGetUpgrades(Configure<AzureAksGetUpgradesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksGetUpgradesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksGetVersions(Configure<AzureAksGetVersionsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksGetVersionsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksInstallCli(Configure<AzureAksInstallCliSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksInstallCliSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksInstallConnector(Configure<AzureAksInstallConnectorSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksInstallConnectorSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksList(Configure<AzureAksListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksRemoveConnector(Configure<AzureAksRemoveConnectorSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksRemoveConnectorSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksRemoveDevSpaces(Configure<AzureAksRemoveDevSpacesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksRemoveDevSpacesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksScale(Configure<AzureAksScaleSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksScaleSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksShow(Configure<AzureAksShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksUpgrade(Configure<AzureAksUpgradeSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksUpgradeSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksUpgradeConnector(Configure<AzureAksUpgradeConnectorSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksUpgradeConnectorSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksUseDevSpaces(Configure<AzureAksUseDevSpacesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksUseDevSpacesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Kubernetes Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAksWait(Configure<AzureAksWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAksWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureAksBrowseSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksBrowseSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Don't launch a web browser after establishing port-forwarding.</p></summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary><p>The listening port for the dashboard.</p></summary>
        public virtual string ListenPort { get; internal set; }
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
              .Add("aks browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--listen-port {value}", ListenPort)
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
    #region AzureAksCreateSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.</p></summary>
        public virtual string AadClientAppId { get; internal set; }
        /// <summary><p>The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).</p></summary>
        public virtual string AadServerAppId { get; internal set; }
        /// <summary><p>The secret of an Azure Active Directory server application.</p></summary>
        public virtual string AadServerAppSecret { get; internal set; }
        /// <summary><p>The ID of an Azure Active Directory tenant.</p></summary>
        public virtual string AadTenantId { get; internal set; }
        /// <summary><p>User account to create on node VMs for SSH access.</p></summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary><p>Disable Kubernetes Role-Based Access Control.</p></summary>
        public virtual string DisableRbac { get; internal set; }
        /// <summary><p>Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.</p></summary>
        public virtual string DnsNamePrefix { get; internal set; }
        /// <summary><p>An IP address assigned to the Kubernetes DNS service.</p></summary>
        public virtual string DnsServiceIp { get; internal set; }
        /// <summary><p>A specific IP address and netmask for the Docker bridge, using standard CIDR notation.</p></summary>
        public virtual string DockerBridgeAddress { get; internal set; }
        /// <summary><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        public virtual IReadOnlyList<string> EnableAddons => EnableAddonsInternal.AsReadOnly();
        internal List<string> EnableAddonsInternal { get; set; } = new List<string>();
        /// <summary><p>Enable Kubernetes Role-Based Access Control. Default: enabled.</p></summary>
        public virtual string EnableRbac { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Version of Kubernetes to use for creating the cluster, such as "1.7.12" or "1.8.7".</p></summary>
        public virtual string KubernetesVersion { get; internal set; }
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The maximum number of pods deployable to a node.</p></summary>
        public virtual int? MaxPods { get; internal set; }
        /// <summary><p>The Kubernetes network plugin to use.</p></summary>
        public virtual string NetworkPlugin { get; internal set; }
        /// <summary><p>(PREVIEW) The Kubernetes network policy to use.</p></summary>
        public virtual string NetworkPolicy { get; internal set; }
        /// <summary><p>Do not use or create a local SSH key.</p></summary>
        public virtual bool? NoSshKey { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.</p></summary>
        public virtual int? NodeCount { get; internal set; }
        /// <summary><p>Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.</p></summary>
        public virtual string NodeOsdiskSize { get; internal set; }
        /// <summary><p>Size of Virtual Machines to create as Kubernetes nodes.</p></summary>
        public virtual string NodeVmSize { get; internal set; }
        /// <summary><p>Node pool name, upto 12 alphanumeric characters.</p></summary>
        public virtual string NodepoolName { get; internal set; }
        /// <summary><p>A CIDR notation IP range from which to assign pod IPs when kubenet is used.</p></summary>
        public virtual string PodCidr { get; internal set; }
        /// <summary><p>A CIDR notation IP range from which to assign service cluster IPs.</p></summary>
        public virtual string ServiceCidr { get; internal set; }
        /// <summary><p>Service principal used for authentication to Azure APIs.</p></summary>
        public virtual bool? ServicePrincipal { get; internal set; }
        /// <summary><p>Skip role assignment for subnet (advanced networking).</p></summary>
        public virtual string SkipSubnetRoleAssignment { get; internal set; }
        /// <summary><p>Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.</p></summary>
        public virtual string SshKeyValue { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The ID of a subnet in an existing VNet into which to deploy the cluster.</p></summary>
        public virtual string VnetSubnetId { get; internal set; }
        /// <summary><p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.</p></summary>
        public virtual string WorkspaceResourceId { get; internal set; }
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
              .Add("aks create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aad-client-app-id {value}", AadClientAppId)
              .Add("--aad-server-app-id {value}", AadServerAppId)
              .Add("--aad-server-app-secret {value}", AadServerAppSecret, secret: true)
              .Add("--aad-tenant-id {value}", AadTenantId)
              .Add("--admin-username {value}", AdminUsername)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--disable-rbac {value}", DisableRbac)
              .Add("--dns-name-prefix {value}", DnsNamePrefix)
              .Add("--dns-service-ip {value}", DnsServiceIp)
              .Add("--docker-bridge-address {value}", DockerBridgeAddress)
              .Add("--enable-addons {value}", EnableAddons, separator: ',')
              .Add("--enable-rbac {value}", EnableRbac)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--kubernetes-version {value}", KubernetesVersion)
              .Add("--location {value}", Location)
              .Add("--max-pods {value}", MaxPods)
              .Add("--network-plugin {value}", NetworkPlugin)
              .Add("--network-policy {value}", NetworkPolicy)
              .Add("--no-ssh-key", NoSshKey)
              .Add("--no-wait", NoWait)
              .Add("--node-count {value}", NodeCount)
              .Add("--node-osdisk-size {value}", NodeOsdiskSize)
              .Add("--node-vm-size {value}", NodeVmSize)
              .Add("--nodepool-name {value}", NodepoolName)
              .Add("--pod-cidr {value}", PodCidr)
              .Add("--service-cidr {value}", ServiceCidr)
              .Add("--service-principal", ServicePrincipal)
              .Add("--skip-subnet-role-assignment {value}", SkipSubnetRoleAssignment)
              .Add("--ssh-key-value {value}", SshKeyValue)
              .Add("--tags {value}", Tags)
              .Add("--vnet-subnet-id {value}", VnetSubnetId)
              .Add("--workspace-resource-id {value}", WorkspaceResourceId)
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
    #region AzureAksDeleteSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("aks delete")
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
    #region AzureAksDisableAddonsSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksDisableAddonsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        public virtual IReadOnlyList<string> Addons => AddonsInternal.AsReadOnly();
        internal List<string> AddonsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("aks disable-addons")
              .Add("--addons {value}", Addons, separator: ',')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAksEnableAddonsSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksEnableAddonsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        public virtual IReadOnlyList<string> Addons => AddonsInternal.AsReadOnly();
        internal List<string> AddonsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string SubnetName { get; internal set; }
        /// <summary><p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.</p></summary>
        public virtual string WorkspaceResourceId { get; internal set; }
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
              .Add("aks enable-addons")
              .Add("--addons {value}", Addons, separator: ',')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--subnet-name {value}", SubnetName)
              .Add("--workspace-resource-id {value}", WorkspaceResourceId)
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
    #region AzureAksGetCredentialsSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksGetCredentialsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Get cluster administrator credentials.  Default: cluster user credentials.</p></summary>
        public virtual string Admin { get; internal set; }
        /// <summary><p>Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string OverwriteExisting { get; internal set; }
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
              .Add("aks get-credentials")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin {value}", Admin)
              .Add("--file {value}", File)
              .Add("--overwrite-existing {value}", OverwriteExisting)
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
    #region AzureAksGetUpgradesSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksGetUpgradesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("aks get-upgrades")
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
    #region AzureAksGetVersionsSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksGetVersionsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
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
              .Add("aks get-versions")
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
    #region AzureAksInstallCliSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksInstallCliSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p></p></summary>
        public virtual string ClientVersion { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string InstallLocation { get; internal set; }
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
              .Add("aks install-cli")
              .Add("--client-version {value}", ClientVersion)
              .Add("--install-location {value}", InstallLocation)
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
    #region AzureAksInstallConnectorSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksInstallConnectorSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.</p></summary>
        public virtual string AciResourceGroup { get; internal set; }
        /// <summary><p>URL of a Helm chart that installs ACI Connector.</p></summary>
        public virtual string ChartUrl { get; internal set; }
        /// <summary><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary><p>Name of the ACI Connector.</p></summary>
        public virtual string ConnectorName { get; internal set; }
        /// <summary><p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p></summary>
        public virtual string ImageTag { get; internal set; }
        /// <summary><p>The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Install support for deploying ACIs of this operating system type.</p></summary>
        public virtual AksOsType OsType { get; internal set; }
        /// <summary><p>Service principal used for authentication to Azure APIs.</p></summary>
        public virtual bool? ServicePrincipal { get; internal set; }
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
              .Add("aks install-connector")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aci-resource-group {value}", AciResourceGroup)
              .Add("--chart-url {value}", ChartUrl)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--connector-name {value}", ConnectorName)
              .Add("--image-tag {value}", ImageTag)
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
              .Add("--service-principal", ServicePrincipal)
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
    #region AzureAksListSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
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
              .Add("aks list")
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
    #region AzureAksRemoveConnectorSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksRemoveConnectorSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the ACI Connector.</p></summary>
        public virtual string ConnectorName { get; internal set; }
        /// <summary><p>Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.</p></summary>
        public virtual string Graceful { get; internal set; }
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Remove support for deploying ACIs of this operating system type.</p></summary>
        public virtual AksOsType OsType { get; internal set; }
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
              .Add("aks remove-connector")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--connector-name {value}", ConnectorName)
              .Add("--graceful {value}", Graceful)
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
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
    #region AzureAksRemoveDevSpacesSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksRemoveDevSpacesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("aks remove-dev-spaces")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureAksScaleSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksScaleSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Number of nodes in the Kubernetes node pool.</p></summary>
        public virtual int? NodeCount { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Node pool name, upto 12 alphanumeric characters.</p></summary>
        public virtual string NodepoolName { get; internal set; }
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
              .Add("aks scale")
              .Add("--name {value}", Name)
              .Add("--node-count {value}", NodeCount)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--nodepool-name {value}", NodepoolName)
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
    #region AzureAksShowSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("aks show")
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
    #region AzureAksUpgradeSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUpgradeSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Version of Kubernetes to upgrade the cluster to, such as "1.7.12" or "1.8.7".</p></summary>
        public virtual string KubernetesVersion { get; internal set; }
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("aks upgrade")
              .Add("--kubernetes-version {value}", KubernetesVersion)
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
    #region AzureAksUpgradeConnectorSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUpgradeConnectorSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.</p></summary>
        public virtual string AciResourceGroup { get; internal set; }
        /// <summary><p>URL of a Helm chart that installs ACI Connector.</p></summary>
        public virtual string ChartUrl { get; internal set; }
        /// <summary><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary><p>Name of the ACI Connector.</p></summary>
        public virtual string ConnectorName { get; internal set; }
        /// <summary><p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p></summary>
        public virtual string ImageTag { get; internal set; }
        /// <summary><p>The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Install support for deploying ACIs of this operating system type.</p></summary>
        public virtual AksOsType OsType { get; internal set; }
        /// <summary><p>Service principal used for authentication to Azure APIs.</p></summary>
        public virtual bool? ServicePrincipal { get; internal set; }
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
              .Add("aks upgrade-connector")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aci-resource-group {value}", AciResourceGroup)
              .Add("--chart-url {value}", ChartUrl)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--connector-name {value}", ConnectorName)
              .Add("--image-tag {value}", ImageTag)
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
              .Add("--service-principal", ServicePrincipal)
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
    #region AzureAksUseDevSpacesSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUseDevSpacesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the new or existing dev space to select. Defaults to an interactive selection experience.</p></summary>
        public virtual string Space { get; internal set; }
        /// <summary><p>Update to the latest Azure Dev Spaces client components.</p></summary>
        public virtual string Update { get; internal set; }
        /// <summary><p>Do not prompt for confirmation. Requires --space.</p></summary>
        public virtual string Yes { get; internal set; }
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
              .Add("aks use-dev-spaces")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--space {value}", Space)
              .Add("--update {value}", Update)
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
    #region AzureAksWaitSettings
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAks executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        /// <summary><p>Name of the managed cluster.</p></summary>
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
              .Add("aks wait")
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
    #region AzureAksBrowseSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksBrowseSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetName(this AzureAksBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetName(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetResourceGroup(this AzureAksBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetResourceGroup(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.DisableBrowser"/>.</em></p><p>Don't launch a web browser after establishing port-forwarding.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetDisableBrowser(this AzureAksBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.DisableBrowser"/>.</em></p><p>Don't launch a web browser after establishing port-forwarding.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetDisableBrowser(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region ListenPort
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.ListenPort"/>.</em></p><p>The listening port for the dashboard.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetListenPort(this AzureAksBrowseSettings toolSettings, string listenPort)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListenPort = listenPort;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.ListenPort"/>.</em></p><p>The listening port for the dashboard.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetListenPort(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListenPort = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetSubscription(this AzureAksBrowseSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetSubscription(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetDebug(this AzureAksBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetDebug(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetHelp(this AzureAksBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetHelp(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetOutput(this AzureAksBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetOutput(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetQuery(this AzureAksBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetQuery(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings SetVerbose(this AzureAksBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksBrowseSettings ResetVerbose(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetName(this AzureAksCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetName(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetResourceGroup(this AzureAksCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetResourceGroup(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AadClientAppId
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.AadClientAppId"/>.</em></p><p>The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetAadClientAppId(this AzureAksCreateSettings toolSettings, string aadClientAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = aadClientAppId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.AadClientAppId"/>.</em></p><p>The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadClientAppId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadServerAppId
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.AadServerAppId"/>.</em></p><p>The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetAadServerAppId(this AzureAksCreateSettings toolSettings, string aadServerAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppId = aadServerAppId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.AadServerAppId"/>.</em></p><p>The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadServerAppId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadServerAppSecret
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.AadServerAppSecret"/>.</em></p><p>The secret of an Azure Active Directory server application.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetAadServerAppSecret(this AzureAksCreateSettings toolSettings, string aadServerAppSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppSecret = aadServerAppSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.AadServerAppSecret"/>.</em></p><p>The secret of an Azure Active Directory server application.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadServerAppSecret(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppSecret = null;
            return toolSettings;
        }
        #endregion
        #region AadTenantId
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.AadTenantId"/>.</em></p><p>The ID of an Azure Active Directory tenant.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetAadTenantId(this AzureAksCreateSettings toolSettings, string aadTenantId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = aadTenantId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.AadTenantId"/>.</em></p><p>The ID of an Azure Active Directory tenant.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadTenantId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.AdminUsername"/>.</em></p><p>User account to create on node VMs for SSH access.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetAdminUsername(this AzureAksCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.AdminUsername"/>.</em></p><p>User account to create on node VMs for SSH access.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetAdminUsername(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.ClientSecret"/>.</em></p><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetClientSecret(this AzureAksCreateSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.ClientSecret"/>.</em></p><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetClientSecret(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region DisableRbac
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.DisableRbac"/>.</em></p><p>Disable Kubernetes Role-Based Access Control.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetDisableRbac(this AzureAksCreateSettings toolSettings, string disableRbac)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableRbac = disableRbac;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.DisableRbac"/>.</em></p><p>Disable Kubernetes Role-Based Access Control.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetDisableRbac(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableRbac = null;
            return toolSettings;
        }
        #endregion
        #region DnsNamePrefix
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.DnsNamePrefix"/>.</em></p><p>Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetDnsNamePrefix(this AzureAksCreateSettings toolSettings, string dnsNamePrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNamePrefix = dnsNamePrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.DnsNamePrefix"/>.</em></p><p>Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetDnsNamePrefix(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNamePrefix = null;
            return toolSettings;
        }
        #endregion
        #region DnsServiceIp
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.DnsServiceIp"/>.</em></p><p>An IP address assigned to the Kubernetes DNS service.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetDnsServiceIp(this AzureAksCreateSettings toolSettings, string dnsServiceIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServiceIp = dnsServiceIp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.DnsServiceIp"/>.</em></p><p>An IP address assigned to the Kubernetes DNS service.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetDnsServiceIp(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServiceIp = null;
            return toolSettings;
        }
        #endregion
        #region DockerBridgeAddress
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.DockerBridgeAddress"/>.</em></p><p>A specific IP address and netmask for the Docker bridge, using standard CIDR notation.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetDockerBridgeAddress(this AzureAksCreateSettings toolSettings, string dockerBridgeAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerBridgeAddress = dockerBridgeAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.DockerBridgeAddress"/>.</em></p><p>A specific IP address and netmask for the Docker bridge, using standard CIDR notation.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetDockerBridgeAddress(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerBridgeAddress = null;
            return toolSettings;
        }
        #endregion
        #region EnableAddons
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.EnableAddons"/> to a new list.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetEnableAddons(this AzureAksCreateSettings toolSettings, params string[] enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal = enableAddons.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.EnableAddons"/> to a new list.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetEnableAddons(this AzureAksCreateSettings toolSettings, IEnumerable<string> enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal = enableAddons.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAksCreateSettings.EnableAddons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings AddEnableAddons(this AzureAksCreateSettings toolSettings, params string[] enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal.AddRange(enableAddons);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAksCreateSettings.EnableAddons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings AddEnableAddons(this AzureAksCreateSettings toolSettings, IEnumerable<string> enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal.AddRange(enableAddons);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAksCreateSettings.EnableAddons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ClearEnableAddons(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAksCreateSettings.EnableAddons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings RemoveEnableAddons(this AzureAksCreateSettings toolSettings, params string[] enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(enableAddons);
            toolSettings.EnableAddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAksCreateSettings.EnableAddons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksCreateSettings RemoveEnableAddons(this AzureAksCreateSettings toolSettings, IEnumerable<string> enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(enableAddons);
            toolSettings.EnableAddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region EnableRbac
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.EnableRbac"/>.</em></p><p>Enable Kubernetes Role-Based Access Control. Default: enabled.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetEnableRbac(this AzureAksCreateSettings toolSettings, string enableRbac)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableRbac = enableRbac;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.EnableRbac"/>.</em></p><p>Enable Kubernetes Role-Based Access Control. Default: enabled.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetEnableRbac(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableRbac = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetGenerateSshKeys(this AzureAksCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetGenerateSshKeys(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region KubernetesVersion
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.KubernetesVersion"/>.</em></p><p>Version of Kubernetes to use for creating the cluster, such as "1.7.12" or "1.8.7".</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetKubernetesVersion(this AzureAksCreateSettings toolSettings, string kubernetesVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = kubernetesVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.KubernetesVersion"/>.</em></p><p>Version of Kubernetes to use for creating the cluster, such as "1.7.12" or "1.8.7".</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetKubernetesVersion(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetLocation(this AzureAksCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetLocation(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MaxPods
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.MaxPods"/>.</em></p><p>The maximum number of pods deployable to a node.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetMaxPods(this AzureAksCreateSettings toolSettings, int? maxPods)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxPods = maxPods;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.MaxPods"/>.</em></p><p>The maximum number of pods deployable to a node.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetMaxPods(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxPods = null;
            return toolSettings;
        }
        #endregion
        #region NetworkPlugin
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NetworkPlugin"/>.</em></p><p>The Kubernetes network plugin to use.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNetworkPlugin(this AzureAksCreateSettings toolSettings, string networkPlugin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPlugin = networkPlugin;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NetworkPlugin"/>.</em></p><p>The Kubernetes network plugin to use.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNetworkPlugin(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPlugin = null;
            return toolSettings;
        }
        #endregion
        #region NetworkPolicy
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NetworkPolicy"/>.</em></p><p>(PREVIEW) The Kubernetes network policy to use.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNetworkPolicy(this AzureAksCreateSettings toolSettings, string networkPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPolicy = networkPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NetworkPolicy"/>.</em></p><p>(PREVIEW) The Kubernetes network policy to use.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNetworkPolicy(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPolicy = null;
            return toolSettings;
        }
        #endregion
        #region NoSshKey
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NoSshKey"/>.</em></p><p>Do not use or create a local SSH key.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNoSshKey(this AzureAksCreateSettings toolSettings, bool? noSshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = noSshKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NoSshKey"/>.</em></p><p>Do not use or create a local SSH key.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksCreateSettings.NoSshKey"/>.</em></p><p>Do not use or create a local SSH key.</p></summary>
        [Pure]
        public static AzureAksCreateSettings EnableNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksCreateSettings.NoSshKey"/>.</em></p><p>Do not use or create a local SSH key.</p></summary>
        [Pure]
        public static AzureAksCreateSettings DisableNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksCreateSettings.NoSshKey"/>.</em></p><p>Do not use or create a local SSH key.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ToggleNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = !toolSettings.NoSshKey;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNoWait(this AzureAksCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksCreateSettings EnableNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksCreateSettings DisableNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ToggleNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region NodeCount
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NodeCount"/>.</em></p><p>Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNodeCount(this AzureAksCreateSettings toolSettings, int? nodeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = nodeCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NodeCount"/>.</em></p><p>Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodeCount(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = null;
            return toolSettings;
        }
        #endregion
        #region NodeOsdiskSize
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NodeOsdiskSize"/>.</em></p><p>Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNodeOsdiskSize(this AzureAksCreateSettings toolSettings, string nodeOsdiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeOsdiskSize = nodeOsdiskSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NodeOsdiskSize"/>.</em></p><p>Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodeOsdiskSize(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeOsdiskSize = null;
            return toolSettings;
        }
        #endregion
        #region NodeVmSize
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NodeVmSize"/>.</em></p><p>Size of Virtual Machines to create as Kubernetes nodes.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNodeVmSize(this AzureAksCreateSettings toolSettings, string nodeVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeVmSize = nodeVmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NodeVmSize"/>.</em></p><p>Size of Virtual Machines to create as Kubernetes nodes.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodeVmSize(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeVmSize = null;
            return toolSettings;
        }
        #endregion
        #region NodepoolName
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.NodepoolName"/>.</em></p><p>Node pool name, upto 12 alphanumeric characters.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetNodepoolName(this AzureAksCreateSettings toolSettings, string nodepoolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = nodepoolName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.NodepoolName"/>.</em></p><p>Node pool name, upto 12 alphanumeric characters.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodepoolName(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = null;
            return toolSettings;
        }
        #endregion
        #region PodCidr
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.PodCidr"/>.</em></p><p>A CIDR notation IP range from which to assign pod IPs when kubenet is used.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetPodCidr(this AzureAksCreateSettings toolSettings, string podCidr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PodCidr = podCidr;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.PodCidr"/>.</em></p><p>A CIDR notation IP range from which to assign pod IPs when kubenet is used.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetPodCidr(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PodCidr = null;
            return toolSettings;
        }
        #endregion
        #region ServiceCidr
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.ServiceCidr"/>.</em></p><p>A CIDR notation IP range from which to assign service cluster IPs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetServiceCidr(this AzureAksCreateSettings toolSettings, string serviceCidr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceCidr = serviceCidr;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.ServiceCidr"/>.</em></p><p>A CIDR notation IP range from which to assign service cluster IPs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetServiceCidr(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceCidr = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetServicePrincipal(this AzureAksCreateSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksCreateSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings EnableServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksCreateSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings DisableServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksCreateSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ToggleServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region SkipSubnetRoleAssignment
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.SkipSubnetRoleAssignment"/>.</em></p><p>Skip role assignment for subnet (advanced networking).</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetSkipSubnetRoleAssignment(this AzureAksCreateSettings toolSettings, string skipSubnetRoleAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipSubnetRoleAssignment = skipSubnetRoleAssignment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.SkipSubnetRoleAssignment"/>.</em></p><p>Skip role assignment for subnet (advanced networking).</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetSkipSubnetRoleAssignment(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipSubnetRoleAssignment = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.SshKeyValue"/>.</em></p><p>Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetSshKeyValue(this AzureAksCreateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.SshKeyValue"/>.</em></p><p>Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetSshKeyValue(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetTags(this AzureAksCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetTags(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VnetSubnetId
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.VnetSubnetId"/>.</em></p><p>The ID of a subnet in an existing VNet into which to deploy the cluster.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetVnetSubnetId(this AzureAksCreateSettings toolSettings, string vnetSubnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetSubnetId = vnetSubnetId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.VnetSubnetId"/>.</em></p><p>The ID of a subnet in an existing VNet into which to deploy the cluster.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetVnetSubnetId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetSubnetId = null;
            return toolSettings;
        }
        #endregion
        #region WorkspaceResourceId
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.WorkspaceResourceId"/>.</em></p><p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetWorkspaceResourceId(this AzureAksCreateSettings toolSettings, string workspaceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = workspaceResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.WorkspaceResourceId"/>.</em></p><p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetWorkspaceResourceId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetSubscription(this AzureAksCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetSubscription(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetDebug(this AzureAksCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetDebug(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetHelp(this AzureAksCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetHelp(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetOutput(this AzureAksCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetOutput(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetQuery(this AzureAksCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetQuery(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings SetVerbose(this AzureAksCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksCreateSettings ResetVerbose(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetName(this AzureAksDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetName(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetResourceGroup(this AzureAksDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetResourceGroup(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetNoWait(this AzureAksDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings EnableNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings DisableNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ToggleNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetYes(this AzureAksDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetYes(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetSubscription(this AzureAksDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetSubscription(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetDebug(this AzureAksDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetDebug(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetHelp(this AzureAksDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetHelp(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetOutput(this AzureAksDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetOutput(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetQuery(this AzureAksDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetQuery(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings SetVerbose(this AzureAksDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksDeleteSettings ResetVerbose(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksDisableAddonsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksDisableAddonsSettingsExtensions
    {
        #region Addons
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Addons"/> to a new list.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetAddons(this AzureAksDisableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Addons"/> to a new list.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetAddons(this AzureAksDisableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAksDisableAddonsSettings.Addons"/>.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings AddAddons(this AzureAksDisableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAksDisableAddonsSettings.Addons"/>.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings AddAddons(this AzureAksDisableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAksDisableAddonsSettings.Addons"/>.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ClearAddons(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAksDisableAddonsSettings.Addons"/>.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings RemoveAddons(this AzureAksDisableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAksDisableAddonsSettings.Addons"/>.</em></p><p>Disable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings RemoveAddons(this AzureAksDisableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetName(this AzureAksDisableAddonsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetName(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetResourceGroup(this AzureAksDisableAddonsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetResourceGroup(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetNoWait(this AzureAksDisableAddonsSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksDisableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings EnableNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksDisableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings DisableNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksDisableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ToggleNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetSubscription(this AzureAksDisableAddonsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetSubscription(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetDebug(this AzureAksDisableAddonsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetDebug(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetHelp(this AzureAksDisableAddonsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetHelp(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetOutput(this AzureAksDisableAddonsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetOutput(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetQuery(this AzureAksDisableAddonsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetQuery(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksDisableAddonsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetVerbose(this AzureAksDisableAddonsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksDisableAddonsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetVerbose(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksEnableAddonsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksEnableAddonsSettingsExtensions
    {
        #region Addons
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Addons"/> to a new list.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetAddons(this AzureAksEnableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Addons"/> to a new list.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetAddons(this AzureAksEnableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAksEnableAddonsSettings.Addons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings AddAddons(this AzureAksEnableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAksEnableAddonsSettings.Addons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings AddAddons(this AzureAksEnableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAksEnableAddonsSettings.Addons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ClearAddons(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAksEnableAddonsSettings.Addons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings RemoveAddons(this AzureAksEnableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAksEnableAddonsSettings.Addons"/>.</em></p><p>Enable the Kubernetes addons in a comma-separated list.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings RemoveAddons(this AzureAksEnableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetName(this AzureAksEnableAddonsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetName(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetResourceGroup(this AzureAksEnableAddonsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetResourceGroup(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetNoWait(this AzureAksEnableAddonsSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksEnableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings EnableNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksEnableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings DisableNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksEnableAddonsSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ToggleNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SubnetName
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.SubnetName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetSubnetName(this AzureAksEnableAddonsSettings toolSettings, string subnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetName = subnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.SubnetName"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetSubnetName(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetName = null;
            return toolSettings;
        }
        #endregion
        #region WorkspaceResourceId
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.WorkspaceResourceId"/>.</em></p><p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetWorkspaceResourceId(this AzureAksEnableAddonsSettings toolSettings, string workspaceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = workspaceResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.WorkspaceResourceId"/>.</em></p><p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetWorkspaceResourceId(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetSubscription(this AzureAksEnableAddonsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetSubscription(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetDebug(this AzureAksEnableAddonsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetDebug(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetHelp(this AzureAksEnableAddonsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetHelp(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetOutput(this AzureAksEnableAddonsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetOutput(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetQuery(this AzureAksEnableAddonsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetQuery(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksEnableAddonsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetVerbose(this AzureAksEnableAddonsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksEnableAddonsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetVerbose(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksGetCredentialsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksGetCredentialsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetName(this AzureAksGetCredentialsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetName(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetResourceGroup(this AzureAksGetCredentialsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetResourceGroup(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Admin
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Admin"/>.</em></p><p>Get cluster administrator credentials.  Default: cluster user credentials.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetAdmin(this AzureAksGetCredentialsSettings toolSettings, string admin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Admin = admin;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Admin"/>.</em></p><p>Get cluster administrator credentials.  Default: cluster user credentials.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetAdmin(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Admin = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.File"/>.</em></p><p>Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetFile(this AzureAksGetCredentialsSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.File"/>.</em></p><p>Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetFile(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region OverwriteExisting
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.OverwriteExisting"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetOverwriteExisting(this AzureAksGetCredentialsSettings toolSettings, string overwriteExisting)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverwriteExisting = overwriteExisting;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.OverwriteExisting"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetOverwriteExisting(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverwriteExisting = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetSubscription(this AzureAksGetCredentialsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetSubscription(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetDebug(this AzureAksGetCredentialsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetDebug(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetHelp(this AzureAksGetCredentialsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetHelp(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetOutput(this AzureAksGetCredentialsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetOutput(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetQuery(this AzureAksGetCredentialsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetQuery(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksGetCredentialsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetVerbose(this AzureAksGetCredentialsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetCredentialsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetVerbose(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksGetUpgradesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksGetUpgradesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetName(this AzureAksGetUpgradesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetName(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetResourceGroup(this AzureAksGetUpgradesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetResourceGroup(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetSubscription(this AzureAksGetUpgradesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetSubscription(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetDebug(this AzureAksGetUpgradesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetDebug(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetHelp(this AzureAksGetUpgradesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetHelp(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetOutput(this AzureAksGetUpgradesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetOutput(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetQuery(this AzureAksGetUpgradesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetQuery(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksGetUpgradesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetVerbose(this AzureAksGetUpgradesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetUpgradesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetVerbose(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksGetVersionsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksGetVersionsSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetLocation(this AzureAksGetVersionsSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetLocation(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetSubscription(this AzureAksGetVersionsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetSubscription(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetDebug(this AzureAksGetVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetDebug(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetHelp(this AzureAksGetVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetHelp(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetOutput(this AzureAksGetVersionsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetOutput(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetQuery(this AzureAksGetVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetQuery(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksGetVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetVerbose(this AzureAksGetVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksGetVersionsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetVerbose(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksInstallCliSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksInstallCliSettingsExtensions
    {
        #region ClientVersion
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.ClientVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetClientVersion(this AzureAksInstallCliSettings toolSettings, string clientVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = clientVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.ClientVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetClientVersion(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = null;
            return toolSettings;
        }
        #endregion
        #region InstallLocation
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.InstallLocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetInstallLocation(this AzureAksInstallCliSettings toolSettings, string installLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = installLocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.InstallLocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetInstallLocation(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetSubscription(this AzureAksInstallCliSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetSubscription(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetDebug(this AzureAksInstallCliSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetDebug(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetHelp(this AzureAksInstallCliSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetHelp(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetOutput(this AzureAksInstallCliSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetOutput(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetQuery(this AzureAksInstallCliSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetQuery(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksInstallCliSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings SetVerbose(this AzureAksInstallCliSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallCliSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetVerbose(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksInstallConnectorSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksInstallConnectorSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetName(this AzureAksInstallConnectorSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetName(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetResourceGroup(this AzureAksInstallConnectorSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetResourceGroup(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AciResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.AciResourceGroup"/>.</em></p><p>The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetAciResourceGroup(this AzureAksInstallConnectorSettings toolSettings, string aciResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = aciResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.AciResourceGroup"/>.</em></p><p>The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetAciResourceGroup(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ChartUrl
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.ChartUrl"/>.</em></p><p>URL of a Helm chart that installs ACI Connector.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetChartUrl(this AzureAksInstallConnectorSettings toolSettings, string chartUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = chartUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.ChartUrl"/>.</em></p><p>URL of a Helm chart that installs ACI Connector.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetChartUrl(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.ClientSecret"/>.</em></p><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetClientSecret(this AzureAksInstallConnectorSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.ClientSecret"/>.</em></p><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetClientSecret(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region ConnectorName
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.ConnectorName"/>.</em></p><p>Name of the ACI Connector.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetConnectorName(this AzureAksInstallConnectorSettings toolSettings, string connectorName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = connectorName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.ConnectorName"/>.</em></p><p>Name of the ACI Connector.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetConnectorName(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = null;
            return toolSettings;
        }
        #endregion
        #region ImageTag
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.ImageTag"/>.</em></p><p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetImageTag(this AzureAksInstallConnectorSettings toolSettings, string imageTag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = imageTag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.ImageTag"/>.</em></p><p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetImageTag(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Location"/>.</em></p><p>The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetLocation(this AzureAksInstallConnectorSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Location"/>.</em></p><p>The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetLocation(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.OsType"/>.</em></p><p>Install support for deploying ACIs of this operating system type.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetOsType(this AzureAksInstallConnectorSettings toolSettings, AksOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.OsType"/>.</em></p><p>Install support for deploying ACIs of this operating system type.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetOsType(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetServicePrincipal(this AzureAksInstallConnectorSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings EnableServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings DisableServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ToggleServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetSubscription(this AzureAksInstallConnectorSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetSubscription(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetDebug(this AzureAksInstallConnectorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetDebug(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetHelp(this AzureAksInstallConnectorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetHelp(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetOutput(this AzureAksInstallConnectorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetOutput(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetQuery(this AzureAksInstallConnectorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetQuery(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksInstallConnectorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetVerbose(this AzureAksInstallConnectorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksInstallConnectorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetVerbose(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksListSettings SetResourceGroup(this AzureAksListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetResourceGroup(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksListSettings SetSubscription(this AzureAksListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetSubscription(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksListSettings SetDebug(this AzureAksListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetDebug(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksListSettings SetHelp(this AzureAksListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetHelp(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksListSettings SetOutput(this AzureAksListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetOutput(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksListSettings SetQuery(this AzureAksListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetQuery(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksListSettings SetVerbose(this AzureAksListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksListSettings ResetVerbose(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksRemoveConnectorSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksRemoveConnectorSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetName(this AzureAksRemoveConnectorSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetName(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetResourceGroup(this AzureAksRemoveConnectorSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetResourceGroup(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ConnectorName
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.ConnectorName"/>.</em></p><p>Name of the ACI Connector.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetConnectorName(this AzureAksRemoveConnectorSettings toolSettings, string connectorName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = connectorName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.ConnectorName"/>.</em></p><p>Name of the ACI Connector.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetConnectorName(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = null;
            return toolSettings;
        }
        #endregion
        #region Graceful
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Graceful"/>.</em></p><p>Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetGraceful(this AzureAksRemoveConnectorSettings toolSettings, string graceful)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Graceful = graceful;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Graceful"/>.</em></p><p>Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetGraceful(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Graceful = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetLocation(this AzureAksRemoveConnectorSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetLocation(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.OsType"/>.</em></p><p>Remove support for deploying ACIs of this operating system type.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetOsType(this AzureAksRemoveConnectorSettings toolSettings, AksOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.OsType"/>.</em></p><p>Remove support for deploying ACIs of this operating system type.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetOsType(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetSubscription(this AzureAksRemoveConnectorSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetSubscription(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetDebug(this AzureAksRemoveConnectorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetDebug(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetHelp(this AzureAksRemoveConnectorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetHelp(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetOutput(this AzureAksRemoveConnectorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetOutput(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetQuery(this AzureAksRemoveConnectorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetQuery(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetVerbose(this AzureAksRemoveConnectorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetVerbose(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksRemoveDevSpacesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksRemoveDevSpacesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetName(this AzureAksRemoveDevSpacesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetName(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetResourceGroup(this AzureAksRemoveDevSpacesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetResourceGroup(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetYes(this AzureAksRemoveDevSpacesSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetYes(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetSubscription(this AzureAksRemoveDevSpacesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetSubscription(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetDebug(this AzureAksRemoveDevSpacesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetDebug(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetHelp(this AzureAksRemoveDevSpacesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetHelp(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetOutput(this AzureAksRemoveDevSpacesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetOutput(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetQuery(this AzureAksRemoveDevSpacesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetQuery(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetVerbose(this AzureAksRemoveDevSpacesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetVerbose(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksScaleSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksScaleSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetName(this AzureAksScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetName(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NodeCount
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.NodeCount"/>.</em></p><p>Number of nodes in the Kubernetes node pool.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetNodeCount(this AzureAksScaleSettings toolSettings, int? nodeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = nodeCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.NodeCount"/>.</em></p><p>Number of nodes in the Kubernetes node pool.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetNodeCount(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetResourceGroup(this AzureAksScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetResourceGroup(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetNoWait(this AzureAksScaleSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksScaleSettings EnableNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksScaleSettings DisableNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksScaleSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ToggleNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region NodepoolName
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.NodepoolName"/>.</em></p><p>Node pool name, upto 12 alphanumeric characters.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetNodepoolName(this AzureAksScaleSettings toolSettings, string nodepoolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = nodepoolName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.NodepoolName"/>.</em></p><p>Node pool name, upto 12 alphanumeric characters.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetNodepoolName(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetSubscription(this AzureAksScaleSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetSubscription(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetDebug(this AzureAksScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetDebug(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetHelp(this AzureAksScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetHelp(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetOutput(this AzureAksScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetOutput(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetQuery(this AzureAksScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetQuery(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksScaleSettings SetVerbose(this AzureAksScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksScaleSettings ResetVerbose(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetName(this AzureAksShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetName(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetResourceGroup(this AzureAksShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetResourceGroup(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetSubscription(this AzureAksShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetSubscription(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetDebug(this AzureAksShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetDebug(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetHelp(this AzureAksShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetHelp(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetOutput(this AzureAksShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetOutput(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetQuery(this AzureAksShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetQuery(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksShowSettings SetVerbose(this AzureAksShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksShowSettings ResetVerbose(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUpgradeSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUpgradeSettingsExtensions
    {
        #region KubernetesVersion
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.KubernetesVersion"/>.</em></p><p>Version of Kubernetes to upgrade the cluster to, such as "1.7.12" or "1.8.7".</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetKubernetesVersion(this AzureAksUpgradeSettings toolSettings, string kubernetesVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = kubernetesVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.KubernetesVersion"/>.</em></p><p>Version of Kubernetes to upgrade the cluster to, such as "1.7.12" or "1.8.7".</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetKubernetesVersion(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetName(this AzureAksUpgradeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetName(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetResourceGroup(this AzureAksUpgradeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetResourceGroup(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetNoWait(this AzureAksUpgradeSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksUpgradeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings EnableNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksUpgradeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings DisableNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksUpgradeSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ToggleNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetYes(this AzureAksUpgradeSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetYes(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetSubscription(this AzureAksUpgradeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetSubscription(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetDebug(this AzureAksUpgradeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetDebug(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetHelp(this AzureAksUpgradeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetHelp(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetOutput(this AzureAksUpgradeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetOutput(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetQuery(this AzureAksUpgradeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetQuery(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings SetVerbose(this AzureAksUpgradeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetVerbose(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUpgradeConnectorSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUpgradeConnectorSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetName(this AzureAksUpgradeConnectorSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetName(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AciResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.AciResourceGroup"/>.</em></p><p>The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetAciResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings, string aciResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = aciResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.AciResourceGroup"/>.</em></p><p>The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetAciResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ChartUrl
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ChartUrl"/>.</em></p><p>URL of a Helm chart that installs ACI Connector.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetChartUrl(this AzureAksUpgradeConnectorSettings toolSettings, string chartUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = chartUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ChartUrl"/>.</em></p><p>URL of a Helm chart that installs ACI Connector.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetChartUrl(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ClientSecret"/>.</em></p><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetClientSecret(this AzureAksUpgradeConnectorSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ClientSecret"/>.</em></p><p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetClientSecret(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region ConnectorName
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ConnectorName"/>.</em></p><p>Name of the ACI Connector.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetConnectorName(this AzureAksUpgradeConnectorSettings toolSettings, string connectorName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = connectorName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ConnectorName"/>.</em></p><p>Name of the ACI Connector.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetConnectorName(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = null;
            return toolSettings;
        }
        #endregion
        #region ImageTag
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ImageTag"/>.</em></p><p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetImageTag(this AzureAksUpgradeConnectorSettings toolSettings, string imageTag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = imageTag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ImageTag"/>.</em></p><p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetImageTag(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Location"/>.</em></p><p>The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetLocation(this AzureAksUpgradeConnectorSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Location"/>.</em></p><p>The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetLocation(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.OsType"/>.</em></p><p>Install support for deploying ACIs of this operating system type.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetOsType(this AzureAksUpgradeConnectorSettings toolSettings, AksOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.OsType"/>.</em></p><p>Install support for deploying ACIs of this operating system type.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetOsType(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings EnableServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings DisableServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/>.</em></p><p>Service principal used for authentication to Azure APIs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ToggleServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetSubscription(this AzureAksUpgradeConnectorSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetSubscription(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetDebug(this AzureAksUpgradeConnectorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetDebug(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetHelp(this AzureAksUpgradeConnectorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetHelp(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetOutput(this AzureAksUpgradeConnectorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetOutput(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetQuery(this AzureAksUpgradeConnectorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetQuery(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetVerbose(this AzureAksUpgradeConnectorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetVerbose(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUseDevSpacesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUseDevSpacesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetName(this AzureAksUseDevSpacesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetName(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetResourceGroup(this AzureAksUseDevSpacesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetResourceGroup(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Space
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Space"/>.</em></p><p>Name of the new or existing dev space to select. Defaults to an interactive selection experience.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetSpace(this AzureAksUseDevSpacesSettings toolSettings, string space)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Space = space;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Space"/>.</em></p><p>Name of the new or existing dev space to select. Defaults to an interactive selection experience.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetSpace(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Space = null;
            return toolSettings;
        }
        #endregion
        #region Update
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Update"/>.</em></p><p>Update to the latest Azure Dev Spaces client components.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetUpdate(this AzureAksUseDevSpacesSettings toolSettings, string update)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Update = update;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Update"/>.</em></p><p>Update to the latest Azure Dev Spaces client components.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetUpdate(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Update = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Yes"/>.</em></p><p>Do not prompt for confirmation. Requires --space.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetYes(this AzureAksUseDevSpacesSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Yes"/>.</em></p><p>Do not prompt for confirmation. Requires --space.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetYes(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetSubscription(this AzureAksUseDevSpacesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetSubscription(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetDebug(this AzureAksUseDevSpacesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetDebug(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetHelp(this AzureAksUseDevSpacesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetHelp(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetOutput(this AzureAksUseDevSpacesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetOutput(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetQuery(this AzureAksUseDevSpacesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetQuery(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetVerbose(this AzureAksUseDevSpacesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetVerbose(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetName(this AzureAksWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Name"/>.</em></p><p>Name of the managed cluster.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetName(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetResourceGroup(this AzureAksWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetResourceGroup(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetCreated(this AzureAksWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetCreated(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetCustom(this AzureAksWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetCustom(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetDeleted(this AzureAksWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetDeleted(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetExists(this AzureAksWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetExists(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetInterval(this AzureAksWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetInterval(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetTimeout(this AzureAksWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetTimeout(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetUpdated(this AzureAksWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetUpdated(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetSubscription(this AzureAksWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetSubscription(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetDebug(this AzureAksWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetDebug(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetHelp(this AzureAksWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetHelp(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetOutput(this AzureAksWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetOutput(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetQuery(this AzureAksWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetQuery(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAksWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksWaitSettings SetVerbose(this AzureAksWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAksWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAksWaitSettings ResetVerbose(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AksOsType
    /// <summary><p>Used within <see cref="AzureAksTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AksOsType : Enumeration
    {
        public static AksOsType both = new AksOsType { Value = "both" };
        public static AksOsType linux = new AksOsType { Value = "linux" };
        public static AksOsType windows = new AksOsType { Value = "windows" };
    }
    #endregion
}
