// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.20 [CommitSha: 67bb27fd].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzurePolicy.json.

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
    public static partial class AzurePolicyTasks
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public static string AzurePolicyPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage resource policies.</p></summary>
        public static IEnumerable<string> AzurePolicy(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzurePolicyPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzurePolicySettings toolSettings);
        static partial void PostProcess(AzurePolicySettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicy(Configure<AzurePolicySettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicySettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyAssignmentCreateSettings toolSettings);
        static partial void PostProcess(AzurePolicyAssignmentCreateSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyAssignmentCreate(Configure<AzurePolicyAssignmentCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyAssignmentCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyAssignmentDeleteSettings toolSettings);
        static partial void PostProcess(AzurePolicyAssignmentDeleteSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyAssignmentDelete(Configure<AzurePolicyAssignmentDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyAssignmentDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyAssignmentListSettings toolSettings);
        static partial void PostProcess(AzurePolicyAssignmentListSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyAssignmentList(Configure<AzurePolicyAssignmentListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyAssignmentListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyAssignmentShowSettings toolSettings);
        static partial void PostProcess(AzurePolicyAssignmentShowSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyAssignmentShow(Configure<AzurePolicyAssignmentShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyAssignmentShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyDefinitionCreateSettings toolSettings);
        static partial void PostProcess(AzurePolicyDefinitionCreateSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyDefinitionCreate(Configure<AzurePolicyDefinitionCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyDefinitionCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyDefinitionDeleteSettings toolSettings);
        static partial void PostProcess(AzurePolicyDefinitionDeleteSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyDefinitionDelete(Configure<AzurePolicyDefinitionDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyDefinitionDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyDefinitionListSettings toolSettings);
        static partial void PostProcess(AzurePolicyDefinitionListSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyDefinitionList(Configure<AzurePolicyDefinitionListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyDefinitionListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyDefinitionShowSettings toolSettings);
        static partial void PostProcess(AzurePolicyDefinitionShowSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyDefinitionShow(Configure<AzurePolicyDefinitionShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyDefinitionShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicyDefinitionUpdateSettings toolSettings);
        static partial void PostProcess(AzurePolicyDefinitionUpdateSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicyDefinitionUpdate(Configure<AzurePolicyDefinitionUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicyDefinitionUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicySetDefinitionCreateSettings toolSettings);
        static partial void PostProcess(AzurePolicySetDefinitionCreateSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicySetDefinitionCreate(Configure<AzurePolicySetDefinitionCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicySetDefinitionCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicySetDefinitionDeleteSettings toolSettings);
        static partial void PostProcess(AzurePolicySetDefinitionDeleteSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicySetDefinitionDelete(Configure<AzurePolicySetDefinitionDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicySetDefinitionDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicySetDefinitionListSettings toolSettings);
        static partial void PostProcess(AzurePolicySetDefinitionListSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicySetDefinitionList(Configure<AzurePolicySetDefinitionListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicySetDefinitionListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicySetDefinitionShowSettings toolSettings);
        static partial void PostProcess(AzurePolicySetDefinitionShowSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicySetDefinitionShow(Configure<AzurePolicySetDefinitionShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicySetDefinitionShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzurePolicySetDefinitionUpdateSettings toolSettings);
        static partial void PostProcess(AzurePolicySetDefinitionUpdateSettings toolSettings);
        /// <summary><p>Manage resource policies.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/policy?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzurePolicySetDefinitionUpdate(Configure<AzurePolicySetDefinitionUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzurePolicySetDefinitionUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzurePolicySettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
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
              .Add("policy")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicyAssignmentCreateSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>Display name of the assignment.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>Name of the new assignment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated scopes where the policy assignment does not apply.</p></summary>
        public virtual string NotScopes { get; internal set; }
        /// <summary><p>JSON formatted string or path to file with parameter values of policy rule.</p></summary>
        public virtual string Params { get; internal set; }
        /// <summary><p>Name or id of the policy definition.</p></summary>
        public virtual string Policy { get; internal set; }
        /// <summary><p>Name or id of the policy set definition.</p></summary>
        public virtual string PolicySetDefinition { get; internal set; }
        /// <summary><p>The resource group where the policy will be applied.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        public virtual string Scope { get; internal set; }
        /// <summary><p>Policy sku.</p></summary>
        public virtual PolicyAssignmentCreateSku Sku { get; internal set; }
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
              .Add("policy assignment create")
              .Add("--display-name {value}", DisplayName)
              .Add("--name {value}", Name)
              .Add("--not-scopes {value}", NotScopes)
              .Add("--params {value}", Params)
              .Add("--policy {value}", Policy)
              .Add("--policy-set-definition {value}", PolicySetDefinition)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--sku {value}", Sku)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicyAssignmentDeleteSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>Name of the assignment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The resource group where the policy will be applied.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
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
              .Add("policy assignment delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyAssignmentListSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>Include assignment either inherited from parent scope or at child scope.</p></summary>
        public virtual string DisableScopeStrictMatch { get; internal set; }
        /// <summary><p>The resource group where the policy will be applied.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
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
              .Add("policy assignment list")
              .Add("--disable-scope-strict-match {value}", DisableScopeStrictMatch)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyAssignmentShowSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyAssignmentShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>Name of the assignment.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The resource group where the policy will be applied.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
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
              .Add("policy assignment show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzurePolicyDefinitionCreateSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>Name of the new policy definition.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Description of policy definition.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Display name of policy definition.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>Metadata in space-separated key=value pairs.</p></summary>
        public virtual IReadOnlyDictionary<string, string> Metadata => MetadataInternal.AsReadOnly();
        internal Dictionary<string,string> MetadataInternal { get; set; } = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>Mode of the new policy definition.</p></summary>
        public virtual PolicyDefinitionCreateMode Mode { get; internal set; }
        /// <summary><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        public virtual string Params { get; internal set; }
        /// <summary><p>Policy rules in JSON format, or a path to a file containing JSON rules.</p></summary>
        public virtual string Rules { get; internal set; }
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
              .Add("policy definition create")
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--metadata {value}", Metadata, "{key}={value}", separator: ' ')
              .Add("--mode {value}", Mode)
              .Add("--params {value}", Params)
              .Add("--rules {value}", Rules)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicyDefinitionDeleteSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>The policy definition name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("policy definition delete")
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
    #region AzurePolicyDefinitionListSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
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
              .Add("policy definition list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicyDefinitionShowSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>The policy definition name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("policy definition show")
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
    #region AzurePolicyDefinitionUpdateSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicyDefinitionUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>The policy definition name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Description of policy definition.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Display name of policy definition.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>Metadata in space-separated key=value pairs.</p></summary>
        public virtual IReadOnlyDictionary<string, string> Metadata => MetadataInternal.AsReadOnly();
        internal Dictionary<string,string> MetadataInternal { get; set; } = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
        /// <summary><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        public virtual string Params { get; internal set; }
        /// <summary><p>JSON formatted string or a path to a file with such content.</p></summary>
        public virtual string Rules { get; internal set; }
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
              .Add("policy definition update")
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--metadata {value}", Metadata, "{key}={value}", separator: ' ')
              .Add("--params {value}", Params)
              .Add("--rules {value}", Rules)
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
    #region AzurePolicySetDefinitionCreateSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>Policy definitions in JSON format, or a path to a file containing JSON rules.</p></summary>
        public virtual string Definitions { get; internal set; }
        /// <summary><p>Name of the new policy set definition.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Description of policy set definition.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Display name of policy set definition.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        public virtual string Params { get; internal set; }
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
              .Add("policy set-definition create")
              .Add("--definitions {value}", Definitions)
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--params {value}", Params)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicySetDefinitionDeleteSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>The policy set definition name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("policy set-definition delete")
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
    #region AzurePolicySetDefinitionListSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
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
              .Add("policy set-definition list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicySetDefinitionShowSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>The policy set definition name.</p></summary>
        public virtual string Name { get; internal set; }
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
              .Add("policy set-definition show")
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
    #region AzurePolicySetDefinitionUpdateSettings
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzurePolicySetDefinitionUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzurePolicy executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzurePolicyTasks.AzurePolicyPath;
        /// <summary><p>The policy set definition name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>JSON formatted string or a path to a file or uri with such content.</p></summary>
        public virtual string Definitions { get; internal set; }
        /// <summary><p>Description of policy set definition.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>Display name of policy set definition.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        public virtual string Params { get; internal set; }
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
              .Add("policy set-definition update")
              .Add("--name {value}", Name)
              .Add("--definitions {value}", Definitions)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--params {value}", Params)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzurePolicySettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySettings SetDebug(this AzurePolicySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySettings ResetDebug(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySettings SetHelp(this AzurePolicySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySettings ResetHelp(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySettings SetOutput(this AzurePolicySettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySettings ResetOutput(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySettings SetQuery(this AzurePolicySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySettings ResetQuery(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySettings SetVerbose(this AzurePolicySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySettings ResetVerbose(this AzurePolicySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.DisplayName"/>.</em></p><p>Display name of the assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetDisplayName(this AzurePolicyAssignmentCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.DisplayName"/>.</em></p><p>Display name of the assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetDisplayName(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Name"/>.</em></p><p>Name of the new assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetName(this AzurePolicyAssignmentCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Name"/>.</em></p><p>Name of the new assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetName(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NotScopes
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/>.</em></p><p>Space-separated scopes where the policy assignment does not apply.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings, string notScopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopes = notScopes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.NotScopes"/>.</em></p><p>Space-separated scopes where the policy assignment does not apply.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetNotScopes(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NotScopes = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Params"/>.</em></p><p>JSON formatted string or path to file with parameter values of policy rule.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetParams(this AzurePolicyAssignmentCreateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Params"/>.</em></p><p>JSON formatted string or path to file with parameter values of policy rule.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetParams(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Policy
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Policy"/>.</em></p><p>Name or id of the policy definition.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetPolicy(this AzurePolicyAssignmentCreateSettings toolSettings, string policy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = policy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Policy"/>.</em></p><p>Name or id of the policy definition.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetPolicy(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Policy = null;
            return toolSettings;
        }
        #endregion
        #region PolicySetDefinition
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.PolicySetDefinition"/>.</em></p><p>Name or id of the policy set definition.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetPolicySetDefinition(this AzurePolicyAssignmentCreateSettings toolSettings, string policySetDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = policySetDefinition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.PolicySetDefinition"/>.</em></p><p>Name or id of the policy set definition.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetPolicySetDefinition(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PolicySetDefinition = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetResourceGroup(this AzurePolicyAssignmentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetResourceGroup(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetScope(this AzurePolicyAssignmentCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetScope(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Sku"/>.</em></p><p>Policy sku.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetSku(this AzurePolicyAssignmentCreateSettings toolSettings, PolicyAssignmentCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Sku"/>.</em></p><p>Policy sku.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetSku(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetDebug(this AzurePolicyAssignmentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetDebug(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetHelp(this AzurePolicyAssignmentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetHelp(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetOutput(this AzurePolicyAssignmentCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetOutput(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetQuery(this AzurePolicyAssignmentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetQuery(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings SetVerbose(this AzurePolicyAssignmentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentCreateSettings ResetVerbose(this AzurePolicyAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Name"/>.</em></p><p>Name of the assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetName(this AzurePolicyAssignmentDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Name"/>.</em></p><p>Name of the assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetName(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetResourceGroup(this AzurePolicyAssignmentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetResourceGroup(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetScope(this AzurePolicyAssignmentDeleteSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetScope(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetDebug(this AzurePolicyAssignmentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetDebug(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetHelp(this AzurePolicyAssignmentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetHelp(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetOutput(this AzurePolicyAssignmentDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetOutput(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetQuery(this AzurePolicyAssignmentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetQuery(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings SetVerbose(this AzurePolicyAssignmentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentDeleteSettings ResetVerbose(this AzurePolicyAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentListSettingsExtensions
    {
        #region DisableScopeStrictMatch
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.DisableScopeStrictMatch"/>.</em></p><p>Include assignment either inherited from parent scope or at child scope.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetDisableScopeStrictMatch(this AzurePolicyAssignmentListSettings toolSettings, string disableScopeStrictMatch)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableScopeStrictMatch = disableScopeStrictMatch;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.DisableScopeStrictMatch"/>.</em></p><p>Include assignment either inherited from parent scope or at child scope.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetDisableScopeStrictMatch(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableScopeStrictMatch = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetResourceGroup(this AzurePolicyAssignmentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetResourceGroup(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetScope(this AzurePolicyAssignmentListSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetScope(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetDebug(this AzurePolicyAssignmentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetDebug(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetHelp(this AzurePolicyAssignmentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetHelp(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetOutput(this AzurePolicyAssignmentListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetOutput(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetQuery(this AzurePolicyAssignmentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetQuery(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings SetVerbose(this AzurePolicyAssignmentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentListSettings ResetVerbose(this AzurePolicyAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyAssignmentShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyAssignmentShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Name"/>.</em></p><p>Name of the assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetName(this AzurePolicyAssignmentShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Name"/>.</em></p><p>Name of the assignment.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetName(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetResourceGroup(this AzurePolicyAssignmentShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.ResourceGroup"/>.</em></p><p>The resource group where the policy will be applied.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetResourceGroup(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetScope(this AzurePolicyAssignmentShowSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Scope"/>.</em></p><p>Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetScope(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetDebug(this AzurePolicyAssignmentShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetDebug(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetHelp(this AzurePolicyAssignmentShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetHelp(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetOutput(this AzurePolicyAssignmentShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetOutput(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetQuery(this AzurePolicyAssignmentShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetQuery(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyAssignmentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings SetVerbose(this AzurePolicyAssignmentShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyAssignmentShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyAssignmentShowSettings ResetVerbose(this AzurePolicyAssignmentShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Name"/>.</em></p><p>Name of the new policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetName(this AzurePolicyDefinitionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Name"/>.</em></p><p>Name of the new policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetName(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Description"/>.</em></p><p>Description of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetDescription(this AzurePolicyDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Description"/>.</em></p><p>Description of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetDescription(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.DisplayName"/>.</em></p><p>Display name of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetDisplayName(this AzurePolicyDefinitionCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.DisplayName"/>.</em></p><p>Display name of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetDisplayName(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Metadata
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/> to a new dictionary.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetMetadata(this AzurePolicyDefinitionCreateSettings toolSettings, IDictionary<string, string> metadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal = metadata.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ClearMetadata(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings AddMetadatum(this AzurePolicyDefinitionCreateSettings toolSettings, string metadatumKey, string metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Add(metadatumKey, metadatumValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings RemoveMetadatum(this AzurePolicyDefinitionCreateSettings toolSettings, string metadatumKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Remove(metadatumKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="AzurePolicyDefinitionCreateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetMetadatum(this AzurePolicyDefinitionCreateSettings toolSettings, string metadatumKey, string metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal[metadatumKey] = metadatumValue;
            return toolSettings;
        }
        #endregion
        #region Mode
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Mode"/>.</em></p><p>Mode of the new policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetMode(this AzurePolicyDefinitionCreateSettings toolSettings, PolicyDefinitionCreateMode mode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = mode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Mode"/>.</em></p><p>Mode of the new policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetMode(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mode = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetParams(this AzurePolicyDefinitionCreateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetParams(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Rules
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Rules"/>.</em></p><p>Policy rules in JSON format, or a path to a file containing JSON rules.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetRules(this AzurePolicyDefinitionCreateSettings toolSettings, string rules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = rules;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Rules"/>.</em></p><p>Policy rules in JSON format, or a path to a file containing JSON rules.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetRules(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetDebug(this AzurePolicyDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetDebug(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetHelp(this AzurePolicyDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetHelp(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetOutput(this AzurePolicyDefinitionCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetOutput(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetQuery(this AzurePolicyDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetQuery(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings SetVerbose(this AzurePolicyDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionCreateSettings ResetVerbose(this AzurePolicyDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Name"/>.</em></p><p>The policy definition name.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetName(this AzurePolicyDefinitionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Name"/>.</em></p><p>The policy definition name.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetName(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetDebug(this AzurePolicyDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetDebug(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetHelp(this AzurePolicyDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetHelp(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetOutput(this AzurePolicyDefinitionDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetOutput(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetQuery(this AzurePolicyDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetQuery(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings SetVerbose(this AzurePolicyDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionDeleteSettings ResetVerbose(this AzurePolicyDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetDebug(this AzurePolicyDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetDebug(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetHelp(this AzurePolicyDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetHelp(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetOutput(this AzurePolicyDefinitionListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetOutput(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetQuery(this AzurePolicyDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetQuery(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings SetVerbose(this AzurePolicyDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionListSettings ResetVerbose(this AzurePolicyDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Name"/>.</em></p><p>The policy definition name.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetName(this AzurePolicyDefinitionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Name"/>.</em></p><p>The policy definition name.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetName(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetDebug(this AzurePolicyDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetDebug(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetHelp(this AzurePolicyDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetHelp(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetOutput(this AzurePolicyDefinitionShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetOutput(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetQuery(this AzurePolicyDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetQuery(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings SetVerbose(this AzurePolicyDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionShowSettings ResetVerbose(this AzurePolicyDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicyDefinitionUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicyDefinitionUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Name"/>.</em></p><p>The policy definition name.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetName(this AzurePolicyDefinitionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Name"/>.</em></p><p>The policy definition name.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetName(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Description"/>.</em></p><p>Description of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetDescription(this AzurePolicyDefinitionUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Description"/>.</em></p><p>Description of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetDescription(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.DisplayName"/>.</em></p><p>Display name of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetDisplayName(this AzurePolicyDefinitionUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.DisplayName"/>.</em></p><p>Display name of policy definition.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetDisplayName(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Metadata
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/> to a new dictionary.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetMetadata(this AzurePolicyDefinitionUpdateSettings toolSettings, IDictionary<string, string> metadata)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal = metadata.ToDictionary(x => x.Key, x => x.Value, StringComparer.OrdinalIgnoreCase);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ClearMetadata(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Adds a new key-value-pair <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings AddMetadatum(this AzurePolicyDefinitionUpdateSettings toolSettings, string metadatumKey, string metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Add(metadatumKey, metadatumValue);
            return toolSettings;
        }
        /// <summary><p><em>Removes a key-value-pair from <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings RemoveMetadatum(this AzurePolicyDefinitionUpdateSettings toolSettings, string metadatumKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal.Remove(metadatumKey);
            return toolSettings;
        }
        /// <summary><p><em>Sets a key-value-pair in <see cref="AzurePolicyDefinitionUpdateSettings.Metadata"/>.</em></p><p>Metadata in space-separated key=value pairs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetMetadatum(this AzurePolicyDefinitionUpdateSettings toolSettings, string metadatumKey, string metadatumValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MetadataInternal[metadatumKey] = metadatumValue;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetParams(this AzurePolicyDefinitionUpdateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetParams(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Rules
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Rules"/>.</em></p><p>JSON formatted string or a path to a file with such content.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetRules(this AzurePolicyDefinitionUpdateSettings toolSettings, string rules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = rules;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Rules"/>.</em></p><p>JSON formatted string or a path to a file with such content.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetRules(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Rules = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetAdd(this AzurePolicyDefinitionUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetAdd(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetRemove(this AzurePolicyDefinitionUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetRemove(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetSet(this AzurePolicyDefinitionUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetSet(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetDebug(this AzurePolicyDefinitionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetDebug(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetHelp(this AzurePolicyDefinitionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetHelp(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetOutput(this AzurePolicyDefinitionUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetOutput(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetQuery(this AzurePolicyDefinitionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetQuery(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicyDefinitionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings SetVerbose(this AzurePolicyDefinitionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicyDefinitionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicyDefinitionUpdateSettings ResetVerbose(this AzurePolicyDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionCreateSettingsExtensions
    {
        #region Definitions
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Definitions"/>.</em></p><p>Policy definitions in JSON format, or a path to a file containing JSON rules.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDefinitions(this AzurePolicySetDefinitionCreateSettings toolSettings, string definitions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = definitions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Definitions"/>.</em></p><p>Policy definitions in JSON format, or a path to a file containing JSON rules.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDefinitions(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Name"/>.</em></p><p>Name of the new policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetName(this AzurePolicySetDefinitionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Name"/>.</em></p><p>Name of the new policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetName(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Description"/>.</em></p><p>Description of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDescription(this AzurePolicySetDefinitionCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Description"/>.</em></p><p>Description of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDescription(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.DisplayName"/>.</em></p><p>Display name of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDisplayName(this AzurePolicySetDefinitionCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.DisplayName"/>.</em></p><p>Display name of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDisplayName(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetParams(this AzurePolicySetDefinitionCreateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetParams(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetDebug(this AzurePolicySetDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetDebug(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetHelp(this AzurePolicySetDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetHelp(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetOutput(this AzurePolicySetDefinitionCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetOutput(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetQuery(this AzurePolicySetDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetQuery(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings SetVerbose(this AzurePolicySetDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionCreateSettings ResetVerbose(this AzurePolicySetDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Name"/>.</em></p><p>The policy set definition name.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetName(this AzurePolicySetDefinitionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Name"/>.</em></p><p>The policy set definition name.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetName(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetDebug(this AzurePolicySetDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetDebug(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetHelp(this AzurePolicySetDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetHelp(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetOutput(this AzurePolicySetDefinitionDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetOutput(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetQuery(this AzurePolicySetDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetQuery(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings SetVerbose(this AzurePolicySetDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionDeleteSettings ResetVerbose(this AzurePolicySetDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetDebug(this AzurePolicySetDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetDebug(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetHelp(this AzurePolicySetDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetHelp(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetOutput(this AzurePolicySetDefinitionListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetOutput(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetQuery(this AzurePolicySetDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetQuery(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings SetVerbose(this AzurePolicySetDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionListSettings ResetVerbose(this AzurePolicySetDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Name"/>.</em></p><p>The policy set definition name.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetName(this AzurePolicySetDefinitionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Name"/>.</em></p><p>The policy set definition name.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetName(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetDebug(this AzurePolicySetDefinitionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetDebug(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetHelp(this AzurePolicySetDefinitionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetHelp(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetOutput(this AzurePolicySetDefinitionShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetOutput(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetQuery(this AzurePolicySetDefinitionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetQuery(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings SetVerbose(this AzurePolicySetDefinitionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionShowSettings ResetVerbose(this AzurePolicySetDefinitionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzurePolicySetDefinitionUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzurePolicySetDefinitionUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Name"/>.</em></p><p>The policy set definition name.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetName(this AzurePolicySetDefinitionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Name"/>.</em></p><p>The policy set definition name.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetName(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Definitions
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Definitions"/>.</em></p><p>JSON formatted string or a path to a file or uri with such content.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDefinitions(this AzurePolicySetDefinitionUpdateSettings toolSettings, string definitions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = definitions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Definitions"/>.</em></p><p>JSON formatted string or a path to a file or uri with such content.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDefinitions(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Definitions = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Description"/>.</em></p><p>Description of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDescription(this AzurePolicySetDefinitionUpdateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Description"/>.</em></p><p>Description of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDescription(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.DisplayName"/>.</em></p><p>Display name of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDisplayName(this AzurePolicySetDefinitionUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.DisplayName"/>.</em></p><p>Display name of policy set definition.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDisplayName(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Params
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetParams(this AzurePolicySetDefinitionUpdateSettings toolSettings, string @params)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = @params;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Params"/>.</em></p><p>JSON formatted string or a path to a file or uri with parameter definitions.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetParams(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Params = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetDebug(this AzurePolicySetDefinitionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetDebug(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetHelp(this AzurePolicySetDefinitionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetHelp(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetOutput(this AzurePolicySetDefinitionUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetOutput(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetQuery(this AzurePolicySetDefinitionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetQuery(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzurePolicySetDefinitionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings SetVerbose(this AzurePolicySetDefinitionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzurePolicySetDefinitionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzurePolicySetDefinitionUpdateSettings ResetVerbose(this AzurePolicySetDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PolicyAssignmentCreateSku
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class PolicyAssignmentCreateSku : Enumeration
    {
        public static PolicyAssignmentCreateSku free = new PolicyAssignmentCreateSku { Value = "free" };
        public static PolicyAssignmentCreateSku standard = new PolicyAssignmentCreateSku { Value = "standard" };
    }
    #endregion
    #region PolicyDefinitionCreateMode
    /// <summary><p>Used within <see cref="AzurePolicyTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class PolicyDefinitionCreateMode : Enumeration
    {
        public static PolicyDefinitionCreateMode all = new PolicyDefinitionCreateMode { Value = "all" };
        public static PolicyDefinitionCreateMode indexed = new PolicyDefinitionCreateMode { Value = "indexed" };
        public static PolicyDefinitionCreateMode notspecified = new PolicyDefinitionCreateMode { Value = "notspecified" };
    }
    #endregion
}
