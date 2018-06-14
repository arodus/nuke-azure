// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureFeature.json.

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
    public static partial class AzureFeatureTasks
    {
        /// <summary><p>Path to the AzureFeature executable.</p></summary>
        public static string AzureFeaturePath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage resource provider features.</p></summary>
        public static IEnumerable<string> AzureFeature(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureFeaturePath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureFeatureListSettings toolSettings);
        static partial void PostProcess(AzureFeatureListSettings toolSettings);
        /// <summary><p>Manage resource provider features.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureFeatureList(Configure<AzureFeatureListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFeatureListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureFeatureRegisterSettings toolSettings);
        static partial void PostProcess(AzureFeatureRegisterSettings toolSettings);
        /// <summary><p>Manage resource provider features.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureFeatureRegister(Configure<AzureFeatureRegisterSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFeatureRegisterSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureFeatureShowSettings toolSettings);
        static partial void PostProcess(AzureFeatureShowSettings toolSettings);
        /// <summary><p>Manage resource provider features.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureFeatureShow(Configure<AzureFeatureShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFeatureShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureFeatureListSettings
    /// <summary><p>Used within <see cref="AzureFeatureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeatureListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFeature executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFeatureTasks.AzureFeaturePath;
        /// <summary><p>The resource namespace, aka 'provider'.</p></summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("feature list")
              .Add("--namespace {value}", Namespace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFeatureRegisterSettings
    /// <summary><p>Used within <see cref="AzureFeatureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeatureRegisterSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFeature executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFeatureTasks.AzureFeaturePath;
        /// <summary><p>The feature name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The resource namespace, aka 'provider'.</p></summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("feature register")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFeatureShowSettings
    /// <summary><p>Used within <see cref="AzureFeatureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeatureShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureFeature executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureFeatureTasks.AzureFeaturePath;
        /// <summary><p>The feature name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The resource namespace, aka 'provider'.</p></summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("feature show")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFeatureListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFeatureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeatureListSettingsExtensions
    {
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureFeatureListSettings.Namespace"/>.</em></p><p>The resource namespace, aka 'provider'.</p></summary>
        [Pure]
        public static AzureFeatureListSettings SetNamespace(this AzureFeatureListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureListSettings.Namespace"/>.</em></p><p>The resource namespace, aka 'provider'.</p></summary>
        [Pure]
        public static AzureFeatureListSettings ResetNamespace(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFeatureListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeatureListSettings SetDebug(this AzureFeatureListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeatureListSettings ResetDebug(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFeatureListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeatureListSettings SetHelp(this AzureFeatureListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeatureListSettings ResetHelp(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFeatureListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeatureListSettings SetOutput(this AzureFeatureListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeatureListSettings ResetOutput(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFeatureListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeatureListSettings SetQuery(this AzureFeatureListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeatureListSettings ResetQuery(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFeatureListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeatureListSettings SetVerbose(this AzureFeatureListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeatureListSettings ResetVerbose(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFeatureRegisterSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFeatureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeatureRegisterSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Name"/>.</em></p><p>The feature name.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetName(this AzureFeatureRegisterSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Name"/>.</em></p><p>The feature name.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetName(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Namespace"/>.</em></p><p>The resource namespace, aka 'provider'.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetNamespace(this AzureFeatureRegisterSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Namespace"/>.</em></p><p>The resource namespace, aka 'provider'.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetNamespace(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetDebug(this AzureFeatureRegisterSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetDebug(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetHelp(this AzureFeatureRegisterSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetHelp(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetOutput(this AzureFeatureRegisterSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetOutput(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetQuery(this AzureFeatureRegisterSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetQuery(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFeatureRegisterSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetVerbose(this AzureFeatureRegisterSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureRegisterSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetVerbose(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFeatureShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureFeatureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeatureShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Name"/>.</em></p><p>The feature name.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetName(this AzureFeatureShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Name"/>.</em></p><p>The feature name.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetName(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Namespace"/>.</em></p><p>The resource namespace, aka 'provider'.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetNamespace(this AzureFeatureShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Namespace"/>.</em></p><p>The resource namespace, aka 'provider'.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetNamespace(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetDebug(this AzureFeatureShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetDebug(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetHelp(this AzureFeatureShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetHelp(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetOutput(this AzureFeatureShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetOutput(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetQuery(this AzureFeatureShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetQuery(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFeatureShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings SetVerbose(this AzureFeatureShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeatureShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeatureShowSettings ResetVerbose(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
