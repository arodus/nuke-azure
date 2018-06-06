// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0 [CommitSha: 3eaf2b72].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureResource.json.

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
    public static partial class AzureResourceTasks
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public static string AzureResourcePath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure resources.</p></summary>
        public static IEnumerable<string> AzureResource(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureResourcePath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureResourceCreateSettings toolSettings);
        static partial void PostProcess(AzureResourceCreateSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceCreate(Configure<AzureResourceCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceDeleteSettings toolSettings);
        static partial void PostProcess(AzureResourceDeleteSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceDelete(Configure<AzureResourceDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceInvokeActionSettings toolSettings);
        static partial void PostProcess(AzureResourceInvokeActionSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceInvokeAction(Configure<AzureResourceInvokeActionSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceInvokeActionSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceListSettings toolSettings);
        static partial void PostProcess(AzureResourceListSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceList(Configure<AzureResourceListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceMoveSettings toolSettings);
        static partial void PostProcess(AzureResourceMoveSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceMove(Configure<AzureResourceMoveSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceMoveSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceShowSettings toolSettings);
        static partial void PostProcess(AzureResourceShowSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceShow(Configure<AzureResourceShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceTagSettings toolSettings);
        static partial void PostProcess(AzureResourceTagSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceTag(Configure<AzureResourceTagSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceTagSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceUpdateSettings toolSettings);
        static partial void PostProcess(AzureResourceUpdateSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceUpdate(Configure<AzureResourceUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLinkCreateSettings toolSettings);
        static partial void PostProcess(AzureResourceLinkCreateSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLinkCreate(Configure<AzureResourceLinkCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLinkCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLinkDeleteSettings toolSettings);
        static partial void PostProcess(AzureResourceLinkDeleteSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLinkDelete(Configure<AzureResourceLinkDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLinkDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLinkListSettings toolSettings);
        static partial void PostProcess(AzureResourceLinkListSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLinkList(Configure<AzureResourceLinkListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLinkListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLinkShowSettings toolSettings);
        static partial void PostProcess(AzureResourceLinkShowSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLinkShow(Configure<AzureResourceLinkShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLinkShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLinkUpdateSettings toolSettings);
        static partial void PostProcess(AzureResourceLinkUpdateSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLinkUpdate(Configure<AzureResourceLinkUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLinkUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLockCreateSettings toolSettings);
        static partial void PostProcess(AzureResourceLockCreateSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLockCreate(Configure<AzureResourceLockCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLockCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLockDeleteSettings toolSettings);
        static partial void PostProcess(AzureResourceLockDeleteSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLockDelete(Configure<AzureResourceLockDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLockDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLockListSettings toolSettings);
        static partial void PostProcess(AzureResourceLockListSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLockList(Configure<AzureResourceLockListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLockListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLockShowSettings toolSettings);
        static partial void PostProcess(AzureResourceLockShowSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLockShow(Configure<AzureResourceLockShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLockShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureResourceLockUpdateSettings toolSettings);
        static partial void PostProcess(AzureResourceLockUpdateSettings toolSettings);
        /// <summary><p>Manage Azure resources.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/resource?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureResourceLockUpdate(Configure<AzureResourceLockUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureResourceLockUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureResourceCreateSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>A JSON-formatted string containing resource properties.</p></summary>
        public virtual string Properties { get; internal set; }
        /// <summary><p>Resource ID.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Indicates that the properties object includes other options such as location, tags, sku, and/or plan.</p></summary>
        public virtual string IsFullObject { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The api version of the resource (omit for latest).</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource create")
              .Add("--properties {value}", Properties)
              .Add("--id {value}", Id)
              .Add("--is-full-object {value}", IsFullObject)
              .Add("--location {value}", Location)
              .Add("--api-version {value}", ApiVersion)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceDeleteSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>The api version of the resource (omit for latest).</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource delete")
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceInvokeActionSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceInvokeActionSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>The action that will be invoked on the specified resource.</p></summary>
        public virtual string Action { get; internal set; }
        /// <summary><p>JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.</p></summary>
        public virtual string RequestBody { get; internal set; }
        /// <summary><p>The api version of the resource (omit for latest).</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource invoke-action")
              .Add("--action {value}", Action)
              .Add("--request-body {value}", RequestBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceListSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tag { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource list")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--tag {value}", Tag)
              .Add("--namespace {value}", Namespace)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceMoveSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceMoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>The destination resource group name.</p></summary>
        public virtual string DestinationGroup { get; internal set; }
        /// <summary><p>The space-separated resource ids to be moved.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The destination subscription identifier.</p></summary>
        public virtual string DestinationSubscriptionId { get; internal set; }
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
              .Add("resource move")
              .Add("--destination-group {value}", DestinationGroup)
              .Add("--ids {value}", Ids)
              .Add("--destination-subscription-id {value}", DestinationSubscriptionId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceShowSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        public virtual bool? IncludeResponseBody { get; internal set; }
        /// <summary><p>The api version of the resource (omit for latest).</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource show")
              .Add("--include-response-body", IncludeResponseBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceTagSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceTagSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The api version of the resource (omit for latest).</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource tag")
              .Add("--tags {value}", Tags)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceUpdateSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        public virtual bool? IncludeResponseBody { get; internal set; }
        /// <summary><p>The api version of the resource (omit for latest).</p></summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The resource name. (Ex: myC).</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
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
              .Add("resource update")
              .Add("--include-response-body", IncludeResponseBody)
              .Add("--api-version {value}", ApiVersion)
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--add {value}", Add)
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
    #region AzureResourceLinkCreateSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p></p></summary>
        public virtual string LinkId { get; internal set; }
        /// <summary><p>The id of the resource link target.</p></summary>
        public virtual string TargetId { get; internal set; }
        /// <summary><p>Notes for this link.</p></summary>
        public virtual string Notes { get; internal set; }
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
              .Add("resource link create")
              .Add("--link-id {value}", LinkId)
              .Add("--target-id {value}", TargetId)
              .Add("--notes {value}", Notes)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLinkDeleteSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink.</p></summary>
        public virtual string LinkId { get; internal set; }
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
              .Add("resource link delete")
              .Add("--link-id {value}", LinkId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLinkListSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>A filter for restricting the results.</p></summary>
        public virtual string FilterString { get; internal set; }
        /// <summary><p>The scope for the links.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("resource link list")
              .Add("--filter-string {value}", FilterString)
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
    #region AzureResourceLinkShowSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink.</p></summary>
        public virtual string LinkId { get; internal set; }
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
              .Add("resource link show")
              .Add("--link-id {value}", LinkId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLinkUpdateSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLinkUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p></p></summary>
        public virtual string LinkId { get; internal set; }
        /// <summary><p>Notes for this link.</p></summary>
        public virtual string Notes { get; internal set; }
        /// <summary><p>The id of the resource link target.</p></summary>
        public virtual string TargetId { get; internal set; }
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
              .Add("resource link update")
              .Add("--link-id {value}", LinkId)
              .Add("--notes {value}", Notes)
              .Add("--target-id {value}", TargetId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLockCreateSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p></p></summary>
        public virtual ResourceLockLockType LockType { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Notes about this lock.</p></summary>
        public virtual string Notes { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLockDeleteSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource lock delete")
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLockListSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>A query filter to use to restrict the results.</p></summary>
        public virtual string FilterString { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource lock list")
              .Add("--filter-string {value}", FilterString)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLockShowSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource lock show")
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceLockUpdateSettings
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureResourceLockUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureResource executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureResourceTasks.AzureResourcePath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p></p></summary>
        public virtual ResourceLockLockType LockType { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Notes about this lock.</p></summary>
        public virtual string Notes { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("resource lock update")
              .Add("--ids {value}", Ids)
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--notes {value}", Notes)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureResourceCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceCreateSettingsExtensions
    {
        #region Properties
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Properties"/>.</em></p><p>A JSON-formatted string containing resource properties.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetProperties(this AzureResourceCreateSettings toolSettings, string properties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Properties = properties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Properties"/>.</em></p><p>A JSON-formatted string containing resource properties.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetProperties(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Properties = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Id"/>.</em></p><p>Resource ID.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetId(this AzureResourceCreateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Id"/>.</em></p><p>Resource ID.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetId(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region IsFullObject
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.IsFullObject"/>.</em></p><p>Indicates that the properties object includes other options such as location, tags, sku, and/or plan.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetIsFullObject(this AzureResourceCreateSettings toolSettings, string isFullObject)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsFullObject = isFullObject;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.IsFullObject"/>.</em></p><p>Indicates that the properties object includes other options such as location, tags, sku, and/or plan.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetIsFullObject(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsFullObject = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetLocation(this AzureResourceCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetLocation(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetApiVersion(this AzureResourceCreateSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetApiVersion(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetName(this AzureResourceCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetName(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetNamespace(this AzureResourceCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetNamespace(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetParent(this AzureResourceCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetParent(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetResourceGroup(this AzureResourceCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetResourceGroup(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetResourceType(this AzureResourceCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetResourceType(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetDebug(this AzureResourceCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetDebug(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetHelp(this AzureResourceCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetHelp(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetOutput(this AzureResourceCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetOutput(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetQuery(this AzureResourceCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetQuery(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings SetVerbose(this AzureResourceCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceCreateSettings ResetVerbose(this AzureResourceCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceDeleteSettingsExtensions
    {
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetApiVersion(this AzureResourceDeleteSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetApiVersion(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetIds(this AzureResourceDeleteSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetIds(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetName(this AzureResourceDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetName(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetNamespace(this AzureResourceDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetNamespace(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetParent(this AzureResourceDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetParent(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetResourceGroup(this AzureResourceDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetResourceGroup(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetResourceType(this AzureResourceDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetResourceType(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetDebug(this AzureResourceDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetDebug(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetHelp(this AzureResourceDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetHelp(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetOutput(this AzureResourceDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetOutput(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetQuery(this AzureResourceDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetQuery(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings SetVerbose(this AzureResourceDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceDeleteSettings ResetVerbose(this AzureResourceDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceInvokeActionSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceInvokeActionSettingsExtensions
    {
        #region Action
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Action"/>.</em></p><p>The action that will be invoked on the specified resource.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetAction(this AzureResourceInvokeActionSettings toolSettings, string action)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = action;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Action"/>.</em></p><p>The action that will be invoked on the specified resource.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetAction(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Action = null;
            return toolSettings;
        }
        #endregion
        #region RequestBody
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.RequestBody"/>.</em></p><p>JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetRequestBody(this AzureResourceInvokeActionSettings toolSettings, string requestBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequestBody = requestBody;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.RequestBody"/>.</em></p><p>JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetRequestBody(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequestBody = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetApiVersion(this AzureResourceInvokeActionSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetApiVersion(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetIds(this AzureResourceInvokeActionSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetIds(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetName(this AzureResourceInvokeActionSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetName(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetNamespace(this AzureResourceInvokeActionSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetNamespace(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetParent(this AzureResourceInvokeActionSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetParent(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetResourceGroup(this AzureResourceInvokeActionSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetResourceGroup(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetResourceType(this AzureResourceInvokeActionSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetResourceType(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetDebug(this AzureResourceInvokeActionSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetDebug(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetHelp(this AzureResourceInvokeActionSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetHelp(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetOutput(this AzureResourceInvokeActionSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetOutput(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetQuery(this AzureResourceInvokeActionSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetQuery(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceInvokeActionSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings SetVerbose(this AzureResourceInvokeActionSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceInvokeActionSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceInvokeActionSettings ResetVerbose(this AzureResourceInvokeActionSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceListSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetLocation(this AzureResourceListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetLocation(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceListSettings SetName(this AzureResourceListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetName(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Tag
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Tag"/>.</em></p><p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetTag(this AzureResourceListSettings toolSettings, string tag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tag = tag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Tag"/>.</em></p><p>A single tag in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetTag(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tag = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceListSettings SetNamespace(this AzureResourceListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetNamespace(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetResourceGroup(this AzureResourceListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetResourceGroup(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceListSettings SetResourceType(this AzureResourceListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetResourceType(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetDebug(this AzureResourceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetDebug(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetHelp(this AzureResourceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetHelp(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetOutput(this AzureResourceListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetOutput(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetQuery(this AzureResourceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetQuery(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceListSettings SetVerbose(this AzureResourceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceListSettings ResetVerbose(this AzureResourceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceMoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceMoveSettingsExtensions
    {
        #region DestinationGroup
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.DestinationGroup"/>.</em></p><p>The destination resource group name.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetDestinationGroup(this AzureResourceMoveSettings toolSettings, string destinationGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationGroup = destinationGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.DestinationGroup"/>.</em></p><p>The destination resource group name.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetDestinationGroup(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationGroup = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.Ids"/>.</em></p><p>The space-separated resource ids to be moved.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetIds(this AzureResourceMoveSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.Ids"/>.</em></p><p>The space-separated resource ids to be moved.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetIds(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region DestinationSubscriptionId
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.DestinationSubscriptionId"/>.</em></p><p>The destination subscription identifier.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetDestinationSubscriptionId(this AzureResourceMoveSettings toolSettings, string destinationSubscriptionId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationSubscriptionId = destinationSubscriptionId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.DestinationSubscriptionId"/>.</em></p><p>The destination subscription identifier.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetDestinationSubscriptionId(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DestinationSubscriptionId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetDebug(this AzureResourceMoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetDebug(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetHelp(this AzureResourceMoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetHelp(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetOutput(this AzureResourceMoveSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetOutput(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetQuery(this AzureResourceMoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetQuery(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceMoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings SetVerbose(this AzureResourceMoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceMoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceMoveSettings ResetVerbose(this AzureResourceMoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceShowSettingsExtensions
    {
        #region IncludeResponseBody
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetIncludeResponseBody(this AzureResourceShowSettings toolSettings, bool? includeResponseBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = includeResponseBody;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureResourceShowSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceShowSettings EnableIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureResourceShowSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceShowSettings DisableIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureResourceShowSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ToggleIncludeResponseBody(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = !toolSettings.IncludeResponseBody;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetApiVersion(this AzureResourceShowSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetApiVersion(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetIds(this AzureResourceShowSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetIds(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetName(this AzureResourceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetName(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetNamespace(this AzureResourceShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetNamespace(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetParent(this AzureResourceShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetParent(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetResourceGroup(this AzureResourceShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetResourceGroup(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetResourceType(this AzureResourceShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetResourceType(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetDebug(this AzureResourceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetDebug(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetHelp(this AzureResourceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetHelp(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetOutput(this AzureResourceShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetOutput(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetQuery(this AzureResourceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetQuery(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceShowSettings SetVerbose(this AzureResourceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceShowSettings ResetVerbose(this AzureResourceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceTagSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceTagSettingsExtensions
    {
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetTags(this AzureResourceTagSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetTags(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetApiVersion(this AzureResourceTagSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetApiVersion(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetIds(this AzureResourceTagSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetIds(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetName(this AzureResourceTagSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetName(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetNamespace(this AzureResourceTagSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetNamespace(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetParent(this AzureResourceTagSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetParent(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetResourceGroup(this AzureResourceTagSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetResourceGroup(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetResourceType(this AzureResourceTagSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetResourceType(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetDebug(this AzureResourceTagSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetDebug(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetHelp(this AzureResourceTagSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetHelp(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetOutput(this AzureResourceTagSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetOutput(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetQuery(this AzureResourceTagSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetQuery(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceTagSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceTagSettings SetVerbose(this AzureResourceTagSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceTagSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceTagSettings ResetVerbose(this AzureResourceTagSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceUpdateSettingsExtensions
    {
        #region IncludeResponseBody
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetIncludeResponseBody(this AzureResourceUpdateSettings toolSettings, bool? includeResponseBody)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = includeResponseBody;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings EnableIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings DisableIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureResourceUpdateSettings.IncludeResponseBody"/>.</em></p><p>Use if the default command output doesn't capture all of the property data.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ToggleIncludeResponseBody(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeResponseBody = !toolSettings.IncludeResponseBody;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetApiVersion(this AzureResourceUpdateSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.ApiVersion"/>.</em></p><p>The api version of the resource (omit for latest).</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetApiVersion(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetIds(this AzureResourceUpdateSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetIds(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetName(this AzureResourceUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Name"/>.</em></p><p>The resource name. (Ex: myC).</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetName(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetNamespace(this AzureResourceUpdateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetNamespace(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetParent(this AzureResourceUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetParent(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetResourceGroup(this AzureResourceUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetResourceGroup(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetResourceType(this AzureResourceUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetResourceType(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetAdd(this AzureResourceUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetAdd(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetRemove(this AzureResourceUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetRemove(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetSet(this AzureResourceUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetSet(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetDebug(this AzureResourceUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetDebug(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetHelp(this AzureResourceUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetHelp(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetOutput(this AzureResourceUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetOutput(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetQuery(this AzureResourceUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetQuery(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings SetVerbose(this AzureResourceUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceUpdateSettings ResetVerbose(this AzureResourceUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkCreateSettingsExtensions
    {
        #region LinkId
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.LinkId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetLinkId(this AzureResourceLinkCreateSettings toolSettings, string linkId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = linkId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.LinkId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetLinkId(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = null;
            return toolSettings;
        }
        #endregion
        #region TargetId
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.TargetId"/>.</em></p><p>The id of the resource link target.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetTargetId(this AzureResourceLinkCreateSettings toolSettings, string targetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = targetId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.TargetId"/>.</em></p><p>The id of the resource link target.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetTargetId(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.Notes"/>.</em></p><p>Notes for this link.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetNotes(this AzureResourceLinkCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.Notes"/>.</em></p><p>Notes for this link.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetNotes(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetDebug(this AzureResourceLinkCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetDebug(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetHelp(this AzureResourceLinkCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetHelp(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetOutput(this AzureResourceLinkCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetOutput(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetQuery(this AzureResourceLinkCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetQuery(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLinkCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings SetVerbose(this AzureResourceLinkCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkCreateSettings ResetVerbose(this AzureResourceLinkCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkDeleteSettingsExtensions
    {
        #region LinkId
        /// <summary><p><em>Sets <see cref="AzureResourceLinkDeleteSettings.LinkId"/>.</em></p><p>The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetLinkId(this AzureResourceLinkDeleteSettings toolSettings, string linkId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = linkId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkDeleteSettings.LinkId"/>.</em></p><p>The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetLinkId(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetDebug(this AzureResourceLinkDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetDebug(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetHelp(this AzureResourceLinkDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetHelp(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetOutput(this AzureResourceLinkDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetOutput(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetQuery(this AzureResourceLinkDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetQuery(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLinkDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings SetVerbose(this AzureResourceLinkDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkDeleteSettings ResetVerbose(this AzureResourceLinkDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkListSettingsExtensions
    {
        #region FilterString
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.FilterString"/>.</em></p><p>A filter for restricting the results.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetFilterString(this AzureResourceLinkListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.FilterString"/>.</em></p><p>A filter for restricting the results.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetFilterString(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.Scope"/>.</em></p><p>The scope for the links.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetScope(this AzureResourceLinkListSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.Scope"/>.</em></p><p>The scope for the links.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetScope(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetDebug(this AzureResourceLinkListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetDebug(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetHelp(this AzureResourceLinkListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetHelp(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetOutput(this AzureResourceLinkListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetOutput(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetQuery(this AzureResourceLinkListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetQuery(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLinkListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings SetVerbose(this AzureResourceLinkListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkListSettings ResetVerbose(this AzureResourceLinkListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkShowSettingsExtensions
    {
        #region LinkId
        /// <summary><p><em>Sets <see cref="AzureResourceLinkShowSettings.LinkId"/>.</em></p><p>The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetLinkId(this AzureResourceLinkShowSettings toolSettings, string linkId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = linkId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkShowSettings.LinkId"/>.</em></p><p>The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetLinkId(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLinkShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetDebug(this AzureResourceLinkShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetDebug(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLinkShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetHelp(this AzureResourceLinkShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetHelp(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLinkShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetOutput(this AzureResourceLinkShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetOutput(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLinkShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetQuery(this AzureResourceLinkShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetQuery(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLinkShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings SetVerbose(this AzureResourceLinkShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkShowSettings ResetVerbose(this AzureResourceLinkShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLinkUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLinkUpdateSettingsExtensions
    {
        #region LinkId
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.LinkId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetLinkId(this AzureResourceLinkUpdateSettings toolSettings, string linkId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = linkId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.LinkId"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetLinkId(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinkId = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Notes"/>.</em></p><p>Notes for this link.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetNotes(this AzureResourceLinkUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Notes"/>.</em></p><p>Notes for this link.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetNotes(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region TargetId
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.TargetId"/>.</em></p><p>The id of the resource link target.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetTargetId(this AzureResourceLinkUpdateSettings toolSettings, string targetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = targetId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.TargetId"/>.</em></p><p>The id of the resource link target.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetTargetId(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetDebug(this AzureResourceLinkUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetDebug(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetHelp(this AzureResourceLinkUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetHelp(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetOutput(this AzureResourceLinkUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetOutput(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetQuery(this AzureResourceLinkUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetQuery(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLinkUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings SetVerbose(this AzureResourceLinkUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLinkUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLinkUpdateSettings ResetVerbose(this AzureResourceLinkUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetLockType(this AzureResourceLockCreateSettings toolSettings, ResourceLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetLockType(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetName(this AzureResourceLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetName(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetNotes(this AzureResourceLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetNotes(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetResourceGroup(this AzureResourceLockCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetResourceGroup(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetNamespace(this AzureResourceLockCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetNamespace(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetParent(this AzureResourceLockCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetParent(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetResource(this AzureResourceLockCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetResource(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetResourceType(this AzureResourceLockCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetResourceType(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetDebug(this AzureResourceLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetDebug(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetHelp(this AzureResourceLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetHelp(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetOutput(this AzureResourceLockCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetOutput(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetQuery(this AzureResourceLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetQuery(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLockCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings SetVerbose(this AzureResourceLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockCreateSettings ResetVerbose(this AzureResourceLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetIds(this AzureResourceLockDeleteSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetIds(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetName(this AzureResourceLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetName(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetResourceGroup(this AzureResourceLockDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetResourceGroup(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetNamespace(this AzureResourceLockDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetNamespace(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetParent(this AzureResourceLockDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetParent(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetResource(this AzureResourceLockDeleteSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetResource(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetResourceType(this AzureResourceLockDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetResourceType(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetDebug(this AzureResourceLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetDebug(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetHelp(this AzureResourceLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetHelp(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetOutput(this AzureResourceLockDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetOutput(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetQuery(this AzureResourceLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetQuery(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLockDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings SetVerbose(this AzureResourceLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockDeleteSettings ResetVerbose(this AzureResourceLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockListSettingsExtensions
    {
        #region FilterString
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.FilterString"/>.</em></p><p>A query filter to use to restrict the results.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetFilterString(this AzureResourceLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.FilterString"/>.</em></p><p>A query filter to use to restrict the results.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetFilterString(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetResourceGroup(this AzureResourceLockListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetResourceGroup(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetNamespace(this AzureResourceLockListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetNamespace(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetParent(this AzureResourceLockListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetParent(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetResource(this AzureResourceLockListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetResource(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetResourceType(this AzureResourceLockListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetResourceType(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetDebug(this AzureResourceLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetDebug(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetHelp(this AzureResourceLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetHelp(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetOutput(this AzureResourceLockListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetOutput(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetQuery(this AzureResourceLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetQuery(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLockListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings SetVerbose(this AzureResourceLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockListSettings ResetVerbose(this AzureResourceLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockShowSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetIds(this AzureResourceLockShowSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetIds(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetName(this AzureResourceLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetName(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetResourceGroup(this AzureResourceLockShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetResourceGroup(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetNamespace(this AzureResourceLockShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetNamespace(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetParent(this AzureResourceLockShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetParent(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetResource(this AzureResourceLockShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetResource(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetResourceType(this AzureResourceLockShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetResourceType(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetDebug(this AzureResourceLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetDebug(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetHelp(this AzureResourceLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetHelp(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetOutput(this AzureResourceLockShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetOutput(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetQuery(this AzureResourceLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetQuery(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLockShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings SetVerbose(this AzureResourceLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockShowSettings ResetVerbose(this AzureResourceLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureResourceLockUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureResourceLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetIds(this AzureResourceLockUpdateSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetIds(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetLockType(this AzureResourceLockUpdateSettings toolSettings, ResourceLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetLockType(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetName(this AzureResourceLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetName(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetNotes(this AzureResourceLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetNotes(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetResourceGroup(this AzureResourceLockUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetResourceGroup(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetNamespace(this AzureResourceLockUpdateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetNamespace(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetParent(this AzureResourceLockUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetParent(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetResource(this AzureResourceLockUpdateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Resource"/>.</em></p><p>If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetResource(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetResourceType(this AzureResourceLockUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetResourceType(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetDebug(this AzureResourceLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetDebug(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetHelp(this AzureResourceLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetHelp(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetOutput(this AzureResourceLockUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetOutput(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetQuery(this AzureResourceLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetQuery(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureResourceLockUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings SetVerbose(this AzureResourceLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureResourceLockUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureResourceLockUpdateSettings ResetVerbose(this AzureResourceLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ResourceLockLockType
    /// <summary><p>Used within <see cref="AzureResourceTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class ResourceLockLockType : Enumeration
    {
        public static ResourceLockLockType cannotdelete = new ResourceLockLockType { Value = "cannotdelete" };
        public static ResourceLockLockType readonly_ = new ResourceLockLockType { Value = "readonly" };
    }
    #endregion
}
