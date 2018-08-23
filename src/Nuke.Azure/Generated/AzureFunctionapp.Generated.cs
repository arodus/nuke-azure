// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureFunctionapp.json.

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
    public static partial class AzureFunctionappTasks
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public static string AzureFunctionappPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage function apps.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionapp(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureFunctionappPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappCreate(Configure<AzureFunctionappCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDelete(Configure<AzureFunctionappDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappList(Configure<AzureFunctionappListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappListConsumptionLocations(Configure<AzureFunctionappListConsumptionLocationsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappListConsumptionLocationsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappRestart(Configure<AzureFunctionappRestartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappRestartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappShow(Configure<AzureFunctionappShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappStart(Configure<AzureFunctionappStartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappStartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappStop(Configure<AzureFunctionappStopSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappStopSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappUpdate(Configure<AzureFunctionappUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfig(Configure<AzureFunctionappConfigSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentListPublishingProfiles(Configure<AzureFunctionappDeploymentListPublishingProfilesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentListPublishingProfilesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappIdentityAssign(Configure<AzureFunctionappIdentityAssignSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappIdentityAssignSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappIdentityRemove(Configure<AzureFunctionappIdentityRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappIdentityRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappIdentityShow(Configure<AzureFunctionappIdentityShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappIdentityShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigAppsettingsDelete(Configure<AzureFunctionappConfigAppsettingsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigAppsettingsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigAppsettingsList(Configure<AzureFunctionappConfigAppsettingsListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigAppsettingsListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigAppsettingsSet(Configure<AzureFunctionappConfigAppsettingsSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigAppsettingsSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigHostnameAdd(Configure<AzureFunctionappConfigHostnameAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigHostnameAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigHostnameDelete(Configure<AzureFunctionappConfigHostnameDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigHostnameDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigHostnameGetExternalIp(Configure<AzureFunctionappConfigHostnameGetExternalIpSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigHostnameGetExternalIpSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigHostnameList(Configure<AzureFunctionappConfigHostnameListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigHostnameListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigSslBind(Configure<AzureFunctionappConfigSslBindSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigSslBindSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigSslDelete(Configure<AzureFunctionappConfigSslDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigSslDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigSslList(Configure<AzureFunctionappConfigSslListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigSslListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigSslUnbind(Configure<AzureFunctionappConfigSslUnbindSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigSslUnbindSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappConfigSslUpload(Configure<AzureFunctionappConfigSslUploadSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappConfigSslUploadSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceConfig(Configure<AzureFunctionappDeploymentSourceConfigSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceConfigSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceConfigLocalGit(Configure<AzureFunctionappDeploymentSourceConfigLocalGitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceConfigLocalGitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceConfigZip(Configure<AzureFunctionappDeploymentSourceConfigZipSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceConfigZipSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceDelete(Configure<AzureFunctionappDeploymentSourceDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceShow(Configure<AzureFunctionappDeploymentSourceShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceSync(Configure<AzureFunctionappDeploymentSourceSyncSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceSyncSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentSourceUpdateToken(Configure<AzureFunctionappDeploymentSourceUpdateTokenSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentSourceUpdateTokenSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentUserSet(Configure<AzureFunctionappDeploymentUserSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentUserSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage function apps.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/functionapp?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureFunctionappDeploymentUserShow(Configure<AzureFunctionappDeploymentUserShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFunctionappDeploymentUserShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureFunctionappCreateSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Provide a string value of a Storage Account in the provided Resource Group. Or Resource ID of a Storage Account in a different Resource Group.</p></summary>
        public virtual string StorageAccount { get; internal set; }
        /// <summary><p>Geographic location where Function App will be hosted. Use 'functionapp list-consumption-locations' to view available locations.</p></summary>
        public virtual string ConsumptionPlanLocation { get; internal set; }
        /// <summary><p>Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.</p></summary>
        public virtual string DeploymentContainerImageName { get; internal set; }
        /// <summary><p>Enable local git.</p></summary>
        public virtual string DeploymentLocalGit { get; internal set; }
        /// <summary><p>The branch to deploy.</p></summary>
        public virtual string DeploymentSourceBranch { get; internal set; }
        /// <summary><p>Git repository URL to link with manual integration.</p></summary>
        public virtual string DeploymentSourceUrl { get; internal set; }
        /// <summary><p>Name or resource id of the function app service plan. Use 'appservice plan create' to get one.</p></summary>
        public virtual string Plan { get; internal set; }
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
              .Add("functionapp create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--storage-account {value}", StorageAccount)
              .Add("--consumption-plan-location {value}", ConsumptionPlanLocation)
              .Add("--deployment-container-image-name {value}", DeploymentContainerImageName)
              .Add("--deployment-local-git {value}", DeploymentLocalGit)
              .Add("--deployment-source-branch {value}", DeploymentSourceBranch)
              .Add("--deployment-source-url {value}", DeploymentSourceUrl)
              .Add("--plan {value}", Plan)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappDeleteSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp delete")
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
    #region AzureFunctionappListSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
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
              .Add("functionapp list")
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
    #region AzureFunctionappListConsumptionLocationsSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappListConsumptionLocationsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
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
              .Add("functionapp list-consumption-locations")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappRestartSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappRestartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp restart")
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
    #region AzureFunctionappShowSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp show")
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
    #region AzureFunctionappStartSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp start")
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
    #region AzureFunctionappStopSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappStopSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp stop")
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
    #region AzureFunctionappUpdateSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        public virtual string ForceString { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
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
              .Add("functionapp update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
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
    #region AzureFunctionappConfigSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
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
              .Add("functionapp config")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappDeploymentListPublishingProfilesSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentListPublishingProfilesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp deployment list-publishing-profiles")
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
    #region AzureFunctionappIdentityAssignSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappIdentityAssignSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Role name or id the managed identity will be assigned.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>The scope the managed identity has access to.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("functionapp identity assign")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappIdentityRemoveSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappIdentityRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp identity remove")
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
    #region AzureFunctionappIdentityShowSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappIdentityShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp identity show")
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
    #region AzureFunctionappConfigAppsettingsDeleteSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigAppsettingsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated app setting names.</p></summary>
        public virtual string SettingNames { get; internal set; }
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
              .Add("functionapp config appsettings delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--setting-names {value}", SettingNames)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappConfigAppsettingsListSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigAppsettingsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the webapp. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
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
              .Add("functionapp config appsettings list")
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
    #region AzureFunctionappConfigAppsettingsSetSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigAppsettingsSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        public virtual IReadOnlyDictionary<string, object> Settings => SettingsInternal.AsReadOnly();
        internal Dictionary<string, object> SettingsInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Space-separated slot app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        public virtual IReadOnlyDictionary<string, object> SlotSettings => SlotSettingsInternal.AsReadOnly();
        internal Dictionary<string, object> SlotSettingsInternal { get; set; } = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
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
              .Add("functionapp config appsettings set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--settings {value}", Settings, "{key}={value}", separator: ' ')
              .Add("--slot-settings {value}", SlotSettings, "{key}={value}", separator: ' ')
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappConfigHostnameAddSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigHostnameAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Hostname assigned to the site, such as custom domains.</p></summary>
        public virtual string Hostname { get; internal set; }
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp config hostname add")
              .Add("--hostname {value}", Hostname)
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
    #region AzureFunctionappConfigHostnameDeleteSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigHostnameDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Hostname assigned to the site, such as custom domains.</p></summary>
        public virtual string Hostname { get; internal set; }
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp config hostname delete")
              .Add("--hostname {value}", Hostname)
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
    #region AzureFunctionappConfigHostnameGetExternalIpSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigHostnameGetExternalIpSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp config hostname get-external-ip")
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
    #region AzureFunctionappConfigHostnameListSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigHostnameListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the webapp. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        public virtual string WebappName { get; internal set; }
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
              .Add("functionapp config hostname list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--webapp-name {value}", WebappName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappConfigSslBindSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigSslBindSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>The ssl cert thumbprint.</p></summary>
        public virtual string CertificateThumbprint { get; internal set; }
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The ssl cert type.</p></summary>
        public virtual FunctionappConfigSslBindSslType SslType { get; internal set; }
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
              .Add("functionapp config ssl bind")
              .Add("--certificate-thumbprint {value}", CertificateThumbprint)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--ssl-type {value}", SslType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappConfigSslDeleteSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigSslDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>The ssl cert thumbprint.</p></summary>
        public virtual string CertificateThumbprint { get; internal set; }
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
              .Add("functionapp config ssl delete")
              .Add("--certificate-thumbprint {value}", CertificateThumbprint)
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
    #region AzureFunctionappConfigSslListSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigSslListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
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
              .Add("functionapp config ssl list")
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
    #region AzureFunctionappConfigSslUnbindSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigSslUnbindSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>The ssl cert thumbprint.</p></summary>
        public virtual string CertificateThumbprint { get; internal set; }
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp config ssl unbind")
              .Add("--certificate-thumbprint {value}", CertificateThumbprint)
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
    #region AzureFunctionappConfigSslUploadSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappConfigSslUploadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>The filepath for the .pfx file.</p></summary>
        public virtual string CertificateFile { get; internal set; }
        /// <summary><p>The ssl cert password.</p></summary>
        public virtual string CertificatePassword { get; internal set; }
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp config ssl upload")
              .Add("--certificate-file {value}", CertificateFile)
              .Add("--certificate-password {value}", CertificatePassword, secret: true)
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
    #region AzureFunctionappDeploymentSourceConfigSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceConfigSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Repository url to pull the latest source from, e.g. <a href="https://github.com/foo/foo-web">https://github.com/foo/foo-web</a>.</p></summary>
        public virtual string RepoUrl { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The branch name of the repository.</p></summary>
        public virtual string Branch { get; internal set; }
        /// <summary><p>Git access token required for auto sync.</p></summary>
        public virtual string GitToken { get; internal set; }
        /// <summary><p>Disable automatic sync between source control and web.</p></summary>
        public virtual string ManualIntegration { get; internal set; }
        /// <summary><p>Repository type.</p></summary>
        public virtual FunctionappDeploymentSourceConfigRepositoryType RepositoryType { get; internal set; }
        /// <summary><p>Working directory of the application. Default will be root of the repo.</p></summary>
        public virtual string AppWorkingDir { get; internal set; }
        /// <summary><p>To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.</p></summary>
        public virtual string CdAccountCreate { get; internal set; }
        /// <summary><p>Web application framework you used to develop your app. Default is AspNet.</p></summary>
        public virtual FunctionappDeploymentSourceConfigCdAppType CdAppType { get; internal set; }
        /// <summary><p>URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&amp;lt;accountname&amp;gt;.visualstudio.com/&amp;lt;projectname&amp;gt;.</p></summary>
        public virtual string CdProjectUrl { get; internal set; }
        /// <summary><p>Task runner for nodejs. Default is None.</p></summary>
        public virtual FunctionappDeploymentSourceConfigNodejsTaskRunner NodejsTaskRunner { get; internal set; }
        /// <summary><p>Password for the private repository.</p></summary>
        public virtual string PrivateRepoPassword { get; internal set; }
        /// <summary><p>Username for the private repository.</p></summary>
        public virtual string PrivateRepoUsername { get; internal set; }
        /// <summary><p>Framework used for Python application. Default is Django.</p></summary>
        public virtual FunctionappDeploymentSourceConfigPythonFramework PythonFramework { get; internal set; }
        /// <summary><p>Python version used for application. Default is Python 3.5.3 x86.</p></summary>
        public virtual FunctionappDeploymentSourceConfigPythonVersion PythonVersion { get; internal set; }
        /// <summary><p>Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.</p></summary>
        public virtual string SlotSwap { get; internal set; }
        /// <summary><p>Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.</p></summary>
        public virtual string Test { get; internal set; }
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
              .Add("functionapp deployment source config")
              .Add("--name {value}", Name)
              .Add("--repo-url {value}", RepoUrl)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--branch {value}", Branch)
              .Add("--git-token {value}", GitToken)
              .Add("--manual-integration {value}", ManualIntegration)
              .Add("--repository-type {value}", RepositoryType)
              .Add("--app-working-dir {value}", AppWorkingDir)
              .Add("--cd-account-create {value}", CdAccountCreate)
              .Add("--cd-app-type {value}", CdAppType)
              .Add("--cd-project-url {value}", CdProjectUrl)
              .Add("--nodejs-task-runner {value}", NodejsTaskRunner)
              .Add("--private-repo-password {value}", PrivateRepoPassword, secret: true)
              .Add("--private-repo-username {value}", PrivateRepoUsername)
              .Add("--python-framework {value}", PythonFramework)
              .Add("--python-version {value}", PythonVersion)
              .Add("--slot-swap {value}", SlotSwap)
              .Add("--test {value}", Test)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappDeploymentSourceConfigLocalGitSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceConfigLocalGitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp deployment source config-local-git")
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
    #region AzureFunctionappDeploymentSourceConfigZipSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceConfigZipSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>A zip file path for deployment.</p></summary>
        public virtual string Src { get; internal set; }
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
              .Add("functionapp deployment source config-zip")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--src {value}", Src)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappDeploymentSourceDeleteSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp deployment source delete")
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
    #region AzureFunctionappDeploymentSourceShowSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp deployment source show")
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
    #region AzureFunctionappDeploymentSourceSyncSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceSyncSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Name of the function app.</p></summary>
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
              .Add("functionapp deployment source sync")
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
    #region AzureFunctionappDeploymentSourceUpdateTokenSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentSourceUpdateTokenSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>Git access token required for auto sync.</p></summary>
        public virtual string GitToken { get; internal set; }
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
              .Add("functionapp deployment source update-token")
              .Add("--git-token {value}", GitToken)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappDeploymentUserSetSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentUserSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
        /// <summary><p>User name.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>Password, will prompt if not specified.</p></summary>
        public virtual string Password { get; internal set; }
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
              .Add("functionapp deployment user set")
              .Add("--user-name {value}", UserName)
              .Add("--password {value}", Password, secret: true)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappDeploymentUserShowSettings
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFunctionappDeploymentUserShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFunctionapp executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFunctionappTasks.AzureFunctionappPath;
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
              .Add("functionapp deployment user show")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFunctionappCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetName(this AzureFunctionappCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetName(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetResourceGroup(this AzureFunctionappCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetResourceGroup(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region StorageAccount
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.StorageAccount"/>.</em></p><p>Provide a string value of a Storage Account in the provided Resource Group. Or Resource ID of a Storage Account in a different Resource Group.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetStorageAccount(this AzureFunctionappCreateSettings toolSettings, string storageAccount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = storageAccount;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.StorageAccount"/>.</em></p><p>Provide a string value of a Storage Account in the provided Resource Group. Or Resource ID of a Storage Account in a different Resource Group.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetStorageAccount(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageAccount = null;
            return toolSettings;
        }
        #endregion
        #region ConsumptionPlanLocation
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.ConsumptionPlanLocation"/>.</em></p><p>Geographic location where Function App will be hosted. Use 'functionapp list-consumption-locations' to view available locations.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetConsumptionPlanLocation(this AzureFunctionappCreateSettings toolSettings, string consumptionPlanLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConsumptionPlanLocation = consumptionPlanLocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.ConsumptionPlanLocation"/>.</em></p><p>Geographic location where Function App will be hosted. Use 'functionapp list-consumption-locations' to view available locations.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetConsumptionPlanLocation(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConsumptionPlanLocation = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentContainerImageName
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.DeploymentContainerImageName"/>.</em></p><p>Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetDeploymentContainerImageName(this AzureFunctionappCreateSettings toolSettings, string deploymentContainerImageName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentContainerImageName = deploymentContainerImageName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.DeploymentContainerImageName"/>.</em></p><p>Linux only. Container image name from Docker Hub, e.g. publisher/image-name:tag.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetDeploymentContainerImageName(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentContainerImageName = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentLocalGit
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.DeploymentLocalGit"/>.</em></p><p>Enable local git.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetDeploymentLocalGit(this AzureFunctionappCreateSettings toolSettings, string deploymentLocalGit)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentLocalGit = deploymentLocalGit;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.DeploymentLocalGit"/>.</em></p><p>Enable local git.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetDeploymentLocalGit(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentLocalGit = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentSourceBranch
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.DeploymentSourceBranch"/>.</em></p><p>The branch to deploy.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetDeploymentSourceBranch(this AzureFunctionappCreateSettings toolSettings, string deploymentSourceBranch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceBranch = deploymentSourceBranch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.DeploymentSourceBranch"/>.</em></p><p>The branch to deploy.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetDeploymentSourceBranch(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceBranch = null;
            return toolSettings;
        }
        #endregion
        #region DeploymentSourceUrl
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.DeploymentSourceUrl"/>.</em></p><p>Git repository URL to link with manual integration.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetDeploymentSourceUrl(this AzureFunctionappCreateSettings toolSettings, string deploymentSourceUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceUrl = deploymentSourceUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.DeploymentSourceUrl"/>.</em></p><p>Git repository URL to link with manual integration.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetDeploymentSourceUrl(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DeploymentSourceUrl = null;
            return toolSettings;
        }
        #endregion
        #region Plan
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Plan"/>.</em></p><p>Name or resource id of the function app service plan. Use 'appservice plan create' to get one.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetPlan(this AzureFunctionappCreateSettings toolSettings, string plan)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = plan;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Plan"/>.</em></p><p>Name or resource id of the function app service plan. Use 'appservice plan create' to get one.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetPlan(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plan = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetDebug(this AzureFunctionappCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetDebug(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetHelp(this AzureFunctionappCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetHelp(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetOutput(this AzureFunctionappCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetOutput(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetQuery(this AzureFunctionappCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetQuery(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings SetVerbose(this AzureFunctionappCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappCreateSettings ResetVerbose(this AzureFunctionappCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetName(this AzureFunctionappDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetName(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetResourceGroup(this AzureFunctionappDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetResourceGroup(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetDebug(this AzureFunctionappDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetDebug(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetHelp(this AzureFunctionappDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetHelp(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetOutput(this AzureFunctionappDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetOutput(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetQuery(this AzureFunctionappDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetQuery(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings SetVerbose(this AzureFunctionappDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeleteSettings ResetVerbose(this AzureFunctionappDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings SetResourceGroup(this AzureFunctionappListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings ResetResourceGroup(this AzureFunctionappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings SetDebug(this AzureFunctionappListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings ResetDebug(this AzureFunctionappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings SetHelp(this AzureFunctionappListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings ResetHelp(this AzureFunctionappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings SetOutput(this AzureFunctionappListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings ResetOutput(this AzureFunctionappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings SetQuery(this AzureFunctionappListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings ResetQuery(this AzureFunctionappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings SetVerbose(this AzureFunctionappListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListSettings ResetVerbose(this AzureFunctionappListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappListConsumptionLocationsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappListConsumptionLocationsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappListConsumptionLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings SetDebug(this AzureFunctionappListConsumptionLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListConsumptionLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings ResetDebug(this AzureFunctionappListConsumptionLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappListConsumptionLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings SetHelp(this AzureFunctionappListConsumptionLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListConsumptionLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings ResetHelp(this AzureFunctionappListConsumptionLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappListConsumptionLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings SetOutput(this AzureFunctionappListConsumptionLocationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListConsumptionLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings ResetOutput(this AzureFunctionappListConsumptionLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappListConsumptionLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings SetQuery(this AzureFunctionappListConsumptionLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListConsumptionLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings ResetQuery(this AzureFunctionappListConsumptionLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappListConsumptionLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings SetVerbose(this AzureFunctionappListConsumptionLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappListConsumptionLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappListConsumptionLocationsSettings ResetVerbose(this AzureFunctionappListConsumptionLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappRestartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappRestartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetName(this AzureFunctionappRestartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetName(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetResourceGroup(this AzureFunctionappRestartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetResourceGroup(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetDebug(this AzureFunctionappRestartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetDebug(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetHelp(this AzureFunctionappRestartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetHelp(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetOutput(this AzureFunctionappRestartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetOutput(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetQuery(this AzureFunctionappRestartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetQuery(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings SetVerbose(this AzureFunctionappRestartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappRestartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappRestartSettings ResetVerbose(this AzureFunctionappRestartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetName(this AzureFunctionappShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetName(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetResourceGroup(this AzureFunctionappShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetResourceGroup(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetDebug(this AzureFunctionappShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetDebug(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetHelp(this AzureFunctionappShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetHelp(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetOutput(this AzureFunctionappShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetOutput(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetQuery(this AzureFunctionappShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetQuery(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings SetVerbose(this AzureFunctionappShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappShowSettings ResetVerbose(this AzureFunctionappShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappStartSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetName(this AzureFunctionappStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetName(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetResourceGroup(this AzureFunctionappStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetResourceGroup(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetDebug(this AzureFunctionappStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetDebug(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetHelp(this AzureFunctionappStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetHelp(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetOutput(this AzureFunctionappStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetOutput(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetQuery(this AzureFunctionappStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetQuery(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings SetVerbose(this AzureFunctionappStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStartSettings ResetVerbose(this AzureFunctionappStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappStopSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappStopSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetName(this AzureFunctionappStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetName(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetResourceGroup(this AzureFunctionappStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetResourceGroup(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetDebug(this AzureFunctionappStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetDebug(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetHelp(this AzureFunctionappStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetHelp(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetOutput(this AzureFunctionappStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetOutput(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetQuery(this AzureFunctionappStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetQuery(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings SetVerbose(this AzureFunctionappStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappStopSettings ResetVerbose(this AzureFunctionappStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetName(this AzureFunctionappUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetName(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetResourceGroup(this AzureFunctionappUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetResourceGroup(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetAdd(this AzureFunctionappUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetAdd(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetForceString(this AzureFunctionappUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetForceString(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetRemove(this AzureFunctionappUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetRemove(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetSet(this AzureFunctionappUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetSet(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetDebug(this AzureFunctionappUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetDebug(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetHelp(this AzureFunctionappUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetHelp(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetOutput(this AzureFunctionappUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetOutput(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetQuery(this AzureFunctionappUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetQuery(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings SetVerbose(this AzureFunctionappUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappUpdateSettings ResetVerbose(this AzureFunctionappUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings SetDebug(this AzureFunctionappConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings ResetDebug(this AzureFunctionappConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings SetHelp(this AzureFunctionappConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings ResetHelp(this AzureFunctionappConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings SetOutput(this AzureFunctionappConfigSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings ResetOutput(this AzureFunctionappConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings SetQuery(this AzureFunctionappConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings ResetQuery(this AzureFunctionappConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings SetVerbose(this AzureFunctionappConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSettings ResetVerbose(this AzureFunctionappConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentListPublishingProfilesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentListPublishingProfilesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetName(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetName(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetResourceGroup(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetResourceGroup(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetDebug(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetDebug(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetHelp(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetHelp(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetOutput(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetOutput(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetQuery(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetQuery(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings SetVerbose(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentListPublishingProfilesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentListPublishingProfilesSettings ResetVerbose(this AzureFunctionappDeploymentListPublishingProfilesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappIdentityAssignSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappIdentityAssignSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetName(this AzureFunctionappIdentityAssignSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetName(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetResourceGroup(this AzureFunctionappIdentityAssignSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetResourceGroup(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the managed identity will be assigned.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetRole(this AzureFunctionappIdentityAssignSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Role"/>.</em></p><p>Role name or id the managed identity will be assigned.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetRole(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Scope"/>.</em></p><p>The scope the managed identity has access to.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetScope(this AzureFunctionappIdentityAssignSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Scope"/>.</em></p><p>The scope the managed identity has access to.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetScope(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetDebug(this AzureFunctionappIdentityAssignSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetDebug(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetHelp(this AzureFunctionappIdentityAssignSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetHelp(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetOutput(this AzureFunctionappIdentityAssignSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetOutput(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetQuery(this AzureFunctionappIdentityAssignSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetQuery(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings SetVerbose(this AzureFunctionappIdentityAssignSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityAssignSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityAssignSettings ResetVerbose(this AzureFunctionappIdentityAssignSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappIdentityRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappIdentityRemoveSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetName(this AzureFunctionappIdentityRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetName(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetResourceGroup(this AzureFunctionappIdentityRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetResourceGroup(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetDebug(this AzureFunctionappIdentityRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetDebug(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetHelp(this AzureFunctionappIdentityRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetHelp(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetOutput(this AzureFunctionappIdentityRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetOutput(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetQuery(this AzureFunctionappIdentityRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetQuery(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings SetVerbose(this AzureFunctionappIdentityRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityRemoveSettings ResetVerbose(this AzureFunctionappIdentityRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappIdentityShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappIdentityShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetName(this AzureFunctionappIdentityShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetName(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetResourceGroup(this AzureFunctionappIdentityShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetResourceGroup(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetDebug(this AzureFunctionappIdentityShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetDebug(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetHelp(this AzureFunctionappIdentityShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetHelp(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetOutput(this AzureFunctionappIdentityShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetOutput(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetQuery(this AzureFunctionappIdentityShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetQuery(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings SetVerbose(this AzureFunctionappIdentityShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappIdentityShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappIdentityShowSettings ResetVerbose(this AzureFunctionappIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigAppsettingsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigAppsettingsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetName(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetName(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetResourceGroup(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetResourceGroup(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SettingNames
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.SettingNames"/>.</em></p><p>Space-separated app setting names.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetSettingNames(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string settingNames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingNames = settingNames;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.SettingNames"/>.</em></p><p>Space-separated app setting names.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetSettingNames(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingNames = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetDebug(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetDebug(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetHelp(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetHelp(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetOutput(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetOutput(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetQuery(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetQuery(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings SetVerbose(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsDeleteSettings ResetVerbose(this AzureFunctionappConfigAppsettingsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigAppsettingsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigAppsettingsListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.Name"/>.</em></p><p>Name of the webapp. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetName(this AzureFunctionappConfigAppsettingsListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.Name"/>.</em></p><p>Name of the webapp. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetName(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetResourceGroup(this AzureFunctionappConfigAppsettingsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetResourceGroup(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetDebug(this AzureFunctionappConfigAppsettingsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetDebug(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetHelp(this AzureFunctionappConfigAppsettingsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetHelp(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetOutput(this AzureFunctionappConfigAppsettingsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetOutput(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetQuery(this AzureFunctionappConfigAppsettingsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetQuery(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings SetVerbose(this AzureFunctionappConfigAppsettingsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsListSettings ResetVerbose(this AzureFunctionappConfigAppsettingsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigAppsettingsSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigAppsettingsSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetName(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetName(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetResourceGroup(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetResourceGroup(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Settings
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Settings"/> to a new dictionary.</em></p><p>Space-separated app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetSettings(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, IDictionary<string, object> settings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsInternal = settings.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureFunctionappConfigAppsettingsSetSettings.Settings"/>.</em></p><p>Space-separated app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ClearSettings(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="AzureFunctionappConfigAppsettingsSetSettings.Settings"/>.</em></p><p>Space-separated app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings AddSetting(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string settingKey, object settingValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsInternal.Add(settingKey, settingValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="AzureFunctionappConfigAppsettingsSetSettings.Settings"/>.</em></p><p>Space-separated app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings RemoveSetting(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string settingKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsInternal.Remove(settingKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="AzureFunctionappConfigAppsettingsSetSettings.Settings"/>.</em></p><p>Space-separated app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetSetting(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string settingKey, object settingValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingsInternal[settingKey] = settingValue;
            return toolSettings;
        }
        #endregion
        #region SlotSettings
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.SlotSettings"/> to a new dictionary.</em></p><p>Space-separated slot app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetSlotSettings(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, IDictionary<string, object> slotSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettingsInternal = slotSettings.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureFunctionappConfigAppsettingsSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ClearSlotSettings(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettingsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="AzureFunctionappConfigAppsettingsSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings AddSlotSetting(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string slotSettingKey, object slotSettingValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettingsInternal.Add(slotSettingKey, slotSettingValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="AzureFunctionappConfigAppsettingsSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings RemoveSlotSetting(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string slotSettingKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettingsInternal.Remove(slotSettingKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="AzureFunctionappConfigAppsettingsSetSettings.SlotSettings"/>.</em></p><p>Space-separated slot app settings in a format of &lt;name&gt;=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetSlotSetting(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string slotSettingKey, object slotSettingValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSettingsInternal[slotSettingKey] = slotSettingValue;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetDebug(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetDebug(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetHelp(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetHelp(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetOutput(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetOutput(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetQuery(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetQuery(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings SetVerbose(this AzureFunctionappConfigAppsettingsSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigAppsettingsSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigAppsettingsSetSettings ResetVerbose(this AzureFunctionappConfigAppsettingsSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigHostnameAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigHostnameAddSettingsExtensions
    {
        #region Hostname
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetHostname(this AzureFunctionappConfigHostnameAddSettings toolSettings, string hostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = hostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetHostname(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetName(this AzureFunctionappConfigHostnameAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetName(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetResourceGroup(this AzureFunctionappConfigHostnameAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetResourceGroup(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetDebug(this AzureFunctionappConfigHostnameAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetDebug(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetHelp(this AzureFunctionappConfigHostnameAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetHelp(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetOutput(this AzureFunctionappConfigHostnameAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetOutput(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetQuery(this AzureFunctionappConfigHostnameAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetQuery(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings SetVerbose(this AzureFunctionappConfigHostnameAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameAddSettings ResetVerbose(this AzureFunctionappConfigHostnameAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigHostnameDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigHostnameDeleteSettingsExtensions
    {
        #region Hostname
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetHostname(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string hostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = hostname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Hostname"/>.</em></p><p>Hostname assigned to the site, such as custom domains.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetHostname(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetName(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetName(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetResourceGroup(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetResourceGroup(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetDebug(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetDebug(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetHelp(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetHelp(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetOutput(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetOutput(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetQuery(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetQuery(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings SetVerbose(this AzureFunctionappConfigHostnameDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameDeleteSettings ResetVerbose(this AzureFunctionappConfigHostnameDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigHostnameGetExternalIpSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigHostnameGetExternalIpSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetName(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetName(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetResourceGroup(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetResourceGroup(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetDebug(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetDebug(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetHelp(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetHelp(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetOutput(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetOutput(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetQuery(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetQuery(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings SetVerbose(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameGetExternalIpSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameGetExternalIpSettings ResetVerbose(this AzureFunctionappConfigHostnameGetExternalIpSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigHostnameListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigHostnameListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetResourceGroup(this AzureFunctionappConfigHostnameListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetResourceGroup(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WebappName
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.WebappName"/>.</em></p><p>Name of the webapp. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetWebappName(this AzureFunctionappConfigHostnameListSettings toolSettings, string webappName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = webappName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.WebappName"/>.</em></p><p>Name of the webapp. You can configure the default using 'az configure --defaults web=&lt;name&gt;'.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetWebappName(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WebappName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetDebug(this AzureFunctionappConfigHostnameListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetDebug(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetHelp(this AzureFunctionappConfigHostnameListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetHelp(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetOutput(this AzureFunctionappConfigHostnameListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetOutput(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetQuery(this AzureFunctionappConfigHostnameListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetQuery(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigHostnameListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings SetVerbose(this AzureFunctionappConfigHostnameListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigHostnameListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigHostnameListSettings ResetVerbose(this AzureFunctionappConfigHostnameListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigSslBindSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigSslBindSettingsExtensions
    {
        #region CertificateThumbprint
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetCertificateThumbprint(this AzureFunctionappConfigSslBindSettings toolSettings, string certificateThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = certificateThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetCertificateThumbprint(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetName(this AzureFunctionappConfigSslBindSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetName(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetResourceGroup(this AzureFunctionappConfigSslBindSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetResourceGroup(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SslType
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.SslType"/>.</em></p><p>The ssl cert type.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetSslType(this AzureFunctionappConfigSslBindSettings toolSettings, FunctionappConfigSslBindSslType sslType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslType = sslType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.SslType"/>.</em></p><p>The ssl cert type.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetSslType(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetDebug(this AzureFunctionappConfigSslBindSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetDebug(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetHelp(this AzureFunctionappConfigSslBindSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetHelp(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetOutput(this AzureFunctionappConfigSslBindSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetOutput(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetQuery(this AzureFunctionappConfigSslBindSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetQuery(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslBindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings SetVerbose(this AzureFunctionappConfigSslBindSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslBindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslBindSettings ResetVerbose(this AzureFunctionappConfigSslBindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigSslDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigSslDeleteSettingsExtensions
    {
        #region CertificateThumbprint
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetCertificateThumbprint(this AzureFunctionappConfigSslDeleteSettings toolSettings, string certificateThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = certificateThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetCertificateThumbprint(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetResourceGroup(this AzureFunctionappConfigSslDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetResourceGroup(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetDebug(this AzureFunctionappConfigSslDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetDebug(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetHelp(this AzureFunctionappConfigSslDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetHelp(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetOutput(this AzureFunctionappConfigSslDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetOutput(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetQuery(this AzureFunctionappConfigSslDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetQuery(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings SetVerbose(this AzureFunctionappConfigSslDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslDeleteSettings ResetVerbose(this AzureFunctionappConfigSslDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigSslListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigSslListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings SetResourceGroup(this AzureFunctionappConfigSslListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings ResetResourceGroup(this AzureFunctionappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings SetDebug(this AzureFunctionappConfigSslListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings ResetDebug(this AzureFunctionappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings SetHelp(this AzureFunctionappConfigSslListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings ResetHelp(this AzureFunctionappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings SetOutput(this AzureFunctionappConfigSslListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings ResetOutput(this AzureFunctionappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings SetQuery(this AzureFunctionappConfigSslListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings ResetQuery(this AzureFunctionappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings SetVerbose(this AzureFunctionappConfigSslListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslListSettings ResetVerbose(this AzureFunctionappConfigSslListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigSslUnbindSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigSslUnbindSettingsExtensions
    {
        #region CertificateThumbprint
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetCertificateThumbprint(this AzureFunctionappConfigSslUnbindSettings toolSettings, string certificateThumbprint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = certificateThumbprint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.CertificateThumbprint"/>.</em></p><p>The ssl cert thumbprint.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetCertificateThumbprint(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateThumbprint = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetName(this AzureFunctionappConfigSslUnbindSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetName(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetResourceGroup(this AzureFunctionappConfigSslUnbindSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetResourceGroup(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetDebug(this AzureFunctionappConfigSslUnbindSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetDebug(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetHelp(this AzureFunctionappConfigSslUnbindSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetHelp(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetOutput(this AzureFunctionappConfigSslUnbindSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetOutput(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetQuery(this AzureFunctionappConfigSslUnbindSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetQuery(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUnbindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings SetVerbose(this AzureFunctionappConfigSslUnbindSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUnbindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUnbindSettings ResetVerbose(this AzureFunctionappConfigSslUnbindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappConfigSslUploadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappConfigSslUploadSettingsExtensions
    {
        #region CertificateFile
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.CertificateFile"/>.</em></p><p>The filepath for the .pfx file.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetCertificateFile(this AzureFunctionappConfigSslUploadSettings toolSettings, string certificateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = certificateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.CertificateFile"/>.</em></p><p>The filepath for the .pfx file.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetCertificateFile(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificateFile = null;
            return toolSettings;
        }
        #endregion
        #region CertificatePassword
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.CertificatePassword"/>.</em></p><p>The ssl cert password.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetCertificatePassword(this AzureFunctionappConfigSslUploadSettings toolSettings, string certificatePassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = certificatePassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.CertificatePassword"/>.</em></p><p>The ssl cert password.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetCertificatePassword(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CertificatePassword = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetName(this AzureFunctionappConfigSslUploadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetName(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetResourceGroup(this AzureFunctionappConfigSslUploadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetResourceGroup(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetDebug(this AzureFunctionappConfigSslUploadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetDebug(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetHelp(this AzureFunctionappConfigSslUploadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetHelp(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetOutput(this AzureFunctionappConfigSslUploadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetOutput(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetQuery(this AzureFunctionappConfigSslUploadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetQuery(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappConfigSslUploadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings SetVerbose(this AzureFunctionappConfigSslUploadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappConfigSslUploadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappConfigSslUploadSettings ResetVerbose(this AzureFunctionappConfigSslUploadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceConfigSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceConfigSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetName(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetName(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region RepoUrl
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.RepoUrl"/>.</em></p><p>Repository url to pull the latest source from, e.g. <a href="https://github.com/foo/foo-web">https://github.com/foo/foo-web</a>.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetRepoUrl(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string repoUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepoUrl = repoUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.RepoUrl"/>.</em></p><p>Repository url to pull the latest source from, e.g. <a href="https://github.com/foo/foo-web">https://github.com/foo/foo-web</a>.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetRepoUrl(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepoUrl = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetResourceGroup(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetResourceGroup(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Branch
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Branch"/>.</em></p><p>The branch name of the repository.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetBranch(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string branch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = branch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Branch"/>.</em></p><p>The branch name of the repository.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetBranch(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Branch = null;
            return toolSettings;
        }
        #endregion
        #region GitToken
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetGitToken(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string gitToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = gitToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetGitToken(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = null;
            return toolSettings;
        }
        #endregion
        #region ManualIntegration
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.ManualIntegration"/>.</em></p><p>Disable automatic sync between source control and web.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetManualIntegration(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string manualIntegration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManualIntegration = manualIntegration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.ManualIntegration"/>.</em></p><p>Disable automatic sync between source control and web.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetManualIntegration(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ManualIntegration = null;
            return toolSettings;
        }
        #endregion
        #region RepositoryType
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.RepositoryType"/>.</em></p><p>Repository type.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetRepositoryType(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, FunctionappDeploymentSourceConfigRepositoryType repositoryType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepositoryType = repositoryType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.RepositoryType"/>.</em></p><p>Repository type.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetRepositoryType(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RepositoryType = null;
            return toolSettings;
        }
        #endregion
        #region AppWorkingDir
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.AppWorkingDir"/>.</em></p><p>Working directory of the application. Default will be root of the repo.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetAppWorkingDir(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string appWorkingDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppWorkingDir = appWorkingDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.AppWorkingDir"/>.</em></p><p>Working directory of the application. Default will be root of the repo.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetAppWorkingDir(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppWorkingDir = null;
            return toolSettings;
        }
        #endregion
        #region CdAccountCreate
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.CdAccountCreate"/>.</em></p><p>To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetCdAccountCreate(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string cdAccountCreate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAccountCreate = cdAccountCreate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.CdAccountCreate"/>.</em></p><p>To create a new Visual Studio Team Services (VSTS) account if it doesn't exist already.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetCdAccountCreate(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAccountCreate = null;
            return toolSettings;
        }
        #endregion
        #region CdAppType
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.CdAppType"/>.</em></p><p>Web application framework you used to develop your app. Default is AspNet.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetCdAppType(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, FunctionappDeploymentSourceConfigCdAppType cdAppType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAppType = cdAppType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.CdAppType"/>.</em></p><p>Web application framework you used to develop your app. Default is AspNet.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetCdAppType(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdAppType = null;
            return toolSettings;
        }
        #endregion
        #region CdProjectUrl
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.CdProjectUrl"/>.</em></p><p>URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&amp;lt;accountname&amp;gt;.visualstudio.com/&amp;lt;projectname&amp;gt;.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetCdProjectUrl(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string cdProjectUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdProjectUrl = cdProjectUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.CdProjectUrl"/>.</em></p><p>URL of the Visual Studio Team Services (VSTS) project to use for continuous delivery. URL should be in format https://&amp;lt;accountname&amp;gt;.visualstudio.com/&amp;lt;projectname&amp;gt;.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetCdProjectUrl(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CdProjectUrl = null;
            return toolSettings;
        }
        #endregion
        #region NodejsTaskRunner
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.NodejsTaskRunner"/>.</em></p><p>Task runner for nodejs. Default is None.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetNodejsTaskRunner(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, FunctionappDeploymentSourceConfigNodejsTaskRunner nodejsTaskRunner)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodejsTaskRunner = nodejsTaskRunner;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.NodejsTaskRunner"/>.</em></p><p>Task runner for nodejs. Default is None.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetNodejsTaskRunner(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodejsTaskRunner = null;
            return toolSettings;
        }
        #endregion
        #region PrivateRepoPassword
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PrivateRepoPassword"/>.</em></p><p>Password for the private repository.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetPrivateRepoPassword(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string privateRepoPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoPassword = privateRepoPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PrivateRepoPassword"/>.</em></p><p>Password for the private repository.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetPrivateRepoPassword(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoPassword = null;
            return toolSettings;
        }
        #endregion
        #region PrivateRepoUsername
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PrivateRepoUsername"/>.</em></p><p>Username for the private repository.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetPrivateRepoUsername(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string privateRepoUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoUsername = privateRepoUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PrivateRepoUsername"/>.</em></p><p>Username for the private repository.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetPrivateRepoUsername(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PrivateRepoUsername = null;
            return toolSettings;
        }
        #endregion
        #region PythonFramework
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PythonFramework"/>.</em></p><p>Framework used for Python application. Default is Django.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetPythonFramework(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, FunctionappDeploymentSourceConfigPythonFramework pythonFramework)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonFramework = pythonFramework;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PythonFramework"/>.</em></p><p>Framework used for Python application. Default is Django.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetPythonFramework(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonFramework = null;
            return toolSettings;
        }
        #endregion
        #region PythonVersion
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PythonVersion"/>.</em></p><p>Python version used for application. Default is Python 3.5.3 x86.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetPythonVersion(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, FunctionappDeploymentSourceConfigPythonVersion pythonVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonVersion = pythonVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.PythonVersion"/>.</em></p><p>Python version used for application. Default is Python 3.5.3 x86.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetPythonVersion(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PythonVersion = null;
            return toolSettings;
        }
        #endregion
        #region SlotSwap
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.SlotSwap"/>.</em></p><p>Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetSlotSwap(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string slotSwap)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSwap = slotSwap;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.SlotSwap"/>.</em></p><p>Name of the slot to be used for deployment and later promote to production. If slot is not available, it will be created. Default: Not configured.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetSlotSwap(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlotSwap = null;
            return toolSettings;
        }
        #endregion
        #region Test
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Test"/>.</em></p><p>Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetTest(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string test)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Test = test;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Test"/>.</em></p><p>Name of the web app to be used for load testing. If web app is not available, it will be created. Default: Disable.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetTest(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Test = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetDebug(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetDebug(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetHelp(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetHelp(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetOutput(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetOutput(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetQuery(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetQuery(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings SetVerbose(this AzureFunctionappDeploymentSourceConfigSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigSettings ResetVerbose(this AzureFunctionappDeploymentSourceConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceConfigLocalGitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceConfigLocalGitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetName(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetName(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetResourceGroup(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetResourceGroup(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetDebug(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetDebug(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetHelp(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetHelp(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetOutput(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetOutput(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetQuery(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetQuery(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings SetVerbose(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigLocalGitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigLocalGitSettings ResetVerbose(this AzureFunctionappDeploymentSourceConfigLocalGitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceConfigZipSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceConfigZipSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetName(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetName(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetResourceGroup(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetResourceGroup(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Src
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Src"/>.</em></p><p>A zip file path for deployment.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetSrc(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string src)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Src = src;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Src"/>.</em></p><p>A zip file path for deployment.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetSrc(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Src = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetDebug(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetDebug(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetHelp(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetHelp(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetOutput(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetOutput(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetQuery(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetQuery(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings SetVerbose(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceConfigZipSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceConfigZipSettings ResetVerbose(this AzureFunctionappDeploymentSourceConfigZipSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetName(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetName(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetResourceGroup(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetResourceGroup(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetDebug(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetDebug(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetHelp(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetHelp(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetOutput(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetOutput(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetQuery(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetQuery(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings SetVerbose(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceDeleteSettings ResetVerbose(this AzureFunctionappDeploymentSourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetName(this AzureFunctionappDeploymentSourceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetName(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetResourceGroup(this AzureFunctionappDeploymentSourceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetResourceGroup(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetDebug(this AzureFunctionappDeploymentSourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetDebug(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetHelp(this AzureFunctionappDeploymentSourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetHelp(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetOutput(this AzureFunctionappDeploymentSourceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetOutput(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetQuery(this AzureFunctionappDeploymentSourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetQuery(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings SetVerbose(this AzureFunctionappDeploymentSourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceShowSettings ResetVerbose(this AzureFunctionappDeploymentSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceSyncSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceSyncSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetName(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Name"/>.</em></p><p>Name of the function app.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetName(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetResourceGroup(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetResourceGroup(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetDebug(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetDebug(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetHelp(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetHelp(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetOutput(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetOutput(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetQuery(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetQuery(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings SetVerbose(this AzureFunctionappDeploymentSourceSyncSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceSyncSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceSyncSettings ResetVerbose(this AzureFunctionappDeploymentSourceSyncSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentSourceUpdateTokenSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentSourceUpdateTokenSettingsExtensions
    {
        #region GitToken
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings SetGitToken(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings, string gitToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = gitToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.GitToken"/>.</em></p><p>Git access token required for auto sync.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings ResetGitToken(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GitToken = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings SetDebug(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings ResetDebug(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings SetHelp(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings ResetHelp(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings SetOutput(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings ResetOutput(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings SetQuery(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings ResetQuery(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings SetVerbose(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentSourceUpdateTokenSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentSourceUpdateTokenSettings ResetVerbose(this AzureFunctionappDeploymentSourceUpdateTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentUserSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentUserSetSettingsExtensions
    {
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.UserName"/>.</em></p><p>User name.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetUserName(this AzureFunctionappDeploymentUserSetSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.UserName"/>.</em></p><p>User name.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetUserName(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.Password"/>.</em></p><p>Password, will prompt if not specified.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetPassword(this AzureFunctionappDeploymentUserSetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.Password"/>.</em></p><p>Password, will prompt if not specified.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetPassword(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetDebug(this AzureFunctionappDeploymentUserSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetDebug(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetHelp(this AzureFunctionappDeploymentUserSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetHelp(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetOutput(this AzureFunctionappDeploymentUserSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetOutput(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetQuery(this AzureFunctionappDeploymentUserSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetQuery(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings SetVerbose(this AzureFunctionappDeploymentUserSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserSetSettings ResetVerbose(this AzureFunctionappDeploymentUserSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFunctionappDeploymentUserShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFunctionappDeploymentUserShowSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings SetDebug(this AzureFunctionappDeploymentUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings ResetDebug(this AzureFunctionappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings SetHelp(this AzureFunctionappDeploymentUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings ResetHelp(this AzureFunctionappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings SetOutput(this AzureFunctionappDeploymentUserShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings ResetOutput(this AzureFunctionappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings SetQuery(this AzureFunctionappDeploymentUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings ResetQuery(this AzureFunctionappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFunctionappDeploymentUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings SetVerbose(this AzureFunctionappDeploymentUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFunctionappDeploymentUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFunctionappDeploymentUserShowSettings ResetVerbose(this AzureFunctionappDeploymentUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region FunctionappConfigSslBindSslType
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class FunctionappConfigSslBindSslType : Enumeration
    {
        public static FunctionappConfigSslBindSslType ip = new FunctionappConfigSslBindSslType { Value = "ip" };
        public static FunctionappConfigSslBindSslType sni = new FunctionappConfigSslBindSslType { Value = "sni" };
    }
    #endregion
    #region FunctionappDeploymentSourceConfigRepositoryType
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class FunctionappDeploymentSourceConfigRepositoryType : Enumeration
    {
        public static FunctionappDeploymentSourceConfigRepositoryType externalgit = new FunctionappDeploymentSourceConfigRepositoryType { Value = "externalgit" };
        public static FunctionappDeploymentSourceConfigRepositoryType git = new FunctionappDeploymentSourceConfigRepositoryType { Value = "git" };
        public static FunctionappDeploymentSourceConfigRepositoryType github = new FunctionappDeploymentSourceConfigRepositoryType { Value = "github" };
        public static FunctionappDeploymentSourceConfigRepositoryType localgit = new FunctionappDeploymentSourceConfigRepositoryType { Value = "localgit" };
        public static FunctionappDeploymentSourceConfigRepositoryType mercurial = new FunctionappDeploymentSourceConfigRepositoryType { Value = "mercurial" };
        public static FunctionappDeploymentSourceConfigRepositoryType vsts = new FunctionappDeploymentSourceConfigRepositoryType { Value = "vsts" };
    }
    #endregion
    #region FunctionappDeploymentSourceConfigCdAppType
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class FunctionappDeploymentSourceConfigCdAppType : Enumeration
    {
        public static FunctionappDeploymentSourceConfigCdAppType aspnet = new FunctionappDeploymentSourceConfigCdAppType { Value = "aspnet" };
        public static FunctionappDeploymentSourceConfigCdAppType aspnetcore = new FunctionappDeploymentSourceConfigCdAppType { Value = "aspnetcore" };
        public static FunctionappDeploymentSourceConfigCdAppType nodejs = new FunctionappDeploymentSourceConfigCdAppType { Value = "nodejs" };
        public static FunctionappDeploymentSourceConfigCdAppType php = new FunctionappDeploymentSourceConfigCdAppType { Value = "php" };
        public static FunctionappDeploymentSourceConfigCdAppType python = new FunctionappDeploymentSourceConfigCdAppType { Value = "python" };
    }
    #endregion
    #region FunctionappDeploymentSourceConfigNodejsTaskRunner
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class FunctionappDeploymentSourceConfigNodejsTaskRunner : Enumeration
    {
        public static FunctionappDeploymentSourceConfigNodejsTaskRunner grunt = new FunctionappDeploymentSourceConfigNodejsTaskRunner { Value = "grunt" };
        public static FunctionappDeploymentSourceConfigNodejsTaskRunner gulp = new FunctionappDeploymentSourceConfigNodejsTaskRunner { Value = "gulp" };
        public static FunctionappDeploymentSourceConfigNodejsTaskRunner none = new FunctionappDeploymentSourceConfigNodejsTaskRunner { Value = "none" };
    }
    #endregion
    #region FunctionappDeploymentSourceConfigPythonFramework
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class FunctionappDeploymentSourceConfigPythonFramework : Enumeration
    {
        public static FunctionappDeploymentSourceConfigPythonFramework bottle = new FunctionappDeploymentSourceConfigPythonFramework { Value = "bottle" };
        public static FunctionappDeploymentSourceConfigPythonFramework django = new FunctionappDeploymentSourceConfigPythonFramework { Value = "django" };
        public static FunctionappDeploymentSourceConfigPythonFramework flask = new FunctionappDeploymentSourceConfigPythonFramework { Value = "flask" };
    }
    #endregion
    #region FunctionappDeploymentSourceConfigPythonVersion
    /// <summary><p>Used within <see cref="AzureFunctionappTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class FunctionappDeploymentSourceConfigPythonVersion : Enumeration
    {
        public static FunctionappDeploymentSourceConfigPythonVersion python_2_7_12_x64 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 2.7.12 x64" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_2_7_12_x86 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 2.7.12 x86" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_2_7_13_x64 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 2.7.13 x64" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_2_7_13_x86 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 2.7.13 x86" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_3_5_3_x64 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 3.5.3 x64" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_3_5_3_x86 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 3.5.3 x86" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_3_6_0_x64 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 3.6.0 x64" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_3_6_0_x86 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 3.6.0 x86" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_3_6_1_x86 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 3.6.1 x86" };
        public static FunctionappDeploymentSourceConfigPythonVersion python_3_6_2_x64 = new FunctionappDeploymentSourceConfigPythonVersion { Value = "python 3.6.2 x64" };
    }
    #endregion
}
