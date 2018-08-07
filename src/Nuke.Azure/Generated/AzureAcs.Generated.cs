// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.0 [CommitSha: 5a428f0d].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAcs.json.

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
    public static partial class AzureAcsTasks
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public static string AzureAcsPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Container Services.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcs(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAcsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsBrowse(Configure<AzureAcsBrowseSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsBrowseSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsCreate(Configure<AzureAcsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsDelete(Configure<AzureAcsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsList(Configure<AzureAcsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsListLocations(Configure<AzureAcsListLocationsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsListLocationsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsScale(Configure<AzureAcsScaleSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsScaleSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsShow(Configure<AzureAcsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsWait(Configure<AzureAcsWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesBrowse(Configure<AzureAcsKubernetesBrowseSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsKubernetesBrowseSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesGetCredentials(Configure<AzureAcsKubernetesGetCredentialsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsKubernetesGetCredentialsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesInstallCli(Configure<AzureAcsKubernetesInstallCliSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsKubernetesInstallCliSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsDcosBrowse(Configure<AzureAcsDcosBrowseSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsDcosBrowseSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Container Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAcsDcosInstallCli(Configure<AzureAcsDcosInstallCliSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAcsDcosInstallCliSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureAcsBrowseSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsBrowseSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary><p>If set a path to an SSH key to use, only applies to DCOS.</p></summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--ssh-key-file {value}", SshKeyFile)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsCreateSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The adminstration password for Windows nodes. Only available if --windows=true.</p></summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary><p>User name for the Linux Virtual Machines.</p></summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string AgentCount { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.</p></summary>
        public virtual string AgentOsdiskSize { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.</p></summary>
        public virtual string AgentPorts { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.</p></summary>
        public virtual string AgentProfiles { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.</p></summary>
        public virtual AcsCreateAgentStorageProfile AgentStorageProfile { get; internal set; }
        /// <summary><p>Set the default size for agent pools vms.</p></summary>
        public virtual string AgentVmSize { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".</p></summary>
        public virtual string AgentVnetSubnetId { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary><p>Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.</p></summary>
        public virtual string DnsPrefix { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The number of masters for the cluster.</p></summary>
        public virtual string MasterCount { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.</p></summary>
        public virtual string MasterFirstConsecutiveStaticIp { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.</p></summary>
        public virtual string MasterOsdiskSize { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.</p></summary>
        public virtual string MasterProfile { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.</p></summary>
        public virtual AcsCreateAgentStorageProfile MasterStorageProfile { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.</p></summary>
        public virtual string MasterVmSize { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".</p></summary>
        public virtual string MasterVnetSubnetId { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>The type of orchestrator used to manage the applications on the cluster.</p></summary>
        public virtual AcsCreateOrchestratorType OrchestratorType { get; internal set; }
        /// <summary><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.</p></summary>
        public virtual string OrchestratorVersion { get; internal set; }
        /// <summary><p></p></summary>
        public virtual bool? ServicePrincipal { get; internal set; }
        /// <summary><p>Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.</p></summary>
        public virtual string SshKeyValue { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Generate and validate the ARM template without creating any resources.</p></summary>
        public virtual string Validate { get; internal set; }
        /// <summary><p>If true, set the default osType of agent pools to be Windows.</p></summary>
        public virtual string Windows { get; internal set; }
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
              .Add("acs create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--admin-username {value}", AdminUsername)
              .Add("--agent-count {value}", AgentCount)
              .Add("--agent-osdisk-size {value}", AgentOsdiskSize)
              .Add("--agent-ports {value}", AgentPorts)
              .Add("--agent-profiles {value}", AgentProfiles)
              .Add("--agent-storage-profile {value}", AgentStorageProfile)
              .Add("--agent-vm-size {value}", AgentVmSize)
              .Add("--agent-vnet-subnet-id {value}", AgentVnetSubnetId)
              .Add("--api-version {value}", ApiVersion)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--dns-prefix {value}", DnsPrefix)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--location {value}", Location)
              .Add("--master-count {value}", MasterCount)
              .Add("--master-first-consecutive-static-ip {value}", MasterFirstConsecutiveStaticIp)
              .Add("--master-osdisk-size {value}", MasterOsdiskSize)
              .Add("--master-profile {value}", MasterProfile)
              .Add("--master-storage-profile {value}", MasterStorageProfile)
              .Add("--master-vm-size {value}", MasterVmSize)
              .Add("--master-vnet-subnet-id {value}", MasterVnetSubnetId)
              .Add("--no-wait {value}", NoWait)
              .Add("--orchestrator-type {value}", OrchestratorType)
              .Add("--orchestrator-version {value}", OrchestratorVersion)
              .Add("--service-principal", ServicePrincipal)
              .Add("--ssh-key-value {value}", SshKeyValue)
              .Add("--tags {value}", Tags)
              .Add("--validate {value}", Validate)
              .Add("--windows {value}", Windows)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsDeleteSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("acs delete")
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
    #region AzureAcsListSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
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
              .Add("acs list")
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
    #region AzureAcsListLocationsSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsListLocationsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
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
              .Add("acs list-locations")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsScaleSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsScaleSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string NewAgentCount { get; internal set; }
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
              .Add("acs scale")
              .Add("--name {value}", Name)
              .Add("--new-agent-count {value}", NewAgentCount)
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
    #region AzureAcsShowSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("acs show")
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
    #region AzureAcsWaitSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
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
              .Add("acs wait")
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
    #region AzureAcsKubernetesBrowseSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsKubernetesBrowseSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs kubernetes browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--ssh-key-file {value}", SshKeyFile)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsKubernetesGetCredentialsSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsKubernetesGetCredentialsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Where to install the kubectl config file.</p></summary>
        public virtual string File { get; internal set; }
        /// <summary><p>Path to an SSH key file to use.</p></summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs kubernetes get-credentials")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--file {value}", File)
              .Add("--ssh-key-file {value}", SshKeyFile)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsKubernetesInstallCliSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsKubernetesInstallCliSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p></p></summary>
        public virtual string ClientVersion { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string InstallLocation { get; internal set; }
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
              .Add("acs kubernetes install-cli")
              .Add("--client-version {value}", ClientVersion)
              .Add("--install-location {value}", InstallLocation)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsDcosBrowseSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsDcosBrowseSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary><p>Path to an SSH key file to use.</p></summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs dcos browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--ssh-key-file {value}", SshKeyFile)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsDcosInstallCliSettings
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsDcosInstallCliSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAcs executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        /// <summary><p></p></summary>
        public virtual string ClientVersion { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string InstallLocation { get; internal set; }
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
              .Add("acs dcos install-cli")
              .Add("--client-version {value}", ClientVersion)
              .Add("--install-location {value}", InstallLocation)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAcsBrowseSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsBrowseSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetName(this AzureAcsBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetName(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.ResourceGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetResourceGroup(this AzureAcsBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.ResourceGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetResourceGroup(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.DisableBrowser"/>.</em></p><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetDisableBrowser(this AzureAcsBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.DisableBrowser"/>.</em></p><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetDisableBrowser(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.SshKeyFile"/>.</em></p><p>If set a path to an SSH key to use, only applies to DCOS.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetSshKeyFile(this AzureAcsBrowseSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.SshKeyFile"/>.</em></p><p>If set a path to an SSH key to use, only applies to DCOS.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetSshKeyFile(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetDebug(this AzureAcsBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetDebug(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetHelp(this AzureAcsBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetHelp(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetOutput(this AzureAcsBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetOutput(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetQuery(this AzureAcsBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetQuery(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings SetVerbose(this AzureAcsBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetVerbose(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetName(this AzureAcsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetName(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetResourceGroup(this AzureAcsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetResourceGroup(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AdminPassword"/>.</em></p><p>The adminstration password for Windows nodes. Only available if --windows=true.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAdminPassword(this AzureAcsCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AdminPassword"/>.</em></p><p>The adminstration password for Windows nodes. Only available if --windows=true.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAdminPassword(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AdminUsername"/>.</em></p><p>User name for the Linux Virtual Machines.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAdminUsername(this AzureAcsCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AdminUsername"/>.</em></p><p>User name for the Linux Virtual Machines.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAdminUsername(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region AgentCount
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentCount"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentCount(this AzureAcsCreateSettings toolSettings, string agentCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentCount = agentCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentCount"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentCount(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentCount = null;
            return toolSettings;
        }
        #endregion
        #region AgentOsdiskSize
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentOsdiskSize"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentOsdiskSize(this AzureAcsCreateSettings toolSettings, string agentOsdiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentOsdiskSize = agentOsdiskSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentOsdiskSize"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentOsdiskSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentOsdiskSize = null;
            return toolSettings;
        }
        #endregion
        #region AgentPorts
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentPorts"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentPorts(this AzureAcsCreateSettings toolSettings, string agentPorts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentPorts = agentPorts;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentPorts"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentPorts(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentPorts = null;
            return toolSettings;
        }
        #endregion
        #region AgentProfiles
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentProfiles"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentProfiles(this AzureAcsCreateSettings toolSettings, string agentProfiles)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentProfiles = agentProfiles;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentProfiles"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentProfiles(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentProfiles = null;
            return toolSettings;
        }
        #endregion
        #region AgentStorageProfile
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentStorageProfile"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentStorageProfile(this AzureAcsCreateSettings toolSettings, AcsCreateAgentStorageProfile agentStorageProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentStorageProfile = agentStorageProfile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentStorageProfile"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentStorageProfile(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentStorageProfile = null;
            return toolSettings;
        }
        #endregion
        #region AgentVmSize
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentVmSize"/>.</em></p><p>Set the default size for agent pools vms.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentVmSize(this AzureAcsCreateSettings toolSettings, string agentVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVmSize = agentVmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentVmSize"/>.</em></p><p>Set the default size for agent pools vms.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentVmSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVmSize = null;
            return toolSettings;
        }
        #endregion
        #region AgentVnetSubnetId
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.AgentVnetSubnetId"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentVnetSubnetId(this AzureAcsCreateSettings toolSettings, string agentVnetSubnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVnetSubnetId = agentVnetSubnetId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.AgentVnetSubnetId"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentVnetSubnetId(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVnetSubnetId = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.ApiVersion"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetApiVersion(this AzureAcsCreateSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.ApiVersion"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetApiVersion(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.ClientSecret"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetClientSecret(this AzureAcsCreateSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.ClientSecret"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetClientSecret(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region DnsPrefix
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.DnsPrefix"/>.</em></p><p>Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetDnsPrefix(this AzureAcsCreateSettings toolSettings, string dnsPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsPrefix = dnsPrefix;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.DnsPrefix"/>.</em></p><p>Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetDnsPrefix(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsPrefix = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetGenerateSshKeys(this AzureAcsCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetGenerateSshKeys(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetLocation(this AzureAcsCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetLocation(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MasterCount
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterCount"/>.</em></p><p>The number of masters for the cluster.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterCount(this AzureAcsCreateSettings toolSettings, string masterCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterCount = masterCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterCount"/>.</em></p><p>The number of masters for the cluster.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterCount(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterCount = null;
            return toolSettings;
        }
        #endregion
        #region MasterFirstConsecutiveStaticIp
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterFirstConsecutiveStaticIp"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterFirstConsecutiveStaticIp(this AzureAcsCreateSettings toolSettings, string masterFirstConsecutiveStaticIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterFirstConsecutiveStaticIp = masterFirstConsecutiveStaticIp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterFirstConsecutiveStaticIp"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterFirstConsecutiveStaticIp(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterFirstConsecutiveStaticIp = null;
            return toolSettings;
        }
        #endregion
        #region MasterOsdiskSize
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterOsdiskSize"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterOsdiskSize(this AzureAcsCreateSettings toolSettings, string masterOsdiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterOsdiskSize = masterOsdiskSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterOsdiskSize"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterOsdiskSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterOsdiskSize = null;
            return toolSettings;
        }
        #endregion
        #region MasterProfile
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterProfile"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterProfile(this AzureAcsCreateSettings toolSettings, string masterProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterProfile = masterProfile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterProfile"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterProfile(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterProfile = null;
            return toolSettings;
        }
        #endregion
        #region MasterStorageProfile
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterStorageProfile"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterStorageProfile(this AzureAcsCreateSettings toolSettings, AcsCreateAgentStorageProfile masterStorageProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterStorageProfile = masterStorageProfile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterStorageProfile"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterStorageProfile(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterStorageProfile = null;
            return toolSettings;
        }
        #endregion
        #region MasterVmSize
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterVmSize"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterVmSize(this AzureAcsCreateSettings toolSettings, string masterVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVmSize = masterVmSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterVmSize"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterVmSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVmSize = null;
            return toolSettings;
        }
        #endregion
        #region MasterVnetSubnetId
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.MasterVnetSubnetId"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterVnetSubnetId(this AzureAcsCreateSettings toolSettings, string masterVnetSubnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVnetSubnetId = masterVnetSubnetId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.MasterVnetSubnetId"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterVnetSubnetId(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVnetSubnetId = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetNoWait(this AzureAcsCreateSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetNoWait(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region OrchestratorType
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.OrchestratorType"/>.</em></p><p>The type of orchestrator used to manage the applications on the cluster.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetOrchestratorType(this AzureAcsCreateSettings toolSettings, AcsCreateOrchestratorType orchestratorType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorType = orchestratorType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.OrchestratorType"/>.</em></p><p>The type of orchestrator used to manage the applications on the cluster.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetOrchestratorType(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorType = null;
            return toolSettings;
        }
        #endregion
        #region OrchestratorVersion
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.OrchestratorVersion"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetOrchestratorVersion(this AzureAcsCreateSettings toolSettings, string orchestratorVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorVersion = orchestratorVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.OrchestratorVersion"/>.</em></p><p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetOrchestratorVersion(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorVersion = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.ServicePrincipal"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetServicePrincipal(this AzureAcsCreateSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.ServicePrincipal"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAcsCreateSettings.ServicePrincipal"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings EnableServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAcsCreateSettings.ServicePrincipal"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings DisableServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAcsCreateSettings.ServicePrincipal"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsCreateSettings ToggleServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.SshKeyValue"/>.</em></p><p>Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetSshKeyValue(this AzureAcsCreateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.SshKeyValue"/>.</em></p><p>Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetSshKeyValue(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetTags(this AzureAcsCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetTags(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Validate
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetValidate(this AzureAcsCreateSettings toolSettings, string validate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = validate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Validate"/>.</em></p><p>Generate and validate the ARM template without creating any resources.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetValidate(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = null;
            return toolSettings;
        }
        #endregion
        #region Windows
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Windows"/>.</em></p><p>If true, set the default osType of agent pools to be Windows.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetWindows(this AzureAcsCreateSettings toolSettings, string windows)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = windows;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Windows"/>.</em></p><p>If true, set the default osType of agent pools to be Windows.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetWindows(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetDebug(this AzureAcsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetDebug(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetHelp(this AzureAcsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetHelp(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetOutput(this AzureAcsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetOutput(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetQuery(this AzureAcsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetQuery(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings SetVerbose(this AzureAcsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsCreateSettings ResetVerbose(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetName(this AzureAcsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetName(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetResourceGroup(this AzureAcsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetResourceGroup(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetYes(this AzureAcsDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetYes(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetDebug(this AzureAcsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetDebug(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetHelp(this AzureAcsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetHelp(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetOutput(this AzureAcsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetOutput(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetQuery(this AzureAcsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetQuery(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings SetVerbose(this AzureAcsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetVerbose(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsListSettings SetResourceGroup(this AzureAcsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsListSettings ResetResourceGroup(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsListSettings SetDebug(this AzureAcsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsListSettings ResetDebug(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsListSettings SetHelp(this AzureAcsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsListSettings ResetHelp(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsListSettings SetOutput(this AzureAcsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsListSettings ResetOutput(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsListSettings SetQuery(this AzureAcsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsListSettings ResetQuery(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsListSettings SetVerbose(this AzureAcsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsListSettings ResetVerbose(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsListLocationsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsListLocationsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsListLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetDebug(this AzureAcsListLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetDebug(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsListLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetHelp(this AzureAcsListLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetHelp(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsListLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetOutput(this AzureAcsListLocationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetOutput(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsListLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetQuery(this AzureAcsListLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetQuery(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsListLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetVerbose(this AzureAcsListLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsListLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetVerbose(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsScaleSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsScaleSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetName(this AzureAcsScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetName(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NewAgentCount
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.NewAgentCount"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetNewAgentCount(this AzureAcsScaleSettings toolSettings, string newAgentCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewAgentCount = newAgentCount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.NewAgentCount"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetNewAgentCount(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewAgentCount = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetResourceGroup(this AzureAcsScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetResourceGroup(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetDebug(this AzureAcsScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetDebug(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetHelp(this AzureAcsScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetHelp(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetOutput(this AzureAcsScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetOutput(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetQuery(this AzureAcsScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetQuery(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings SetVerbose(this AzureAcsScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsScaleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsScaleSettings ResetVerbose(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetName(this AzureAcsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetName(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetResourceGroup(this AzureAcsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetResourceGroup(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetDebug(this AzureAcsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetDebug(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetHelp(this AzureAcsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetHelp(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetOutput(this AzureAcsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetOutput(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetQuery(this AzureAcsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetQuery(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsShowSettings SetVerbose(this AzureAcsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsShowSettings ResetVerbose(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetName(this AzureAcsWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetName(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetResourceGroup(this AzureAcsWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetResourceGroup(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetCreated(this AzureAcsWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetCreated(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetCustom(this AzureAcsWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetCustom(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetDeleted(this AzureAcsWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetDeleted(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetExists(this AzureAcsWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetExists(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetInterval(this AzureAcsWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetInterval(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetTimeout(this AzureAcsWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetTimeout(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetUpdated(this AzureAcsWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetUpdated(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetDebug(this AzureAcsWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetDebug(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetHelp(this AzureAcsWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetHelp(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetOutput(this AzureAcsWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetOutput(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetQuery(this AzureAcsWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetQuery(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings SetVerbose(this AzureAcsWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsWaitSettings ResetVerbose(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsKubernetesBrowseSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsKubernetesBrowseSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetName(this AzureAcsKubernetesBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetName(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.ResourceGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetResourceGroup(this AzureAcsKubernetesBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.ResourceGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetResourceGroup(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.DisableBrowser"/>.</em></p><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetDisableBrowser(this AzureAcsKubernetesBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.DisableBrowser"/>.</em></p><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetDisableBrowser(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.SshKeyFile"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetSshKeyFile(this AzureAcsKubernetesBrowseSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.SshKeyFile"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetSshKeyFile(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetDebug(this AzureAcsKubernetesBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetDebug(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetHelp(this AzureAcsKubernetesBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetHelp(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetOutput(this AzureAcsKubernetesBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetOutput(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetQuery(this AzureAcsKubernetesBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetQuery(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetVerbose(this AzureAcsKubernetesBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetVerbose(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsKubernetesGetCredentialsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsKubernetesGetCredentialsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetName(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetName(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetResourceGroup(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetResourceGroup(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.File"/>.</em></p><p>Where to install the kubectl config file.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.File"/>.</em></p><p>Where to install the kubectl config file.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.SshKeyFile"/>.</em></p><p>Path to an SSH key file to use.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetSshKeyFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.SshKeyFile"/>.</em></p><p>Path to an SSH key file to use.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetSshKeyFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetDebug(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetDebug(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetHelp(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetHelp(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetOutput(this AzureAcsKubernetesGetCredentialsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetOutput(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetQuery(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetQuery(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetVerbose(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetVerbose(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsKubernetesInstallCliSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsKubernetesInstallCliSettingsExtensions
    {
        #region ClientVersion
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.ClientVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetClientVersion(this AzureAcsKubernetesInstallCliSettings toolSettings, string clientVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = clientVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.ClientVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetClientVersion(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = null;
            return toolSettings;
        }
        #endregion
        #region InstallLocation
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.InstallLocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetInstallLocation(this AzureAcsKubernetesInstallCliSettings toolSettings, string installLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = installLocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.InstallLocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetInstallLocation(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetDebug(this AzureAcsKubernetesInstallCliSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetDebug(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetHelp(this AzureAcsKubernetesInstallCliSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetHelp(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetOutput(this AzureAcsKubernetesInstallCliSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetOutput(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetQuery(this AzureAcsKubernetesInstallCliSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetQuery(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetVerbose(this AzureAcsKubernetesInstallCliSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetVerbose(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsDcosBrowseSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsDcosBrowseSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetName(this AzureAcsDcosBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Name"/>.</em></p><p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetName(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.ResourceGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetResourceGroup(this AzureAcsDcosBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.ResourceGroup"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetResourceGroup(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.DisableBrowser"/>.</em></p><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetDisableBrowser(this AzureAcsDcosBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.DisableBrowser"/>.</em></p><p>Do not open browser after opening a proxy to the cluster web user interface.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetDisableBrowser(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.SshKeyFile"/>.</em></p><p>Path to an SSH key file to use.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetSshKeyFile(this AzureAcsDcosBrowseSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.SshKeyFile"/>.</em></p><p>Path to an SSH key file to use.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetSshKeyFile(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetDebug(this AzureAcsDcosBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetDebug(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetHelp(this AzureAcsDcosBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetHelp(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetOutput(this AzureAcsDcosBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetOutput(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetQuery(this AzureAcsDcosBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetQuery(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetVerbose(this AzureAcsDcosBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetVerbose(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsDcosInstallCliSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsDcosInstallCliSettingsExtensions
    {
        #region ClientVersion
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.ClientVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetClientVersion(this AzureAcsDcosInstallCliSettings toolSettings, string clientVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = clientVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.ClientVersion"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetClientVersion(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = null;
            return toolSettings;
        }
        #endregion
        #region InstallLocation
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.InstallLocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetInstallLocation(this AzureAcsDcosInstallCliSettings toolSettings, string installLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = installLocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.InstallLocation"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetInstallLocation(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetDebug(this AzureAcsDcosInstallCliSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetDebug(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetHelp(this AzureAcsDcosInstallCliSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetHelp(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetOutput(this AzureAcsDcosInstallCliSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetOutput(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetQuery(this AzureAcsDcosInstallCliSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetQuery(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetVerbose(this AzureAcsDcosInstallCliSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetVerbose(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AcsCreateAgentStorageProfile
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcsCreateAgentStorageProfile : Enumeration
    {
        public static AcsCreateAgentStorageProfile manageddisks = new AcsCreateAgentStorageProfile { Value = "manageddisks" };
        public static AcsCreateAgentStorageProfile storageaccount = new AcsCreateAgentStorageProfile { Value = "storageaccount" };
    }
    #endregion
    #region AcsCreateOrchestratorType
    /// <summary><p>Used within <see cref="AzureAcsTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AcsCreateOrchestratorType : Enumeration
    {
        public static AcsCreateOrchestratorType custom = new AcsCreateOrchestratorType { Value = "custom" };
        public static AcsCreateOrchestratorType dcos = new AcsCreateOrchestratorType { Value = "dcos" };
        public static AcsCreateOrchestratorType dockerce = new AcsCreateOrchestratorType { Value = "dockerce" };
        public static AcsCreateOrchestratorType kubernetes = new AcsCreateOrchestratorType { Value = "kubernetes" };
        public static AcsCreateOrchestratorType swarm = new AcsCreateOrchestratorType { Value = "swarm" };
    }
    #endregion
}
