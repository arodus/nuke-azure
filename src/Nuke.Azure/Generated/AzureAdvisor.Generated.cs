// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.0 [CommitSha: 5a428f0d].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAdvisor.json.

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
    public static partial class AzureAdvisorTasks
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public static string AzureAdvisorPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Advisor.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisor(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAdvisorPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisor(Configure<AzureAdvisorSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisorRecommendationDisable(Configure<AzureAdvisorRecommendationDisableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorRecommendationDisableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisorRecommendationEnable(Configure<AzureAdvisorRecommendationEnableSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorRecommendationEnableSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisorRecommendationList(Configure<AzureAdvisorRecommendationListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorRecommendationListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisorConfigurationList(Configure<AzureAdvisorConfigurationListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorConfigurationListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisorConfigurationShow(Configure<AzureAdvisorConfigurationShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorConfigurationShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Advisor.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/advisor?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdvisorConfigurationUpdate(Configure<AzureAdvisorConfigurationUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdvisorConfigurationUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureAdvisorSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
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
              .Add("advisor")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdvisorRecommendationDisableSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorRecommendationDisableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
        /// <summary><p>Number of days to disable. If not specified, the recommendation is disabled forever.</p></summary>
        public virtual int? Days { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The name of the recommendation as output by the list command.</p></summary>
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
              .Add("advisor recommendation disable")
              .Add("--days {value}", Days)
              .Add("--ids {value}", Ids)
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
    #region AzureAdvisorRecommendationEnableSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorRecommendationEnableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>The name of the recommendation as output by the list command.</p></summary>
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
              .Add("advisor recommendation enable")
              .Add("--ids {value}", Ids)
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
    #region AzureAdvisorRecommendationListSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorRecommendationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
        /// <summary><p>Name of recommendation category.</p></summary>
        public virtual AdvisorRecommendationListCategory Category { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Generate new recommendations.</p></summary>
        public virtual string Refresh { get; internal set; }
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
              .Add("advisor recommendation list")
              .Add("--category {value}", Category)
              .Add("--ids {value}", Ids)
              .Add("--refresh {value}", Refresh)
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
    #region AzureAdvisorConfigurationListSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorConfigurationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
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
              .Add("advisor configuration list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdvisorConfigurationShowSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorConfigurationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
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
              .Add("advisor configuration show")
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
    #region AzureAdvisorConfigurationUpdateSettings
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdvisorConfigurationUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAdvisor executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdvisorTasks.AzureAdvisorPath;
        /// <summary><p>Exclude from recommendation generation.</p></summary>
        public virtual string Exclude { get; internal set; }
        /// <summary><p>Include in recommendation generation.</p></summary>
        public virtual string Include { get; internal set; }
        /// <summary><p>Value for low CPU threshold.</p></summary>
        public virtual AdvisorConfigurationUpdateLowCpuThreshold LowCpuThreshold { get; internal set; }
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
              .Add("advisor configuration update")
              .Add("--exclude {value}", Exclude)
              .Add("--include {value}", Include)
              .Add("--low-cpu-threshold {value}", LowCpuThreshold)
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
    #region AzureAdvisorSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorSettings SetDebug(this AzureAdvisorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorSettings ResetDebug(this AzureAdvisorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorSettings SetHelp(this AzureAdvisorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorSettings ResetHelp(this AzureAdvisorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorSettings SetOutput(this AzureAdvisorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorSettings ResetOutput(this AzureAdvisorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorSettings SetQuery(this AzureAdvisorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorSettings ResetQuery(this AzureAdvisorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorSettings SetVerbose(this AzureAdvisorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorSettings ResetVerbose(this AzureAdvisorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdvisorRecommendationDisableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorRecommendationDisableSettingsExtensions
    {
        #region Days
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Days"/>.</em></p><p>Number of days to disable. If not specified, the recommendation is disabled forever.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetDays(this AzureAdvisorRecommendationDisableSettings toolSettings, int? days)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Days = days;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Days"/>.</em></p><p>Number of days to disable. If not specified, the recommendation is disabled forever.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetDays(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Days = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetIds(this AzureAdvisorRecommendationDisableSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetIds(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Name"/>.</em></p><p>The name of the recommendation as output by the list command.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetName(this AzureAdvisorRecommendationDisableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Name"/>.</em></p><p>The name of the recommendation as output by the list command.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetName(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetResourceGroup(this AzureAdvisorRecommendationDisableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetResourceGroup(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetDebug(this AzureAdvisorRecommendationDisableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetDebug(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetHelp(this AzureAdvisorRecommendationDisableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetHelp(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetOutput(this AzureAdvisorRecommendationDisableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetOutput(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetQuery(this AzureAdvisorRecommendationDisableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetQuery(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings SetVerbose(this AzureAdvisorRecommendationDisableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationDisableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationDisableSettings ResetVerbose(this AzureAdvisorRecommendationDisableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdvisorRecommendationEnableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorRecommendationEnableSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetIds(this AzureAdvisorRecommendationEnableSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetIds(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Name"/>.</em></p><p>The name of the recommendation as output by the list command.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetName(this AzureAdvisorRecommendationEnableSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Name"/>.</em></p><p>The name of the recommendation as output by the list command.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetName(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetResourceGroup(this AzureAdvisorRecommendationEnableSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetResourceGroup(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetDebug(this AzureAdvisorRecommendationEnableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetDebug(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetHelp(this AzureAdvisorRecommendationEnableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetHelp(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetOutput(this AzureAdvisorRecommendationEnableSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetOutput(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetQuery(this AzureAdvisorRecommendationEnableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetQuery(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings SetVerbose(this AzureAdvisorRecommendationEnableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationEnableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationEnableSettings ResetVerbose(this AzureAdvisorRecommendationEnableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdvisorRecommendationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorRecommendationListSettingsExtensions
    {
        #region Category
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Category"/>.</em></p><p>Name of recommendation category.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetCategory(this AzureAdvisorRecommendationListSettings toolSettings, AdvisorRecommendationListCategory category)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Category = category;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Category"/>.</em></p><p>Name of recommendation category.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetCategory(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Category = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetIds(this AzureAdvisorRecommendationListSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetIds(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Refresh
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Refresh"/>.</em></p><p>Generate new recommendations.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetRefresh(this AzureAdvisorRecommendationListSettings toolSettings, string refresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = refresh;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Refresh"/>.</em></p><p>Generate new recommendations.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetRefresh(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetResourceGroup(this AzureAdvisorRecommendationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetResourceGroup(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetDebug(this AzureAdvisorRecommendationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetDebug(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetHelp(this AzureAdvisorRecommendationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetHelp(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetOutput(this AzureAdvisorRecommendationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetOutput(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetQuery(this AzureAdvisorRecommendationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetQuery(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorRecommendationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings SetVerbose(this AzureAdvisorRecommendationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorRecommendationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorRecommendationListSettings ResetVerbose(this AzureAdvisorRecommendationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdvisorConfigurationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorConfigurationListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings SetDebug(this AzureAdvisorConfigurationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings ResetDebug(this AzureAdvisorConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings SetHelp(this AzureAdvisorConfigurationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings ResetHelp(this AzureAdvisorConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings SetOutput(this AzureAdvisorConfigurationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings ResetOutput(this AzureAdvisorConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings SetQuery(this AzureAdvisorConfigurationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings ResetQuery(this AzureAdvisorConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings SetVerbose(this AzureAdvisorConfigurationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationListSettings ResetVerbose(this AzureAdvisorConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdvisorConfigurationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorConfigurationShowSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings SetResourceGroup(this AzureAdvisorConfigurationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings ResetResourceGroup(this AzureAdvisorConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings SetDebug(this AzureAdvisorConfigurationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings ResetDebug(this AzureAdvisorConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings SetHelp(this AzureAdvisorConfigurationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings ResetHelp(this AzureAdvisorConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings SetOutput(this AzureAdvisorConfigurationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings ResetOutput(this AzureAdvisorConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings SetQuery(this AzureAdvisorConfigurationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings ResetQuery(this AzureAdvisorConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings SetVerbose(this AzureAdvisorConfigurationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationShowSettings ResetVerbose(this AzureAdvisorConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdvisorConfigurationUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdvisorConfigurationUpdateSettingsExtensions
    {
        #region Exclude
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Exclude"/>.</em></p><p>Exclude from recommendation generation.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetExclude(this AzureAdvisorConfigurationUpdateSettings toolSettings, string exclude)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exclude = exclude;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Exclude"/>.</em></p><p>Exclude from recommendation generation.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetExclude(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exclude = null;
            return toolSettings;
        }
        #endregion
        #region Include
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Include"/>.</em></p><p>Include in recommendation generation.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetInclude(this AzureAdvisorConfigurationUpdateSettings toolSettings, string include)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Include = include;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Include"/>.</em></p><p>Include in recommendation generation.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetInclude(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Include = null;
            return toolSettings;
        }
        #endregion
        #region LowCpuThreshold
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.LowCpuThreshold"/>.</em></p><p>Value for low CPU threshold.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetLowCpuThreshold(this AzureAdvisorConfigurationUpdateSettings toolSettings, AdvisorConfigurationUpdateLowCpuThreshold lowCpuThreshold)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LowCpuThreshold = lowCpuThreshold;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.LowCpuThreshold"/>.</em></p><p>Value for low CPU threshold.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetLowCpuThreshold(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LowCpuThreshold = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetResourceGroup(this AzureAdvisorConfigurationUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetResourceGroup(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetAdd(this AzureAdvisorConfigurationUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetAdd(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetForceString(this AzureAdvisorConfigurationUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetForceString(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetRemove(this AzureAdvisorConfigurationUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetRemove(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetSet(this AzureAdvisorConfigurationUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetSet(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetDebug(this AzureAdvisorConfigurationUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetDebug(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetHelp(this AzureAdvisorConfigurationUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetHelp(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetOutput(this AzureAdvisorConfigurationUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetOutput(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetQuery(this AzureAdvisorConfigurationUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetQuery(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdvisorConfigurationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings SetVerbose(this AzureAdvisorConfigurationUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdvisorConfigurationUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdvisorConfigurationUpdateSettings ResetVerbose(this AzureAdvisorConfigurationUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AdvisorRecommendationListCategory
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AdvisorRecommendationListCategory : Enumeration
    {
        public static AdvisorRecommendationListCategory cost = new AdvisorRecommendationListCategory { Value = "cost" };
        public static AdvisorRecommendationListCategory highavailability = new AdvisorRecommendationListCategory { Value = "highavailability" };
        public static AdvisorRecommendationListCategory performance = new AdvisorRecommendationListCategory { Value = "performance" };
        public static AdvisorRecommendationListCategory security = new AdvisorRecommendationListCategory { Value = "security" };
    }
    #endregion
    #region AdvisorConfigurationUpdateLowCpuThreshold
    /// <summary><p>Used within <see cref="AzureAdvisorTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AdvisorConfigurationUpdateLowCpuThreshold : Enumeration
    {
        public static AdvisorConfigurationUpdateLowCpuThreshold _10 = new AdvisorConfigurationUpdateLowCpuThreshold { Value = "10" };
        public static AdvisorConfigurationUpdateLowCpuThreshold _15 = new AdvisorConfigurationUpdateLowCpuThreshold { Value = "15" };
        public static AdvisorConfigurationUpdateLowCpuThreshold _20 = new AdvisorConfigurationUpdateLowCpuThreshold { Value = "20" };
        public static AdvisorConfigurationUpdateLowCpuThreshold _5 = new AdvisorConfigurationUpdateLowCpuThreshold { Value = "5" };
    }
    #endregion
}
