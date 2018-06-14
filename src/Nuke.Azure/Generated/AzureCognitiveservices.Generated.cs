// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCognitiveservices.json.

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
    public static partial class AzureCognitiveservicesTasks
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public static string AzureCognitiveservicesPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Cognitive Services accounts.</p></summary>
        public static IEnumerable<string> AzureCognitiveservices(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureCognitiveservicesPath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureCognitiveservicesListSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesListSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesList(Configure<AzureCognitiveservicesListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountCreateSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountCreateSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountCreate(Configure<AzureCognitiveservicesAccountCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountDeleteSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountDelete(Configure<AzureCognitiveservicesAccountDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountListSkusSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountListSkusSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountListSkus(Configure<AzureCognitiveservicesAccountListSkusSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountListSkusSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountShowSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountShowSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountShow(Configure<AzureCognitiveservicesAccountShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountUpdateSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountUpdate(Configure<AzureCognitiveservicesAccountUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountKeysListSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountKeysListSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountKeysList(Configure<AzureCognitiveservicesAccountKeysListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountKeysListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings);
        static partial void PostProcess(AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings);
        /// <summary><p>Manage Azure Cognitive Services accounts.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cognitiveservices?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureCognitiveservicesAccountKeysRegenerate(Configure<AzureCognitiveservicesAccountKeysRegenerateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureCognitiveservicesAccountKeysRegenerateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureCognitiveservicesListSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
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
              .Add("cognitiveservices list")
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
    #region AzureCognitiveservicesAccountCreateSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>The API name of cognitive services account.</p></summary>
        public virtual string Kind { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Cognitive service account name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The Sku of cognitive services account.</p></summary>
        public virtual string Sku { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Do not prompt for terms confirmation.</p></summary>
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
              .Add("cognitiveservices account create")
              .Add("--kind {value}", Kind)
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
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
    #region AzureCognitiveservicesAccountDeleteSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>Cognitive service account name.</p></summary>
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
              .Add("cognitiveservices account delete")
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
    #region AzureCognitiveservicesAccountListSkusSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountListSkusSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>Cognitive service account name.</p></summary>
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
              .Add("cognitiveservices account list-skus")
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
    #region AzureCognitiveservicesAccountShowSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>Cognitive service account name.</p></summary>
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
              .Add("cognitiveservices account show")
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
    #region AzureCognitiveservicesAccountUpdateSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>Cognitive service account name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The Sku of cognitive services account.</p></summary>
        public virtual string Sku { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
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
              .Add("cognitiveservices account update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureCognitiveservicesAccountKeysListSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountKeysListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>Cognitive service account name.</p></summary>
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
              .Add("cognitiveservices account keys list")
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
    #region AzureCognitiveservicesAccountKeysRegenerateSettings
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCognitiveservicesAccountKeysRegenerateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureCognitiveservices executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureCognitiveservicesTasks.AzureCognitiveservicesPath;
        /// <summary><p>Key name to generate.</p></summary>
        public virtual CognitiveservicesAccountKeysRegenerateKeyName KeyName { get; internal set; }
        /// <summary><p>Cognitive service account name.</p></summary>
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
              .Add("cognitiveservices account keys regenerate")
              .Add("--key-name {value}", KeyName)
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
    #region AzureCognitiveservicesListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetResourceGroup(this AzureCognitiveservicesListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetResourceGroup(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetDebug(this AzureCognitiveservicesListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetDebug(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetHelp(this AzureCognitiveservicesListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetHelp(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetOutput(this AzureCognitiveservicesListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetOutput(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetQuery(this AzureCognitiveservicesListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetQuery(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings SetVerbose(this AzureCognitiveservicesListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesListSettings ResetVerbose(this AzureCognitiveservicesListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountCreateSettingsExtensions
    {
        #region Kind
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Kind"/>.</em></p><p>The API name of cognitive services account.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetKind(this AzureCognitiveservicesAccountCreateSettings toolSettings, string kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Kind"/>.</em></p><p>The API name of cognitive services account.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetKind(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetLocation(this AzureCognitiveservicesAccountCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetLocation(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetName(this AzureCognitiveservicesAccountCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetName(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetResourceGroup(this AzureCognitiveservicesAccountCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetResourceGroup(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Sku"/>.</em></p><p>The Sku of cognitive services account.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetSku(this AzureCognitiveservicesAccountCreateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Sku"/>.</em></p><p>The Sku of cognitive services account.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetSku(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetTags(this AzureCognitiveservicesAccountCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetTags(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Yes"/>.</em></p><p>Do not prompt for terms confirmation.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetYes(this AzureCognitiveservicesAccountCreateSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Yes"/>.</em></p><p>Do not prompt for terms confirmation.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetYes(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetDebug(this AzureCognitiveservicesAccountCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetDebug(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetHelp(this AzureCognitiveservicesAccountCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetHelp(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetOutput(this AzureCognitiveservicesAccountCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetOutput(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetQuery(this AzureCognitiveservicesAccountCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetQuery(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings SetVerbose(this AzureCognitiveservicesAccountCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountCreateSettings ResetVerbose(this AzureCognitiveservicesAccountCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetName(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetName(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetResourceGroup(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetResourceGroup(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetDebug(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetDebug(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetHelp(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetHelp(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetOutput(this AzureCognitiveservicesAccountDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetOutput(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetQuery(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetQuery(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings SetVerbose(this AzureCognitiveservicesAccountDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountDeleteSettings ResetVerbose(this AzureCognitiveservicesAccountDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountListSkusSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountListSkusSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetName(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetName(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetResourceGroup(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetResourceGroup(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetDebug(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetDebug(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetHelp(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetHelp(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetOutput(this AzureCognitiveservicesAccountListSkusSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetOutput(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetQuery(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetQuery(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings SetVerbose(this AzureCognitiveservicesAccountListSkusSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountListSkusSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountListSkusSettings ResetVerbose(this AzureCognitiveservicesAccountListSkusSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetName(this AzureCognitiveservicesAccountShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetName(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetResourceGroup(this AzureCognitiveservicesAccountShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetResourceGroup(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetDebug(this AzureCognitiveservicesAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetDebug(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetHelp(this AzureCognitiveservicesAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetHelp(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetOutput(this AzureCognitiveservicesAccountShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetOutput(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetQuery(this AzureCognitiveservicesAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetQuery(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings SetVerbose(this AzureCognitiveservicesAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountShowSettings ResetVerbose(this AzureCognitiveservicesAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetName(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetName(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetResourceGroup(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetResourceGroup(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Sku"/>.</em></p><p>The Sku of cognitive services account.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetSku(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Sku"/>.</em></p><p>The Sku of cognitive services account.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetSku(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetTags(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetTags(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetDebug(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetDebug(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetHelp(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetHelp(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetOutput(this AzureCognitiveservicesAccountUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetOutput(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetQuery(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetQuery(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings SetVerbose(this AzureCognitiveservicesAccountUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountUpdateSettings ResetVerbose(this AzureCognitiveservicesAccountUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountKeysListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountKeysListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetName(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetName(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetResourceGroup(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetResourceGroup(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetDebug(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetDebug(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetHelp(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetHelp(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetOutput(this AzureCognitiveservicesAccountKeysListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetOutput(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetQuery(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetQuery(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings SetVerbose(this AzureCognitiveservicesAccountKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysListSettings ResetVerbose(this AzureCognitiveservicesAccountKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCognitiveservicesAccountKeysRegenerateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCognitiveservicesAccountKeysRegenerateSettingsExtensions
    {
        #region KeyName
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.KeyName"/>.</em></p><p>Key name to generate.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetKeyName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, CognitiveservicesAccountKeysRegenerateKeyName keyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = keyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.KeyName"/>.</em></p><p>Key name to generate.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetKeyName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Name"/>.</em></p><p>Cognitive service account name.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetName(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetResourceGroup(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetResourceGroup(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetDebug(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetDebug(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetHelp(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetHelp(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetOutput(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetOutput(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetQuery(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetQuery(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings SetVerbose(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureCognitiveservicesAccountKeysRegenerateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureCognitiveservicesAccountKeysRegenerateSettings ResetVerbose(this AzureCognitiveservicesAccountKeysRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region CognitiveservicesAccountKeysRegenerateKeyName
    /// <summary><p>Used within <see cref="AzureCognitiveservicesTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class CognitiveservicesAccountKeysRegenerateKeyName : Enumeration
    {
        public static CognitiveservicesAccountKeysRegenerateKeyName key1 = new CognitiveservicesAccountKeysRegenerateKeyName { Value = "key1" };
        public static CognitiveservicesAccountKeysRegenerateKeyName key2 = new CognitiveservicesAccountKeysRegenerateKeyName { Value = "key2" };
    }
    #endregion
}
