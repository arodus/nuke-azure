// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureExtension.json.

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
    public static partial class AzureExtensionTasks
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public static string AzureExtensionPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage and update CLI extensions.</p></summary>
        public static IEnumerable<string> AzureExtension(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureExtensionPath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureExtensionAddSettings toolSettings);
        static partial void PostProcess(AzureExtensionAddSettings toolSettings);
        /// <summary><p>Manage and update CLI extensions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureExtensionAdd(Configure<AzureExtensionAddSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureExtensionAddSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureExtensionListSettings toolSettings);
        static partial void PostProcess(AzureExtensionListSettings toolSettings);
        /// <summary><p>Manage and update CLI extensions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureExtensionList(Configure<AzureExtensionListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureExtensionListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureExtensionListAvailableSettings toolSettings);
        static partial void PostProcess(AzureExtensionListAvailableSettings toolSettings);
        /// <summary><p>Manage and update CLI extensions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureExtensionListAvailable(Configure<AzureExtensionListAvailableSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureExtensionListAvailableSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureExtensionRemoveSettings toolSettings);
        static partial void PostProcess(AzureExtensionRemoveSettings toolSettings);
        /// <summary><p>Manage and update CLI extensions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureExtensionRemove(Configure<AzureExtensionRemoveSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureExtensionRemoveSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureExtensionShowSettings toolSettings);
        static partial void PostProcess(AzureExtensionShowSettings toolSettings);
        /// <summary><p>Manage and update CLI extensions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureExtensionShow(Configure<AzureExtensionShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureExtensionShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureExtensionUpdateSettings toolSettings);
        static partial void PostProcess(AzureExtensionUpdateSettings toolSettings);
        /// <summary><p>Manage and update CLI extensions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/extension?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureExtensionUpdate(Configure<AzureExtensionUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureExtensionUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureExtensionAddSettings
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        /// <summary><p>Name of extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Filepath or URL to an extension.</p></summary>
        public virtual string Source { get; internal set; }
        /// <summary><p>Do not prompt for confirmation.</p></summary>
        public virtual string Yes { get; internal set; }
        /// <summary><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        public virtual IReadOnlyList<string> PipExtraIndexUrls => PipExtraIndexUrlsInternal.AsReadOnly();
        internal List<string> PipExtraIndexUrlsInternal { get; set; } = new List<string>();
        /// <summary><p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p></summary>
        public virtual string PipProxy { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("extension add")
              .Add("--name {value}", Name)
              .Add("--source {value}", Source)
              .Add("--yes {value}", Yes)
              .Add("--pip-extra-index-urls {value}", PipExtraIndexUrls, separator: ' ')
              .Add("--pip-proxy {value}", PipProxy)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionListSettings
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("extension list")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionListAvailableSettings
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionListAvailableSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        /// <summary><p>Show the raw data from the extension index.</p></summary>
        public virtual bool? ShowDetails { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("extension list-available")
              .Add("--show-details", ShowDetails)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionRemoveSettings
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        /// <summary><p>Name of extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("extension remove")
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
    #region AzureExtensionShowSettings
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        /// <summary><p>Name of extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("extension show")
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
    #region AzureExtensionUpdateSettings
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureExtensionUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureExtension executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureExtensionTasks.AzureExtensionPath;
        /// <summary><p>Name of extension.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        public virtual IReadOnlyList<string> PipExtraIndexUrls => PipExtraIndexUrlsInternal.AsReadOnly();
        internal List<string> PipExtraIndexUrlsInternal { get; set; } = new List<string>();
        /// <summary><p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p></summary>
        public virtual string PipProxy { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual Output Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("extension update")
              .Add("--name {value}", Name)
              .Add("--pip-extra-index-urls {value}", PipExtraIndexUrls, separator: ' ')
              .Add("--pip-proxy {value}", PipProxy)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureExtensionAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionAddSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetName(this AzureExtensionAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetName(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Source
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Source"/>.</em></p><p>Filepath or URL to an extension.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetSource(this AzureExtensionAddSettings toolSettings, string source)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = source;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Source"/>.</em></p><p>Filepath or URL to an extension.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetSource(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Source = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetYes(this AzureExtensionAddSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetYes(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region PipExtraIndexUrls
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/> to a new list.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/> to a new list.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings AddPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings AddPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ClearPipExtraIndexUrls(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings RemovePipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureExtensionAddSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings RemovePipExtraIndexUrls(this AzureExtensionAddSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region PipProxy
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.PipProxy"/>.</em></p><p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetPipProxy(this AzureExtensionAddSettings toolSettings, string pipProxy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = pipProxy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.PipProxy"/>.</em></p><p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetPipProxy(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetDebug(this AzureExtensionAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetDebug(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetHelp(this AzureExtensionAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetHelp(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetOutput(this AzureExtensionAddSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetOutput(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetQuery(this AzureExtensionAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetQuery(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureExtensionAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings SetVerbose(this AzureExtensionAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionAddSettings ResetVerbose(this AzureExtensionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionListSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureExtensionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListSettings SetDebug(this AzureExtensionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListSettings ResetDebug(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureExtensionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionListSettings SetHelp(this AzureExtensionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionListSettings ResetHelp(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureExtensionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionListSettings SetOutput(this AzureExtensionListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionListSettings ResetOutput(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureExtensionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionListSettings SetQuery(this AzureExtensionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionListSettings ResetQuery(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureExtensionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListSettings SetVerbose(this AzureExtensionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListSettings ResetVerbose(this AzureExtensionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionListAvailableSettingsExtensions
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionListAvailableSettingsExtensions
    {
        #region ShowDetails
        /// <summary><p><em>Sets <see cref="AzureExtensionListAvailableSettings.ShowDetails"/>.</em></p><p>Show the raw data from the extension index.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetShowDetails(this AzureExtensionListAvailableSettings toolSettings, bool? showDetails)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = showDetails;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListAvailableSettings.ShowDetails"/>.</em></p><p>Show the raw data from the extension index.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureExtensionListAvailableSettings.ShowDetails"/>.</em></p><p>Show the raw data from the extension index.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings EnableShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureExtensionListAvailableSettings.ShowDetails"/>.</em></p><p>Show the raw data from the extension index.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings DisableShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureExtensionListAvailableSettings.ShowDetails"/>.</em></p><p>Show the raw data from the extension index.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ToggleShowDetails(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowDetails = !toolSettings.ShowDetails;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureExtensionListAvailableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetDebug(this AzureExtensionListAvailableSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListAvailableSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetDebug(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureExtensionListAvailableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetHelp(this AzureExtensionListAvailableSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListAvailableSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetHelp(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureExtensionListAvailableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetOutput(this AzureExtensionListAvailableSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListAvailableSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetOutput(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureExtensionListAvailableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetQuery(this AzureExtensionListAvailableSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListAvailableSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetQuery(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureExtensionListAvailableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings SetVerbose(this AzureExtensionListAvailableSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionListAvailableSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionListAvailableSettings ResetVerbose(this AzureExtensionListAvailableSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionRemoveSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureExtensionRemoveSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetName(this AzureExtensionRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionRemoveSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetName(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureExtensionRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetDebug(this AzureExtensionRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetDebug(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureExtensionRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetHelp(this AzureExtensionRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetHelp(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureExtensionRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetOutput(this AzureExtensionRemoveSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetOutput(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureExtensionRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetQuery(this AzureExtensionRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetQuery(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureExtensionRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings SetVerbose(this AzureExtensionRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionRemoveSettings ResetVerbose(this AzureExtensionRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureExtensionShowSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings SetName(this AzureExtensionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionShowSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings ResetName(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureExtensionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings SetDebug(this AzureExtensionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings ResetDebug(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureExtensionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings SetHelp(this AzureExtensionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings ResetHelp(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureExtensionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings SetOutput(this AzureExtensionShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings ResetOutput(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureExtensionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings SetQuery(this AzureExtensionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings ResetQuery(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureExtensionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings SetVerbose(this AzureExtensionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionShowSettings ResetVerbose(this AzureExtensionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureExtensionUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureExtensionTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureExtensionUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetName(this AzureExtensionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.Name"/>.</em></p><p>Name of extension.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetName(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PipExtraIndexUrls
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/> to a new list.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/> to a new list.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal = pipExtraIndexUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings AddPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings AddPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.AddRange(pipExtraIndexUrls);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ClearPipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipExtraIndexUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings RemovePipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, params string[] pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureExtensionUpdateSettings.PipExtraIndexUrls"/>.</em></p><p>Space-separated list of extra URLs of package indexes to use. This should point to a repository compliant with PEP 503 (the simple repository API) or a local directory laid out in the same format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings RemovePipExtraIndexUrls(this AzureExtensionUpdateSettings toolSettings, IEnumerable<string> pipExtraIndexUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(pipExtraIndexUrls);
            toolSettings.PipExtraIndexUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region PipProxy
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.PipProxy"/>.</em></p><p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetPipProxy(this AzureExtensionUpdateSettings toolSettings, string pipProxy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = pipProxy;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.PipProxy"/>.</em></p><p>Proxy for pip to use for extension dependencies in the form of [user:passwd@]proxy.server:port.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetPipProxy(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PipProxy = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetDebug(this AzureExtensionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetDebug(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetHelp(this AzureExtensionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetHelp(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetOutput(this AzureExtensionUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetOutput(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetQuery(this AzureExtensionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetQuery(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureExtensionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings SetVerbose(this AzureExtensionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureExtensionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureExtensionUpdateSettings ResetVerbose(this AzureExtensionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
