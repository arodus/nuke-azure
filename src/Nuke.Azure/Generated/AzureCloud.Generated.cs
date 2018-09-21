// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCloud.json.

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
    public static partial class AzureCloudTasks
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public static string AzureCloudPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage registered Azure clouds.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloud(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureCloudPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudList(Configure<AzureCloudListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudListProfiles(Configure<AzureCloudListProfilesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudListProfilesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudRegister(Configure<AzureCloudRegisterSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudRegisterSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudSet(Configure<AzureCloudSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudShow(Configure<AzureCloudShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudUnregister(Configure<AzureCloudUnregisterSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudUnregisterSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage registered Azure clouds.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cloud?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureCloudUpdate(Configure<AzureCloudUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCloudUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureCloudListSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
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
              .Add("cloud list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCloudListProfilesSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudListProfilesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
        /// <summary><p>Name of a registered cloud.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Show all available profiles supported in the CLI.</p></summary>
        public virtual string ShowAll { get; internal set; }
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
              .Add("cloud list-profiles")
              .Add("--name {value}", Name)
              .Add("--show-all {value}", ShowAll)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCloudRegisterSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudRegisterSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
        /// <summary><p>Name of a registered cloud.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>JSON encoded cloud configuration. Use @{file} to load from a file.</p></summary>
        public virtual string CloudConfig { get; internal set; }
        /// <summary><p>The Active Directory login endpoint.</p></summary>
        public virtual string EndpointActiveDirectory { get; internal set; }
        /// <summary><p>The Active Directory resource ID for data lake services.</p></summary>
        public virtual string EndpointActiveDirectoryDataLakeResourceId { get; internal set; }
        /// <summary><p>The Active Directory resource ID.</p></summary>
        public virtual string EndpointActiveDirectoryGraphResourceId { get; internal set; }
        /// <summary><p>The resource ID to obtain AD tokens for.</p></summary>
        public virtual string EndpointActiveDirectoryResourceId { get; internal set; }
        /// <summary><p>The template gallery endpoint.</p></summary>
        public virtual string EndpointGallery { get; internal set; }
        /// <summary><p>The management service endpoint.</p></summary>
        public virtual string EndpointManagement { get; internal set; }
        /// <summary><p>The resource management endpoint.</p></summary>
        public virtual string EndpointResourceManager { get; internal set; }
        /// <summary><p>The sql server management endpoint.</p></summary>
        public virtual string EndpointSqlManagement { get; internal set; }
        /// <summary><p>The uri of the document which caches commonly used virtual machine images.</p></summary>
        public virtual string EndpointVmImageAliasDoc { get; internal set; }
        /// <summary><p>Profile to use for this cloud.</p></summary>
        public virtual CloudProfile Profile { get; internal set; }
        /// <summary><p>The Azure Container Registry login server suffix.</p></summary>
        public virtual string SuffixAcrLoginServerEndpoint { get; internal set; }
        /// <summary><p>The Data Lake analytics job and catalog service dns suffix.</p></summary>
        public virtual string SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint { get; internal set; }
        /// <summary><p>The Data Lake store filesystem service dns suffix.</p></summary>
        public virtual string SuffixAzureDatalakeStoreFileSystemEndpoint { get; internal set; }
        /// <summary><p>The Key Vault service dns suffix.</p></summary>
        public virtual string SuffixKeyvaultDns { get; internal set; }
        /// <summary><p>The dns suffix for sql servers.</p></summary>
        public virtual string SuffixSqlServerHostname { get; internal set; }
        /// <summary><p>The endpoint suffix for storage accounts.</p></summary>
        public virtual string SuffixStorageEndpoint { get; internal set; }
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
              .Add("cloud register")
              .Add("--name {value}", Name)
              .Add("--cloud-config {value}", CloudConfig)
              .Add("--endpoint-active-directory {value}", EndpointActiveDirectory)
              .Add("--endpoint-active-directory-data-lake-resource-id {value}", EndpointActiveDirectoryDataLakeResourceId)
              .Add("--endpoint-active-directory-graph-resource-id {value}", EndpointActiveDirectoryGraphResourceId)
              .Add("--endpoint-active-directory-resource-id {value}", EndpointActiveDirectoryResourceId)
              .Add("--endpoint-gallery {value}", EndpointGallery)
              .Add("--endpoint-management {value}", EndpointManagement)
              .Add("--endpoint-resource-manager {value}", EndpointResourceManager)
              .Add("--endpoint-sql-management {value}", EndpointSqlManagement)
              .Add("--endpoint-vm-image-alias-doc {value}", EndpointVmImageAliasDoc)
              .Add("--profile {value}", Profile)
              .Add("--suffix-acr-login-server-endpoint {value}", SuffixAcrLoginServerEndpoint)
              .Add("--suffix-azure-datalake-analytics-catalog-and-job-endpoint {value}", SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint)
              .Add("--suffix-azure-datalake-store-file-system-endpoint {value}", SuffixAzureDatalakeStoreFileSystemEndpoint)
              .Add("--suffix-keyvault-dns {value}", SuffixKeyvaultDns)
              .Add("--suffix-sql-server-hostname {value}", SuffixSqlServerHostname)
              .Add("--suffix-storage-endpoint {value}", SuffixStorageEndpoint)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCloudSetSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
        /// <summary><p>Name of a registered cloud.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Profile to use for this cloud.</p></summary>
        public virtual CloudProfile Profile { get; internal set; }
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
              .Add("cloud set")
              .Add("--name {value}", Name)
              .Add("--profile {value}", Profile)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCloudShowSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
        /// <summary><p>Name of a registered cloud.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("cloud show")
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
    #region AzureCloudUnregisterSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudUnregisterSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
        /// <summary><p>Name of a registered cloud.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("cloud unregister")
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
    #region AzureCloudUpdateSettings
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCloudUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCloud executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCloudTasks.AzureCloudPath;
        /// <summary><p>JSON encoded cloud configuration. Use @{file} to load from a file.</p></summary>
        public virtual string CloudConfig { get; internal set; }
        /// <summary><p>The Active Directory login endpoint.</p></summary>
        public virtual string EndpointActiveDirectory { get; internal set; }
        /// <summary><p>The Active Directory resource ID for data lake services.</p></summary>
        public virtual string EndpointActiveDirectoryDataLakeResourceId { get; internal set; }
        /// <summary><p>The Active Directory resource ID.</p></summary>
        public virtual string EndpointActiveDirectoryGraphResourceId { get; internal set; }
        /// <summary><p>The resource ID to obtain AD tokens for.</p></summary>
        public virtual string EndpointActiveDirectoryResourceId { get; internal set; }
        /// <summary><p>The template gallery endpoint.</p></summary>
        public virtual string EndpointGallery { get; internal set; }
        /// <summary><p>The management service endpoint.</p></summary>
        public virtual string EndpointManagement { get; internal set; }
        /// <summary><p>The resource management endpoint.</p></summary>
        public virtual string EndpointResourceManager { get; internal set; }
        /// <summary><p>The sql server management endpoint.</p></summary>
        public virtual string EndpointSqlManagement { get; internal set; }
        /// <summary><p>The uri of the document which caches commonly used virtual machine images.</p></summary>
        public virtual string EndpointVmImageAliasDoc { get; internal set; }
        /// <summary><p>Name of a registered cloud.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Profile to use for this cloud.</p></summary>
        public virtual CloudProfile Profile { get; internal set; }
        /// <summary><p>The Azure Container Registry login server suffix.</p></summary>
        public virtual string SuffixAcrLoginServerEndpoint { get; internal set; }
        /// <summary><p>The Data Lake analytics job and catalog service dns suffix.</p></summary>
        public virtual string SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint { get; internal set; }
        /// <summary><p>The Data Lake store filesystem service dns suffix.</p></summary>
        public virtual string SuffixAzureDatalakeStoreFileSystemEndpoint { get; internal set; }
        /// <summary><p>The Key Vault service dns suffix.</p></summary>
        public virtual string SuffixKeyvaultDns { get; internal set; }
        /// <summary><p>The dns suffix for sql servers.</p></summary>
        public virtual string SuffixSqlServerHostname { get; internal set; }
        /// <summary><p>The endpoint suffix for storage accounts.</p></summary>
        public virtual string SuffixStorageEndpoint { get; internal set; }
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
              .Add("cloud update")
              .Add("--cloud-config {value}", CloudConfig)
              .Add("--endpoint-active-directory {value}", EndpointActiveDirectory)
              .Add("--endpoint-active-directory-data-lake-resource-id {value}", EndpointActiveDirectoryDataLakeResourceId)
              .Add("--endpoint-active-directory-graph-resource-id {value}", EndpointActiveDirectoryGraphResourceId)
              .Add("--endpoint-active-directory-resource-id {value}", EndpointActiveDirectoryResourceId)
              .Add("--endpoint-gallery {value}", EndpointGallery)
              .Add("--endpoint-management {value}", EndpointManagement)
              .Add("--endpoint-resource-manager {value}", EndpointResourceManager)
              .Add("--endpoint-sql-management {value}", EndpointSqlManagement)
              .Add("--endpoint-vm-image-alias-doc {value}", EndpointVmImageAliasDoc)
              .Add("--name {value}", Name)
              .Add("--profile {value}", Profile)
              .Add("--suffix-acr-login-server-endpoint {value}", SuffixAcrLoginServerEndpoint)
              .Add("--suffix-azure-datalake-analytics-catalog-and-job-endpoint {value}", SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint)
              .Add("--suffix-azure-datalake-store-file-system-endpoint {value}", SuffixAzureDatalakeStoreFileSystemEndpoint)
              .Add("--suffix-keyvault-dns {value}", SuffixKeyvaultDns)
              .Add("--suffix-sql-server-hostname {value}", SuffixSqlServerHostname)
              .Add("--suffix-storage-endpoint {value}", SuffixStorageEndpoint)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCloudListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudListSettings SetDebug(this AzureCloudListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudListSettings ResetDebug(this AzureCloudListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudListSettings SetHelp(this AzureCloudListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudListSettings ResetHelp(this AzureCloudListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudListSettings SetOutput(this AzureCloudListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudListSettings ResetOutput(this AzureCloudListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudListSettings SetQuery(this AzureCloudListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudListSettings ResetQuery(this AzureCloudListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudListSettings SetVerbose(this AzureCloudListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudListSettings ResetVerbose(this AzureCloudListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCloudListProfilesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudListProfilesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetName(this AzureCloudListProfilesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetName(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ShowAll
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.ShowAll"/>.</em></p><p>Show all available profiles supported in the CLI.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetShowAll(this AzureCloudListProfilesSettings toolSettings, string showAll)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowAll = showAll;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.ShowAll"/>.</em></p><p>Show all available profiles supported in the CLI.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetShowAll(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowAll = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetDebug(this AzureCloudListProfilesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetDebug(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetHelp(this AzureCloudListProfilesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetHelp(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetOutput(this AzureCloudListProfilesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetOutput(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetQuery(this AzureCloudListProfilesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetQuery(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudListProfilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings SetVerbose(this AzureCloudListProfilesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudListProfilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudListProfilesSettings ResetVerbose(this AzureCloudListProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCloudRegisterSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudRegisterSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetName(this AzureCloudRegisterSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetName(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region CloudConfig
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.CloudConfig"/>.</em></p><p>JSON encoded cloud configuration. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetCloudConfig(this AzureCloudRegisterSettings toolSettings, string cloudConfig)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudConfig = cloudConfig;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.CloudConfig"/>.</em></p><p>JSON encoded cloud configuration. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetCloudConfig(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudConfig = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectory
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectory"/>.</em></p><p>The Active Directory login endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointActiveDirectory(this AzureCloudRegisterSettings toolSettings, string endpointActiveDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectory = endpointActiveDirectory;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectory"/>.</em></p><p>The Active Directory login endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointActiveDirectory(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectory = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectoryDataLakeResourceId
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectoryDataLakeResourceId"/>.</em></p><p>The Active Directory resource ID for data lake services.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointActiveDirectoryDataLakeResourceId(this AzureCloudRegisterSettings toolSettings, string endpointActiveDirectoryDataLakeResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryDataLakeResourceId = endpointActiveDirectoryDataLakeResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectoryDataLakeResourceId"/>.</em></p><p>The Active Directory resource ID for data lake services.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointActiveDirectoryDataLakeResourceId(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryDataLakeResourceId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectoryGraphResourceId
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectoryGraphResourceId"/>.</em></p><p>The Active Directory resource ID.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointActiveDirectoryGraphResourceId(this AzureCloudRegisterSettings toolSettings, string endpointActiveDirectoryGraphResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryGraphResourceId = endpointActiveDirectoryGraphResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectoryGraphResourceId"/>.</em></p><p>The Active Directory resource ID.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointActiveDirectoryGraphResourceId(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryGraphResourceId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectoryResourceId
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectoryResourceId"/>.</em></p><p>The resource ID to obtain AD tokens for.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointActiveDirectoryResourceId(this AzureCloudRegisterSettings toolSettings, string endpointActiveDirectoryResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryResourceId = endpointActiveDirectoryResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointActiveDirectoryResourceId"/>.</em></p><p>The resource ID to obtain AD tokens for.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointActiveDirectoryResourceId(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryResourceId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointGallery
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointGallery"/>.</em></p><p>The template gallery endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointGallery(this AzureCloudRegisterSettings toolSettings, string endpointGallery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointGallery = endpointGallery;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointGallery"/>.</em></p><p>The template gallery endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointGallery(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointGallery = null;
            return toolSettings;
        }
        #endregion
        #region EndpointManagement
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointManagement"/>.</em></p><p>The management service endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointManagement(this AzureCloudRegisterSettings toolSettings, string endpointManagement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointManagement = endpointManagement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointManagement"/>.</em></p><p>The management service endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointManagement(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointManagement = null;
            return toolSettings;
        }
        #endregion
        #region EndpointResourceManager
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointResourceManager"/>.</em></p><p>The resource management endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointResourceManager(this AzureCloudRegisterSettings toolSettings, string endpointResourceManager)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointResourceManager = endpointResourceManager;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointResourceManager"/>.</em></p><p>The resource management endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointResourceManager(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointResourceManager = null;
            return toolSettings;
        }
        #endregion
        #region EndpointSqlManagement
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointSqlManagement"/>.</em></p><p>The sql server management endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointSqlManagement(this AzureCloudRegisterSettings toolSettings, string endpointSqlManagement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointSqlManagement = endpointSqlManagement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointSqlManagement"/>.</em></p><p>The sql server management endpoint.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointSqlManagement(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointSqlManagement = null;
            return toolSettings;
        }
        #endregion
        #region EndpointVmImageAliasDoc
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.EndpointVmImageAliasDoc"/>.</em></p><p>The uri of the document which caches commonly used virtual machine images.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetEndpointVmImageAliasDoc(this AzureCloudRegisterSettings toolSettings, string endpointVmImageAliasDoc)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointVmImageAliasDoc = endpointVmImageAliasDoc;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.EndpointVmImageAliasDoc"/>.</em></p><p>The uri of the document which caches commonly used virtual machine images.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetEndpointVmImageAliasDoc(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointVmImageAliasDoc = null;
            return toolSettings;
        }
        #endregion
        #region Profile
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Profile"/>.</em></p><p>Profile to use for this cloud.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetProfile(this AzureCloudRegisterSettings toolSettings, CloudProfile profile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profile = profile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Profile"/>.</em></p><p>Profile to use for this cloud.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetProfile(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profile = null;
            return toolSettings;
        }
        #endregion
        #region SuffixAcrLoginServerEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.SuffixAcrLoginServerEndpoint"/>.</em></p><p>The Azure Container Registry login server suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetSuffixAcrLoginServerEndpoint(this AzureCloudRegisterSettings toolSettings, string suffixAcrLoginServerEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAcrLoginServerEndpoint = suffixAcrLoginServerEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.SuffixAcrLoginServerEndpoint"/>.</em></p><p>The Azure Container Registry login server suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetSuffixAcrLoginServerEndpoint(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAcrLoginServerEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint"/>.</em></p><p>The Data Lake analytics job and catalog service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetSuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint(this AzureCloudRegisterSettings toolSettings, string suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint = suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint"/>.</em></p><p>The Data Lake analytics job and catalog service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetSuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region SuffixAzureDatalakeStoreFileSystemEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.SuffixAzureDatalakeStoreFileSystemEndpoint"/>.</em></p><p>The Data Lake store filesystem service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetSuffixAzureDatalakeStoreFileSystemEndpoint(this AzureCloudRegisterSettings toolSettings, string suffixAzureDatalakeStoreFileSystemEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeStoreFileSystemEndpoint = suffixAzureDatalakeStoreFileSystemEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.SuffixAzureDatalakeStoreFileSystemEndpoint"/>.</em></p><p>The Data Lake store filesystem service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetSuffixAzureDatalakeStoreFileSystemEndpoint(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeStoreFileSystemEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region SuffixKeyvaultDns
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.SuffixKeyvaultDns"/>.</em></p><p>The Key Vault service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetSuffixKeyvaultDns(this AzureCloudRegisterSettings toolSettings, string suffixKeyvaultDns)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixKeyvaultDns = suffixKeyvaultDns;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.SuffixKeyvaultDns"/>.</em></p><p>The Key Vault service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetSuffixKeyvaultDns(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixKeyvaultDns = null;
            return toolSettings;
        }
        #endregion
        #region SuffixSqlServerHostname
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.SuffixSqlServerHostname"/>.</em></p><p>The dns suffix for sql servers.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetSuffixSqlServerHostname(this AzureCloudRegisterSettings toolSettings, string suffixSqlServerHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixSqlServerHostname = suffixSqlServerHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.SuffixSqlServerHostname"/>.</em></p><p>The dns suffix for sql servers.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetSuffixSqlServerHostname(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixSqlServerHostname = null;
            return toolSettings;
        }
        #endregion
        #region SuffixStorageEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.SuffixStorageEndpoint"/>.</em></p><p>The endpoint suffix for storage accounts.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetSuffixStorageEndpoint(this AzureCloudRegisterSettings toolSettings, string suffixStorageEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixStorageEndpoint = suffixStorageEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.SuffixStorageEndpoint"/>.</em></p><p>The endpoint suffix for storage accounts.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetSuffixStorageEndpoint(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixStorageEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetDebug(this AzureCloudRegisterSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetDebug(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetHelp(this AzureCloudRegisterSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetHelp(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetOutput(this AzureCloudRegisterSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetOutput(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetQuery(this AzureCloudRegisterSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetQuery(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudRegisterSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings SetVerbose(this AzureCloudRegisterSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudRegisterSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudRegisterSettings ResetVerbose(this AzureCloudRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCloudSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetName(this AzureCloudSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetName(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Profile
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Profile"/>.</em></p><p>Profile to use for this cloud.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetProfile(this AzureCloudSetSettings toolSettings, CloudProfile profile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profile = profile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Profile"/>.</em></p><p>Profile to use for this cloud.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetProfile(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profile = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetDebug(this AzureCloudSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetDebug(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetHelp(this AzureCloudSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetHelp(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetOutput(this AzureCloudSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetOutput(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetQuery(this AzureCloudSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetQuery(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudSetSettings SetVerbose(this AzureCloudSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudSetSettings ResetVerbose(this AzureCloudSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCloudShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCloudShowSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudShowSettings SetName(this AzureCloudShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudShowSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudShowSettings ResetName(this AzureCloudShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudShowSettings SetDebug(this AzureCloudShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudShowSettings ResetDebug(this AzureCloudShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudShowSettings SetHelp(this AzureCloudShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudShowSettings ResetHelp(this AzureCloudShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudShowSettings SetOutput(this AzureCloudShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudShowSettings ResetOutput(this AzureCloudShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudShowSettings SetQuery(this AzureCloudShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudShowSettings ResetQuery(this AzureCloudShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudShowSettings SetVerbose(this AzureCloudShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudShowSettings ResetVerbose(this AzureCloudShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCloudUnregisterSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudUnregisterSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCloudUnregisterSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings SetName(this AzureCloudUnregisterSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUnregisterSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings ResetName(this AzureCloudUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudUnregisterSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings SetDebug(this AzureCloudUnregisterSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUnregisterSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings ResetDebug(this AzureCloudUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudUnregisterSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings SetHelp(this AzureCloudUnregisterSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUnregisterSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings ResetHelp(this AzureCloudUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudUnregisterSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings SetOutput(this AzureCloudUnregisterSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUnregisterSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings ResetOutput(this AzureCloudUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudUnregisterSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings SetQuery(this AzureCloudUnregisterSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUnregisterSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings ResetQuery(this AzureCloudUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudUnregisterSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings SetVerbose(this AzureCloudUnregisterSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUnregisterSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudUnregisterSettings ResetVerbose(this AzureCloudUnregisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCloudUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCloudUpdateSettingsExtensions
    {
        #region CloudConfig
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.CloudConfig"/>.</em></p><p>JSON encoded cloud configuration. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetCloudConfig(this AzureCloudUpdateSettings toolSettings, string cloudConfig)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudConfig = cloudConfig;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.CloudConfig"/>.</em></p><p>JSON encoded cloud configuration. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetCloudConfig(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudConfig = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectory
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectory"/>.</em></p><p>The Active Directory login endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointActiveDirectory(this AzureCloudUpdateSettings toolSettings, string endpointActiveDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectory = endpointActiveDirectory;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectory"/>.</em></p><p>The Active Directory login endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointActiveDirectory(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectory = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectoryDataLakeResourceId
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectoryDataLakeResourceId"/>.</em></p><p>The Active Directory resource ID for data lake services.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointActiveDirectoryDataLakeResourceId(this AzureCloudUpdateSettings toolSettings, string endpointActiveDirectoryDataLakeResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryDataLakeResourceId = endpointActiveDirectoryDataLakeResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectoryDataLakeResourceId"/>.</em></p><p>The Active Directory resource ID for data lake services.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointActiveDirectoryDataLakeResourceId(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryDataLakeResourceId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectoryGraphResourceId
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectoryGraphResourceId"/>.</em></p><p>The Active Directory resource ID.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointActiveDirectoryGraphResourceId(this AzureCloudUpdateSettings toolSettings, string endpointActiveDirectoryGraphResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryGraphResourceId = endpointActiveDirectoryGraphResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectoryGraphResourceId"/>.</em></p><p>The Active Directory resource ID.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointActiveDirectoryGraphResourceId(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryGraphResourceId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointActiveDirectoryResourceId
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectoryResourceId"/>.</em></p><p>The resource ID to obtain AD tokens for.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointActiveDirectoryResourceId(this AzureCloudUpdateSettings toolSettings, string endpointActiveDirectoryResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryResourceId = endpointActiveDirectoryResourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointActiveDirectoryResourceId"/>.</em></p><p>The resource ID to obtain AD tokens for.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointActiveDirectoryResourceId(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointActiveDirectoryResourceId = null;
            return toolSettings;
        }
        #endregion
        #region EndpointGallery
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointGallery"/>.</em></p><p>The template gallery endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointGallery(this AzureCloudUpdateSettings toolSettings, string endpointGallery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointGallery = endpointGallery;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointGallery"/>.</em></p><p>The template gallery endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointGallery(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointGallery = null;
            return toolSettings;
        }
        #endregion
        #region EndpointManagement
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointManagement"/>.</em></p><p>The management service endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointManagement(this AzureCloudUpdateSettings toolSettings, string endpointManagement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointManagement = endpointManagement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointManagement"/>.</em></p><p>The management service endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointManagement(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointManagement = null;
            return toolSettings;
        }
        #endregion
        #region EndpointResourceManager
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointResourceManager"/>.</em></p><p>The resource management endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointResourceManager(this AzureCloudUpdateSettings toolSettings, string endpointResourceManager)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointResourceManager = endpointResourceManager;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointResourceManager"/>.</em></p><p>The resource management endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointResourceManager(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointResourceManager = null;
            return toolSettings;
        }
        #endregion
        #region EndpointSqlManagement
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointSqlManagement"/>.</em></p><p>The sql server management endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointSqlManagement(this AzureCloudUpdateSettings toolSettings, string endpointSqlManagement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointSqlManagement = endpointSqlManagement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointSqlManagement"/>.</em></p><p>The sql server management endpoint.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointSqlManagement(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointSqlManagement = null;
            return toolSettings;
        }
        #endregion
        #region EndpointVmImageAliasDoc
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.EndpointVmImageAliasDoc"/>.</em></p><p>The uri of the document which caches commonly used virtual machine images.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetEndpointVmImageAliasDoc(this AzureCloudUpdateSettings toolSettings, string endpointVmImageAliasDoc)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointVmImageAliasDoc = endpointVmImageAliasDoc;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.EndpointVmImageAliasDoc"/>.</em></p><p>The uri of the document which caches commonly used virtual machine images.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetEndpointVmImageAliasDoc(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointVmImageAliasDoc = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetName(this AzureCloudUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Name"/>.</em></p><p>Name of a registered cloud.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetName(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Profile
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Profile"/>.</em></p><p>Profile to use for this cloud.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetProfile(this AzureCloudUpdateSettings toolSettings, CloudProfile profile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profile = profile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Profile"/>.</em></p><p>Profile to use for this cloud.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetProfile(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profile = null;
            return toolSettings;
        }
        #endregion
        #region SuffixAcrLoginServerEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.SuffixAcrLoginServerEndpoint"/>.</em></p><p>The Azure Container Registry login server suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetSuffixAcrLoginServerEndpoint(this AzureCloudUpdateSettings toolSettings, string suffixAcrLoginServerEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAcrLoginServerEndpoint = suffixAcrLoginServerEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.SuffixAcrLoginServerEndpoint"/>.</em></p><p>The Azure Container Registry login server suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetSuffixAcrLoginServerEndpoint(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAcrLoginServerEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint"/>.</em></p><p>The Data Lake analytics job and catalog service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetSuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint(this AzureCloudUpdateSettings toolSettings, string suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint = suffixAzureDatalakeAnalyticsCatalogAndJobEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint"/>.</em></p><p>The Data Lake analytics job and catalog service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetSuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeAnalyticsCatalogAndJobEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region SuffixAzureDatalakeStoreFileSystemEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.SuffixAzureDatalakeStoreFileSystemEndpoint"/>.</em></p><p>The Data Lake store filesystem service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetSuffixAzureDatalakeStoreFileSystemEndpoint(this AzureCloudUpdateSettings toolSettings, string suffixAzureDatalakeStoreFileSystemEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeStoreFileSystemEndpoint = suffixAzureDatalakeStoreFileSystemEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.SuffixAzureDatalakeStoreFileSystemEndpoint"/>.</em></p><p>The Data Lake store filesystem service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetSuffixAzureDatalakeStoreFileSystemEndpoint(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixAzureDatalakeStoreFileSystemEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region SuffixKeyvaultDns
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.SuffixKeyvaultDns"/>.</em></p><p>The Key Vault service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetSuffixKeyvaultDns(this AzureCloudUpdateSettings toolSettings, string suffixKeyvaultDns)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixKeyvaultDns = suffixKeyvaultDns;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.SuffixKeyvaultDns"/>.</em></p><p>The Key Vault service dns suffix.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetSuffixKeyvaultDns(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixKeyvaultDns = null;
            return toolSettings;
        }
        #endregion
        #region SuffixSqlServerHostname
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.SuffixSqlServerHostname"/>.</em></p><p>The dns suffix for sql servers.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetSuffixSqlServerHostname(this AzureCloudUpdateSettings toolSettings, string suffixSqlServerHostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixSqlServerHostname = suffixSqlServerHostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.SuffixSqlServerHostname"/>.</em></p><p>The dns suffix for sql servers.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetSuffixSqlServerHostname(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixSqlServerHostname = null;
            return toolSettings;
        }
        #endregion
        #region SuffixStorageEndpoint
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.SuffixStorageEndpoint"/>.</em></p><p>The endpoint suffix for storage accounts.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetSuffixStorageEndpoint(this AzureCloudUpdateSettings toolSettings, string suffixStorageEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixStorageEndpoint = suffixStorageEndpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.SuffixStorageEndpoint"/>.</em></p><p>The endpoint suffix for storage accounts.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetSuffixStorageEndpoint(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuffixStorageEndpoint = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetDebug(this AzureCloudUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetDebug(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetHelp(this AzureCloudUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetHelp(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetOutput(this AzureCloudUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetOutput(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetQuery(this AzureCloudUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetQuery(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCloudUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings SetVerbose(this AzureCloudUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCloudUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCloudUpdateSettings ResetVerbose(this AzureCloudUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region CloudProfile
    /// <summary><p>Used within <see cref="AzureCloudTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class CloudProfile : Enumeration
    {
        public static CloudProfile _2017_03_09_profile = new CloudProfile { Value = "2017-03-09-profile" };
        public static CloudProfile _2018_03_01_hybrid = new CloudProfile { Value = "2018-03-01-hybrid" };
        public static CloudProfile latest = new CloudProfile { Value = "latest" };
    }
    #endregion
}
