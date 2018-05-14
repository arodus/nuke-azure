// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.20 [CommitSha: 67bb27fd].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAppservice.json.

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
    public static partial class AzureAppserviceTasks
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public static string AzureAppservicePath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage App Service plans.</p></summary>
        public static IEnumerable<string> AzureAppservice(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureAppservicePath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureAppserviceListLocationsSettings toolSettings);
        static partial void PostProcess(AzureAppserviceListLocationsSettings toolSettings);
        /// <summary><p>Manage App Service plans.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAppserviceListLocations(Configure<AzureAppserviceListLocationsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAppserviceListLocationsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAppservicePlanCreateSettings toolSettings);
        static partial void PostProcess(AzureAppservicePlanCreateSettings toolSettings);
        /// <summary><p>Manage App Service plans.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAppservicePlanCreate(Configure<AzureAppservicePlanCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAppservicePlanCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAppservicePlanDeleteSettings toolSettings);
        static partial void PostProcess(AzureAppservicePlanDeleteSettings toolSettings);
        /// <summary><p>Manage App Service plans.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAppservicePlanDelete(Configure<AzureAppservicePlanDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAppservicePlanDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAppservicePlanListSettings toolSettings);
        static partial void PostProcess(AzureAppservicePlanListSettings toolSettings);
        /// <summary><p>Manage App Service plans.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAppservicePlanList(Configure<AzureAppservicePlanListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAppservicePlanListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAppservicePlanShowSettings toolSettings);
        static partial void PostProcess(AzureAppservicePlanShowSettings toolSettings);
        /// <summary><p>Manage App Service plans.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAppservicePlanShow(Configure<AzureAppservicePlanShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAppservicePlanShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAppservicePlanUpdateSettings toolSettings);
        static partial void PostProcess(AzureAppservicePlanUpdateSettings toolSettings);
        /// <summary><p>Manage App Service plans.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/appservice?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAppservicePlanUpdate(Configure<AzureAppservicePlanUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAppservicePlanUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureAppserviceListLocationsSettings
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppserviceListLocationsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        /// <summary><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        public virtual AppserviceSku Sku { get; internal set; }
        /// <summary><p>Get regions which support hosting webapps on Linux workers.</p></summary>
        public virtual string LinuxWorkersEnabled { get; internal set; }
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
              .Add("appservice list-locations")
              .Add("--sku {value}", Sku)
              .Add("--linux-workers-enabled {value}", LinuxWorkersEnabled)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAppservicePlanCreateSettings
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        /// <summary><p>Name of the new app service plan.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Host webapp on Linux worker.</p></summary>
        public virtual string IsLinux { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Number of workers to be allocated.</p></summary>
        public virtual int? NumberOfWorkers { get; internal set; }
        /// <summary><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        public virtual AppserviceSku Sku { get; internal set; }
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
              .Add("appservice plan create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--is-linux {value}", IsLinux)
              .Add("--location {value}", Location)
              .Add("--number-of-workers {value}", NumberOfWorkers)
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
    #region AzureAppservicePlanDeleteSettings
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        /// <summary><p>The name of the app service plan.</p></summary>
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
              .Add("appservice plan delete")
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
    #region AzureAppservicePlanListSettings
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
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
              .Add("appservice plan list")
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
    #region AzureAppservicePlanShowSettings
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        /// <summary><p>The name of the app service plan.</p></summary>
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
              .Add("appservice plan show")
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
    #region AzureAppservicePlanUpdateSettings
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAppservicePlanUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAppservice executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAppserviceTasks.AzureAppservicePath;
        /// <summary><p>The name of the app service plan.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the admin web app.</p></summary>
        public virtual string AdminSiteName { get; internal set; }
        /// <summary><p>Number of workers to be allocated.</p></summary>
        public virtual int? NumberOfWorkers { get; internal set; }
        /// <summary><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        public virtual AppserviceSku Sku { get; internal set; }
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
              .Add("appservice plan update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin-site-name {value}", AdminSiteName)
              .Add("--number-of-workers {value}", NumberOfWorkers)
              .Add("--sku {value}", Sku)
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
    #region AzureAppserviceListLocationsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppserviceListLocationsSettingsExtensions
    {
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Sku"/>.</em></p><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetSku(this AzureAppserviceListLocationsSettings toolSettings, AppserviceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Sku"/>.</em></p><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetSku(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region LinuxWorkersEnabled
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.LinuxWorkersEnabled"/>.</em></p><p>Get regions which support hosting webapps on Linux workers.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetLinuxWorkersEnabled(this AzureAppserviceListLocationsSettings toolSettings, string linuxWorkersEnabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinuxWorkersEnabled = linuxWorkersEnabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.LinuxWorkersEnabled"/>.</em></p><p>Get regions which support hosting webapps on Linux workers.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetLinuxWorkersEnabled(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LinuxWorkersEnabled = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetDebug(this AzureAppserviceListLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetDebug(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetHelp(this AzureAppserviceListLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetHelp(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetOutput(this AzureAppserviceListLocationsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetOutput(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetQuery(this AzureAppserviceListLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetQuery(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAppserviceListLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings SetVerbose(this AzureAppserviceListLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppserviceListLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppserviceListLocationsSettings ResetVerbose(this AzureAppserviceListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Name"/>.</em></p><p>Name of the new app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetName(this AzureAppservicePlanCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Name"/>.</em></p><p>Name of the new app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetName(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetResourceGroup(this AzureAppservicePlanCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetResourceGroup(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region IsLinux
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.IsLinux"/>.</em></p><p>Host webapp on Linux worker.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetIsLinux(this AzureAppservicePlanCreateSettings toolSettings, string isLinux)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsLinux = isLinux;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.IsLinux"/>.</em></p><p>Host webapp on Linux worker.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetIsLinux(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsLinux = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetLocation(this AzureAppservicePlanCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetLocation(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NumberOfWorkers
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.NumberOfWorkers"/>.</em></p><p>Number of workers to be allocated.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetNumberOfWorkers(this AzureAppservicePlanCreateSettings toolSettings, int? numberOfWorkers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = numberOfWorkers;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.NumberOfWorkers"/>.</em></p><p>Number of workers to be allocated.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetNumberOfWorkers(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Sku"/>.</em></p><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetSku(this AzureAppservicePlanCreateSettings toolSettings, AppserviceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Sku"/>.</em></p><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetSku(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetDebug(this AzureAppservicePlanCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetDebug(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetHelp(this AzureAppservicePlanCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetHelp(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetOutput(this AzureAppservicePlanCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetOutput(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetQuery(this AzureAppservicePlanCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetQuery(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings SetVerbose(this AzureAppservicePlanCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanCreateSettings ResetVerbose(this AzureAppservicePlanCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Name"/>.</em></p><p>The name of the app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetName(this AzureAppservicePlanDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Name"/>.</em></p><p>The name of the app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetName(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetResourceGroup(this AzureAppservicePlanDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetResourceGroup(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetYes(this AzureAppservicePlanDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetYes(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetDebug(this AzureAppservicePlanDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetDebug(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetHelp(this AzureAppservicePlanDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetHelp(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetOutput(this AzureAppservicePlanDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetOutput(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetQuery(this AzureAppservicePlanDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetQuery(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings SetVerbose(this AzureAppservicePlanDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanDeleteSettings ResetVerbose(this AzureAppservicePlanDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetResourceGroup(this AzureAppservicePlanListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetResourceGroup(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetDebug(this AzureAppservicePlanListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetDebug(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetHelp(this AzureAppservicePlanListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetHelp(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetOutput(this AzureAppservicePlanListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetOutput(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetQuery(this AzureAppservicePlanListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetQuery(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings SetVerbose(this AzureAppservicePlanListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanListSettings ResetVerbose(this AzureAppservicePlanListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.Name"/>.</em></p><p>The name of the app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetName(this AzureAppservicePlanShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.Name"/>.</em></p><p>The name of the app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetName(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetResourceGroup(this AzureAppservicePlanShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetResourceGroup(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetDebug(this AzureAppservicePlanShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetDebug(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetHelp(this AzureAppservicePlanShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetHelp(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetOutput(this AzureAppservicePlanShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetOutput(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetQuery(this AzureAppservicePlanShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetQuery(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings SetVerbose(this AzureAppservicePlanShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanShowSettings ResetVerbose(this AzureAppservicePlanShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAppservicePlanUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAppservicePlanUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Name"/>.</em></p><p>The name of the app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetName(this AzureAppservicePlanUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Name"/>.</em></p><p>The name of the app service plan.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetName(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetResourceGroup(this AzureAppservicePlanUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetResourceGroup(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AdminSiteName
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.AdminSiteName"/>.</em></p><p>The name of the admin web app.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetAdminSiteName(this AzureAppservicePlanUpdateSettings toolSettings, string adminSiteName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminSiteName = adminSiteName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.AdminSiteName"/>.</em></p><p>The name of the admin web app.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetAdminSiteName(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminSiteName = null;
            return toolSettings;
        }
        #endregion
        #region NumberOfWorkers
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.NumberOfWorkers"/>.</em></p><p>Number of workers to be allocated.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetNumberOfWorkers(this AzureAppservicePlanUpdateSettings toolSettings, int? numberOfWorkers)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = numberOfWorkers;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.NumberOfWorkers"/>.</em></p><p>Number of workers to be allocated.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetNumberOfWorkers(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NumberOfWorkers = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Sku"/>.</em></p><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetSku(this AzureAppservicePlanUpdateSettings toolSettings, AppserviceSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Sku"/>.</em></p><p>The pricing tiers, e.g., F1(Free), D1(Shared), B1(Basic Small), B2(Basic Medium), B3(Basic Large), S1(Standard Small), P1(Premium Small), P1V2(Premium V2 Small) etc.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetSku(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetAdd(this AzureAppservicePlanUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetAdd(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetRemove(this AzureAppservicePlanUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetRemove(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetSet(this AzureAppservicePlanUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetSet(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetDebug(this AzureAppservicePlanUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetDebug(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetHelp(this AzureAppservicePlanUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetHelp(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetOutput(this AzureAppservicePlanUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetOutput(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetQuery(this AzureAppservicePlanUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetQuery(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAppservicePlanUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings SetVerbose(this AzureAppservicePlanUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAppservicePlanUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAppservicePlanUpdateSettings ResetVerbose(this AzureAppservicePlanUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppserviceSku
    /// <summary><p>Used within <see cref="AzureAppserviceTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AppserviceSku : Enumeration
    {
        public static AppserviceSku b1 = new AppserviceSku { Value = "b1" };
        public static AppserviceSku b2 = new AppserviceSku { Value = "b2" };
        public static AppserviceSku b3 = new AppserviceSku { Value = "b3" };
        public static AppserviceSku d1 = new AppserviceSku { Value = "d1" };
        public static AppserviceSku f1 = new AppserviceSku { Value = "f1" };
        public static AppserviceSku free = new AppserviceSku { Value = "free" };
        public static AppserviceSku p1 = new AppserviceSku { Value = "p1" };
        public static AppserviceSku p1v2 = new AppserviceSku { Value = "p1v2" };
        public static AppserviceSku p2 = new AppserviceSku { Value = "p2" };
        public static AppserviceSku p2v2 = new AppserviceSku { Value = "p2v2" };
        public static AppserviceSku p3 = new AppserviceSku { Value = "p3" };
        public static AppserviceSku p3v2 = new AppserviceSku { Value = "p3v2" };
        public static AppserviceSku s1 = new AppserviceSku { Value = "s1" };
        public static AppserviceSku s2 = new AppserviceSku { Value = "s2" };
        public static AppserviceSku s3 = new AppserviceSku { Value = "s3" };
        public static AppserviceSku shared = new AppserviceSku { Value = "shared" };
    }
    #endregion
}
