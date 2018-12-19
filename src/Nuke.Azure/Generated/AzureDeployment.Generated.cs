// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureDeployment.json.

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
    public static partial class AzureDeploymentTasks
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public static string AzureDeploymentPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeployment(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureDeploymentPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentCreate(Configure<AzureDeploymentCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentDelete(Configure<AzureDeploymentDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentExport(Configure<AzureDeploymentExportSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentExportSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentList(Configure<AzureDeploymentListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentShow(Configure<AzureDeploymentShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentValidate(Configure<AzureDeploymentValidateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentValidateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentWait(Configure<AzureDeploymentWaitSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentWaitSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentOperationList(Configure<AzureDeploymentOperationListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentOperationListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Resource Manager deployments at subscription scope.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/deployment?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureDeploymentOperationShow(Configure<AzureDeploymentOperationShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureDeploymentOperationShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureDeploymentCreateSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The deployment name. Default to template file base name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary><p>Supply deployment parameter values.</p></summary>
        public virtual string Parameters { get; internal set; }
        /// <summary><p>A template file path in the file system.</p></summary>
        public virtual string TemplateFile { get; internal set; }
        /// <summary><p>A uri to a remote template file.</p></summary>
        public virtual string TemplateUri { get; internal set; }
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
              .Add("deployment create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--no-wait", NoWait)
              .Add("--parameters {value}", Parameters)
              .Add("--template-file {value}", TemplateFile)
              .Add("--template-uri {value}", TemplateUri)
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
    #region AzureDeploymentDeleteSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The deployment name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("deployment delete")
              .Add("--name {value}", Name)
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
    #region AzureDeploymentExportSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentExportSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The deployment name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("deployment export")
              .Add("--name {value}", Name)
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
    #region AzureDeploymentListSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The filter to apply on the operation. For example, you can use $filter=provisioningState eq '{state}'.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>The number of results to get. If null is passed, returns all deployments.</p></summary>
        public virtual string Top { get; internal set; }
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
              .Add("deployment list")
              .Add("--filter {value}", Filter)
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
    #region AzureDeploymentShowSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The deployment name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("deployment show")
              .Add("--name {value}", Name)
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
    #region AzureDeploymentValidateSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentValidateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Supply deployment parameter values.</p></summary>
        public virtual string Parameters { get; internal set; }
        /// <summary><p>A template file path in the file system.</p></summary>
        public virtual string TemplateFile { get; internal set; }
        /// <summary><p>A uri to a remote template file.</p></summary>
        public virtual string TemplateUri { get; internal set; }
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
              .Add("deployment validate")
              .Add("--location {value}", Location)
              .Add("--parameters {value}", Parameters)
              .Add("--template-file {value}", TemplateFile)
              .Add("--template-uri {value}", TemplateUri)
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
    #region AzureDeploymentWaitSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The deployment name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("deployment wait")
              .Add("--name {value}", Name)
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
    #region AzureDeploymentOperationListSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentOperationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The deployment name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The number of results to return.</p></summary>
        public virtual string Top { get; internal set; }
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
              .Add("deployment operation list")
              .Add("--name {value}", Name)
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
    #region AzureDeploymentOperationShowSettings
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureDeploymentOperationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureDeployment executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureDeploymentTasks.AzureDeploymentPath;
        /// <summary><p>The deployment name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>A list of operation ids to show.</p></summary>
        public virtual string OperationIds { get; internal set; }
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
              .Add("deployment operation show")
              .Add("--name {value}", Name)
              .Add("--operation-ids {value}", OperationIds)
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
    #region AzureDeploymentCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentCreateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetLocation(this AzureDeploymentCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetLocation(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Name"/>.</em></p><p>The deployment name. Default to template file base name.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetName(this AzureDeploymentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Name"/>.</em></p><p>The deployment name. Default to template file base name.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetName(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetNoWait(this AzureDeploymentCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetNoWait(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureDeploymentCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings EnableNoWait(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureDeploymentCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings DisableNoWait(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureDeploymentCreateSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ToggleNoWait(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Parameters"/>.</em></p><p>Supply deployment parameter values.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetParameters(this AzureDeploymentCreateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Parameters"/>.</em></p><p>Supply deployment parameter values.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetParameters(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region TemplateFile
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.TemplateFile"/>.</em></p><p>A template file path in the file system.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetTemplateFile(this AzureDeploymentCreateSettings toolSettings, string templateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = templateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.TemplateFile"/>.</em></p><p>A template file path in the file system.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetTemplateFile(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = null;
            return toolSettings;
        }
        #endregion
        #region TemplateUri
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.TemplateUri"/>.</em></p><p>A uri to a remote template file.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetTemplateUri(this AzureDeploymentCreateSettings toolSettings, string templateUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = templateUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.TemplateUri"/>.</em></p><p>A uri to a remote template file.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetTemplateUri(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetSubscription(this AzureDeploymentCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetSubscription(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetDebug(this AzureDeploymentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetDebug(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetHelp(this AzureDeploymentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetHelp(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetOutput(this AzureDeploymentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetOutput(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetQuery(this AzureDeploymentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetQuery(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings SetVerbose(this AzureDeploymentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentCreateSettings ResetVerbose(this AzureDeploymentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetName(this AzureDeploymentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetName(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetNoWait(this AzureDeploymentDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetNoWait(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureDeploymentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings EnableNoWait(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureDeploymentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings DisableNoWait(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureDeploymentDeleteSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ToggleNoWait(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetSubscription(this AzureDeploymentDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetSubscription(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetDebug(this AzureDeploymentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetDebug(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetHelp(this AzureDeploymentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetHelp(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetOutput(this AzureDeploymentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetOutput(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetQuery(this AzureDeploymentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetQuery(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings SetVerbose(this AzureDeploymentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentDeleteSettings ResetVerbose(this AzureDeploymentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentExportSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentExportSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetName(this AzureDeploymentExportSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetName(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetSubscription(this AzureDeploymentExportSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetSubscription(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetDebug(this AzureDeploymentExportSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetDebug(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetHelp(this AzureDeploymentExportSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetHelp(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetOutput(this AzureDeploymentExportSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetOutput(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetQuery(this AzureDeploymentExportSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetQuery(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentExportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings SetVerbose(this AzureDeploymentExportSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentExportSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentExportSettings ResetVerbose(this AzureDeploymentExportSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentListSettingsExtensions
    {
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Filter"/>.</em></p><p>The filter to apply on the operation. For example, you can use $filter=provisioningState eq '{state}'.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetFilter(this AzureDeploymentListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Filter"/>.</em></p><p>The filter to apply on the operation. For example, you can use $filter=provisioningState eq '{state}'.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetFilter(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Top"/>.</em></p><p>The number of results to get. If null is passed, returns all deployments.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetTop(this AzureDeploymentListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Top"/>.</em></p><p>The number of results to get. If null is passed, returns all deployments.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetTop(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetSubscription(this AzureDeploymentListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetSubscription(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetDebug(this AzureDeploymentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetDebug(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetHelp(this AzureDeploymentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetHelp(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetOutput(this AzureDeploymentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetOutput(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetQuery(this AzureDeploymentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetQuery(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings SetVerbose(this AzureDeploymentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentListSettings ResetVerbose(this AzureDeploymentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetName(this AzureDeploymentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetName(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetSubscription(this AzureDeploymentShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetSubscription(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetDebug(this AzureDeploymentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetDebug(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetHelp(this AzureDeploymentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetHelp(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetOutput(this AzureDeploymentShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetOutput(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetQuery(this AzureDeploymentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetQuery(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings SetVerbose(this AzureDeploymentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentShowSettings ResetVerbose(this AzureDeploymentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentValidateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentValidateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetLocation(this AzureDeploymentValidateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetLocation(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Parameters"/>.</em></p><p>Supply deployment parameter values.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetParameters(this AzureDeploymentValidateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Parameters"/>.</em></p><p>Supply deployment parameter values.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetParameters(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region TemplateFile
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.TemplateFile"/>.</em></p><p>A template file path in the file system.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetTemplateFile(this AzureDeploymentValidateSettings toolSettings, string templateFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = templateFile;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.TemplateFile"/>.</em></p><p>A template file path in the file system.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetTemplateFile(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateFile = null;
            return toolSettings;
        }
        #endregion
        #region TemplateUri
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.TemplateUri"/>.</em></p><p>A uri to a remote template file.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetTemplateUri(this AzureDeploymentValidateSettings toolSettings, string templateUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = templateUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.TemplateUri"/>.</em></p><p>A uri to a remote template file.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetTemplateUri(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TemplateUri = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetSubscription(this AzureDeploymentValidateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetSubscription(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetDebug(this AzureDeploymentValidateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetDebug(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetHelp(this AzureDeploymentValidateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetHelp(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetOutput(this AzureDeploymentValidateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetOutput(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetQuery(this AzureDeploymentValidateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetQuery(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentValidateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings SetVerbose(this AzureDeploymentValidateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentValidateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentValidateSettings ResetVerbose(this AzureDeploymentValidateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetName(this AzureDeploymentWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetName(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetCreated(this AzureDeploymentWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Created"/>.</em></p><p>Wait until created with 'provisioningState' at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetCreated(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetCustom(this AzureDeploymentWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetCustom(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetDeleted(this AzureDeploymentWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Deleted"/>.</em></p><p>Wait until deleted.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetDeleted(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetExists(this AzureDeploymentWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetExists(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetInterval(this AzureDeploymentWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetInterval(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetTimeout(this AzureDeploymentWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetTimeout(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetUpdated(this AzureDeploymentWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Updated"/>.</em></p><p>Wait until updated with provisioningState at 'Succeeded'.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetUpdated(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetSubscription(this AzureDeploymentWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetSubscription(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetDebug(this AzureDeploymentWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetDebug(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetHelp(this AzureDeploymentWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetHelp(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetOutput(this AzureDeploymentWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetOutput(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetQuery(this AzureDeploymentWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetQuery(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings SetVerbose(this AzureDeploymentWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentWaitSettings ResetVerbose(this AzureDeploymentWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentOperationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentOperationListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetName(this AzureDeploymentOperationListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetName(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Top"/>.</em></p><p>The number of results to return.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetTop(this AzureDeploymentOperationListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Top"/>.</em></p><p>The number of results to return.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetTop(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetSubscription(this AzureDeploymentOperationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetSubscription(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetDebug(this AzureDeploymentOperationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetDebug(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetHelp(this AzureDeploymentOperationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetHelp(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetOutput(this AzureDeploymentOperationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetOutput(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetQuery(this AzureDeploymentOperationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetQuery(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings SetVerbose(this AzureDeploymentOperationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationListSettings ResetVerbose(this AzureDeploymentOperationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureDeploymentOperationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureDeploymentTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureDeploymentOperationShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetName(this AzureDeploymentOperationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Name"/>.</em></p><p>The deployment name.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetName(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region OperationIds
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.OperationIds"/>.</em></p><p>A list of operation ids to show.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetOperationIds(this AzureDeploymentOperationShowSettings toolSettings, string operationIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OperationIds = operationIds;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.OperationIds"/>.</em></p><p>A list of operation ids to show.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetOperationIds(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OperationIds = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetSubscription(this AzureDeploymentOperationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetSubscription(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetDebug(this AzureDeploymentOperationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetDebug(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetHelp(this AzureDeploymentOperationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetHelp(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetOutput(this AzureDeploymentOperationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetOutput(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetQuery(this AzureDeploymentOperationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetQuery(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureDeploymentOperationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings SetVerbose(this AzureDeploymentOperationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureDeploymentOperationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureDeploymentOperationShowSettings ResetVerbose(this AzureDeploymentOperationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
