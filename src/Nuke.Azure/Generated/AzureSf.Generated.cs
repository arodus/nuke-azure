// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.0 [CommitSha: 5a428f0d].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureSf.json.

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
    public static partial class AzureSfTasks
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public static string AzureSfPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p></summary>
        public static IReadOnlyCollection<Output> AzureSf(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureSfPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSf(Configure<AzureSfSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfApplication(Configure<AzureSfApplicationSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfApplicationSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterCreate(Configure<AzureSfClusterCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterList(Configure<AzureSfClusterListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterShow(Configure<AzureSfClusterShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfApplicationCertificateAdd(Configure<AzureSfApplicationCertificateAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfApplicationCertificateAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterCertificateAdd(Configure<AzureSfClusterCertificateAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterCertificateAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterCertificateRemove(Configure<AzureSfClusterCertificateRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterCertificateRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterClientCertificateAdd(Configure<AzureSfClusterClientCertificateAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterClientCertificateAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterClientCertificateRemove(Configure<AzureSfClusterClientCertificateRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterClientCertificateRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterDurabilityUpdate(Configure<AzureSfClusterDurabilityUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterDurabilityUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterNodeTypeAdd(Configure<AzureSfClusterNodeTypeAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterNodeTypeAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterNodeAdd(Configure<AzureSfClusterNodeAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterNodeAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterNodeRemove(Configure<AzureSfClusterNodeRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterNodeRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterReliabilityUpdate(Configure<AzureSfClusterReliabilityUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterReliabilityUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterSettingRemove(Configure<AzureSfClusterSettingRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterSettingRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterSettingSet(Configure<AzureSfClusterSettingSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterSettingSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage and administer Azure Service Fabric clusters.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/sf?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureSfClusterUpgradeTypeSet(Configure<AzureSfClusterUpgradeTypeSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureSfClusterUpgradeTypeSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureSfSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
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
              .Add("sf")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfApplicationSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfApplicationSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
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
              .Add("sf application")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterCreateSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        public virtual string CertificateFile { get; internal set; }
        /// <summary><p>The folder of the new certificate file to be created.</p></summary>
        public virtual string CertificateOutputFolder { get; internal set; }
        /// <summary><p>The password of the certificate file.</p></summary>
        public virtual string CertificatePassword { get; internal set; }
        /// <summary><p>The subject name of the certificate to be created.</p></summary>
        public virtual string CertificateSubjectName { get; internal set; }
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The number of nodes in the cluster. Default are 5 nodes.</p></summary>
        public virtual string ClusterSize { get; internal set; }
        /// <summary><p>The Operating System of the VMs that make up the cluster.</p></summary>
        public virtual SfClusterCreateOs Os { get; internal set; }
        /// <summary><p>The path to the template parameter file.</p></summary>
        public virtual string ParameterFile { get; internal set; }
        /// <summary><p>The existing Azure key vault secret URL.</p></summary>
        public virtual string SecretIdentifier { get; internal set; }
        /// <summary><p>The path to the template file.</p></summary>
        public virtual string TemplateFile { get; internal set; }
        /// <summary><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        public virtual string VaultResourceGroup { get; internal set; }
        /// <summary><p>The password of the Vm.</p></summary>
        public virtual string VmPassword { get; internal set; }
        /// <summary><p>The Vm Sku.</p></summary>
        public virtual string VmSku { get; internal set; }
        /// <summary><p>The user name for logging to Vm. Default will be adminuser.</p></summary>
        public virtual string VmUserName { get; internal set; }
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
              .Add("sf cluster create")
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--certificate-file {value}", CertificateFile)
              .Add("--certificate-output-folder {value}", CertificateOutputFolder)
              .Add("--certificate-password {value}", CertificatePassword, secret: true)
              .Add("--certificate-subject-name {value}", CertificateSubjectName)
              .Add("--cluster-name {value}", ClusterName)
              .Add("--cluster-size {value}", ClusterSize)
              .Add("--os {value}", Os)
              .Add("--parameter-file {value}", ParameterFile)
              .Add("--secret-identifier {value}", SecretIdentifier, secret: true)
              .Add("--template-file {value}", TemplateFile)
              .Add("--vault-name {value}", VaultName)
              .Add("--vault-resource-group {value}", VaultResourceGroup)
              .Add("--vm-password {value}", VmPassword, secret: true)
              .Add("--vm-sku {value}", VmSku)
              .Add("--vm-user-name {value}", VmUserName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterListSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>The resource group name.</p></summary>
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
              .Add("sf cluster list")
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
    #region AzureSfClusterShowSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
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
              .Add("sf cluster show")
              .Add("--cluster-name {value}", ClusterName)
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
    #region AzureSfApplicationCertificateAddSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfApplicationCertificateAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        public virtual string CertificateFile { get; internal set; }
        /// <summary><p>The folder of the new certificate file to be created.</p></summary>
        public virtual string CertificateOutputFolder { get; internal set; }
        /// <summary><p>The password of the certificate file.</p></summary>
        public virtual string CertificatePassword { get; internal set; }
        /// <summary><p>The subject name of the certificate to be created.</p></summary>
        public virtual string CertificateSubjectName { get; internal set; }
        /// <summary><p>The existing Azure key vault secret URL.</p></summary>
        public virtual string SecretIdentifier { get; internal set; }
        /// <summary><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        public virtual string VaultResourceGroup { get; internal set; }
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
              .Add("sf application certificate add")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--certificate-file {value}", CertificateFile)
              .Add("--certificate-output-folder {value}", CertificateOutputFolder)
              .Add("--certificate-password {value}", CertificatePassword, secret: true)
              .Add("--certificate-subject-name {value}", CertificateSubjectName)
              .Add("--secret-identifier {value}", SecretIdentifier, secret: true)
              .Add("--vault-name {value}", VaultName)
              .Add("--vault-resource-group {value}", VaultResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterCertificateAddSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterCertificateAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        public virtual string CertificateFile { get; internal set; }
        /// <summary><p>The folder of the new certificate file to be created.</p></summary>
        public virtual string CertificateOutputFolder { get; internal set; }
        /// <summary><p>The password of the certificate file.</p></summary>
        public virtual string CertificatePassword { get; internal set; }
        /// <summary><p>The subject name of the certificate to be created.</p></summary>
        public virtual string CertificateSubjectName { get; internal set; }
        /// <summary><p>The existing Azure key vault secret URL.</p></summary>
        public virtual string SecretIdentifier { get; internal set; }
        /// <summary><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        public virtual string VaultName { get; internal set; }
        /// <summary><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        public virtual string VaultResourceGroup { get; internal set; }
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
              .Add("sf cluster certificate add")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--certificate-file {value}", CertificateFile)
              .Add("--certificate-output-folder {value}", CertificateOutputFolder)
              .Add("--certificate-password {value}", CertificatePassword, secret: true)
              .Add("--certificate-subject-name {value}", CertificateSubjectName)
              .Add("--secret-identifier {value}", SecretIdentifier, secret: true)
              .Add("--vault-name {value}", VaultName)
              .Add("--vault-resource-group {value}", VaultResourceGroup)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterCertificateRemoveSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterCertificateRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The cluster certificate thumbprint to be removed.</p></summary>
        public virtual string Thumbprint { get; internal set; }
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
              .Add("sf cluster certificate remove")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--thumbprint {value}", Thumbprint)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterClientCertificateAddSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterClientCertificateAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Client certificate thumbprint that only has admin permission.</p></summary>
        public virtual string AdminClientThumbprints { get; internal set; }
        /// <summary><p>Client certificate common name.</p></summary>
        public virtual string CertificateCommonName { get; internal set; }
        /// <summary><p>Client certificate issuer thumbprint.</p></summary>
        public virtual string CertificateIssuerThumbprint { get; internal set; }
        /// <summary><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"isAdmin":true, "certificateCommonName": "test.com", "certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].</p></summary>
        public virtual string ClientCertificateCommonNames { get; internal set; }
        /// <summary><p>Client authentication type.</p></summary>
        public virtual string IsAdmin { get; internal set; }
        /// <summary><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        public virtual IReadOnlyList<string> ReadonlyClientThumbprints => ReadonlyClientThumbprintsInternal.AsReadOnly();
        internal List<string> ReadonlyClientThumbprintsInternal { get; set; } = new List<string>();
        /// <summary><p>Client certificate thumbprint.</p></summary>
        public virtual string Thumbprint { get; internal set; }
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
              .Add("sf cluster client-certificate add")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin-client-thumbprints {value}", AdminClientThumbprints)
              .Add("--certificate-common-name {value}", CertificateCommonName)
              .Add("--certificate-issuer-thumbprint {value}", CertificateIssuerThumbprint)
              .Add("--client-certificate-common-names {value}", ClientCertificateCommonNames)
              .Add("--is-admin {value}", IsAdmin)
              .Add("--readonly-client-thumbprints {value}", ReadonlyClientThumbprints, separator: ' ')
              .Add("--thumbprint {value}", Thumbprint)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterClientCertificateRemoveSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterClientCertificateRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Client certificate common name.</p></summary>
        public virtual string CertificateCommonName { get; internal set; }
        /// <summary><p>Client certificate issuer thumbprint.</p></summary>
        public virtual string CertificateIssuerThumbprint { get; internal set; }
        /// <summary><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"certificateCommonName": "test.com","certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].</p></summary>
        public virtual string ClientCertificateCommonNames { get; internal set; }
        /// <summary><p>A single or Space-separated list of client certificate thumbprint(s) to be remove.</p></summary>
        public virtual string Thumbprints { get; internal set; }
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
              .Add("sf cluster client-certificate remove")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--certificate-common-name {value}", CertificateCommonName)
              .Add("--certificate-issuer-thumbprint {value}", CertificateIssuerThumbprint)
              .Add("--client-certificate-common-names {value}", ClientCertificateCommonNames)
              .Add("--thumbprints {value}", Thumbprints)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterDurabilityUpdateSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterDurabilityUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>Durability level.</p></summary>
        public virtual SfClusterDurabilityUpdateDurabilityLevel DurabilityLevel { get; internal set; }
        /// <summary><p>The Node type name.</p></summary>
        public virtual string NodeType { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
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
              .Add("sf cluster durability update")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--durability-level {value}", DurabilityLevel)
              .Add("--node-type {value}", NodeType)
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
    #region AzureSfClusterNodeTypeAddSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterNodeTypeAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p></p></summary>
        public virtual string Capacity { get; internal set; }
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The Node type name.</p></summary>
        public virtual string NodeType { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The password of the Vm.</p></summary>
        public virtual string VmPassword { get; internal set; }
        /// <summary><p>The user name for logging to Vm. Default will be adminuser.</p></summary>
        public virtual string VmUserName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string DurabilityLevel { get; internal set; }
        /// <summary><p>The Vm Sku.</p></summary>
        public virtual string VmSku { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string VmTier { get; internal set; }
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
              .Add("sf cluster node-type add")
              .Add("--capacity {value}", Capacity)
              .Add("--cluster-name {value}", ClusterName)
              .Add("--node-type {value}", NodeType)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--vm-password {value}", VmPassword, secret: true)
              .Add("--vm-user-name {value}", VmUserName)
              .Add("--durability-level {value}", DurabilityLevel)
              .Add("--vm-sku {value}", VmSku)
              .Add("--vm-tier {value}", VmTier)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterNodeAddSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterNodeAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The Node type name.</p></summary>
        public virtual string NodeType { get; internal set; }
        /// <summary><p>Number of nodes to add.</p></summary>
        public virtual int? NumberOfNodesToAdd { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
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
              .Add("sf cluster node add")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--node-type {value}", NodeType)
              .Add("--number-of-nodes-to-add {value}", NumberOfNodesToAdd)
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
    #region AzureSfClusterNodeRemoveSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterNodeRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The Node type name.</p></summary>
        public virtual string NodeType { get; internal set; }
        /// <summary><p>Number of nodes to remove.</p></summary>
        public virtual int? NumberOfNodesToRemove { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
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
              .Add("sf cluster node remove")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--node-type {value}", NodeType)
              .Add("--number-of-nodes-to-remove {value}", NumberOfNodesToRemove)
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
    #region AzureSfClusterReliabilityUpdateSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterReliabilityUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>Durability level.</p></summary>
        public virtual SfClusterDurabilityUpdateDurabilityLevel ReliabilityLevel { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add node count automatically when changing reliability.</p></summary>
        public virtual string AutoAddNode { get; internal set; }
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
              .Add("sf cluster reliability update")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--reliability-level {value}", ReliabilityLevel)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--auto-add-node {value}", AutoAddNode)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterSettingRemoveSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterSettingRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Parameter name.</p></summary>
        public virtual string Parameter { get; internal set; }
        /// <summary><p>Section name.</p></summary>
        public virtual string Section { get; internal set; }
        /// <summary><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout"}].</p></summary>
        public virtual string SettingsSectionDescription { get; internal set; }
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
              .Add("sf cluster setting remove")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--parameter {value}", Parameter)
              .Add("--section {value}", Section)
              .Add("--settings-section-description {value}", SettingsSectionDescription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfClusterSettingSetSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterSettingSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Parameter name.</p></summary>
        public virtual string Parameter { get; internal set; }
        /// <summary><p>Section name.</p></summary>
        public virtual string Section { get; internal set; }
        /// <summary><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout","value": 1000},{"section": "MaxFileOperationTimeout","parameter": "Max2","value": 1000].</p></summary>
        public virtual string SettingsSectionDescription { get; internal set; }
        /// <summary><p>Specify the value.</p></summary>
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
              .Add("sf cluster setting set")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--parameter {value}", Parameter)
              .Add("--section {value}", Section)
              .Add("--settings-section-description {value}", SettingsSectionDescription)
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
    #region AzureSfClusterUpgradeTypeSetSettings
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSfClusterUpgradeTypeSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureSf executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureSfTasks.AzureSfPath;
        /// <summary><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        public virtual string ClusterName { get; internal set; }
        /// <summary><p>The resource group name.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Cluster upgrade mode.</p></summary>
        public virtual SfClusterUpgradeTypeSetUpgradeMode UpgradeMode { get; internal set; }
        /// <summary><p>Cluster code version.</p></summary>
        public virtual string Version { get; internal set; }
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
              .Add("sf cluster upgrade-type set")
              .Add("--cluster-name {value}", ClusterName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--upgrade-mode {value}", UpgradeMode)
              .Add("--version {value}", Version)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSfSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfSettings SetDebug(this AzureSfSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfSettings ResetDebug(this AzureSfSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfSettings SetHelp(this AzureSfSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfSettings ResetHelp(this AzureSfSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfSettings SetOutput(this AzureSfSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfSettings ResetOutput(this AzureSfSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfSettings SetQuery(this AzureSfSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfSettings ResetQuery(this AzureSfSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfSettings SetVerbose(this AzureSfSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfSettings ResetVerbose(this AzureSfSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfApplicationSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfApplicationSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfApplicationSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings SetDebug(this AzureSfApplicationSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings ResetDebug(this AzureSfApplicationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfApplicationSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings SetHelp(this AzureSfApplicationSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings ResetHelp(this AzureSfApplicationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfApplicationSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings SetOutput(this AzureSfApplicationSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings ResetOutput(this AzureSfApplicationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfApplicationSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings SetQuery(this AzureSfApplicationSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings ResetQuery(this AzureSfApplicationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfApplicationSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings SetVerbose(this AzureSfApplicationSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationSettings ResetVerbose(this AzureSfApplicationSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterCreateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetLocation(this AzureSfClusterCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetLocation(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetResourceGroup(this AzureSfClusterCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetResourceGroup(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CertificateFile
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.CertificateFile"/>.</em></p><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetCertificateFile(this AzureSfClusterCreateSettings toolSettings, string certificateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = certificateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.CertificateFile"/>.</em></p><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetCertificateFile(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = null;
            return toolSettings;
        }
        #endregion
        #region CertificateOutputFolder
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.CertificateOutputFolder"/>.</em></p><p>The folder of the new certificate file to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetCertificateOutputFolder(this AzureSfClusterCreateSettings toolSettings, string certificateOutputFolder)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateOutputFolder = certificateOutputFolder;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.CertificateOutputFolder"/>.</em></p><p>The folder of the new certificate file to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetCertificateOutputFolder(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateOutputFolder = null;
            return toolSettings;
        }
        #endregion
        #region CertificatePassword
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.CertificatePassword"/>.</em></p><p>The password of the certificate file.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetCertificatePassword(this AzureSfClusterCreateSettings toolSettings, string certificatePassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = certificatePassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.CertificatePassword"/>.</em></p><p>The password of the certificate file.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetCertificatePassword(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = null;
            return toolSettings;
        }
        #endregion
        #region CertificateSubjectName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.CertificateSubjectName"/>.</em></p><p>The subject name of the certificate to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetCertificateSubjectName(this AzureSfClusterCreateSettings toolSettings, string certificateSubjectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateSubjectName = certificateSubjectName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.CertificateSubjectName"/>.</em></p><p>The subject name of the certificate to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetCertificateSubjectName(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateSubjectName = null;
            return toolSettings;
        }
        #endregion
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetClusterName(this AzureSfClusterCreateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetClusterName(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ClusterSize
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.ClusterSize"/>.</em></p><p>The number of nodes in the cluster. Default are 5 nodes.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetClusterSize(this AzureSfClusterCreateSettings toolSettings, string clusterSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterSize = clusterSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.ClusterSize"/>.</em></p><p>The number of nodes in the cluster. Default are 5 nodes.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetClusterSize(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterSize = null;
            return toolSettings;
        }
        #endregion
        #region Os
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Os"/>.</em></p><p>The Operating System of the VMs that make up the cluster.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetOs(this AzureSfClusterCreateSettings toolSettings, SfClusterCreateOs os)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = os;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Os"/>.</em></p><p>The Operating System of the VMs that make up the cluster.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetOs(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Os = null;
            return toolSettings;
        }
        #endregion
        #region ParameterFile
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.ParameterFile"/>.</em></p><p>The path to the template parameter file.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetParameterFile(this AzureSfClusterCreateSettings toolSettings, string parameterFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ParameterFile = parameterFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.ParameterFile"/>.</em></p><p>The path to the template parameter file.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetParameterFile(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ParameterFile = null;
            return toolSettings;
        }
        #endregion
        #region SecretIdentifier
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.SecretIdentifier"/>.</em></p><p>The existing Azure key vault secret URL.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetSecretIdentifier(this AzureSfClusterCreateSettings toolSettings, string secretIdentifier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretIdentifier = secretIdentifier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.SecretIdentifier"/>.</em></p><p>The existing Azure key vault secret URL.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetSecretIdentifier(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretIdentifier = null;
            return toolSettings;
        }
        #endregion
        #region TemplateFile
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.TemplateFile"/>.</em></p><p>The path to the template file.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetTemplateFile(this AzureSfClusterCreateSettings toolSettings, string templateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = templateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.TemplateFile"/>.</em></p><p>The path to the template file.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetTemplateFile(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.VaultName"/>.</em></p><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetVaultName(this AzureSfClusterCreateSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.VaultName"/>.</em></p><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetVaultName(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region VaultResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.VaultResourceGroup"/>.</em></p><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetVaultResourceGroup(this AzureSfClusterCreateSettings toolSettings, string vaultResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultResourceGroup = vaultResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.VaultResourceGroup"/>.</em></p><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetVaultResourceGroup(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmPassword
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.VmPassword"/>.</em></p><p>The password of the Vm.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetVmPassword(this AzureSfClusterCreateSettings toolSettings, string vmPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPassword = vmPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.VmPassword"/>.</em></p><p>The password of the Vm.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetVmPassword(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPassword = null;
            return toolSettings;
        }
        #endregion
        #region VmSku
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.VmSku"/>.</em></p><p>The Vm Sku.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetVmSku(this AzureSfClusterCreateSettings toolSettings, string vmSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSku = vmSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.VmSku"/>.</em></p><p>The Vm Sku.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetVmSku(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSku = null;
            return toolSettings;
        }
        #endregion
        #region VmUserName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.VmUserName"/>.</em></p><p>The user name for logging to Vm. Default will be adminuser.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetVmUserName(this AzureSfClusterCreateSettings toolSettings, string vmUserName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmUserName = vmUserName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.VmUserName"/>.</em></p><p>The user name for logging to Vm. Default will be adminuser.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetVmUserName(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmUserName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetDebug(this AzureSfClusterCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetDebug(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetHelp(this AzureSfClusterCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetHelp(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetOutput(this AzureSfClusterCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetOutput(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetQuery(this AzureSfClusterCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetQuery(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings SetVerbose(this AzureSfClusterCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCreateSettings ResetVerbose(this AzureSfClusterCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterListSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings SetResourceGroup(this AzureSfClusterListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterListSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings ResetResourceGroup(this AzureSfClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings SetDebug(this AzureSfClusterListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings ResetDebug(this AzureSfClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings SetHelp(this AzureSfClusterListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings ResetHelp(this AzureSfClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings SetOutput(this AzureSfClusterListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings ResetOutput(this AzureSfClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings SetQuery(this AzureSfClusterListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings ResetQuery(this AzureSfClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings SetVerbose(this AzureSfClusterListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterListSettings ResetVerbose(this AzureSfClusterListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterShowSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetClusterName(this AzureSfClusterShowSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetClusterName(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetResourceGroup(this AzureSfClusterShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetResourceGroup(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetDebug(this AzureSfClusterShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetDebug(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetHelp(this AzureSfClusterShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetHelp(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetOutput(this AzureSfClusterShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetOutput(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetQuery(this AzureSfClusterShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetQuery(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings SetVerbose(this AzureSfClusterShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterShowSettings ResetVerbose(this AzureSfClusterShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfApplicationCertificateAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfApplicationCertificateAddSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetClusterName(this AzureSfApplicationCertificateAddSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetClusterName(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetResourceGroup(this AzureSfApplicationCertificateAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetResourceGroup(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CertificateFile
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.CertificateFile"/>.</em></p><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetCertificateFile(this AzureSfApplicationCertificateAddSettings toolSettings, string certificateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = certificateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.CertificateFile"/>.</em></p><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetCertificateFile(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = null;
            return toolSettings;
        }
        #endregion
        #region CertificateOutputFolder
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.CertificateOutputFolder"/>.</em></p><p>The folder of the new certificate file to be created.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetCertificateOutputFolder(this AzureSfApplicationCertificateAddSettings toolSettings, string certificateOutputFolder)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateOutputFolder = certificateOutputFolder;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.CertificateOutputFolder"/>.</em></p><p>The folder of the new certificate file to be created.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetCertificateOutputFolder(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateOutputFolder = null;
            return toolSettings;
        }
        #endregion
        #region CertificatePassword
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.CertificatePassword"/>.</em></p><p>The password of the certificate file.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetCertificatePassword(this AzureSfApplicationCertificateAddSettings toolSettings, string certificatePassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = certificatePassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.CertificatePassword"/>.</em></p><p>The password of the certificate file.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetCertificatePassword(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = null;
            return toolSettings;
        }
        #endregion
        #region CertificateSubjectName
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.CertificateSubjectName"/>.</em></p><p>The subject name of the certificate to be created.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetCertificateSubjectName(this AzureSfApplicationCertificateAddSettings toolSettings, string certificateSubjectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateSubjectName = certificateSubjectName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.CertificateSubjectName"/>.</em></p><p>The subject name of the certificate to be created.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetCertificateSubjectName(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateSubjectName = null;
            return toolSettings;
        }
        #endregion
        #region SecretIdentifier
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.SecretIdentifier"/>.</em></p><p>The existing Azure key vault secret URL.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetSecretIdentifier(this AzureSfApplicationCertificateAddSettings toolSettings, string secretIdentifier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretIdentifier = secretIdentifier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.SecretIdentifier"/>.</em></p><p>The existing Azure key vault secret URL.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetSecretIdentifier(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretIdentifier = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.VaultName"/>.</em></p><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetVaultName(this AzureSfApplicationCertificateAddSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.VaultName"/>.</em></p><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetVaultName(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region VaultResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.VaultResourceGroup"/>.</em></p><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetVaultResourceGroup(this AzureSfApplicationCertificateAddSettings toolSettings, string vaultResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultResourceGroup = vaultResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.VaultResourceGroup"/>.</em></p><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetVaultResourceGroup(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetDebug(this AzureSfApplicationCertificateAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetDebug(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetHelp(this AzureSfApplicationCertificateAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetHelp(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetOutput(this AzureSfApplicationCertificateAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetOutput(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetQuery(this AzureSfApplicationCertificateAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetQuery(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfApplicationCertificateAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings SetVerbose(this AzureSfApplicationCertificateAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfApplicationCertificateAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfApplicationCertificateAddSettings ResetVerbose(this AzureSfApplicationCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterCertificateAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterCertificateAddSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetClusterName(this AzureSfClusterCertificateAddSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetClusterName(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetResourceGroup(this AzureSfClusterCertificateAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetResourceGroup(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CertificateFile
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.CertificateFile"/>.</em></p><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetCertificateFile(this AzureSfClusterCertificateAddSettings toolSettings, string certificateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = certificateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.CertificateFile"/>.</em></p><p>The existing certificate file path for the primary cluster certificate.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetCertificateFile(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = null;
            return toolSettings;
        }
        #endregion
        #region CertificateOutputFolder
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.CertificateOutputFolder"/>.</em></p><p>The folder of the new certificate file to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetCertificateOutputFolder(this AzureSfClusterCertificateAddSettings toolSettings, string certificateOutputFolder)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateOutputFolder = certificateOutputFolder;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.CertificateOutputFolder"/>.</em></p><p>The folder of the new certificate file to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetCertificateOutputFolder(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateOutputFolder = null;
            return toolSettings;
        }
        #endregion
        #region CertificatePassword
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.CertificatePassword"/>.</em></p><p>The password of the certificate file.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetCertificatePassword(this AzureSfClusterCertificateAddSettings toolSettings, string certificatePassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = certificatePassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.CertificatePassword"/>.</em></p><p>The password of the certificate file.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetCertificatePassword(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = null;
            return toolSettings;
        }
        #endregion
        #region CertificateSubjectName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.CertificateSubjectName"/>.</em></p><p>The subject name of the certificate to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetCertificateSubjectName(this AzureSfClusterCertificateAddSettings toolSettings, string certificateSubjectName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateSubjectName = certificateSubjectName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.CertificateSubjectName"/>.</em></p><p>The subject name of the certificate to be created.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetCertificateSubjectName(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateSubjectName = null;
            return toolSettings;
        }
        #endregion
        #region SecretIdentifier
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.SecretIdentifier"/>.</em></p><p>The existing Azure key vault secret URL.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetSecretIdentifier(this AzureSfClusterCertificateAddSettings toolSettings, string secretIdentifier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretIdentifier = secretIdentifier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.SecretIdentifier"/>.</em></p><p>The existing Azure key vault secret URL.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetSecretIdentifier(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretIdentifier = null;
            return toolSettings;
        }
        #endregion
        #region VaultName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.VaultName"/>.</em></p><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetVaultName(this AzureSfClusterCertificateAddSettings toolSettings, string vaultName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = vaultName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.VaultName"/>.</em></p><p>Azure key vault name, it not given it will be the cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetVaultName(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultName = null;
            return toolSettings;
        }
        #endregion
        #region VaultResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.VaultResourceGroup"/>.</em></p><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetVaultResourceGroup(this AzureSfClusterCertificateAddSettings toolSettings, string vaultResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultResourceGroup = vaultResourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.VaultResourceGroup"/>.</em></p><p>Key vault resource group name,if not given it will be cluster resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetVaultResourceGroup(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VaultResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetDebug(this AzureSfClusterCertificateAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetDebug(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetHelp(this AzureSfClusterCertificateAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetHelp(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetOutput(this AzureSfClusterCertificateAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetOutput(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetQuery(this AzureSfClusterCertificateAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetQuery(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings SetVerbose(this AzureSfClusterCertificateAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateAddSettings ResetVerbose(this AzureSfClusterCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterCertificateRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterCertificateRemoveSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetClusterName(this AzureSfClusterCertificateRemoveSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetClusterName(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetResourceGroup(this AzureSfClusterCertificateRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetResourceGroup(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Thumbprint
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.Thumbprint"/>.</em></p><p>The cluster certificate thumbprint to be removed.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetThumbprint(this AzureSfClusterCertificateRemoveSettings toolSettings, string thumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Thumbprint = thumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.Thumbprint"/>.</em></p><p>The cluster certificate thumbprint to be removed.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetThumbprint(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Thumbprint = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetDebug(this AzureSfClusterCertificateRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetDebug(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetHelp(this AzureSfClusterCertificateRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetHelp(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetOutput(this AzureSfClusterCertificateRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetOutput(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetQuery(this AzureSfClusterCertificateRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetQuery(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterCertificateRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings SetVerbose(this AzureSfClusterCertificateRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterCertificateRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterCertificateRemoveSettings ResetVerbose(this AzureSfClusterCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterClientCertificateAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterClientCertificateAddSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetClusterName(this AzureSfClusterClientCertificateAddSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetClusterName(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetResourceGroup(this AzureSfClusterClientCertificateAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetResourceGroup(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AdminClientThumbprints
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.AdminClientThumbprints"/>.</em></p><p>Client certificate thumbprint that only has admin permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetAdminClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, string adminClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminClientThumbprints = adminClientThumbprints;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.AdminClientThumbprints"/>.</em></p><p>Client certificate thumbprint that only has admin permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetAdminClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminClientThumbprints = null;
            return toolSettings;
        }
        #endregion
        #region CertificateCommonName
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.CertificateCommonName"/>.</em></p><p>Client certificate common name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetCertificateCommonName(this AzureSfClusterClientCertificateAddSettings toolSettings, string certificateCommonName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateCommonName = certificateCommonName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.CertificateCommonName"/>.</em></p><p>Client certificate common name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetCertificateCommonName(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateCommonName = null;
            return toolSettings;
        }
        #endregion
        #region CertificateIssuerThumbprint
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.CertificateIssuerThumbprint"/>.</em></p><p>Client certificate issuer thumbprint.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetCertificateIssuerThumbprint(this AzureSfClusterClientCertificateAddSettings toolSettings, string certificateIssuerThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateIssuerThumbprint = certificateIssuerThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.CertificateIssuerThumbprint"/>.</em></p><p>Client certificate issuer thumbprint.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetCertificateIssuerThumbprint(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateIssuerThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region ClientCertificateCommonNames
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.ClientCertificateCommonNames"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"isAdmin":true, "certificateCommonName": "test.com", "certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetClientCertificateCommonNames(this AzureSfClusterClientCertificateAddSettings toolSettings, string clientCertificateCommonNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientCertificateCommonNames = clientCertificateCommonNames;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.ClientCertificateCommonNames"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"isAdmin":true, "certificateCommonName": "test.com", "certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetClientCertificateCommonNames(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientCertificateCommonNames = null;
            return toolSettings;
        }
        #endregion
        #region IsAdmin
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.IsAdmin"/>.</em></p><p>Client authentication type.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetIsAdmin(this AzureSfClusterClientCertificateAddSettings toolSettings, string isAdmin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsAdmin = isAdmin;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.IsAdmin"/>.</em></p><p>Client authentication type.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetIsAdmin(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsAdmin = null;
            return toolSettings;
        }
        #endregion
        #region ReadonlyClientThumbprints
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/> to a new list.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, params string[] readonlyClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadonlyClientThumbprintsInternal = readonlyClientThumbprints.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/> to a new list.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, IEnumerable<string> readonlyClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadonlyClientThumbprintsInternal = readonlyClientThumbprints.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/>.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings AddReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, params string[] readonlyClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadonlyClientThumbprintsInternal.AddRange(readonlyClientThumbprints);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/>.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings AddReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, IEnumerable<string> readonlyClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadonlyClientThumbprintsInternal.AddRange(readonlyClientThumbprints);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/>.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ClearReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReadonlyClientThumbprintsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/>.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings RemoveReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, params string[] readonlyClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(readonlyClientThumbprints);
            toolSettings.ReadonlyClientThumbprintsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureSfClusterClientCertificateAddSettings.ReadonlyClientThumbprints"/>.</em></p><p>Space-separated list of client certificate thumbprint that has read only permission.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings RemoveReadonlyClientThumbprints(this AzureSfClusterClientCertificateAddSettings toolSettings, IEnumerable<string> readonlyClientThumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(readonlyClientThumbprints);
            toolSettings.ReadonlyClientThumbprintsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Thumbprint
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.Thumbprint"/>.</em></p><p>Client certificate thumbprint.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetThumbprint(this AzureSfClusterClientCertificateAddSettings toolSettings, string thumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Thumbprint = thumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.Thumbprint"/>.</em></p><p>Client certificate thumbprint.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetThumbprint(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Thumbprint = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetDebug(this AzureSfClusterClientCertificateAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetDebug(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetHelp(this AzureSfClusterClientCertificateAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetHelp(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetOutput(this AzureSfClusterClientCertificateAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetOutput(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetQuery(this AzureSfClusterClientCertificateAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetQuery(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings SetVerbose(this AzureSfClusterClientCertificateAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateAddSettings ResetVerbose(this AzureSfClusterClientCertificateAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterClientCertificateRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterClientCertificateRemoveSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetClusterName(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetClusterName(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetResourceGroup(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetResourceGroup(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CertificateCommonName
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.CertificateCommonName"/>.</em></p><p>Client certificate common name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetCertificateCommonName(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string certificateCommonName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateCommonName = certificateCommonName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.CertificateCommonName"/>.</em></p><p>Client certificate common name.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetCertificateCommonName(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateCommonName = null;
            return toolSettings;
        }
        #endregion
        #region CertificateIssuerThumbprint
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.CertificateIssuerThumbprint"/>.</em></p><p>Client certificate issuer thumbprint.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetCertificateIssuerThumbprint(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string certificateIssuerThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateIssuerThumbprint = certificateIssuerThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.CertificateIssuerThumbprint"/>.</em></p><p>Client certificate issuer thumbprint.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetCertificateIssuerThumbprint(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateIssuerThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region ClientCertificateCommonNames
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.ClientCertificateCommonNames"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"certificateCommonName": "test.com","certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetClientCertificateCommonNames(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string clientCertificateCommonNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientCertificateCommonNames = clientCertificateCommonNames;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.ClientCertificateCommonNames"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"certificateCommonName": "test.com","certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetClientCertificateCommonNames(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientCertificateCommonNames = null;
            return toolSettings;
        }
        #endregion
        #region Thumbprints
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.Thumbprints"/>.</em></p><p>A single or Space-separated list of client certificate thumbprint(s) to be remove.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetThumbprints(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string thumbprints)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Thumbprints = thumbprints;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.Thumbprints"/>.</em></p><p>A single or Space-separated list of client certificate thumbprint(s) to be remove.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetThumbprints(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Thumbprints = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetDebug(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetDebug(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetHelp(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetHelp(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetOutput(this AzureSfClusterClientCertificateRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetOutput(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetQuery(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetQuery(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterClientCertificateRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings SetVerbose(this AzureSfClusterClientCertificateRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterClientCertificateRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterClientCertificateRemoveSettings ResetVerbose(this AzureSfClusterClientCertificateRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterDurabilityUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterDurabilityUpdateSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetClusterName(this AzureSfClusterDurabilityUpdateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetClusterName(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region DurabilityLevel
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.DurabilityLevel"/>.</em></p><p>Durability level.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetDurabilityLevel(this AzureSfClusterDurabilityUpdateSettings toolSettings, SfClusterDurabilityUpdateDurabilityLevel durabilityLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurabilityLevel = durabilityLevel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.DurabilityLevel"/>.</em></p><p>Durability level.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetDurabilityLevel(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurabilityLevel = null;
            return toolSettings;
        }
        #endregion
        #region NodeType
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetNodeType(this AzureSfClusterDurabilityUpdateSettings toolSettings, string nodeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = nodeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetNodeType(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetResourceGroup(this AzureSfClusterDurabilityUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetResourceGroup(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetDebug(this AzureSfClusterDurabilityUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetDebug(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetHelp(this AzureSfClusterDurabilityUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetHelp(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetOutput(this AzureSfClusterDurabilityUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetOutput(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetQuery(this AzureSfClusterDurabilityUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetQuery(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterDurabilityUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings SetVerbose(this AzureSfClusterDurabilityUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterDurabilityUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterDurabilityUpdateSettings ResetVerbose(this AzureSfClusterDurabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterNodeTypeAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterNodeTypeAddSettingsExtensions
    {
        #region Capacity
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.Capacity"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetCapacity(this AzureSfClusterNodeTypeAddSettings toolSettings, string capacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = capacity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.Capacity"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetCapacity(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capacity = null;
            return toolSettings;
        }
        #endregion
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetClusterName(this AzureSfClusterNodeTypeAddSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetClusterName(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region NodeType
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetNodeType(this AzureSfClusterNodeTypeAddSettings toolSettings, string nodeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = nodeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetNodeType(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetResourceGroup(this AzureSfClusterNodeTypeAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetResourceGroup(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VmPassword
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.VmPassword"/>.</em></p><p>The password of the Vm.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetVmPassword(this AzureSfClusterNodeTypeAddSettings toolSettings, string vmPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPassword = vmPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.VmPassword"/>.</em></p><p>The password of the Vm.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetVmPassword(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmPassword = null;
            return toolSettings;
        }
        #endregion
        #region VmUserName
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.VmUserName"/>.</em></p><p>The user name for logging to Vm. Default will be adminuser.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetVmUserName(this AzureSfClusterNodeTypeAddSettings toolSettings, string vmUserName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmUserName = vmUserName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.VmUserName"/>.</em></p><p>The user name for logging to Vm. Default will be adminuser.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetVmUserName(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmUserName = null;
            return toolSettings;
        }
        #endregion
        #region DurabilityLevel
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.DurabilityLevel"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetDurabilityLevel(this AzureSfClusterNodeTypeAddSettings toolSettings, string durabilityLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurabilityLevel = durabilityLevel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.DurabilityLevel"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetDurabilityLevel(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DurabilityLevel = null;
            return toolSettings;
        }
        #endregion
        #region VmSku
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.VmSku"/>.</em></p><p>The Vm Sku.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetVmSku(this AzureSfClusterNodeTypeAddSettings toolSettings, string vmSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSku = vmSku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.VmSku"/>.</em></p><p>The Vm Sku.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetVmSku(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSku = null;
            return toolSettings;
        }
        #endregion
        #region VmTier
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.VmTier"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetVmTier(this AzureSfClusterNodeTypeAddSettings toolSettings, string vmTier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmTier = vmTier;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.VmTier"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetVmTier(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmTier = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetDebug(this AzureSfClusterNodeTypeAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetDebug(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetHelp(this AzureSfClusterNodeTypeAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetHelp(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetOutput(this AzureSfClusterNodeTypeAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetOutput(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetQuery(this AzureSfClusterNodeTypeAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetQuery(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeTypeAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings SetVerbose(this AzureSfClusterNodeTypeAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeTypeAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeTypeAddSettings ResetVerbose(this AzureSfClusterNodeTypeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterNodeAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterNodeAddSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetClusterName(this AzureSfClusterNodeAddSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetClusterName(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region NodeType
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetNodeType(this AzureSfClusterNodeAddSettings toolSettings, string nodeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = nodeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetNodeType(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = null;
            return toolSettings;
        }
        #endregion
        #region NumberOfNodesToAdd
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.NumberOfNodesToAdd"/>.</em></p><p>Number of nodes to add.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetNumberOfNodesToAdd(this AzureSfClusterNodeAddSettings toolSettings, int? numberOfNodesToAdd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfNodesToAdd = numberOfNodesToAdd;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.NumberOfNodesToAdd"/>.</em></p><p>Number of nodes to add.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetNumberOfNodesToAdd(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfNodesToAdd = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetResourceGroup(this AzureSfClusterNodeAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetResourceGroup(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetDebug(this AzureSfClusterNodeAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetDebug(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetHelp(this AzureSfClusterNodeAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetHelp(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetOutput(this AzureSfClusterNodeAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetOutput(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetQuery(this AzureSfClusterNodeAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetQuery(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings SetVerbose(this AzureSfClusterNodeAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeAddSettings ResetVerbose(this AzureSfClusterNodeAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterNodeRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterNodeRemoveSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetClusterName(this AzureSfClusterNodeRemoveSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetClusterName(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region NodeType
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetNodeType(this AzureSfClusterNodeRemoveSettings toolSettings, string nodeType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = nodeType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.NodeType"/>.</em></p><p>The Node type name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetNodeType(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeType = null;
            return toolSettings;
        }
        #endregion
        #region NumberOfNodesToRemove
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.NumberOfNodesToRemove"/>.</em></p><p>Number of nodes to remove.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetNumberOfNodesToRemove(this AzureSfClusterNodeRemoveSettings toolSettings, int? numberOfNodesToRemove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfNodesToRemove = numberOfNodesToRemove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.NumberOfNodesToRemove"/>.</em></p><p>Number of nodes to remove.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetNumberOfNodesToRemove(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfNodesToRemove = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetResourceGroup(this AzureSfClusterNodeRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetResourceGroup(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetDebug(this AzureSfClusterNodeRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetDebug(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetHelp(this AzureSfClusterNodeRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetHelp(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetOutput(this AzureSfClusterNodeRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetOutput(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetQuery(this AzureSfClusterNodeRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetQuery(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterNodeRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings SetVerbose(this AzureSfClusterNodeRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterNodeRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterNodeRemoveSettings ResetVerbose(this AzureSfClusterNodeRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterReliabilityUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterReliabilityUpdateSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetClusterName(this AzureSfClusterReliabilityUpdateSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetClusterName(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ReliabilityLevel
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.ReliabilityLevel"/>.</em></p><p>Durability level.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetReliabilityLevel(this AzureSfClusterReliabilityUpdateSettings toolSettings, SfClusterDurabilityUpdateDurabilityLevel reliabilityLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReliabilityLevel = reliabilityLevel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.ReliabilityLevel"/>.</em></p><p>Durability level.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetReliabilityLevel(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReliabilityLevel = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetResourceGroup(this AzureSfClusterReliabilityUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetResourceGroup(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AutoAddNode
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.AutoAddNode"/>.</em></p><p>Add node count automatically when changing reliability.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetAutoAddNode(this AzureSfClusterReliabilityUpdateSettings toolSettings, string autoAddNode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoAddNode = autoAddNode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.AutoAddNode"/>.</em></p><p>Add node count automatically when changing reliability.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetAutoAddNode(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoAddNode = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetDebug(this AzureSfClusterReliabilityUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetDebug(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetHelp(this AzureSfClusterReliabilityUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetHelp(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetOutput(this AzureSfClusterReliabilityUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetOutput(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetQuery(this AzureSfClusterReliabilityUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetQuery(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterReliabilityUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings SetVerbose(this AzureSfClusterReliabilityUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterReliabilityUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterReliabilityUpdateSettings ResetVerbose(this AzureSfClusterReliabilityUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterSettingRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterSettingRemoveSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetClusterName(this AzureSfClusterSettingRemoveSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetClusterName(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetResourceGroup(this AzureSfClusterSettingRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetResourceGroup(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Parameter
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Parameter"/>.</em></p><p>Parameter name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetParameter(this AzureSfClusterSettingRemoveSettings toolSettings, string parameter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameter = parameter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Parameter"/>.</em></p><p>Parameter name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetParameter(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameter = null;
            return toolSettings;
        }
        #endregion
        #region Section
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Section"/>.</em></p><p>Section name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetSection(this AzureSfClusterSettingRemoveSettings toolSettings, string section)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Section = section;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Section"/>.</em></p><p>Section name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetSection(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Section = null;
            return toolSettings;
        }
        #endregion
        #region SettingsSectionDescription
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.SettingsSectionDescription"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout"}].</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetSettingsSectionDescription(this AzureSfClusterSettingRemoveSettings toolSettings, string settingsSectionDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsSectionDescription = settingsSectionDescription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.SettingsSectionDescription"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout"}].</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetSettingsSectionDescription(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsSectionDescription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetDebug(this AzureSfClusterSettingRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetDebug(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetHelp(this AzureSfClusterSettingRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetHelp(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetOutput(this AzureSfClusterSettingRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetOutput(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetQuery(this AzureSfClusterSettingRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetQuery(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings SetVerbose(this AzureSfClusterSettingRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingRemoveSettings ResetVerbose(this AzureSfClusterSettingRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterSettingSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterSettingSetSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetClusterName(this AzureSfClusterSettingSetSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetClusterName(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetResourceGroup(this AzureSfClusterSettingSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetResourceGroup(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Parameter
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Parameter"/>.</em></p><p>Parameter name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetParameter(this AzureSfClusterSettingSetSettings toolSettings, string parameter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameter = parameter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Parameter"/>.</em></p><p>Parameter name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetParameter(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameter = null;
            return toolSettings;
        }
        #endregion
        #region Section
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Section"/>.</em></p><p>Section name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetSection(this AzureSfClusterSettingSetSettings toolSettings, string section)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Section = section;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Section"/>.</em></p><p>Section name.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetSection(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Section = null;
            return toolSettings;
        }
        #endregion
        #region SettingsSectionDescription
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.SettingsSectionDescription"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout","value": 1000},{"section": "MaxFileOperationTimeout","parameter": "Max2","value": 1000].</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetSettingsSectionDescription(this AzureSfClusterSettingSetSettings toolSettings, string settingsSectionDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsSectionDescription = settingsSectionDescription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.SettingsSectionDescription"/>.</em></p><p>JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"section": "NamingService","parameter": "MaxOperationTimeout","value": 1000},{"section": "MaxFileOperationTimeout","parameter": "Max2","value": 1000].</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetSettingsSectionDescription(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsSectionDescription = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Value"/>.</em></p><p>Specify the value.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetValue(this AzureSfClusterSettingSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Value"/>.</em></p><p>Specify the value.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetValue(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetDebug(this AzureSfClusterSettingSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetDebug(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetHelp(this AzureSfClusterSettingSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetHelp(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetOutput(this AzureSfClusterSettingSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetOutput(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetQuery(this AzureSfClusterSettingSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetQuery(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterSettingSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings SetVerbose(this AzureSfClusterSettingSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterSettingSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterSettingSetSettings ResetVerbose(this AzureSfClusterSettingSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSfClusterUpgradeTypeSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSfClusterUpgradeTypeSetSettingsExtensions
    {
        #region ClusterName
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetClusterName(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string clusterName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = clusterName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.ClusterName"/>.</em></p><p>Specify the name of the cluster, if not given it will be same as resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetClusterName(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClusterName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetResourceGroup(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.ResourceGroup"/>.</em></p><p>The resource group name.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetResourceGroup(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region UpgradeMode
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.UpgradeMode"/>.</em></p><p>Cluster upgrade mode.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetUpgradeMode(this AzureSfClusterUpgradeTypeSetSettings toolSettings, SfClusterUpgradeTypeSetUpgradeMode upgradeMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpgradeMode = upgradeMode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.UpgradeMode"/>.</em></p><p>Cluster upgrade mode.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetUpgradeMode(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpgradeMode = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.Version"/>.</em></p><p>Cluster code version.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetVersion(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.Version"/>.</em></p><p>Cluster code version.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetVersion(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetDebug(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetDebug(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetHelp(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetHelp(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetOutput(this AzureSfClusterUpgradeTypeSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetOutput(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetQuery(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetQuery(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureSfClusterUpgradeTypeSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings SetVerbose(this AzureSfClusterUpgradeTypeSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureSfClusterUpgradeTypeSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureSfClusterUpgradeTypeSetSettings ResetVerbose(this AzureSfClusterUpgradeTypeSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region SfClusterCreateOs
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class SfClusterCreateOs : Enumeration
    {
        public static SfClusterCreateOs ubuntuserver1604 = new SfClusterCreateOs { Value = "ubuntuserver1604" };
        public static SfClusterCreateOs windowsserver2012r2datacenter = new SfClusterCreateOs { Value = "windowsserver2012r2datacenter" };
        public static SfClusterCreateOs windowsserver2016datacenter = new SfClusterCreateOs { Value = "windowsserver2016datacenter" };
        public static SfClusterCreateOs windowsserver2016datacenterwithcontainers = new SfClusterCreateOs { Value = "windowsserver2016datacenterwithcontainers" };
    }
    #endregion
    #region SfClusterDurabilityUpdateDurabilityLevel
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class SfClusterDurabilityUpdateDurabilityLevel : Enumeration
    {
        public static SfClusterDurabilityUpdateDurabilityLevel bronze = new SfClusterDurabilityUpdateDurabilityLevel { Value = "bronze" };
        public static SfClusterDurabilityUpdateDurabilityLevel gold = new SfClusterDurabilityUpdateDurabilityLevel { Value = "gold" };
        public static SfClusterDurabilityUpdateDurabilityLevel silver = new SfClusterDurabilityUpdateDurabilityLevel { Value = "silver" };
    }
    #endregion
    #region SfClusterUpgradeTypeSetUpgradeMode
    /// <summary><p>Used within <see cref="AzureSfTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class SfClusterUpgradeTypeSetUpgradeMode : Enumeration
    {
        public static SfClusterUpgradeTypeSetUpgradeMode automatic = new SfClusterUpgradeTypeSetUpgradeMode { Value = "automatic" };
        public static SfClusterUpgradeTypeSetUpgradeMode manual = new SfClusterUpgradeTypeSetUpgradeMode { Value = "manual" };
    }
    #endregion
}
