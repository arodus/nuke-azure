// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.15 [CommitSha: 2886d896].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureImage.json.

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
    public static partial class AzureImageTasks
    {
        /// <summary><p>Path to the AzureImage executable.</p></summary>
        public static string AzureImagePath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage custom virtual machine images.</p></summary>
        public static IEnumerable<string> AzureImage(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureImagePath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureImageCreateSettings toolSettings);
        static partial void PostProcess(AzureImageCreateSettings toolSettings);
        /// <summary><p>Manage custom virtual machine images.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/image.yml">official website</a>.</p></summary>
        public static void AzureImageCreate(Configure<AzureImageCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureImageCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureImageDeleteSettings toolSettings);
        static partial void PostProcess(AzureImageDeleteSettings toolSettings);
        /// <summary><p>Manage custom virtual machine images.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/image.yml">official website</a>.</p></summary>
        public static void AzureImageDelete(Configure<AzureImageDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureImageDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureImageListSettings toolSettings);
        static partial void PostProcess(AzureImageListSettings toolSettings);
        /// <summary><p>Manage custom virtual machine images.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/image.yml">official website</a>.</p></summary>
        public static void AzureImageList(Configure<AzureImageListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureImageListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureImageShowSettings toolSettings);
        static partial void PostProcess(AzureImageShowSettings toolSettings);
        /// <summary><p>Manage custom virtual machine images.</p><p>For more details, visit the <a href="https://raw.githubusercontent.com/Azure/azure-docs-cli-python/live/latest/docs-ref-autogen/image.yml">official website</a>.</p></summary>
        public static void AzureImageShow(Configure<AzureImageShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureImageShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureImageCreateSettings
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureImage executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        /// <summary><p>New image name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>OS disk source from the same region, including a virtual machine ID or name, OS disk blob URI, managed OS disk ID or name, or OS snapshot ID or name.</p></summary>
        public virtual string Source { get; internal set; }
        /// <summary><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        public virtual IReadOnlyList<string> DataDiskSources => DataDiskSourcesInternal.AsReadOnly();
        internal List<string> DataDiskSourcesInternal { get; set; } = new List<string>();
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p></p></summary>
        public virtual ImageCreateOsType OsType { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p></summary>
        public virtual bool? ZoneResilient { get; internal set; }
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
              .Add("image create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source {value}", Source)
              .Add("--data-disk-sources {value}", DataDiskSources, separator: ' ')
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
              .Add("--tags {value}", Tags)
              .Add("--zone-resilient", ZoneResilient)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureImageDeleteSettings
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureImage executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        /// <summary><p>The name of the image.</p></summary>
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
              .Add("image delete")
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
    #region AzureImageListSettings
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureImage executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
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
              .Add("image list")
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
    #region AzureImageShowSettings
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureImageShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureImage executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureImageTasks.AzureImagePath;
        /// <summary><p>The name of the image.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The expand expression to apply on the operation.</p></summary>
        public virtual string Expand { get; internal set; }
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
              .Add("image show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--expand {value}", Expand)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureImageCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Name"/>.</em></p><p>New image name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetName(this AzureImageCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Name"/>.</em></p><p>New image name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetName(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetResourceGroup(this AzureImageCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetResourceGroup(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Source"/>.</em></p><p>OS disk source from the same region, including a virtual machine ID or name, OS disk blob URI, managed OS disk ID or name, or OS snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetSource(this AzureImageCreateSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Source"/>.</em></p><p>OS disk source from the same region, including a virtual machine ID or name, OS disk blob URI, managed OS disk ID or name, or OS snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetSource(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region DataDiskSources
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.DataDiskSources"/> to a new list.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetDataDiskSources(this AzureImageCreateSettings toolSettings, params string[] dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal = dataDiskSources.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.DataDiskSources"/> to a new list.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetDataDiskSources(this AzureImageCreateSettings toolSettings, IEnumerable<string> dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal = dataDiskSources.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureImageCreateSettings.DataDiskSources"/>.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings AddDataDiskSources(this AzureImageCreateSettings toolSettings, params string[] dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal.AddRange(dataDiskSources);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureImageCreateSettings.DataDiskSources"/>.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings AddDataDiskSources(this AzureImageCreateSettings toolSettings, IEnumerable<string> dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal.AddRange(dataDiskSources);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureImageCreateSettings.DataDiskSources"/>.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ClearDataDiskSources(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DataDiskSourcesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureImageCreateSettings.DataDiskSources"/>.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings RemoveDataDiskSources(this AzureImageCreateSettings toolSettings, params string[] dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dataDiskSources);
            toolSettings.DataDiskSourcesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureImageCreateSettings.DataDiskSources"/>.</em></p><p>Space-separated list of data disk sources, including unmanaged blob URI, managed disk ID or name, or snapshot ID or name.</p></summary>
        [Pure]
        public static AzureImageCreateSettings RemoveDataDiskSources(this AzureImageCreateSettings toolSettings, IEnumerable<string> dataDiskSources)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(dataDiskSources);
            toolSettings.DataDiskSourcesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetLocation(this AzureImageCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetLocation(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.OsType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureImageCreateSettings SetOsType(this AzureImageCreateSettings toolSettings, ImageCreateOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.OsType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetOsType(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetTags(this AzureImageCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetTags(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region ZoneResilient
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.ZoneResilient"/>.</em></p><p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetZoneResilient(this AzureImageCreateSettings toolSettings, bool? zoneResilient)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = zoneResilient;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.ZoneResilient"/>.</em></p><p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureImageCreateSettings.ZoneResilient"/>.</em></p><p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p></summary>
        [Pure]
        public static AzureImageCreateSettings EnableZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureImageCreateSettings.ZoneResilient"/>.</em></p><p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p></summary>
        [Pure]
        public static AzureImageCreateSettings DisableZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureImageCreateSettings.ZoneResilient"/>.</em></p><p>Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ToggleZoneResilient(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ZoneResilient = !toolSettings.ZoneResilient;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetDebug(this AzureImageCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetDebug(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetHelp(this AzureImageCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetHelp(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetOutput(this AzureImageCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetOutput(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetQuery(this AzureImageCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetQuery(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureImageCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageCreateSettings SetVerbose(this AzureImageCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageCreateSettings ResetVerbose(this AzureImageCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.Name"/>.</em></p><p>The name of the image.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetName(this AzureImageDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.Name"/>.</em></p><p>The name of the image.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetName(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetResourceGroup(this AzureImageDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetResourceGroup(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetDebug(this AzureImageDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetDebug(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetHelp(this AzureImageDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetHelp(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetOutput(this AzureImageDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetOutput(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetQuery(this AzureImageDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetQuery(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureImageDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings SetVerbose(this AzureImageDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageDeleteSettings ResetVerbose(this AzureImageDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureImageListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageListSettings SetResourceGroup(this AzureImageListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageListSettings ResetResourceGroup(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageListSettings SetDebug(this AzureImageListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageListSettings ResetDebug(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageListSettings SetHelp(this AzureImageListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageListSettings ResetHelp(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageListSettings SetOutput(this AzureImageListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageListSettings ResetOutput(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureImageListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageListSettings SetQuery(this AzureImageListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageListSettings ResetQuery(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageListSettings SetVerbose(this AzureImageListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageListSettings ResetVerbose(this AzureImageListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureImageShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureImageShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Name"/>.</em></p><p>The name of the image.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetName(this AzureImageShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Name"/>.</em></p><p>The name of the image.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetName(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetResourceGroup(this AzureImageShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetResourceGroup(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Expand
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Expand"/>.</em></p><p>The expand expression to apply on the operation.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetExpand(this AzureImageShowSettings toolSettings, string expand)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = expand;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Expand"/>.</em></p><p>The expand expression to apply on the operation.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetExpand(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expand = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetDebug(this AzureImageShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetDebug(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetHelp(this AzureImageShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetHelp(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetOutput(this AzureImageShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetOutput(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetQuery(this AzureImageShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetQuery(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageShowSettings SetVerbose(this AzureImageShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureImageShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureImageShowSettings ResetVerbose(this AzureImageShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ImageCreateOsType
    /// <summary><p>Used within <see cref="AzureImageTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class ImageCreateOsType : Enumeration
    {
        public static ImageCreateOsType linux = new ImageCreateOsType { Value = "linux" };
        public static ImageCreateOsType windows = new ImageCreateOsType { Value = "windows" };
    }
    #endregion
}
