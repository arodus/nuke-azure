// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureLab.json.

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
    public static partial class AzureLabTasks
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public static string AzureLabPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure DevTest Labs.</p></summary>
        public static IReadOnlyCollection<Output> AzureLab(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureLabPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabDelete(Configure<AzureLabDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabGet(Configure<AzureLabGetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabGetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabCustomImageCreate(Configure<AzureLabCustomImageCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabCustomImageCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabCustomImageDelete(Configure<AzureLabCustomImageDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabCustomImageDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabCustomImageList(Configure<AzureLabCustomImageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabCustomImageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabCustomImageShow(Configure<AzureLabCustomImageShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabCustomImageShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabEnvironmentCreate(Configure<AzureLabEnvironmentCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabEnvironmentCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabEnvironmentDelete(Configure<AzureLabEnvironmentDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabEnvironmentDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabEnvironmentList(Configure<AzureLabEnvironmentListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabEnvironmentListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabEnvironmentShow(Configure<AzureLabEnvironmentShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabEnvironmentShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabArtifactSourceList(Configure<AzureLabArtifactSourceListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabArtifactSourceListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabArtifactSourceShow(Configure<AzureLabArtifactSourceShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabArtifactSourceShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVnetGet(Configure<AzureLabVnetGetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVnetGetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVnetList(Configure<AzureLabVnetListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVnetListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabSecretDelete(Configure<AzureLabSecretDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabSecretDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabSecretList(Configure<AzureLabSecretListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabSecretListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabSecretSet(Configure<AzureLabSecretSetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabSecretSetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabSecretShow(Configure<AzureLabSecretShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabSecretShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabArtifactList(Configure<AzureLabArtifactListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabArtifactListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabArmTemplateList(Configure<AzureLabArmTemplateListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabArmTemplateListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabArmTemplateShow(Configure<AzureLabArmTemplateShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabArmTemplateShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmApplyArtifacts(Configure<AzureLabVmApplyArtifactsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmApplyArtifactsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmClaim(Configure<AzureLabVmClaimSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmClaimSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmCreate(Configure<AzureLabVmCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmDelete(Configure<AzureLabVmDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmList(Configure<AzureLabVmListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmShow(Configure<AzureLabVmShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmStart(Configure<AzureLabVmStartSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmStartSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabVmStop(Configure<AzureLabVmStopSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabVmStopSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabGalleryImageList(Configure<AzureLabGalleryImageListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabGalleryImageListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabFormulaDelete(Configure<AzureLabFormulaDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabFormulaDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabFormulaExportArtifacts(Configure<AzureLabFormulaExportArtifactsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabFormulaExportArtifactsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabFormulaList(Configure<AzureLabFormulaListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabFormulaListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure DevTest Labs.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lab?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLabFormulaShow(Configure<AzureLabFormulaShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLabFormulaShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureLabDeleteSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
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
              .Add("lab delete")
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
    #region AzureLabGetSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabGetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab get")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabCustomImageCreateSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabCustomImageCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the Lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the image.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The current state of the virtual machine.</p></summary>
        public virtual string OsState { get; internal set; }
        /// <summary><p>Type of the OS on which the custom image is based. Allowed values are: Windows, Linux.</p></summary>
        public virtual string OsType { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource ID of a virtual machine in the provided lab.</p></summary>
        public virtual string SourceVmId { get; internal set; }
        /// <summary><p>The author of the custom image.</p></summary>
        public virtual string Author { get; internal set; }
        /// <summary><p>A detailed description for the custom image.</p></summary>
        public virtual string Description { get; internal set; }
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
              .Add("lab custom-image create")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--os-state {value}", OsState)
              .Add("--os-type {value}", OsType)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source-vm-id {value}", SourceVmId)
              .Add("--author {value}", Author)
              .Add("--description {value}", Description)
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
    #region AzureLabCustomImageDeleteSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabCustomImageDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the custom image.</p></summary>
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
              .Add("lab custom-image delete")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabCustomImageListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabCustomImageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=vm)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab custom-image list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabCustomImageShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabCustomImageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the custom image.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=vm)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab custom-image show")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabEnvironmentCreateSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabEnvironmentCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name or ID of the ARM template in the lab.</p></summary>
        public virtual string ArmTemplate { get; internal set; }
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the environment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the lab's resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the artifact source in the lab.</p></summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary><p>JSON encoded list of parameters. Use '@{file}' to load from a file.</p></summary>
        public virtual string Parameters { get; internal set; }
        /// <summary><p>The tags for the resource.</p></summary>
        public virtual string Tags { get; internal set; }
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
              .Add("lab environment create")
              .Add("--arm-template {value}", ArmTemplate)
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--parameters {value}", Parameters)
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
    #region AzureLabEnvironmentDeleteSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabEnvironmentDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the environment.</p></summary>
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
              .Add("lab environment delete")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabEnvironmentListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabEnvironmentListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=deploymentProperties)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab environment list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabEnvironmentShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabEnvironmentShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the environment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=deploymentProperties)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab environment show")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabArtifactSourceListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabArtifactSourceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab artifact-source list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabArtifactSourceShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabArtifactSourceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the artifact source.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab artifact-source show")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabVnetGetSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVnetGetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the virtual network.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($expand=externalSubnets)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab vnet get")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabVnetListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVnetListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($expand=externalSubnets)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab vnet list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabSecretDeleteSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabSecretDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the secret.</p></summary>
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
              .Add("lab secret delete")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabSecretListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabSecretListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=value)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab secret list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabSecretSetSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabSecretSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Value of the secret.</p></summary>
        public virtual string Value { get; internal set; }
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
              .Add("lab secret set")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--value {value}", Value)
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
    #region AzureLabSecretShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabSecretShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the secret.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=value)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab secret show")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabArtifactListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabArtifactListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the artifact source.</p></summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=title)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab artifact list")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabArmTemplateListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabArmTemplateListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the artifact source.</p></summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab arm-template list")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabArmTemplateShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabArmTemplateShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the artifact source.</p></summary>
        public virtual string ArtifactSourceName { get; internal set; }
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the Azure Resource Manager template.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of lab's resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Whether or not to export parameters template.</p></summary>
        public virtual string ExportParameters { get; internal set; }
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
              .Add("lab arm-template show")
              .Add("--artifact-source-name {value}", ArtifactSourceName)
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--export-parameters {value}", ExportParameters)
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
    #region AzureLabVmApplyArtifactsSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmApplyArtifactsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the Lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the virtual machine.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of lab's resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.</p></summary>
        public virtual string Artifacts { get; internal set; }
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
              .Add("lab vm apply-artifacts")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--artifacts {value}", Artifacts)
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
    #region AzureLabVmClaimSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmClaimSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the virtual machine to claim.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of lab's resource group.</p></summary>
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
              .Add("lab vm claim")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabVmCreateSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the virtual machine.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Flag indicating if the VM should be created as claimable.</p></summary>
        public virtual string AllowClaim { get; internal set; }
        /// <summary><p>JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.</p></summary>
        public virtual string Artifacts { get; internal set; }
        /// <summary><p>Storage type to use for virtual machine.</p></summary>
        public virtual string DiskType { get; internal set; }
        /// <summary><p>The expiration date in UTC(YYYY-mm-dd) for the VM.</p></summary>
        public virtual string ExpirationDate { get; internal set; }
        /// <summary><p>Name of the formula. Use `az lab formula list` for available formulas.</p></summary>
        public virtual string Formula { get; internal set; }
        /// <summary><p>Generate SSH public and private key files if missing.</p></summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary><p>The name of the operating system image (gallery image name or custom image name/ID).</p></summary>
        public virtual string Image { get; internal set; }
        /// <summary><p>Type of the image. Allowed values are: gallery, custom.</p></summary>
        public virtual string ImageType { get; internal set; }
        /// <summary><p>Notes for the virtual machine.</p></summary>
        public virtual string Notes { get; internal set; }
        /// <summary><p>The size of the VM to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        public virtual string Size { get; internal set; }
        /// <summary><p>Space-separated tags in `key[=value]` format.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Password for the VM admin.</p></summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary><p>Username for the VM admin.</p></summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary><p>Type of authentication allowed for the VM. Allowed values are: password, ssh.</p></summary>
        public virtual string AuthenticationType { get; internal set; }
        /// <summary><p>Name of the saved secret to be used for authentication.</p></summary>
        public virtual string SavedSecret { get; internal set; }
        /// <summary><p>The SSH public key or public key file path. Use `--generate-ssh-keys` to generate SSH keys.</p></summary>
        public virtual string SshKey { get; internal set; }
        /// <summary><p>Type of IP configuration to use for the VM. Allowed values are: shared, public, private.</p></summary>
        public virtual string IpConfiguration { get; internal set; }
        /// <summary><p>Name of the subnet to add the VM to.</p></summary>
        public virtual string Subnet { get; internal set; }
        /// <summary><p>Name of the virtual network to add the VM to.</p></summary>
        public virtual string VnetName { get; internal set; }
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
              .Add("lab vm create")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--allow-claim {value}", AllowClaim)
              .Add("--artifacts {value}", Artifacts)
              .Add("--disk-type {value}", DiskType)
              .Add("--expiration-date {value}", ExpirationDate)
              .Add("--formula {value}", Formula)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--image {value}", Image)
              .Add("--image-type {value}", ImageType)
              .Add("--notes {value}", Notes)
              .Add("--size {value}", Size)
              .Add("--tags {value}", Tags)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--admin-username {value}", AdminUsername)
              .Add("--authentication-type {value}", AuthenticationType)
              .Add("--saved-secret {value}", SavedSecret, secret: true)
              .Add("--ssh-key {value}", SshKey)
              .Add("--ip-configuration {value}", IpConfiguration)
              .Add("--subnet {value}", Subnet)
              .Add("--vnet-name {value}", VnetName)
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
    #region AzureLabVmDeleteSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the virtual machine.</p></summary>
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
              .Add("lab vm delete")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabVmListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>List all virtual machines in the lab. Cannot be used with `--filters`.</p></summary>
        public virtual string All { get; internal set; }
        /// <summary><p>List only claimable virtual machines in the lab. Cannot be used with `--filters`.</p></summary>
        public virtual string Claimable { get; internal set; }
        /// <summary><p>The expand query.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>Object ID of the owner to list VMs for.</p></summary>
        public virtual string ObjectId { get; internal set; }
        /// <summary><p>The ordering expression for the results using OData notation.</p></summary>
        public virtual string OrderBy { get; internal set; }
        /// <summary><p>The maximum number of resources to return.</p></summary>
        public virtual int? Top { get; internal set; }
        /// <summary><p>Name or ID of the environment to list virtual machines in. Cannot be used with `--filters`.</p></summary>
        public virtual string Environment { get; internal set; }
        /// <summary><p>The filter to apply.</p></summary>
        public virtual string Filters { get; internal set; }
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
              .Add("lab vm list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--all {value}", All)
              .Add("--claimable {value}", Claimable)
              .Add("--expand {value}", Expand)
              .Add("--object-id {value}", ObjectId)
              .Add("--order-by {value}", OrderBy)
              .Add("--top {value}", Top)
              .Add("--environment {value}", Environment)
              .Add("--filters {value}", Filters)
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
    #region AzureLabVmShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the virtual machine.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($expand=artifacts,computeVm,networkInterface,applicableSchedule)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab vm show")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabVmStartSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmStartSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the virtual machine.</p></summary>
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
              .Add("lab vm start")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabVmStopSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabVmStopSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the virtual machine.</p></summary>
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
              .Add("lab vm stop")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabGalleryImageListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabGalleryImageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=author)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab gallery-image list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabFormulaDeleteSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabFormulaDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>The name of the formula.</p></summary>
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
              .Add("lab formula delete")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabFormulaExportArtifactsSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabFormulaExportArtifactsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the formula.</p></summary>
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
              .Add("lab formula export-artifacts")
              .Add("--lab-name {value}", LabName)
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
    #region AzureLabFormulaListSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabFormulaListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>The name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=description)'.</p></summary>
        public virtual string Expand { get; internal set; }
        /// <summary><p>The filter to apply to the operation.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The ordering expression for the results, using OData notation.</p></summary>
        public virtual string Orderby { get; internal set; }
        /// <summary><p>The maximum number of resources to return from the operation.</p></summary>
        public virtual int? Top { get; internal set; }
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
              .Add("lab formula list")
              .Add("--lab-name {value}", LabName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--filter {value}", Filter)
              .Add("--orderby {value}", Orderby)
              .Add("--top {value}", Top)
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
    #region AzureLabFormulaShowSettings
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLabFormulaShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLab executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLabTasks.AzureLabPath;
        /// <summary><p>Name of the lab.</p></summary>
        public virtual string LabName { get; internal set; }
        /// <summary><p>Name of the formula.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Specify the $expand query. Example: 'properties($select=description)'.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("lab formula show")
              .Add("--lab-name {value}", LabName)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
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
    #region AzureLabDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Name"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetName(this AzureLabDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Name"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetName(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetResourceGroup(this AzureLabDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetResourceGroup(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetSubscription(this AzureLabDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetSubscription(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetDebug(this AzureLabDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetDebug(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetHelp(this AzureLabDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetHelp(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetOutput(this AzureLabDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetOutput(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetQuery(this AzureLabDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetQuery(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings SetVerbose(this AzureLabDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabDeleteSettings ResetVerbose(this AzureLabDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabGetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabGetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Name"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetName(this AzureLabGetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Name"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetName(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetResourceGroup(this AzureLabGetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetResourceGroup(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetExpand(this AzureLabGetSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetExpand(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetSubscription(this AzureLabGetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetSubscription(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetDebug(this AzureLabGetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetDebug(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetHelp(this AzureLabGetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetHelp(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetOutput(this AzureLabGetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetOutput(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetQuery(this AzureLabGetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetQuery(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabGetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabGetSettings SetVerbose(this AzureLabGetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabGetSettings ResetVerbose(this AzureLabGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabCustomImageCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabCustomImageCreateSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.LabName"/>.</em></p><p>Name of the Lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetLabName(this AzureLabCustomImageCreateSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.LabName"/>.</em></p><p>Name of the Lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetLabName(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Name"/>.</em></p><p>Name of the image.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetName(this AzureLabCustomImageCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Name"/>.</em></p><p>Name of the image.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetName(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region OsState
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.OsState"/>.</em></p><p>The current state of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetOsState(this AzureLabCustomImageCreateSettings toolSettings, string osState)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsState = osState;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.OsState"/>.</em></p><p>The current state of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetOsState(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsState = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.OsType"/>.</em></p><p>Type of the OS on which the custom image is based. Allowed values are: Windows, Linux.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetOsType(this AzureLabCustomImageCreateSettings toolSettings, string osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.OsType"/>.</em></p><p>Type of the OS on which the custom image is based. Allowed values are: Windows, Linux.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetOsType(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetResourceGroup(this AzureLabCustomImageCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetResourceGroup(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SourceVmId
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.SourceVmId"/>.</em></p><p>The resource ID of a virtual machine in the provided lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetSourceVmId(this AzureLabCustomImageCreateSettings toolSettings, string sourceVmId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceVmId = sourceVmId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.SourceVmId"/>.</em></p><p>The resource ID of a virtual machine in the provided lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetSourceVmId(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceVmId = null;
            return toolSettings;
        }
        #endregion
        #region Author
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Author"/>.</em></p><p>The author of the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetAuthor(this AzureLabCustomImageCreateSettings toolSettings, string author)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Author = author;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Author"/>.</em></p><p>The author of the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetAuthor(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Author = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Description"/>.</em></p><p>A detailed description for the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetDescription(this AzureLabCustomImageCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Description"/>.</em></p><p>A detailed description for the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetDescription(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetSubscription(this AzureLabCustomImageCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetSubscription(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetDebug(this AzureLabCustomImageCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetDebug(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetHelp(this AzureLabCustomImageCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetHelp(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetOutput(this AzureLabCustomImageCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetOutput(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetQuery(this AzureLabCustomImageCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetQuery(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings SetVerbose(this AzureLabCustomImageCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageCreateSettings ResetVerbose(this AzureLabCustomImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabCustomImageDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabCustomImageDeleteSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetLabName(this AzureLabCustomImageDeleteSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetLabName(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Name"/>.</em></p><p>The name of the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetName(this AzureLabCustomImageDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Name"/>.</em></p><p>The name of the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetName(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetResourceGroup(this AzureLabCustomImageDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetResourceGroup(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetSubscription(this AzureLabCustomImageDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetSubscription(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetDebug(this AzureLabCustomImageDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetDebug(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetHelp(this AzureLabCustomImageDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetHelp(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetOutput(this AzureLabCustomImageDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetOutput(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetQuery(this AzureLabCustomImageDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetQuery(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings SetVerbose(this AzureLabCustomImageDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageDeleteSettings ResetVerbose(this AzureLabCustomImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabCustomImageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabCustomImageListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetLabName(this AzureLabCustomImageListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetLabName(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetResourceGroup(this AzureLabCustomImageListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetResourceGroup(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=vm)'.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetExpand(this AzureLabCustomImageListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=vm)'.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetExpand(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetFilter(this AzureLabCustomImageListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetFilter(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetOrderby(this AzureLabCustomImageListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetOrderby(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetTop(this AzureLabCustomImageListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetTop(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetSubscription(this AzureLabCustomImageListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetSubscription(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetDebug(this AzureLabCustomImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetDebug(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetHelp(this AzureLabCustomImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetHelp(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetOutput(this AzureLabCustomImageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetOutput(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetQuery(this AzureLabCustomImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetQuery(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings SetVerbose(this AzureLabCustomImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageListSettings ResetVerbose(this AzureLabCustomImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabCustomImageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabCustomImageShowSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetLabName(this AzureLabCustomImageShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetLabName(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Name"/>.</em></p><p>The name of the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetName(this AzureLabCustomImageShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Name"/>.</em></p><p>The name of the custom image.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetName(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetResourceGroup(this AzureLabCustomImageShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetResourceGroup(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=vm)'.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetExpand(this AzureLabCustomImageShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=vm)'.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetExpand(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetSubscription(this AzureLabCustomImageShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetSubscription(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetDebug(this AzureLabCustomImageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetDebug(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetHelp(this AzureLabCustomImageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetHelp(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetOutput(this AzureLabCustomImageShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetOutput(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetQuery(this AzureLabCustomImageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetQuery(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabCustomImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings SetVerbose(this AzureLabCustomImageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabCustomImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabCustomImageShowSettings ResetVerbose(this AzureLabCustomImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabEnvironmentCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabEnvironmentCreateSettingsExtensions
    {
        #region ArmTemplate
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.ArmTemplate"/>.</em></p><p>Name or ID of the ARM template in the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetArmTemplate(this AzureLabEnvironmentCreateSettings toolSettings, string armTemplate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArmTemplate = armTemplate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.ArmTemplate"/>.</em></p><p>Name or ID of the ARM template in the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetArmTemplate(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArmTemplate = null;
            return toolSettings;
        }
        #endregion
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetLabName(this AzureLabEnvironmentCreateSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetLabName(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Name"/>.</em></p><p>Name of the environment.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetName(this AzureLabEnvironmentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Name"/>.</em></p><p>Name of the environment.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetName(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.ResourceGroup"/>.</em></p><p>Name of the lab's resource group.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetResourceGroup(this AzureLabEnvironmentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.ResourceGroup"/>.</em></p><p>Name of the lab's resource group.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetResourceGroup(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ArtifactSourceName
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.ArtifactSourceName"/>.</em></p><p>Name of the artifact source in the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetArtifactSourceName(this AzureLabEnvironmentCreateSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.ArtifactSourceName"/>.</em></p><p>Name of the artifact source in the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetArtifactSourceName(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Parameters"/>.</em></p><p>JSON encoded list of parameters. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetParameters(this AzureLabEnvironmentCreateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Parameters"/>.</em></p><p>JSON encoded list of parameters. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetParameters(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Tags"/>.</em></p><p>The tags for the resource.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetTags(this AzureLabEnvironmentCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Tags"/>.</em></p><p>The tags for the resource.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetTags(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetSubscription(this AzureLabEnvironmentCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetSubscription(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetDebug(this AzureLabEnvironmentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetDebug(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetHelp(this AzureLabEnvironmentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetHelp(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetOutput(this AzureLabEnvironmentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetOutput(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetQuery(this AzureLabEnvironmentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetQuery(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings SetVerbose(this AzureLabEnvironmentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentCreateSettings ResetVerbose(this AzureLabEnvironmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabEnvironmentDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabEnvironmentDeleteSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetLabName(this AzureLabEnvironmentDeleteSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetLabName(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Name"/>.</em></p><p>The name of the environment.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetName(this AzureLabEnvironmentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Name"/>.</em></p><p>The name of the environment.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetName(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetResourceGroup(this AzureLabEnvironmentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetResourceGroup(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetSubscription(this AzureLabEnvironmentDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetSubscription(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetDebug(this AzureLabEnvironmentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetDebug(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetHelp(this AzureLabEnvironmentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetHelp(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetOutput(this AzureLabEnvironmentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetOutput(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetQuery(this AzureLabEnvironmentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetQuery(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings SetVerbose(this AzureLabEnvironmentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentDeleteSettings ResetVerbose(this AzureLabEnvironmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabEnvironmentListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabEnvironmentListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetLabName(this AzureLabEnvironmentListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetLabName(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetResourceGroup(this AzureLabEnvironmentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetResourceGroup(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=deploymentProperties)'.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetExpand(this AzureLabEnvironmentListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=deploymentProperties)'.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetExpand(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetFilter(this AzureLabEnvironmentListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetFilter(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetOrderby(this AzureLabEnvironmentListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetOrderby(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetTop(this AzureLabEnvironmentListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetTop(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetSubscription(this AzureLabEnvironmentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetSubscription(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetDebug(this AzureLabEnvironmentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetDebug(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetHelp(this AzureLabEnvironmentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetHelp(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetOutput(this AzureLabEnvironmentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetOutput(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetQuery(this AzureLabEnvironmentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetQuery(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings SetVerbose(this AzureLabEnvironmentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentListSettings ResetVerbose(this AzureLabEnvironmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabEnvironmentShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabEnvironmentShowSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetLabName(this AzureLabEnvironmentShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetLabName(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Name"/>.</em></p><p>The name of the environment.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetName(this AzureLabEnvironmentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Name"/>.</em></p><p>The name of the environment.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetName(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetResourceGroup(this AzureLabEnvironmentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetResourceGroup(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=deploymentProperties)'.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetExpand(this AzureLabEnvironmentShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=deploymentProperties)'.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetExpand(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetSubscription(this AzureLabEnvironmentShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetSubscription(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetDebug(this AzureLabEnvironmentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetDebug(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetHelp(this AzureLabEnvironmentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetHelp(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetOutput(this AzureLabEnvironmentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetOutput(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetQuery(this AzureLabEnvironmentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetQuery(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabEnvironmentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings SetVerbose(this AzureLabEnvironmentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabEnvironmentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabEnvironmentShowSettings ResetVerbose(this AzureLabEnvironmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabArtifactSourceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabArtifactSourceListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetLabName(this AzureLabArtifactSourceListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetLabName(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetResourceGroup(this AzureLabArtifactSourceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetResourceGroup(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetExpand(this AzureLabArtifactSourceListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetExpand(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetFilter(this AzureLabArtifactSourceListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetFilter(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetOrderby(this AzureLabArtifactSourceListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetOrderby(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetTop(this AzureLabArtifactSourceListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetTop(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetSubscription(this AzureLabArtifactSourceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetSubscription(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetDebug(this AzureLabArtifactSourceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetDebug(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetHelp(this AzureLabArtifactSourceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetHelp(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetOutput(this AzureLabArtifactSourceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetOutput(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetQuery(this AzureLabArtifactSourceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetQuery(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings SetVerbose(this AzureLabArtifactSourceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceListSettings ResetVerbose(this AzureLabArtifactSourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabArtifactSourceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabArtifactSourceShowSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetLabName(this AzureLabArtifactSourceShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetLabName(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Name"/>.</em></p><p>The name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetName(this AzureLabArtifactSourceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Name"/>.</em></p><p>The name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetName(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetResourceGroup(this AzureLabArtifactSourceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetResourceGroup(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetExpand(this AzureLabArtifactSourceShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetExpand(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetSubscription(this AzureLabArtifactSourceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetSubscription(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetDebug(this AzureLabArtifactSourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetDebug(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetHelp(this AzureLabArtifactSourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetHelp(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetOutput(this AzureLabArtifactSourceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetOutput(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetQuery(this AzureLabArtifactSourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetQuery(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabArtifactSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings SetVerbose(this AzureLabArtifactSourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactSourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactSourceShowSettings ResetVerbose(this AzureLabArtifactSourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVnetGetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVnetGetSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetLabName(this AzureLabVnetGetSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetLabName(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Name"/>.</em></p><p>The name of the virtual network.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetName(this AzureLabVnetGetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Name"/>.</em></p><p>The name of the virtual network.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetName(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetResourceGroup(this AzureLabVnetGetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetResourceGroup(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($expand=externalSubnets)'.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetExpand(this AzureLabVnetGetSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($expand=externalSubnets)'.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetExpand(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetSubscription(this AzureLabVnetGetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetSubscription(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetDebug(this AzureLabVnetGetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetDebug(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetHelp(this AzureLabVnetGetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetHelp(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetOutput(this AzureLabVnetGetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetOutput(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetQuery(this AzureLabVnetGetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetQuery(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVnetGetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings SetVerbose(this AzureLabVnetGetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetGetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetGetSettings ResetVerbose(this AzureLabVnetGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVnetListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVnetListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetLabName(this AzureLabVnetListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetLabName(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetResourceGroup(this AzureLabVnetListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetResourceGroup(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($expand=externalSubnets)'.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetExpand(this AzureLabVnetListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($expand=externalSubnets)'.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetExpand(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetFilter(this AzureLabVnetListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetFilter(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetOrderby(this AzureLabVnetListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetOrderby(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetTop(this AzureLabVnetListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetTop(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetSubscription(this AzureLabVnetListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetSubscription(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetDebug(this AzureLabVnetListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetDebug(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetHelp(this AzureLabVnetListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetHelp(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetOutput(this AzureLabVnetListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetOutput(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetQuery(this AzureLabVnetListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetQuery(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVnetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings SetVerbose(this AzureLabVnetListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVnetListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVnetListSettings ResetVerbose(this AzureLabVnetListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabSecretDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabSecretDeleteSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetLabName(this AzureLabSecretDeleteSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetLabName(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Name"/>.</em></p><p>The name of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetName(this AzureLabSecretDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Name"/>.</em></p><p>The name of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetName(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetResourceGroup(this AzureLabSecretDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetResourceGroup(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetSubscription(this AzureLabSecretDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetSubscription(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetDebug(this AzureLabSecretDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetDebug(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetHelp(this AzureLabSecretDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetHelp(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetOutput(this AzureLabSecretDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetOutput(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetQuery(this AzureLabSecretDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetQuery(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabSecretDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings SetVerbose(this AzureLabSecretDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretDeleteSettings ResetVerbose(this AzureLabSecretDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabSecretListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabSecretListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetLabName(this AzureLabSecretListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetLabName(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetResourceGroup(this AzureLabSecretListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetResourceGroup(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=value)'.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetExpand(this AzureLabSecretListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=value)'.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetExpand(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetFilter(this AzureLabSecretListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetFilter(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetOrderby(this AzureLabSecretListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetOrderby(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetTop(this AzureLabSecretListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetTop(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetSubscription(this AzureLabSecretListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetSubscription(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetDebug(this AzureLabSecretListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetDebug(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetHelp(this AzureLabSecretListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetHelp(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetOutput(this AzureLabSecretListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetOutput(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetQuery(this AzureLabSecretListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetQuery(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabSecretListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings SetVerbose(this AzureLabSecretListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretListSettings ResetVerbose(this AzureLabSecretListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabSecretSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabSecretSetSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetLabName(this AzureLabSecretSetSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetLabName(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetName(this AzureLabSecretSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Name"/>.</em></p><p>Name of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetName(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetResourceGroup(this AzureLabSecretSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetResourceGroup(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Value"/>.</em></p><p>Value of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetValue(this AzureLabSecretSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Value"/>.</em></p><p>Value of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetValue(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetSubscription(this AzureLabSecretSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetSubscription(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetDebug(this AzureLabSecretSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetDebug(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetHelp(this AzureLabSecretSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetHelp(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetOutput(this AzureLabSecretSetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetOutput(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetQuery(this AzureLabSecretSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetQuery(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabSecretSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings SetVerbose(this AzureLabSecretSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretSetSettings ResetVerbose(this AzureLabSecretSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabSecretShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabSecretShowSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetLabName(this AzureLabSecretShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetLabName(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Name"/>.</em></p><p>The name of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetName(this AzureLabSecretShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Name"/>.</em></p><p>The name of the secret.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetName(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetResourceGroup(this AzureLabSecretShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetResourceGroup(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=value)'.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetExpand(this AzureLabSecretShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=value)'.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetExpand(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetSubscription(this AzureLabSecretShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetSubscription(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetDebug(this AzureLabSecretShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetDebug(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetHelp(this AzureLabSecretShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetHelp(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetOutput(this AzureLabSecretShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetOutput(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetQuery(this AzureLabSecretShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetQuery(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabSecretShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings SetVerbose(this AzureLabSecretShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabSecretShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabSecretShowSettings ResetVerbose(this AzureLabSecretShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabArtifactListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabArtifactListSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.ArtifactSourceName"/>.</em></p><p>The name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetArtifactSourceName(this AzureLabArtifactListSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.ArtifactSourceName"/>.</em></p><p>The name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetArtifactSourceName(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetLabName(this AzureLabArtifactListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetLabName(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetResourceGroup(this AzureLabArtifactListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetResourceGroup(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=title)'.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetExpand(this AzureLabArtifactListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=title)'.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetExpand(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetFilter(this AzureLabArtifactListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetFilter(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetOrderby(this AzureLabArtifactListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetOrderby(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetTop(this AzureLabArtifactListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetTop(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetSubscription(this AzureLabArtifactListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetSubscription(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetDebug(this AzureLabArtifactListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetDebug(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetHelp(this AzureLabArtifactListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetHelp(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetOutput(this AzureLabArtifactListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetOutput(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetQuery(this AzureLabArtifactListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetQuery(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabArtifactListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings SetVerbose(this AzureLabArtifactListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArtifactListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArtifactListSettings ResetVerbose(this AzureLabArtifactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabArmTemplateListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabArmTemplateListSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.ArtifactSourceName"/>.</em></p><p>The name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetArtifactSourceName(this AzureLabArmTemplateListSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.ArtifactSourceName"/>.</em></p><p>The name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetArtifactSourceName(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetLabName(this AzureLabArmTemplateListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetLabName(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetResourceGroup(this AzureLabArmTemplateListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetResourceGroup(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetExpand(this AzureLabArmTemplateListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=displayName)'.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetExpand(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetFilter(this AzureLabArmTemplateListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetFilter(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetOrderby(this AzureLabArmTemplateListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetOrderby(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetTop(this AzureLabArmTemplateListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetTop(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetSubscription(this AzureLabArmTemplateListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetSubscription(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetDebug(this AzureLabArmTemplateListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetDebug(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetHelp(this AzureLabArmTemplateListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetHelp(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetOutput(this AzureLabArmTemplateListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetOutput(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetQuery(this AzureLabArmTemplateListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetQuery(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings SetVerbose(this AzureLabArmTemplateListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateListSettings ResetVerbose(this AzureLabArmTemplateListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabArmTemplateShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabArmTemplateShowSettingsExtensions
    {
        #region ArtifactSourceName
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.ArtifactSourceName"/>.</em></p><p>Name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetArtifactSourceName(this AzureLabArmTemplateShowSettings toolSettings, string artifactSourceName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = artifactSourceName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.ArtifactSourceName"/>.</em></p><p>Name of the artifact source.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetArtifactSourceName(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ArtifactSourceName = null;
            return toolSettings;
        }
        #endregion
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetLabName(this AzureLabArmTemplateShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetLabName(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Name"/>.</em></p><p>Name of the Azure Resource Manager template.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetName(this AzureLabArmTemplateShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Name"/>.</em></p><p>Name of the Azure Resource Manager template.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetName(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.ResourceGroup"/>.</em></p><p>Name of lab's resource group.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetResourceGroup(this AzureLabArmTemplateShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.ResourceGroup"/>.</em></p><p>Name of lab's resource group.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetResourceGroup(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ExportParameters
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.ExportParameters"/>.</em></p><p>Whether or not to export parameters template.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetExportParameters(this AzureLabArmTemplateShowSettings toolSettings, string exportParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExportParameters = exportParameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.ExportParameters"/>.</em></p><p>Whether or not to export parameters template.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetExportParameters(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExportParameters = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetSubscription(this AzureLabArmTemplateShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetSubscription(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetDebug(this AzureLabArmTemplateShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetDebug(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetHelp(this AzureLabArmTemplateShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetHelp(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetOutput(this AzureLabArmTemplateShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetOutput(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetQuery(this AzureLabArmTemplateShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetQuery(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabArmTemplateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings SetVerbose(this AzureLabArmTemplateShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabArmTemplateShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabArmTemplateShowSettings ResetVerbose(this AzureLabArmTemplateShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmApplyArtifactsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmApplyArtifactsSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.LabName"/>.</em></p><p>Name of the Lab.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetLabName(this AzureLabVmApplyArtifactsSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.LabName"/>.</em></p><p>Name of the Lab.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetLabName(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Name"/>.</em></p><p>Name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetName(this AzureLabVmApplyArtifactsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Name"/>.</em></p><p>Name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetName(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.ResourceGroup"/>.</em></p><p>Name of lab's resource group.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetResourceGroup(this AzureLabVmApplyArtifactsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.ResourceGroup"/>.</em></p><p>Name of lab's resource group.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetResourceGroup(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Artifacts
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Artifacts"/>.</em></p><p>JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetArtifacts(this AzureLabVmApplyArtifactsSettings toolSettings, string artifacts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Artifacts = artifacts;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Artifacts"/>.</em></p><p>JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetArtifacts(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Artifacts = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetSubscription(this AzureLabVmApplyArtifactsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetSubscription(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetDebug(this AzureLabVmApplyArtifactsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetDebug(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetHelp(this AzureLabVmApplyArtifactsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetHelp(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetOutput(this AzureLabVmApplyArtifactsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetOutput(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetQuery(this AzureLabVmApplyArtifactsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetQuery(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmApplyArtifactsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings SetVerbose(this AzureLabVmApplyArtifactsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmApplyArtifactsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmApplyArtifactsSettings ResetVerbose(this AzureLabVmApplyArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmClaimSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmClaimSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetIds(this AzureLabVmClaimSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetIds(this AzureLabVmClaimSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureLabVmClaimSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings AddIds(this AzureLabVmClaimSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureLabVmClaimSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings AddIds(this AzureLabVmClaimSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureLabVmClaimSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ClearIds(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureLabVmClaimSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings RemoveIds(this AzureLabVmClaimSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureLabVmClaimSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings RemoveIds(this AzureLabVmClaimSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetLabName(this AzureLabVmClaimSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetLabName(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Name"/>.</em></p><p>Name of the virtual machine to claim.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetName(this AzureLabVmClaimSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Name"/>.</em></p><p>Name of the virtual machine to claim.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetName(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.ResourceGroup"/>.</em></p><p>Name of lab's resource group.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetResourceGroup(this AzureLabVmClaimSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.ResourceGroup"/>.</em></p><p>Name of lab's resource group.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetResourceGroup(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetSubscription(this AzureLabVmClaimSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetSubscription(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetDebug(this AzureLabVmClaimSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetDebug(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetHelp(this AzureLabVmClaimSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetHelp(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetOutput(this AzureLabVmClaimSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetOutput(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetQuery(this AzureLabVmClaimSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetQuery(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmClaimSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings SetVerbose(this AzureLabVmClaimSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmClaimSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmClaimSettings ResetVerbose(this AzureLabVmClaimSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmCreateSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetLabName(this AzureLabVmCreateSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetLabName(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Name"/>.</em></p><p>Name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetName(this AzureLabVmCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Name"/>.</em></p><p>Name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetName(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetResourceGroup(this AzureLabVmCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetResourceGroup(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AllowClaim
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.AllowClaim"/>.</em></p><p>Flag indicating if the VM should be created as claimable.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetAllowClaim(this AzureLabVmCreateSettings toolSettings, string allowClaim)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowClaim = allowClaim;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.AllowClaim"/>.</em></p><p>Flag indicating if the VM should be created as claimable.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetAllowClaim(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowClaim = null;
            return toolSettings;
        }
        #endregion
        #region Artifacts
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Artifacts"/>.</em></p><p>JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetArtifacts(this AzureLabVmCreateSettings toolSettings, string artifacts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Artifacts = artifacts;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Artifacts"/>.</em></p><p>JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetArtifacts(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Artifacts = null;
            return toolSettings;
        }
        #endregion
        #region DiskType
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.DiskType"/>.</em></p><p>Storage type to use for virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetDiskType(this AzureLabVmCreateSettings toolSettings, string diskType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskType = diskType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.DiskType"/>.</em></p><p>Storage type to use for virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetDiskType(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DiskType = null;
            return toolSettings;
        }
        #endregion
        #region ExpirationDate
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.ExpirationDate"/>.</em></p><p>The expiration date in UTC(YYYY-mm-dd) for the VM.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetExpirationDate(this AzureLabVmCreateSettings toolSettings, string expirationDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpirationDate = expirationDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.ExpirationDate"/>.</em></p><p>The expiration date in UTC(YYYY-mm-dd) for the VM.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetExpirationDate(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpirationDate = null;
            return toolSettings;
        }
        #endregion
        #region Formula
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Formula"/>.</em></p><p>Name of the formula. Use `az lab formula list` for available formulas.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetFormula(this AzureLabVmCreateSettings toolSettings, string formula)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Formula = formula;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Formula"/>.</em></p><p>Name of the formula. Use `az lab formula list` for available formulas.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetFormula(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Formula = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetGenerateSshKeys(this AzureLabVmCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.GenerateSshKeys"/>.</em></p><p>Generate SSH public and private key files if missing.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetGenerateSshKeys(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Image
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Image"/>.</em></p><p>The name of the operating system image (gallery image name or custom image name/ID).</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetImage(this AzureLabVmCreateSettings toolSettings, string image)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = image;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Image"/>.</em></p><p>The name of the operating system image (gallery image name or custom image name/ID).</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetImage(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Image = null;
            return toolSettings;
        }
        #endregion
        #region ImageType
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.ImageType"/>.</em></p><p>Type of the image. Allowed values are: gallery, custom.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetImageType(this AzureLabVmCreateSettings toolSettings, string imageType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageType = imageType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.ImageType"/>.</em></p><p>Type of the image. Allowed values are: gallery, custom.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetImageType(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageType = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Notes"/>.</em></p><p>Notes for the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetNotes(this AzureLabVmCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Notes"/>.</em></p><p>Notes for the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetNotes(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Size
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Size"/>.</em></p><p>The size of the VM to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetSize(this AzureLabVmCreateSettings toolSettings, string size)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = size;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Size"/>.</em></p><p>The size of the VM to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetSize(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Size = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Tags"/>.</em></p><p>Space-separated tags in `key[=value]` format.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetTags(this AzureLabVmCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Tags"/>.</em></p><p>Space-separated tags in `key[=value]` format.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetTags(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.AdminPassword"/>.</em></p><p>Password for the VM admin.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetAdminPassword(this AzureLabVmCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.AdminPassword"/>.</em></p><p>Password for the VM admin.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetAdminPassword(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.AdminUsername"/>.</em></p><p>Username for the VM admin.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetAdminUsername(this AzureLabVmCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.AdminUsername"/>.</em></p><p>Username for the VM admin.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetAdminUsername(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region AuthenticationType
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.AuthenticationType"/>.</em></p><p>Type of authentication allowed for the VM. Allowed values are: password, ssh.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetAuthenticationType(this AzureLabVmCreateSettings toolSettings, string authenticationType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthenticationType = authenticationType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.AuthenticationType"/>.</em></p><p>Type of authentication allowed for the VM. Allowed values are: password, ssh.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetAuthenticationType(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthenticationType = null;
            return toolSettings;
        }
        #endregion
        #region SavedSecret
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.SavedSecret"/>.</em></p><p>Name of the saved secret to be used for authentication.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetSavedSecret(this AzureLabVmCreateSettings toolSettings, string savedSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SavedSecret = savedSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.SavedSecret"/>.</em></p><p>Name of the saved secret to be used for authentication.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetSavedSecret(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SavedSecret = null;
            return toolSettings;
        }
        #endregion
        #region SshKey
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.SshKey"/>.</em></p><p>The SSH public key or public key file path. Use `--generate-ssh-keys` to generate SSH keys.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetSshKey(this AzureLabVmCreateSettings toolSettings, string sshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = sshKey;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.SshKey"/>.</em></p><p>The SSH public key or public key file path. Use `--generate-ssh-keys` to generate SSH keys.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetSshKey(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKey = null;
            return toolSettings;
        }
        #endregion
        #region IpConfiguration
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.IpConfiguration"/>.</em></p><p>Type of IP configuration to use for the VM. Allowed values are: shared, public, private.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetIpConfiguration(this AzureLabVmCreateSettings toolSettings, string ipConfiguration)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpConfiguration = ipConfiguration;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.IpConfiguration"/>.</em></p><p>Type of IP configuration to use for the VM. Allowed values are: shared, public, private.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetIpConfiguration(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpConfiguration = null;
            return toolSettings;
        }
        #endregion
        #region Subnet
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Subnet"/>.</em></p><p>Name of the subnet to add the VM to.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetSubnet(this AzureLabVmCreateSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Subnet"/>.</em></p><p>Name of the subnet to add the VM to.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetSubnet(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region VnetName
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.VnetName"/>.</em></p><p>Name of the virtual network to add the VM to.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetVnetName(this AzureLabVmCreateSettings toolSettings, string vnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = vnetName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.VnetName"/>.</em></p><p>Name of the virtual network to add the VM to.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetVnetName(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetSubscription(this AzureLabVmCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetSubscription(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetDebug(this AzureLabVmCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetDebug(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetHelp(this AzureLabVmCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetHelp(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetOutput(this AzureLabVmCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetOutput(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetQuery(this AzureLabVmCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetQuery(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings SetVerbose(this AzureLabVmCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmCreateSettings ResetVerbose(this AzureLabVmCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmDeleteSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetLabName(this AzureLabVmDeleteSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetLabName(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetName(this AzureLabVmDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetName(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetResourceGroup(this AzureLabVmDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetResourceGroup(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetSubscription(this AzureLabVmDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetSubscription(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetDebug(this AzureLabVmDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetDebug(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetHelp(this AzureLabVmDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetHelp(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetOutput(this AzureLabVmDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetOutput(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetQuery(this AzureLabVmDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetQuery(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings SetVerbose(this AzureLabVmDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmDeleteSettings ResetVerbose(this AzureLabVmDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetLabName(this AzureLabVmListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetLabName(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetResourceGroup(this AzureLabVmListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetResourceGroup(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region All
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.All"/>.</em></p><p>List all virtual machines in the lab. Cannot be used with `--filters`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetAll(this AzureLabVmListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.All"/>.</em></p><p>List all virtual machines in the lab. Cannot be used with `--filters`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetAll(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region Claimable
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Claimable"/>.</em></p><p>List only claimable virtual machines in the lab. Cannot be used with `--filters`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetClaimable(this AzureLabVmListSettings toolSettings, string claimable)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Claimable = claimable;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Claimable"/>.</em></p><p>List only claimable virtual machines in the lab. Cannot be used with `--filters`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetClaimable(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Claimable = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Expand"/>.</em></p><p>The expand query.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetExpand(this AzureLabVmListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Expand"/>.</em></p><p>The expand query.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetExpand(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region ObjectId
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.ObjectId"/>.</em></p><p>Object ID of the owner to list VMs for.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetObjectId(this AzureLabVmListSettings toolSettings, string objectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = objectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.ObjectId"/>.</em></p><p>Object ID of the owner to list VMs for.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetObjectId(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ObjectId = null;
            return toolSettings;
        }
        #endregion
        #region OrderBy
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.OrderBy"/>.</em></p><p>The ordering expression for the results using OData notation.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetOrderBy(this AzureLabVmListSettings toolSettings, string orderBy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderBy = orderBy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.OrderBy"/>.</em></p><p>The ordering expression for the results using OData notation.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetOrderBy(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrderBy = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Top"/>.</em></p><p>The maximum number of resources to return.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetTop(this AzureLabVmListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Top"/>.</em></p><p>The maximum number of resources to return.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetTop(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Environment
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Environment"/>.</em></p><p>Name or ID of the environment to list virtual machines in. Cannot be used with `--filters`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetEnvironment(this AzureLabVmListSettings toolSettings, string environment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Environment = environment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Environment"/>.</em></p><p>Name or ID of the environment to list virtual machines in. Cannot be used with `--filters`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetEnvironment(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Environment = null;
            return toolSettings;
        }
        #endregion
        #region Filters
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Filters"/>.</em></p><p>The filter to apply.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetFilters(this AzureLabVmListSettings toolSettings, string filters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filters = filters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Filters"/>.</em></p><p>The filter to apply.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetFilters(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filters = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetSubscription(this AzureLabVmListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetSubscription(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetDebug(this AzureLabVmListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetDebug(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetHelp(this AzureLabVmListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetHelp(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetOutput(this AzureLabVmListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetOutput(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetQuery(this AzureLabVmListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetQuery(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmListSettings SetVerbose(this AzureLabVmListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmListSettings ResetVerbose(this AzureLabVmListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmShowSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetLabName(this AzureLabVmShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetLabName(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetName(this AzureLabVmShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetName(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetResourceGroup(this AzureLabVmShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetResourceGroup(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($expand=artifacts,computeVm,networkInterface,applicableSchedule)'.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetExpand(this AzureLabVmShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($expand=artifacts,computeVm,networkInterface,applicableSchedule)'.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetExpand(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetSubscription(this AzureLabVmShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetSubscription(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetDebug(this AzureLabVmShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetDebug(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetHelp(this AzureLabVmShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetHelp(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetOutput(this AzureLabVmShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetOutput(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetQuery(this AzureLabVmShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetQuery(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings SetVerbose(this AzureLabVmShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmShowSettings ResetVerbose(this AzureLabVmShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmStartSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmStartSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetLabName(this AzureLabVmStartSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetLabName(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetName(this AzureLabVmStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetName(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetResourceGroup(this AzureLabVmStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetResourceGroup(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetSubscription(this AzureLabVmStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetSubscription(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetDebug(this AzureLabVmStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetDebug(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetHelp(this AzureLabVmStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetHelp(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetOutput(this AzureLabVmStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetOutput(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetQuery(this AzureLabVmStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetQuery(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings SetVerbose(this AzureLabVmStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStartSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStartSettings ResetVerbose(this AzureLabVmStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabVmStopSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabVmStopSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetLabName(this AzureLabVmStopSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetLabName(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetName(this AzureLabVmStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Name"/>.</em></p><p>The name of the virtual machine.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetName(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetResourceGroup(this AzureLabVmStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetResourceGroup(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetSubscription(this AzureLabVmStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetSubscription(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetDebug(this AzureLabVmStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetDebug(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetHelp(this AzureLabVmStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetHelp(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetOutput(this AzureLabVmStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetOutput(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetQuery(this AzureLabVmStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetQuery(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabVmStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings SetVerbose(this AzureLabVmStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabVmStopSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabVmStopSettings ResetVerbose(this AzureLabVmStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabGalleryImageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabGalleryImageListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetLabName(this AzureLabGalleryImageListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetLabName(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetResourceGroup(this AzureLabGalleryImageListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetResourceGroup(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=author)'.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetExpand(this AzureLabGalleryImageListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=author)'.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetExpand(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetFilter(this AzureLabGalleryImageListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetFilter(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetOrderby(this AzureLabGalleryImageListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetOrderby(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetTop(this AzureLabGalleryImageListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetTop(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetSubscription(this AzureLabGalleryImageListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetSubscription(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetDebug(this AzureLabGalleryImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetDebug(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetHelp(this AzureLabGalleryImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetHelp(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetOutput(this AzureLabGalleryImageListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetOutput(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetQuery(this AzureLabGalleryImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetQuery(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabGalleryImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings SetVerbose(this AzureLabGalleryImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabGalleryImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabGalleryImageListSettings ResetVerbose(this AzureLabGalleryImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabFormulaDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabFormulaDeleteSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetLabName(this AzureLabFormulaDeleteSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetLabName(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Name"/>.</em></p><p>The name of the formula.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetName(this AzureLabFormulaDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Name"/>.</em></p><p>The name of the formula.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetName(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetResourceGroup(this AzureLabFormulaDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetResourceGroup(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetSubscription(this AzureLabFormulaDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetSubscription(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetDebug(this AzureLabFormulaDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetDebug(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetHelp(this AzureLabFormulaDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetHelp(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetOutput(this AzureLabFormulaDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetOutput(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetQuery(this AzureLabFormulaDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetQuery(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabFormulaDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings SetVerbose(this AzureLabFormulaDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaDeleteSettings ResetVerbose(this AzureLabFormulaDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabFormulaExportArtifactsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabFormulaExportArtifactsSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetLabName(this AzureLabFormulaExportArtifactsSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetLabName(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Name"/>.</em></p><p>Name of the formula.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetName(this AzureLabFormulaExportArtifactsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Name"/>.</em></p><p>Name of the formula.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetName(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetResourceGroup(this AzureLabFormulaExportArtifactsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetResourceGroup(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetSubscription(this AzureLabFormulaExportArtifactsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetSubscription(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetDebug(this AzureLabFormulaExportArtifactsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetDebug(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetHelp(this AzureLabFormulaExportArtifactsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetHelp(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetOutput(this AzureLabFormulaExportArtifactsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetOutput(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetQuery(this AzureLabFormulaExportArtifactsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetQuery(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabFormulaExportArtifactsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings SetVerbose(this AzureLabFormulaExportArtifactsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaExportArtifactsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaExportArtifactsSettings ResetVerbose(this AzureLabFormulaExportArtifactsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabFormulaListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabFormulaListSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetLabName(this AzureLabFormulaListSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.LabName"/>.</em></p><p>The name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetLabName(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetResourceGroup(this AzureLabFormulaListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetResourceGroup(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=description)'.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetExpand(this AzureLabFormulaListSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=description)'.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetExpand(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetFilter(this AzureLabFormulaListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Filter"/>.</em></p><p>The filter to apply to the operation.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetFilter(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Orderby
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetOrderby(this AzureLabFormulaListSettings toolSettings, string orderby)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = orderby;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Orderby"/>.</em></p><p>The ordering expression for the results, using OData notation.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetOrderby(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Orderby = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetTop(this AzureLabFormulaListSettings toolSettings, int? top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Top"/>.</em></p><p>The maximum number of resources to return from the operation.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetTop(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetSubscription(this AzureLabFormulaListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetSubscription(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetDebug(this AzureLabFormulaListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetDebug(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetHelp(this AzureLabFormulaListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetHelp(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetOutput(this AzureLabFormulaListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetOutput(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetQuery(this AzureLabFormulaListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetQuery(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabFormulaListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings SetVerbose(this AzureLabFormulaListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaListSettings ResetVerbose(this AzureLabFormulaListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLabFormulaShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLabTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLabFormulaShowSettingsExtensions
    {
        #region LabName
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetLabName(this AzureLabFormulaShowSettings toolSettings, string labName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = labName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.LabName"/>.</em></p><p>Name of the lab.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetLabName(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LabName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Name"/>.</em></p><p>Name of the formula.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetName(this AzureLabFormulaShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Name"/>.</em></p><p>Name of the formula.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetName(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetResourceGroup(this AzureLabFormulaShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetResourceGroup(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=description)'.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetExpand(this AzureLabFormulaShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Expand"/>.</em></p><p>Specify the $expand query. Example: 'properties($select=description)'.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetExpand(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetSubscription(this AzureLabFormulaShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetSubscription(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetDebug(this AzureLabFormulaShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetDebug(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetHelp(this AzureLabFormulaShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetHelp(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetOutput(this AzureLabFormulaShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetOutput(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetQuery(this AzureLabFormulaShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetQuery(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLabFormulaShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings SetVerbose(this AzureLabFormulaShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLabFormulaShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLabFormulaShowSettings ResetVerbose(this AzureLabFormulaShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
