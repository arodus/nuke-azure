// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.15 [CommitSha: 2886d896].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureContainer.json.

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
    public static partial class AzureContainerTasks
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public static string AzureContainerPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Container Instances.</p></summary>
        public static IEnumerable<string> AzureContainer(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureContainerPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureContainerAttachSettings toolSettings);
        static partial void PostProcess(AzureContainerAttachSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerAttach(Configure<AzureContainerAttachSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerAttachSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureContainerCreateSettings toolSettings);
        static partial void PostProcess(AzureContainerCreateSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerCreate(Configure<AzureContainerCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureContainerDeleteSettings toolSettings);
        static partial void PostProcess(AzureContainerDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerDelete(Configure<AzureContainerDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureContainerExecSettings toolSettings);
        static partial void PostProcess(AzureContainerExecSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerExec(Configure<AzureContainerExecSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerExecSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureContainerListSettings toolSettings);
        static partial void PostProcess(AzureContainerListSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerList(Configure<AzureContainerListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureContainerLogsSettings toolSettings);
        static partial void PostProcess(AzureContainerLogsSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerLogs(Configure<AzureContainerLogsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerLogsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureContainerShowSettings toolSettings);
        static partial void PostProcess(AzureContainerShowSettings toolSettings);
        /// <summary><p>Manage Azure Container Instances.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/container.yml">official website</a>.</p></summary>
        public static void AzureContainerShow(Configure<AzureContainerShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureContainerShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureContainerAttachSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerAttachSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        /// <summary><p>The name of the container group.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The container to attach to. If omitted, the first container in the container group will be chosen.</p></summary>
        public virtual string ContainerName { get; internal set; }
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
              .Add("container attach")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--container-name {value}", ContainerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureContainerCreateSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        /// <summary><p>The container image name.</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>The name of the container group.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.</p></summary>
        public virtual string CommandLine { get; internal set; }
        /// <summary><p>The required number of CPU cores of the containers.</p></summary>
        public virtual string Cpu { get; internal set; }
        /// <summary><p>The dns name label for container group with public IP.</p></summary>
        public virtual string DnsNameLabel { get; internal set; }
        /// <summary><p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p></summary>
        public virtual IReadOnlyDictionary<string, string> EnvironmentVariables => EnvironmentVariablesInternal.AsReadOnly();
        internal Dictionary<string,string> EnvironmentVariablesInternal { get; set; } = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>The IP address type of the container group.</p></summary>
        public virtual ContainerCreateIpAddress IpAddress { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The required memory of the containers in GB.</p></summary>
        public virtual string Memory { get; internal set; }
        /// <summary><p>The OS type of the containers.</p></summary>
        public virtual ContainerCreateOsType OsType { get; internal set; }
        /// <summary><p>The ports to open.</p></summary>
        public virtual string Ports { get; internal set; }
        /// <summary><p>Restart policy for all containers within the container group.</p></summary>
        public virtual ContainerCreateRestartPolicy RestartPolicy { get; internal set; }
        /// <summary><p>Space-separated secrets in 'key=value' format.</p></summary>
        public virtual IReadOnlyDictionary<string, string> Secrets => SecretsInternal.AsReadOnly();
        internal Dictionary<string,string> SecretsInternal { get; set; } = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>The path within the container where the secrets volume should be mounted. Must not contain colon ':'.</p></summary>
        public virtual string SecretsMountPath { get; internal set; }
        /// <summary><p>The storage account access key used to access the Azure File share.</p></summary>
        public virtual string AzureFileVolumeAccountKey { get; internal set; }
        /// <summary><p>The name of the storage account that contains the Azure File share.</p></summary>
        public virtual string AzureFileVolumeAccountName { get; internal set; }
        /// <summary><p>The path within the container where the azure file volume should be mounted. Must not contain colon ':'.</p></summary>
        public virtual string AzureFileVolumeMountPath { get; internal set; }
        /// <summary><p>The name of the Azure File share to be mounted as a volume.</p></summary>
        public virtual string AzureFileVolumeShareName { get; internal set; }
        /// <summary><p>The target directory path in the git repository. Must not contain '..'.</p></summary>
        public virtual string GitrepoDir { get; internal set; }
        /// <summary><p>The path within the container where the git repo volume should be mounted. Must not contain colon ':'.</p></summary>
        public virtual string GitrepoMountPath { get; internal set; }
        /// <summary><p>The commit hash for the specified revision.</p></summary>
        public virtual string GitrepoRevision { get; internal set; }
        /// <summary><p>The URL of a git repository to be mounted as a volume.</p></summary>
        public virtual string GitrepoUrl { get; internal set; }
        /// <summary><p>The container image registry login server.</p></summary>
        public virtual string RegistryLoginServer { get; internal set; }
        /// <summary><p>The password to log in container image registry server.</p></summary>
        public virtual string RegistryPassword { get; internal set; }
        /// <summary><p>The username to log in container image registry server.</p></summary>
        public virtual string RegistryUsername { get; internal set; }
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
              .Add("container create")
              .Add("--image {value}", Image)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--command-line {value}", CommandLine)
              .Add("--cpu {value}", Cpu)
              .Add("--dns-name-label {value}", DnsNameLabel)
              .Add("--environment-variables {value}", EnvironmentVariables, "{key}={value}", separator: ' ')
              .Add("--ip-address {value}", IpAddress)
              .Add("--location {value}", Location)
              .Add("--memory {value}", Memory)
              .Add("--os-type {value}", OsType)
              .Add("--ports {value}", Ports)
              .Add("--restart-policy {value}", RestartPolicy)
              .Add("--secrets {value}", Secrets, "{key}={value}", separator: ' ')
              .Add("--secrets-mount-path {value}", SecretsMountPath)
              .Add("--azure-file-volume-account-key {value}", AzureFileVolumeAccountKey)
              .Add("--azure-file-volume-account-name {value}", AzureFileVolumeAccountName)
              .Add("--azure-file-volume-mount-path {value}", AzureFileVolumeMountPath)
              .Add("--azure-file-volume-share-name {value}", AzureFileVolumeShareName)
              .Add("--gitrepo-dir {value}", GitrepoDir)
              .Add("--gitrepo-mount-path {value}", GitrepoMountPath)
              .Add("--gitrepo-revision {value}", GitrepoRevision)
              .Add("--gitrepo-url {value}", GitrepoUrl)
              .Add("--registry-login-server {value}", RegistryLoginServer)
              .Add("--registry-password {value}", RegistryPassword)
              .Add("--registry-username {value}", RegistryUsername)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureContainerDeleteSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        /// <summary><p>The name of the container group.</p></summary>
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
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("container delete")
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
    #region AzureContainerExecSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerExecSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        /// <summary><p>The command to run from within the container.</p></summary>
        public virtual string ExecCommand { get; internal set; }
        /// <summary><p>The name of the container group.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The container name where to execute the command. Can be ommitted for container groups with only one container.</p></summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary><p>The col size for the command output.</p></summary>
        public virtual string TerminalColSize { get; internal set; }
        /// <summary><p>The row size for the command output.</p></summary>
        public virtual string TerminalRowSize { get; internal set; }
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
              .Add("container exec")
              .Add("--exec-command {value}", ExecCommand)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--container-name {value}", ContainerName)
              .Add("--terminal-col-size {value}", TerminalColSize)
              .Add("--terminal-row-size {value}", TerminalRowSize)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureContainerListSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
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
              .Add("container list")
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
    #region AzureContainerLogsSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerLogsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        /// <summary><p>The name of the container group.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The container name to tail the logs. If omitted, the first container in the container group will be chosen.</p></summary>
        public virtual string ContainerName { get; internal set; }
        /// <summary><p>Indicate to stream the tailing logs.</p></summary>
        public virtual string Follow { get; internal set; }
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
              .Add("container logs")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--container-name {value}", ContainerName)
              .Add("--follow {value}", Follow)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureContainerShowSettings
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureContainerShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureContainer executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureContainerTasks.AzureContainerPath;
        /// <summary><p>The name of the container group.</p></summary>
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
              .Add("container show")
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
    #region AzureContainerAttachSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerAttachSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetName(this AzureContainerAttachSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetName(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetResourceGroup(this AzureContainerAttachSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetResourceGroup(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ContainerName
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.ContainerName"/>.</em></p><p>The container to attach to. If omitted, the first container in the container group will be chosen.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetContainerName(this AzureContainerAttachSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.ContainerName"/>.</em></p><p>The container to attach to. If omitted, the first container in the container group will be chosen.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetContainerName(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetDebug(this AzureContainerAttachSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetDebug(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetHelp(this AzureContainerAttachSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetHelp(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetOutput(this AzureContainerAttachSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetOutput(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetQuery(this AzureContainerAttachSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetQuery(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings SetVerbose(this AzureContainerAttachSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerAttachSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerAttachSettings ResetVerbose(this AzureContainerAttachSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerCreateSettingsExtensions
    {
        #region Image
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Image"/>.</em></p><p>The container image name.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetImage(this AzureContainerCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Image"/>.</em></p><p>The container image name.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetImage(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetName(this AzureContainerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetResourceGroup(this AzureContainerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetResourceGroup(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CommandLine
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.CommandLine"/>.</em></p><p>The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetCommandLine(this AzureContainerCreateSettings toolSettings, string commandLine)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandLine = commandLine;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.CommandLine"/>.</em></p><p>The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetCommandLine(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CommandLine = null;
            return toolSettings;
        }
        #endregion
        #region Cpu
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Cpu"/>.</em></p><p>The required number of CPU cores of the containers.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetCpu(this AzureContainerCreateSettings toolSettings, string cpu)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = cpu;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Cpu"/>.</em></p><p>The required number of CPU cores of the containers.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetCpu(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cpu = null;
            return toolSettings;
        }
        #endregion
        #region DnsNameLabel
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.DnsNameLabel"/>.</em></p><p>The dns name label for container group with public IP.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetDnsNameLabel(this AzureContainerCreateSettings toolSettings, string dnsNameLabel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNameLabel = dnsNameLabel;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.DnsNameLabel"/>.</em></p><p>The dns name label for container group with public IP.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetDnsNameLabel(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNameLabel = null;
            return toolSettings;
        }
        #endregion
        #region EnvironmentVariables
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.EnvironmentVariables"/> to a new dictionary.</em></p><p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetEnvironmentVariables(this AzureContainerCreateSettings toolSettings, IDictionary<string, string> environmentVariables)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnvironmentVariablesInternal = environmentVariables.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureContainerCreateSettings.EnvironmentVariables"/>.</em></p><p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ClearEnvironmentVariables(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnvironmentVariablesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="AzureContainerCreateSettings.EnvironmentVariables"/>.</em></p><p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings AddEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string environmentVariableKey, string environmentVariableValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnvironmentVariablesInternal.Add(environmentVariableKey, environmentVariableValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="AzureContainerCreateSettings.EnvironmentVariables"/>.</em></p><p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string environmentVariableKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnvironmentVariablesInternal.Remove(environmentVariableKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="AzureContainerCreateSettings.EnvironmentVariables"/>.</em></p><p>A list of environment variable for the container. Space-separated values in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetEnvironmentVariable(this AzureContainerCreateSettings toolSettings, string environmentVariableKey, string environmentVariableValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnvironmentVariablesInternal[environmentVariableKey] = environmentVariableValue;
            return toolSettings;
        }
        #endregion
        #region IpAddress
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.IpAddress"/>.</em></p><p>The IP address type of the container group.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetIpAddress(this AzureContainerCreateSettings toolSettings, ContainerCreateIpAddress ipAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpAddress = ipAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.IpAddress"/>.</em></p><p>The IP address type of the container group.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetIpAddress(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetLocation(this AzureContainerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetLocation(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Memory
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Memory"/>.</em></p><p>The required memory of the containers in GB.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetMemory(this AzureContainerCreateSettings toolSettings, string memory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Memory = memory;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Memory"/>.</em></p><p>The required memory of the containers in GB.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetMemory(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Memory = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.OsType"/>.</em></p><p>The OS type of the containers.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetOsType(this AzureContainerCreateSettings toolSettings, ContainerCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.OsType"/>.</em></p><p>The OS type of the containers.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetOsType(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region Ports
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Ports"/>.</em></p><p>The ports to open.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetPorts(this AzureContainerCreateSettings toolSettings, string ports)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ports = ports;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Ports"/>.</em></p><p>The ports to open.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetPorts(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ports = null;
            return toolSettings;
        }
        #endregion
        #region RestartPolicy
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.RestartPolicy"/>.</em></p><p>Restart policy for all containers within the container group.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetRestartPolicy(this AzureContainerCreateSettings toolSettings, ContainerCreateRestartPolicy restartPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartPolicy = restartPolicy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.RestartPolicy"/>.</em></p><p>Restart policy for all containers within the container group.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRestartPolicy(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestartPolicy = null;
            return toolSettings;
        }
        #endregion
        #region Secrets
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Secrets"/> to a new dictionary.</em></p><p>Space-separated secrets in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecrets(this AzureContainerCreateSettings toolSettings, IDictionary<string, string> secrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal = secrets.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureContainerCreateSettings.Secrets"/>.</em></p><p>Space-separated secrets in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ClearSecrets(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="AzureContainerCreateSettings.Secrets"/>.</em></p><p>Space-separated secrets in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings AddSecret(this AzureContainerCreateSettings toolSettings, string secretKey, string secretValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Add(secretKey, secretValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="AzureContainerCreateSettings.Secrets"/>.</em></p><p>Space-separated secrets in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings RemoveSecret(this AzureContainerCreateSettings toolSettings, string secretKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal.Remove(secretKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="AzureContainerCreateSettings.Secrets"/>.</em></p><p>Space-separated secrets in 'key=value' format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecret(this AzureContainerCreateSettings toolSettings, string secretKey, string secretValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsInternal[secretKey] = secretValue;
            return toolSettings;
        }
        #endregion
        #region SecretsMountPath
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.SecretsMountPath"/>.</em></p><p>The path within the container where the secrets volume should be mounted. Must not contain colon ':'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetSecretsMountPath(this AzureContainerCreateSettings toolSettings, string secretsMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsMountPath = secretsMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.SecretsMountPath"/>.</em></p><p>The path within the container where the secrets volume should be mounted. Must not contain colon ':'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetSecretsMountPath(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecretsMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeAccountKey
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountKey"/>.</em></p><p>The storage account access key used to access the Azure File share.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeAccountKey(this AzureContainerCreateSettings toolSettings, string azureFileVolumeAccountKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountKey = azureFileVolumeAccountKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountKey"/>.</em></p><p>The storage account access key used to access the Azure File share.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeAccountKey(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountKey = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeAccountName
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountName"/>.</em></p><p>The name of the storage account that contains the Azure File share.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeAccountName(this AzureContainerCreateSettings toolSettings, string azureFileVolumeAccountName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountName = azureFileVolumeAccountName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeAccountName"/>.</em></p><p>The name of the storage account that contains the Azure File share.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeAccountName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeAccountName = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeMountPath
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeMountPath"/>.</em></p><p>The path within the container where the azure file volume should be mounted. Must not contain colon ':'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeMountPath(this AzureContainerCreateSettings toolSettings, string azureFileVolumeMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeMountPath = azureFileVolumeMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeMountPath"/>.</em></p><p>The path within the container where the azure file volume should be mounted. Must not contain colon ':'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeMountPath(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeMountPath = null;
            return toolSettings;
        }
        #endregion
        #region AzureFileVolumeShareName
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.AzureFileVolumeShareName"/>.</em></p><p>The name of the Azure File share to be mounted as a volume.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetAzureFileVolumeShareName(this AzureContainerCreateSettings toolSettings, string azureFileVolumeShareName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeShareName = azureFileVolumeShareName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.AzureFileVolumeShareName"/>.</em></p><p>The name of the Azure File share to be mounted as a volume.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetAzureFileVolumeShareName(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AzureFileVolumeShareName = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoDir
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoDir"/>.</em></p><p>The target directory path in the git repository. Must not contain '..'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoDir(this AzureContainerCreateSettings toolSettings, string gitrepoDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoDir = gitrepoDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoDir"/>.</em></p><p>The target directory path in the git repository. Must not contain '..'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoDir(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoDir = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoMountPath
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoMountPath"/>.</em></p><p>The path within the container where the git repo volume should be mounted. Must not contain colon ':'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoMountPath(this AzureContainerCreateSettings toolSettings, string gitrepoMountPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoMountPath = gitrepoMountPath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoMountPath"/>.</em></p><p>The path within the container where the git repo volume should be mounted. Must not contain colon ':'.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoMountPath(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoMountPath = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoRevision
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoRevision"/>.</em></p><p>The commit hash for the specified revision.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoRevision(this AzureContainerCreateSettings toolSettings, string gitrepoRevision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoRevision = gitrepoRevision;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoRevision"/>.</em></p><p>The commit hash for the specified revision.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoRevision(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoRevision = null;
            return toolSettings;
        }
        #endregion
        #region GitrepoUrl
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.GitrepoUrl"/>.</em></p><p>The URL of a git repository to be mounted as a volume.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetGitrepoUrl(this AzureContainerCreateSettings toolSettings, string gitrepoUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoUrl = gitrepoUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.GitrepoUrl"/>.</em></p><p>The URL of a git repository to be mounted as a volume.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetGitrepoUrl(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitrepoUrl = null;
            return toolSettings;
        }
        #endregion
        #region RegistryLoginServer
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.RegistryLoginServer"/>.</em></p><p>The container image registry login server.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetRegistryLoginServer(this AzureContainerCreateSettings toolSettings, string registryLoginServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryLoginServer = registryLoginServer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.RegistryLoginServer"/>.</em></p><p>The container image registry login server.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRegistryLoginServer(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryLoginServer = null;
            return toolSettings;
        }
        #endregion
        #region RegistryPassword
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.RegistryPassword"/>.</em></p><p>The password to log in container image registry server.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetRegistryPassword(this AzureContainerCreateSettings toolSettings, string registryPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryPassword = registryPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.RegistryPassword"/>.</em></p><p>The password to log in container image registry server.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRegistryPassword(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryPassword = null;
            return toolSettings;
        }
        #endregion
        #region RegistryUsername
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.RegistryUsername"/>.</em></p><p>The username to log in container image registry server.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetRegistryUsername(this AzureContainerCreateSettings toolSettings, string registryUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryUsername = registryUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.RegistryUsername"/>.</em></p><p>The username to log in container image registry server.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetRegistryUsername(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RegistryUsername = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetDebug(this AzureContainerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetDebug(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetHelp(this AzureContainerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetHelp(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetOutput(this AzureContainerCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetOutput(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetQuery(this AzureContainerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetQuery(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings SetVerbose(this AzureContainerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerCreateSettings ResetVerbose(this AzureContainerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetName(this AzureContainerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetName(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetResourceGroup(this AzureContainerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetResourceGroup(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetYes(this AzureContainerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetYes(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetDebug(this AzureContainerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetDebug(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetHelp(this AzureContainerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetHelp(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetOutput(this AzureContainerDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetOutput(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetQuery(this AzureContainerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetQuery(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings SetVerbose(this AzureContainerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerDeleteSettings ResetVerbose(this AzureContainerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerExecSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerExecSettingsExtensions
    {
        #region ExecCommand
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.ExecCommand"/>.</em></p><p>The command to run from within the container.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetExecCommand(this AzureContainerExecSettings toolSettings, string execCommand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecCommand = execCommand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.ExecCommand"/>.</em></p><p>The command to run from within the container.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetExecCommand(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExecCommand = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetName(this AzureContainerExecSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetName(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetResourceGroup(this AzureContainerExecSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetResourceGroup(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ContainerName
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.ContainerName"/>.</em></p><p>The container name where to execute the command. Can be ommitted for container groups with only one container.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetContainerName(this AzureContainerExecSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.ContainerName"/>.</em></p><p>The container name where to execute the command. Can be ommitted for container groups with only one container.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetContainerName(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region TerminalColSize
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.TerminalColSize"/>.</em></p><p>The col size for the command output.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetTerminalColSize(this AzureContainerExecSettings toolSettings, string terminalColSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalColSize = terminalColSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.TerminalColSize"/>.</em></p><p>The col size for the command output.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetTerminalColSize(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalColSize = null;
            return toolSettings;
        }
        #endregion
        #region TerminalRowSize
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.TerminalRowSize"/>.</em></p><p>The row size for the command output.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetTerminalRowSize(this AzureContainerExecSettings toolSettings, string terminalRowSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalRowSize = terminalRowSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.TerminalRowSize"/>.</em></p><p>The row size for the command output.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetTerminalRowSize(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TerminalRowSize = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetDebug(this AzureContainerExecSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetDebug(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetHelp(this AzureContainerExecSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetHelp(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetOutput(this AzureContainerExecSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetOutput(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetQuery(this AzureContainerExecSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetQuery(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerExecSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerExecSettings SetVerbose(this AzureContainerExecSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerExecSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerExecSettings ResetVerbose(this AzureContainerExecSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerListSettings SetResourceGroup(this AzureContainerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerListSettings ResetResourceGroup(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerListSettings SetDebug(this AzureContainerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerListSettings ResetDebug(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerListSettings SetHelp(this AzureContainerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerListSettings ResetHelp(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerListSettings SetOutput(this AzureContainerListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerListSettings ResetOutput(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerListSettings SetQuery(this AzureContainerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerListSettings ResetQuery(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerListSettings SetVerbose(this AzureContainerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerListSettings ResetVerbose(this AzureContainerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerLogsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerLogsSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetName(this AzureContainerLogsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetName(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetResourceGroup(this AzureContainerLogsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetResourceGroup(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ContainerName
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.ContainerName"/>.</em></p><p>The container name to tail the logs. If omitted, the first container in the container group will be chosen.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetContainerName(this AzureContainerLogsSettings toolSettings, string containerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = containerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.ContainerName"/>.</em></p><p>The container name to tail the logs. If omitted, the first container in the container group will be chosen.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetContainerName(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContainerName = null;
            return toolSettings;
        }
        #endregion
        #region Follow
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Follow"/>.</em></p><p>Indicate to stream the tailing logs.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetFollow(this AzureContainerLogsSettings toolSettings, string follow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = follow;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Follow"/>.</em></p><p>Indicate to stream the tailing logs.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetFollow(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetDebug(this AzureContainerLogsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetDebug(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetHelp(this AzureContainerLogsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetHelp(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetOutput(this AzureContainerLogsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetOutput(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetQuery(this AzureContainerLogsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetQuery(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerLogsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings SetVerbose(this AzureContainerLogsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerLogsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerLogsSettings ResetVerbose(this AzureContainerLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureContainerShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureContainerShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetName(this AzureContainerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.Name"/>.</em></p><p>The name of the container group.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetName(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetResourceGroup(this AzureContainerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetResourceGroup(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetDebug(this AzureContainerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetDebug(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetHelp(this AzureContainerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetHelp(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetOutput(this AzureContainerShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetOutput(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetQuery(this AzureContainerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetQuery(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureContainerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerShowSettings SetVerbose(this AzureContainerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureContainerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureContainerShowSettings ResetVerbose(this AzureContainerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ContainerCreateIpAddress
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class ContainerCreateIpAddress : Enumeration
    {
        public static ContainerCreateIpAddress public_ = new ContainerCreateIpAddress { Value = "public" };
    }
    #endregion
    #region ContainerCreateOsType
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class ContainerCreateOsType : Enumeration
    {
        public static ContainerCreateOsType linux = new ContainerCreateOsType { Value = "linux" };
        public static ContainerCreateOsType windows = new ContainerCreateOsType { Value = "windows" };
    }
    #endregion
    #region ContainerCreateRestartPolicy
    /// <summary><p>Used within <see cref="AzureContainerTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class ContainerCreateRestartPolicy : Enumeration
    {
        public static ContainerCreateRestartPolicy always = new ContainerCreateRestartPolicy { Value = "always" };
        public static ContainerCreateRestartPolicy never = new ContainerCreateRestartPolicy { Value = "never" };
        public static ContainerCreateRestartPolicy onfailure = new ContainerCreateRestartPolicy { Value = "onfailure" };
    }
    #endregion
}
