// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.3 [CommitSha: 0aff3c55].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/Azure.json.

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
    public static partial class AzureTasks
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public static string AzurePath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>General Tasks.</p></summary>
        public static IEnumerable<string> Azure(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool redirectOutput = false, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzurePath, arguments, workingDirectory, environmentVariables, timeout, redirectOutput, outputFilter);
            process.AssertZeroExitCode();
            return process.HasOutput ? process.Output.Select(x => x.Text) : null;
        }
        static partial void PreProcess(AzureConfigureSettings toolSettings);
        static partial void PostProcess(AzureConfigureSettings toolSettings);
        /// <summary><p>General Tasks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureConfigure(Configure<AzureConfigureSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureConfigureSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureFeedbackSettings toolSettings);
        static partial void PostProcess(AzureFeedbackSettings toolSettings);
        /// <summary><p>General Tasks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureFeedback(Configure<AzureFeedbackSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFeedbackSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureFindSettings toolSettings);
        static partial void PostProcess(AzureFindSettings toolSettings);
        /// <summary><p>General Tasks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureFind(Configure<AzureFindSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureFindSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureInteractiveSettings toolSettings);
        static partial void PostProcess(AzureInteractiveSettings toolSettings);
        /// <summary><p>General Tasks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureInteractive(Configure<AzureInteractiveSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureInteractiveSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureLoginSettings toolSettings);
        static partial void PostProcess(AzureLoginSettings toolSettings);
        /// <summary><p>General Tasks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureLogin(Configure<AzureLoginSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLoginSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureLogoutSettings toolSettings);
        static partial void PostProcess(AzureLogoutSettings toolSettings);
        /// <summary><p>General Tasks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/reference-index?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureLogout(Configure<AzureLogoutSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLogoutSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureConfigureSettings
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureConfigureSettings : ToolSettings
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        /// <summary><p>Space-separated 'name=value' pairs for common argument defaults.</p></summary>
        public virtual string Defaults { get; internal set; }
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
              .Add("configure")
              .Add("--defaults {value}", Defaults)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFeedbackSettings
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeedbackSettings : ToolSettings
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
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
              .Add("feedback")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureFindSettings
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFindSettings : ToolSettings
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        /// <summary><p>Query text to find.</p></summary>
        public virtual string SearchQuery { get; internal set; }
        /// <summary><p>Clear the current index and reindex the command modules.</p></summary>
        public virtual string Reindex { get; internal set; }
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
              .Add("find")
              .Add("--search-query {value}", SearchQuery)
              .Add("--reindex {value}", Reindex)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureInteractiveSettings
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureInteractiveSettings : ToolSettings
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        /// <summary><p>The colors of the shell.</p></summary>
        public virtual InteractiveStyle Style { get; internal set; }
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
              .Add("interactive")
              .Add("--style {value}", Style)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLoginSettings
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLoginSettings : ToolSettings
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        /// <summary><p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p></summary>
        public virtual bool? AllowNoSubscriptions { get; internal set; }
        /// <summary><p>Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The credential representing a service principal.</p></summary>
        public virtual bool? ServicePrincipal { get; internal set; }
        /// <summary><p>The AAD tenant, must provide when using service principals.</p></summary>
        public virtual string Tenant { get; internal set; }
        /// <summary><p>User name, service principal, or managed service identity ID.</p></summary>
        public virtual string Username { get; internal set; }
        /// <summary><p>Log in using the Virtual Machine's identity.</p></summary>
        public virtual bool? Identity { get; internal set; }
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
              .Add("login")
              .Add("--allow-no-subscriptions", AllowNoSubscriptions)
              .Add("--password {value}", Password, secret: true)
              .Add("--service-principal", ServicePrincipal)
              .Add("--tenant {value}", Tenant)
              .Add("--username {value}", Username)
              .Add("--identity", Identity)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLogoutSettings
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLogoutSettings : ToolSettings
    {
        /// <summary><p>Path to the Azure executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureTasks.AzurePath;
        /// <summary><p>Account user, if missing, logout the current active account.</p></summary>
        public virtual string Username { get; internal set; }
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
              .Add("logout")
              .Add("--username {value}", Username)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureConfigureSettingsExtensions
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureConfigureSettingsExtensions
    {
        #region Defaults
        /// <summary><p><em>Sets <see cref="AzureConfigureSettings.Defaults"/>.</em></p><p>Space-separated 'name=value' pairs for common argument defaults.</p></summary>
        [Pure]
        public static AzureConfigureSettings SetDefaults(this AzureConfigureSettings toolSettings, string defaults)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defaults = defaults;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConfigureSettings.Defaults"/>.</em></p><p>Space-separated 'name=value' pairs for common argument defaults.</p></summary>
        [Pure]
        public static AzureConfigureSettings ResetDefaults(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Defaults = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureConfigureSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConfigureSettings SetDebug(this AzureConfigureSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConfigureSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureConfigureSettings ResetDebug(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureConfigureSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConfigureSettings SetHelp(this AzureConfigureSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConfigureSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureConfigureSettings ResetHelp(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureConfigureSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConfigureSettings SetOutput(this AzureConfigureSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConfigureSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureConfigureSettings ResetOutput(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureConfigureSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureConfigureSettings SetQuery(this AzureConfigureSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConfigureSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureConfigureSettings ResetQuery(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureConfigureSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConfigureSettings SetVerbose(this AzureConfigureSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureConfigureSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureConfigureSettings ResetVerbose(this AzureConfigureSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFeedbackSettingsExtensions
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeedbackSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFeedbackSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeedbackSettings SetDebug(this AzureFeedbackSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeedbackSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFeedbackSettings ResetDebug(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFeedbackSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeedbackSettings SetHelp(this AzureFeedbackSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeedbackSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFeedbackSettings ResetHelp(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFeedbackSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeedbackSettings SetOutput(this AzureFeedbackSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeedbackSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFeedbackSettings ResetOutput(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFeedbackSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeedbackSettings SetQuery(this AzureFeedbackSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeedbackSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFeedbackSettings ResetQuery(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFeedbackSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeedbackSettings SetVerbose(this AzureFeedbackSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFeedbackSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFeedbackSettings ResetVerbose(this AzureFeedbackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFindSettingsExtensions
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFindSettingsExtensions
    {
        #region SearchQuery
        /// <summary><p><em>Sets <see cref="AzureFindSettings.SearchQuery"/>.</em></p><p>Query text to find.</p></summary>
        [Pure]
        public static AzureFindSettings SetSearchQuery(this AzureFindSettings toolSettings, string searchQuery)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SearchQuery = searchQuery;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.SearchQuery"/>.</em></p><p>Query text to find.</p></summary>
        [Pure]
        public static AzureFindSettings ResetSearchQuery(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SearchQuery = null;
            return toolSettings;
        }
        #endregion
        #region Reindex
        /// <summary><p><em>Sets <see cref="AzureFindSettings.Reindex"/>.</em></p><p>Clear the current index and reindex the command modules.</p></summary>
        [Pure]
        public static AzureFindSettings SetReindex(this AzureFindSettings toolSettings, string reindex)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reindex = reindex;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.Reindex"/>.</em></p><p>Clear the current index and reindex the command modules.</p></summary>
        [Pure]
        public static AzureFindSettings ResetReindex(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reindex = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureFindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFindSettings SetDebug(this AzureFindSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureFindSettings ResetDebug(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureFindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFindSettings SetHelp(this AzureFindSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureFindSettings ResetHelp(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureFindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFindSettings SetOutput(this AzureFindSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureFindSettings ResetOutput(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureFindSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFindSettings SetQuery(this AzureFindSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureFindSettings ResetQuery(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureFindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFindSettings SetVerbose(this AzureFindSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureFindSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureFindSettings ResetVerbose(this AzureFindSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureInteractiveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureInteractiveSettingsExtensions
    {
        #region Style
        /// <summary><p><em>Sets <see cref="AzureInteractiveSettings.Style"/>.</em></p><p>The colors of the shell.</p></summary>
        [Pure]
        public static AzureInteractiveSettings SetStyle(this AzureInteractiveSettings toolSettings, InteractiveStyle style)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Style = style;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureInteractiveSettings.Style"/>.</em></p><p>The colors of the shell.</p></summary>
        [Pure]
        public static AzureInteractiveSettings ResetStyle(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Style = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureInteractiveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureInteractiveSettings SetDebug(this AzureInteractiveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureInteractiveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureInteractiveSettings ResetDebug(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureInteractiveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureInteractiveSettings SetHelp(this AzureInteractiveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureInteractiveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureInteractiveSettings ResetHelp(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureInteractiveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureInteractiveSettings SetOutput(this AzureInteractiveSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureInteractiveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureInteractiveSettings ResetOutput(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureInteractiveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureInteractiveSettings SetQuery(this AzureInteractiveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureInteractiveSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureInteractiveSettings ResetQuery(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureInteractiveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureInteractiveSettings SetVerbose(this AzureInteractiveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureInteractiveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureInteractiveSettings ResetVerbose(this AzureInteractiveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLoginSettingsExtensions
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLoginSettingsExtensions
    {
        #region AllowNoSubscriptions
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.AllowNoSubscriptions"/>.</em></p><p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p></summary>
        [Pure]
        public static AzureLoginSettings SetAllowNoSubscriptions(this AzureLoginSettings toolSettings, bool? allowNoSubscriptions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = allowNoSubscriptions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.AllowNoSubscriptions"/>.</em></p><p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureLoginSettings.AllowNoSubscriptions"/>.</em></p><p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p></summary>
        [Pure]
        public static AzureLoginSettings EnableAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureLoginSettings.AllowNoSubscriptions"/>.</em></p><p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p></summary>
        [Pure]
        public static AzureLoginSettings DisableAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureLoginSettings.AllowNoSubscriptions"/>.</em></p><p>Support access tenants without subscriptions. It's uncommon but useful to run tenant level commands, such as 'az ad'.</p></summary>
        [Pure]
        public static AzureLoginSettings ToggleAllowNoSubscriptions(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AllowNoSubscriptions = !toolSettings.AllowNoSubscriptions;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Password"/>.</em></p><p>Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureLoginSettings SetPassword(this AzureLoginSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Password"/>.</em></p><p>Credentials like user password, or for a service principal, provide client secret or a pem file with key and public certificate. Will prompt if not given.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetPassword(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.ServicePrincipal"/>.</em></p><p>The credential representing a service principal.</p></summary>
        [Pure]
        public static AzureLoginSettings SetServicePrincipal(this AzureLoginSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.ServicePrincipal"/>.</em></p><p>The credential representing a service principal.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureLoginSettings.ServicePrincipal"/>.</em></p><p>The credential representing a service principal.</p></summary>
        [Pure]
        public static AzureLoginSettings EnableServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureLoginSettings.ServicePrincipal"/>.</em></p><p>The credential representing a service principal.</p></summary>
        [Pure]
        public static AzureLoginSettings DisableServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureLoginSettings.ServicePrincipal"/>.</em></p><p>The credential representing a service principal.</p></summary>
        [Pure]
        public static AzureLoginSettings ToggleServicePrincipal(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Tenant
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Tenant"/>.</em></p><p>The AAD tenant, must provide when using service principals.</p></summary>
        [Pure]
        public static AzureLoginSettings SetTenant(this AzureLoginSettings toolSettings, string tenant)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tenant = tenant;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Tenant"/>.</em></p><p>The AAD tenant, must provide when using service principals.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetTenant(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tenant = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Username"/>.</em></p><p>User name, service principal, or managed service identity ID.</p></summary>
        [Pure]
        public static AzureLoginSettings SetUsername(this AzureLoginSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Username"/>.</em></p><p>User name, service principal, or managed service identity ID.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetUsername(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Identity
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Identity"/>.</em></p><p>Log in using the Virtual Machine's identity.</p></summary>
        [Pure]
        public static AzureLoginSettings SetIdentity(this AzureLoginSettings toolSettings, bool? identity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = identity;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Identity"/>.</em></p><p>Log in using the Virtual Machine's identity.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureLoginSettings.Identity"/>.</em></p><p>Log in using the Virtual Machine's identity.</p></summary>
        [Pure]
        public static AzureLoginSettings EnableIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureLoginSettings.Identity"/>.</em></p><p>Log in using the Virtual Machine's identity.</p></summary>
        [Pure]
        public static AzureLoginSettings DisableIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureLoginSettings.Identity"/>.</em></p><p>Log in using the Virtual Machine's identity.</p></summary>
        [Pure]
        public static AzureLoginSettings ToggleIdentity(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Identity = !toolSettings.Identity;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLoginSettings SetDebug(this AzureLoginSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetDebug(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLoginSettings SetHelp(this AzureLoginSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetHelp(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLoginSettings SetOutput(this AzureLoginSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetOutput(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureLoginSettings SetQuery(this AzureLoginSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetQuery(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLoginSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLoginSettings SetVerbose(this AzureLoginSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLoginSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLoginSettings ResetVerbose(this AzureLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLogoutSettingsExtensions
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLogoutSettingsExtensions
    {
        #region Username
        /// <summary><p><em>Sets <see cref="AzureLogoutSettings.Username"/>.</em></p><p>Account user, if missing, logout the current active account.</p></summary>
        [Pure]
        public static AzureLogoutSettings SetUsername(this AzureLogoutSettings toolSettings, string username)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLogoutSettings.Username"/>.</em></p><p>Account user, if missing, logout the current active account.</p></summary>
        [Pure]
        public static AzureLogoutSettings ResetUsername(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLogoutSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLogoutSettings SetDebug(this AzureLogoutSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLogoutSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLogoutSettings ResetDebug(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLogoutSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLogoutSettings SetHelp(this AzureLogoutSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLogoutSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLogoutSettings ResetHelp(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLogoutSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLogoutSettings SetOutput(this AzureLogoutSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLogoutSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLogoutSettings ResetOutput(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLogoutSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureLogoutSettings SetQuery(this AzureLogoutSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLogoutSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureLogoutSettings ResetQuery(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLogoutSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLogoutSettings SetVerbose(this AzureLogoutSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLogoutSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLogoutSettings ResetVerbose(this AzureLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region InteractiveStyle
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class InteractiveStyle : Enumeration
    {
        public static InteractiveStyle bg = new InteractiveStyle { Value = "bg" };
        public static InteractiveStyle br = new InteractiveStyle { Value = "br" };
        public static InteractiveStyle contrast = new InteractiveStyle { Value = "contrast" };
        public static InteractiveStyle default_ = new InteractiveStyle { Value = "default" };
        public static InteractiveStyle grey = new InteractiveStyle { Value = "grey" };
        public static InteractiveStyle halloween = new InteractiveStyle { Value = "halloween" };
        public static InteractiveStyle neon = new InteractiveStyle { Value = "neon" };
        public static InteractiveStyle none = new InteractiveStyle { Value = "none" };
        public static InteractiveStyle pastel = new InteractiveStyle { Value = "pastel" };
        public static InteractiveStyle primary = new InteractiveStyle { Value = "primary" };
        public static InteractiveStyle purple = new InteractiveStyle { Value = "purple" };
        public static InteractiveStyle quiet = new InteractiveStyle { Value = "quiet" };
    }
    #endregion
    #region Output
    /// <summary><p>Used within <see cref="AzureTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class Output : Enumeration
    {
        public static Output json = new Output { Value = "json" };
        public static Output jsonc = new Output { Value = "jsonc" };
        public static Output table = new Output { Value = "table" };
        public static Output tsv = new Output { Value = "tsv" };
    }
    #endregion
}
