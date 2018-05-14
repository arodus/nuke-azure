// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.20 [CommitSha: 67bb27fd].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureMysql.json.

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
    public static partial class AzureMysqlTasks
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public static string AzureMysqlPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Database for MySQL servers.</p></summary>
        public static IEnumerable<string> AzureMysql(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureMysqlPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureMysqlSettings toolSettings);
        static partial void PostProcess(AzureMysqlSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysql(Configure<AzureMysqlSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlDbCreateSettings toolSettings);
        static partial void PostProcess(AzureMysqlDbCreateSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlDbCreate(Configure<AzureMysqlDbCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlDbCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlDbDeleteSettings toolSettings);
        static partial void PostProcess(AzureMysqlDbDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlDbDelete(Configure<AzureMysqlDbDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlDbDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlDbListSettings toolSettings);
        static partial void PostProcess(AzureMysqlDbListSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlDbList(Configure<AzureMysqlDbListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlDbListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlDbShowSettings toolSettings);
        static partial void PostProcess(AzureMysqlDbShowSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlDbShow(Configure<AzureMysqlDbShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlDbShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerLogsDownloadSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerLogsDownloadSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerLogsDownload(Configure<AzureMysqlServerLogsDownloadSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerLogsDownloadSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerLogsListSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerLogsListSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerLogsList(Configure<AzureMysqlServerLogsListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerLogsListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerCreateSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerCreateSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerCreate(Configure<AzureMysqlServerCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerDeleteSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerDelete(Configure<AzureMysqlServerDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerGeorestoreSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerGeorestoreSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerGeorestore(Configure<AzureMysqlServerGeorestoreSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerGeorestoreSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerListSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerListSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerList(Configure<AzureMysqlServerListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerRestoreSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerRestoreSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerRestore(Configure<AzureMysqlServerRestoreSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerRestoreSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerShowSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerShowSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerShow(Configure<AzureMysqlServerShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerUpdateSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerUpdate(Configure<AzureMysqlServerUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerWaitSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerWaitSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerWait(Configure<AzureMysqlServerWaitSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerWaitSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerConfigurationListSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerConfigurationListSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerConfigurationList(Configure<AzureMysqlServerConfigurationListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerConfigurationListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerConfigurationSetSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerConfigurationSetSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerConfigurationSet(Configure<AzureMysqlServerConfigurationSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerConfigurationSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerConfigurationShowSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerConfigurationShowSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerConfigurationShow(Configure<AzureMysqlServerConfigurationShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerConfigurationShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerFirewallRuleCreateSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerFirewallRuleCreateSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerFirewallRuleCreate(Configure<AzureMysqlServerFirewallRuleCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerFirewallRuleCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerFirewallRuleDeleteSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerFirewallRuleDeleteSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerFirewallRuleDelete(Configure<AzureMysqlServerFirewallRuleDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerFirewallRuleDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerFirewallRuleListSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerFirewallRuleListSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerFirewallRuleList(Configure<AzureMysqlServerFirewallRuleListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerFirewallRuleListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerFirewallRuleShowSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerFirewallRuleShowSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerFirewallRuleShow(Configure<AzureMysqlServerFirewallRuleShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerFirewallRuleShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureMysqlServerFirewallRuleUpdateSettings toolSettings);
        static partial void PostProcess(AzureMysqlServerFirewallRuleUpdateSettings toolSettings);
        /// <summary><p>Manage Azure Database for MySQL servers.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/mysql?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureMysqlServerFirewallRuleUpdate(Configure<AzureMysqlServerFirewallRuleUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureMysqlServerFirewallRuleUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureMysqlSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
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
              .Add("mysql")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlDbCreateSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the database.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>The charset of the database.</p></summary>
        public virtual string Charset { get; internal set; }
        /// <summary><p>The collation of the database.</p></summary>
        public virtual string Collation { get; internal set; }
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
              .Add("mysql db create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--charset {value}", Charset)
              .Add("--collation {value}", Collation)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlDbDeleteSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the database.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql db delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzureMysqlDbListSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql db list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlDbShowSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlDbShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the database.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql db show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerLogsDownloadSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerLogsDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Space-separated list of log filenames on the server to download.</p></summary>
        public virtual IReadOnlyList<string> Name => NameInternal.AsReadOnly();
        internal List<string> NameInternal { get; set; } = new List<string>();
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql server-logs download")
              .Add("--name {value}", Name, separator: ' ')
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerLogsListSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerLogsListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Integer in hours to indicate file last modify time, default value is 72.</p></summary>
        public virtual string FileLastWritten { get; internal set; }
        /// <summary><p>The pattern that file name should match.</p></summary>
        public virtual string FilenameContains { get; internal set; }
        /// <summary><p>The file size limitation to filter files.</p></summary>
        public virtual string MaxFileSize { get; internal set; }
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
              .Add("mysql server-logs list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--file-last-written {value}", FileLastWritten)
              .Add("--filename-contains {value}", FilenameContains)
              .Add("--max-file-size {value}", MaxFileSize)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerCreateSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        public virtual string SkuName { get; internal set; }
        /// <summary><p>The number of days a backup is retained.</p></summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary><p>Enable Geo-redundant or not for server backup.</p></summary>
        public virtual string GeoRedundantBackup { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Enable ssl enforcement or not when connect to server.</p></summary>
        public virtual MysqlServerSslEnforcement SslEnforcement { get; internal set; }
        /// <summary><p>The max storage size of the server. Unit is megabytes.</p></summary>
        public virtual string StorageSize { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Server version.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string AdminUser { get; internal set; }
        /// <summary><p>The password of the administrator login.</p></summary>
        public virtual string AdminPassword { get; internal set; }
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
              .Add("mysql server create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sku-name {value}", SkuName)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--geo-redundant-backup {value}", GeoRedundantBackup)
              .Add("--location {value}", Location)
              .Add("--ssl-enforcement {value}", SslEnforcement)
              .Add("--storage-size {value}", StorageSize)
              .Add("--tags {value}", Tags)
              .Add("--version {value}", Version)
              .Add("--admin-user {value}", AdminUser)
              .Add("--admin-password {value}", AdminPassword)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerDeleteSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of the server.</p></summary>
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
              .Add("mysql server delete")
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
    #region AzureMysqlServerGeorestoreSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerGeorestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The name or ID of the source server to restore from.</p></summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary><p>The max days of retention, unit is days.</p></summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary><p>Enable Geo-redundant or not for server backup.</p></summary>
        public virtual string GeoRedundantBackup { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
        /// <summary><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        public virtual string SkuName { get; internal set; }
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
              .Add("mysql server georestore")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--source-server {value}", SourceServer)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--geo-redundant-backup {value}", GeoRedundantBackup)
              .Add("--no-wait {value}", NoWait)
              .Add("--sku-name {value}", SkuName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerListSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
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
              .Add("mysql server list")
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
    #region AzureMysqlServerRestoreSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerRestoreSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p></summary>
        public virtual string RestorePointInTime { get; internal set; }
        /// <summary><p>The name or ID of the source server to restore from.</p></summary>
        public virtual string SourceServer { get; internal set; }
        /// <summary><p>Do not wait for the long-running operation to finish.</p></summary>
        public virtual string NoWait { get; internal set; }
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
              .Add("mysql server restore")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--restore-point-in-time {value}", RestorePointInTime)
              .Add("--source-server {value}", SourceServer)
              .Add("--no-wait {value}", NoWait)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerShowSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of the server.</p></summary>
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
              .Add("mysql server show")
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
    #region AzureMysqlServerUpdateSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The password of the administrator login.</p></summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary><p>The number of days a backup is retained.</p></summary>
        public virtual string BackupRetention { get; internal set; }
        /// <summary><p>Enable ssl enforcement or not when connect to server.</p></summary>
        public virtual MysqlServerSslEnforcement SslEnforcement { get; internal set; }
        /// <summary><p>The max storage size of the server. Unit is megabytes.</p></summary>
        public virtual string StorageSize { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Number of vcore.</p></summary>
        public virtual int? Vcore { get; internal set; }
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
              .Add("mysql server update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin-password {value}", AdminPassword)
              .Add("--backup-retention {value}", BackupRetention)
              .Add("--ssl-enforcement {value}", SslEnforcement)
              .Add("--storage-size {value}", StorageSize)
              .Add("--tags {value}", Tags)
              .Add("--vcore {value}", Vcore)
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
    #region AzureMysqlServerWaitSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerWaitSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of the server.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        public virtual string Custom { get; internal set; }
        /// <summary><p>Wait until the resource exists.</p></summary>
        public virtual string Exists { get; internal set; }
        /// <summary><p>Polling interval in seconds.</p></summary>
        public virtual string Interval { get; internal set; }
        /// <summary><p>Maximum wait in seconds.</p></summary>
        public virtual string Timeout { get; internal set; }
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
              .Add("mysql server wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--custom {value}", Custom)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerConfigurationListSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerConfigurationListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql server configuration list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerConfigurationSetSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerConfigurationSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the server configuration.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>Value of the configuration. If not provided, configuration value will be set to default.</p></summary>
        public virtual string Value { get; internal set; }
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
              .Add("mysql server configuration set")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--value {value}", Value)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerConfigurationShowSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerConfigurationShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the server configuration.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql server configuration show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerFirewallRuleCreateSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
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
              .Add("mysql server firewall-rule create")
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--start-ip-address {value}", StartIpAddress)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerFirewallRuleDeleteSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql server firewall-rule delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
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
    #region AzureMysqlServerFirewallRuleListSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql server firewall-rule list")
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerFirewallRuleShowSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
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
              .Add("mysql server firewall-rule show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureMysqlServerFirewallRuleUpdateSettings
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureMysqlServerFirewallRuleUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureMysql executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureMysqlTasks.AzureMysqlPath;
        /// <summary><p>The name of the firewall rule.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the server.</p></summary>
        public virtual string ServerName { get; internal set; }
        /// <summary><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string EndIpAddress { get; internal set; }
        /// <summary><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        public virtual string StartIpAddress { get; internal set; }
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
              .Add("mysql server firewall-rule update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--server-name {value}", ServerName)
              .Add("--end-ip-address {value}", EndIpAddress)
              .Add("--start-ip-address {value}", StartIpAddress)
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
    #region AzureMysqlSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlSettings SetDebug(this AzureMysqlSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlSettings ResetDebug(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlSettings SetHelp(this AzureMysqlSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlSettings ResetHelp(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlSettings SetOutput(this AzureMysqlSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlSettings ResetOutput(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlSettings SetQuery(this AzureMysqlSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlSettings ResetQuery(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlSettings SetVerbose(this AzureMysqlSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlSettings ResetVerbose(this AzureMysqlSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetName(this AzureMysqlDbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetName(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetResourceGroup(this AzureMysqlDbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetResourceGroup(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetServerName(this AzureMysqlDbCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetServerName(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Charset
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Charset"/>.</em></p><p>The charset of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetCharset(this AzureMysqlDbCreateSettings toolSettings, string charset)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = charset;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Charset"/>.</em></p><p>The charset of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetCharset(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Charset = null;
            return toolSettings;
        }
        #endregion
        #region Collation
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Collation"/>.</em></p><p>The collation of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetCollation(this AzureMysqlDbCreateSettings toolSettings, string collation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = collation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Collation"/>.</em></p><p>The collation of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetCollation(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Collation = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetDebug(this AzureMysqlDbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetDebug(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetHelp(this AzureMysqlDbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetHelp(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetOutput(this AzureMysqlDbCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetOutput(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetQuery(this AzureMysqlDbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetQuery(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlDbCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings SetVerbose(this AzureMysqlDbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbCreateSettings ResetVerbose(this AzureMysqlDbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetName(this AzureMysqlDbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetName(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetResourceGroup(this AzureMysqlDbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetResourceGroup(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetServerName(this AzureMysqlDbDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetServerName(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetYes(this AzureMysqlDbDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetYes(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetDebug(this AzureMysqlDbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetDebug(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetHelp(this AzureMysqlDbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetHelp(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetOutput(this AzureMysqlDbDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetOutput(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetQuery(this AzureMysqlDbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetQuery(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlDbDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings SetVerbose(this AzureMysqlDbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbDeleteSettings ResetVerbose(this AzureMysqlDbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetResourceGroup(this AzureMysqlDbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetResourceGroup(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetServerName(this AzureMysqlDbListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetServerName(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetDebug(this AzureMysqlDbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetDebug(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetHelp(this AzureMysqlDbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetHelp(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetOutput(this AzureMysqlDbListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetOutput(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetQuery(this AzureMysqlDbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetQuery(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlDbListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings SetVerbose(this AzureMysqlDbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbListSettings ResetVerbose(this AzureMysqlDbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlDbShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlDbShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetName(this AzureMysqlDbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.Name"/>.</em></p><p>The name of the database.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetName(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetResourceGroup(this AzureMysqlDbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetResourceGroup(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetServerName(this AzureMysqlDbShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetServerName(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetDebug(this AzureMysqlDbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetDebug(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetHelp(this AzureMysqlDbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetHelp(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetOutput(this AzureMysqlDbShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetOutput(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetQuery(this AzureMysqlDbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetQuery(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlDbShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings SetVerbose(this AzureMysqlDbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlDbShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlDbShowSettings ResetVerbose(this AzureMysqlDbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerLogsDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerLogsDownloadSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Name"/> to a new list.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetName(this AzureMysqlServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Name"/> to a new list.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetName(this AzureMysqlServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal = name.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMysqlServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings AddName(this AzureMysqlServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureMysqlServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings AddName(this AzureMysqlServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.AddRange(name);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureMysqlServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ClearName(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NameInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMysqlServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings RemoveName(this AzureMysqlServerLogsDownloadSettings toolSettings, params string[] name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureMysqlServerLogsDownloadSettings.Name"/>.</em></p><p>Space-separated list of log filenames on the server to download.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings RemoveName(this AzureMysqlServerLogsDownloadSettings toolSettings, IEnumerable<string> name)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(name);
            toolSettings.NameInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetResourceGroup(this AzureMysqlServerLogsDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetResourceGroup(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetServerName(this AzureMysqlServerLogsDownloadSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetServerName(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetDebug(this AzureMysqlServerLogsDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetDebug(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetHelp(this AzureMysqlServerLogsDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetHelp(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetOutput(this AzureMysqlServerLogsDownloadSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetOutput(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetQuery(this AzureMysqlServerLogsDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetQuery(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings SetVerbose(this AzureMysqlServerLogsDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsDownloadSettings ResetVerbose(this AzureMysqlServerLogsDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerLogsListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerLogsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetResourceGroup(this AzureMysqlServerLogsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetResourceGroup(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetServerName(this AzureMysqlServerLogsListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetServerName(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region FileLastWritten
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.FileLastWritten"/>.</em></p><p>Integer in hours to indicate file last modify time, default value is 72.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetFileLastWritten(this AzureMysqlServerLogsListSettings toolSettings, string fileLastWritten)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = fileLastWritten;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.FileLastWritten"/>.</em></p><p>Integer in hours to indicate file last modify time, default value is 72.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetFileLastWritten(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FileLastWritten = null;
            return toolSettings;
        }
        #endregion
        #region FilenameContains
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.FilenameContains"/>.</em></p><p>The pattern that file name should match.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetFilenameContains(this AzureMysqlServerLogsListSettings toolSettings, string filenameContains)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = filenameContains;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.FilenameContains"/>.</em></p><p>The pattern that file name should match.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetFilenameContains(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilenameContains = null;
            return toolSettings;
        }
        #endregion
        #region MaxFileSize
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.MaxFileSize"/>.</em></p><p>The file size limitation to filter files.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetMaxFileSize(this AzureMysqlServerLogsListSettings toolSettings, string maxFileSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = maxFileSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.MaxFileSize"/>.</em></p><p>The file size limitation to filter files.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetMaxFileSize(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxFileSize = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetDebug(this AzureMysqlServerLogsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetDebug(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetHelp(this AzureMysqlServerLogsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetHelp(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetOutput(this AzureMysqlServerLogsListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetOutput(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetQuery(this AzureMysqlServerLogsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetQuery(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerLogsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings SetVerbose(this AzureMysqlServerLogsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerLogsListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerLogsListSettings ResetVerbose(this AzureMysqlServerLogsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetName(this AzureMysqlServerCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetName(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetResourceGroup(this AzureMysqlServerCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetResourceGroup(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetSkuName(this AzureMysqlServerCreateSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetSkuName(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetBackupRetention(this AzureMysqlServerCreateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetBackupRetention(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetGeoRedundantBackup(this AzureMysqlServerCreateSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetGeoRedundantBackup(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetLocation(this AzureMysqlServerCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetLocation(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetSslEnforcement(this AzureMysqlServerCreateSettings toolSettings, MysqlServerSslEnforcement sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetSslEnforcement(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetStorageSize(this AzureMysqlServerCreateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetStorageSize(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetTags(this AzureMysqlServerCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetTags(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Version"/>.</em></p><p>Server version.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetVersion(this AzureMysqlServerCreateSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Version"/>.</em></p><p>Server version.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetVersion(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region AdminUser
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.AdminUser"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetAdminUser(this AzureMysqlServerCreateSettings toolSettings, string adminUser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = adminUser;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.AdminUser"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetAdminUser(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUser = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetAdminPassword(this AzureMysqlServerCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetAdminPassword(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetDebug(this AzureMysqlServerCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetDebug(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetHelp(this AzureMysqlServerCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetHelp(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetOutput(this AzureMysqlServerCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetOutput(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetQuery(this AzureMysqlServerCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetQuery(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings SetVerbose(this AzureMysqlServerCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerCreateSettings ResetVerbose(this AzureMysqlServerCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetName(this AzureMysqlServerDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetName(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetResourceGroup(this AzureMysqlServerDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetResourceGroup(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetYes(this AzureMysqlServerDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetYes(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetDebug(this AzureMysqlServerDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetDebug(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetHelp(this AzureMysqlServerDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetHelp(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetOutput(this AzureMysqlServerDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetOutput(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetQuery(this AzureMysqlServerDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetQuery(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings SetVerbose(this AzureMysqlServerDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerDeleteSettings ResetVerbose(this AzureMysqlServerDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerGeorestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerGeorestoreSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetLocation(this AzureMysqlServerGeorestoreSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetLocation(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetName(this AzureMysqlServerGeorestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetName(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetResourceGroup(this AzureMysqlServerGeorestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetResourceGroup(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetSourceServer(this AzureMysqlServerGeorestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetSourceServer(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.BackupRetention"/>.</em></p><p>The max days of retention, unit is days.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetBackupRetention(this AzureMysqlServerGeorestoreSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.BackupRetention"/>.</em></p><p>The max days of retention, unit is days.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetBackupRetention(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region GeoRedundantBackup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetGeoRedundantBackup(this AzureMysqlServerGeorestoreSettings toolSettings, string geoRedundantBackup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = geoRedundantBackup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.GeoRedundantBackup"/>.</em></p><p>Enable Geo-redundant or not for server backup.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetGeoRedundantBackup(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GeoRedundantBackup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetNoWait(this AzureMysqlServerGeorestoreSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetNoWait(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetSkuName(this AzureMysqlServerGeorestoreSettings toolSettings, string skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.SkuName"/>.</em></p><p>The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetSkuName(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetDebug(this AzureMysqlServerGeorestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetDebug(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetHelp(this AzureMysqlServerGeorestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetHelp(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetOutput(this AzureMysqlServerGeorestoreSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetOutput(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetQuery(this AzureMysqlServerGeorestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetQuery(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerGeorestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings SetVerbose(this AzureMysqlServerGeorestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerGeorestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerGeorestoreSettings ResetVerbose(this AzureMysqlServerGeorestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings SetResourceGroup(this AzureMysqlServerListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetResourceGroup(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings SetDebug(this AzureMysqlServerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetDebug(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings SetHelp(this AzureMysqlServerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetHelp(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings SetOutput(this AzureMysqlServerListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetOutput(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings SetQuery(this AzureMysqlServerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetQuery(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings SetVerbose(this AzureMysqlServerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerListSettings ResetVerbose(this AzureMysqlServerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerRestoreSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerRestoreSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetName(this AzureMysqlServerRestoreSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetName(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetResourceGroup(this AzureMysqlServerRestoreSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetResourceGroup(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region RestorePointInTime
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.RestorePointInTime"/>.</em></p><p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetRestorePointInTime(this AzureMysqlServerRestoreSettings toolSettings, string restorePointInTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = restorePointInTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.RestorePointInTime"/>.</em></p><p>The point in time to restore from (ISO8601 format), e.g., 2017-04-26T02:10:00+08:00.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetRestorePointInTime(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RestorePointInTime = null;
            return toolSettings;
        }
        #endregion
        #region SourceServer
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetSourceServer(this AzureMysqlServerRestoreSettings toolSettings, string sourceServer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = sourceServer;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.SourceServer"/>.</em></p><p>The name or ID of the source server to restore from.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetSourceServer(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SourceServer = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetNoWait(this AzureMysqlServerRestoreSettings toolSettings, string noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.NoWait"/>.</em></p><p>Do not wait for the long-running operation to finish.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetNoWait(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetDebug(this AzureMysqlServerRestoreSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetDebug(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetHelp(this AzureMysqlServerRestoreSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetHelp(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetOutput(this AzureMysqlServerRestoreSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetOutput(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetQuery(this AzureMysqlServerRestoreSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetQuery(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings SetVerbose(this AzureMysqlServerRestoreSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerRestoreSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerRestoreSettings ResetVerbose(this AzureMysqlServerRestoreSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetName(this AzureMysqlServerShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetName(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetResourceGroup(this AzureMysqlServerShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetResourceGroup(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetDebug(this AzureMysqlServerShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetDebug(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetHelp(this AzureMysqlServerShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetHelp(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetOutput(this AzureMysqlServerShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetOutput(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetQuery(this AzureMysqlServerShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetQuery(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings SetVerbose(this AzureMysqlServerShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerShowSettings ResetVerbose(this AzureMysqlServerShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetName(this AzureMysqlServerUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetName(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetResourceGroup(this AzureMysqlServerUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetResourceGroup(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetAdminPassword(this AzureMysqlServerUpdateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.AdminPassword"/>.</em></p><p>The password of the administrator login.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetAdminPassword(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region BackupRetention
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetBackupRetention(this AzureMysqlServerUpdateSettings toolSettings, string backupRetention)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = backupRetention;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.BackupRetention"/>.</em></p><p>The number of days a backup is retained.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetBackupRetention(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BackupRetention = null;
            return toolSettings;
        }
        #endregion
        #region SslEnforcement
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetSslEnforcement(this AzureMysqlServerUpdateSettings toolSettings, MysqlServerSslEnforcement sslEnforcement)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = sslEnforcement;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.SslEnforcement"/>.</em></p><p>Enable ssl enforcement or not when connect to server.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetSslEnforcement(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SslEnforcement = null;
            return toolSettings;
        }
        #endregion
        #region StorageSize
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetStorageSize(this AzureMysqlServerUpdateSettings toolSettings, string storageSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = storageSize;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.StorageSize"/>.</em></p><p>The max storage size of the server. Unit is megabytes.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetStorageSize(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StorageSize = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetTags(this AzureMysqlServerUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetTags(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Vcore
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Vcore"/>.</em></p><p>Number of vcore.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetVcore(this AzureMysqlServerUpdateSettings toolSettings, int? vcore)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vcore = vcore;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Vcore"/>.</em></p><p>Number of vcore.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetVcore(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Vcore = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetAdd(this AzureMysqlServerUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetAdd(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetRemove(this AzureMysqlServerUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetRemove(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetSet(this AzureMysqlServerUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetSet(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetDebug(this AzureMysqlServerUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetDebug(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetHelp(this AzureMysqlServerUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetHelp(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetOutput(this AzureMysqlServerUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetOutput(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetQuery(this AzureMysqlServerUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetQuery(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings SetVerbose(this AzureMysqlServerUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerUpdateSettings ResetVerbose(this AzureMysqlServerUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerWaitSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerWaitSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetName(this AzureMysqlServerWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Name"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetName(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetResourceGroup(this AzureMysqlServerWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetResourceGroup(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetCustom(this AzureMysqlServerWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Custom"/>.</em></p><p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetCustom(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetExists(this AzureMysqlServerWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Exists"/>.</em></p><p>Wait until the resource exists.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetExists(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetInterval(this AzureMysqlServerWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Interval"/>.</em></p><p>Polling interval in seconds.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetInterval(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetTimeout(this AzureMysqlServerWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Timeout"/>.</em></p><p>Maximum wait in seconds.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetTimeout(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetDebug(this AzureMysqlServerWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetDebug(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetHelp(this AzureMysqlServerWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetHelp(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetOutput(this AzureMysqlServerWaitSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetOutput(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetQuery(this AzureMysqlServerWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetQuery(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings SetVerbose(this AzureMysqlServerWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerWaitSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerWaitSettings ResetVerbose(this AzureMysqlServerWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerConfigurationListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerConfigurationListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetResourceGroup(this AzureMysqlServerConfigurationListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetResourceGroup(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetServerName(this AzureMysqlServerConfigurationListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetServerName(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetDebug(this AzureMysqlServerConfigurationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetDebug(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetHelp(this AzureMysqlServerConfigurationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetHelp(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetOutput(this AzureMysqlServerConfigurationListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetOutput(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetQuery(this AzureMysqlServerConfigurationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetQuery(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings SetVerbose(this AzureMysqlServerConfigurationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationListSettings ResetVerbose(this AzureMysqlServerConfigurationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerConfigurationSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerConfigurationSetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetName(this AzureMysqlServerConfigurationSetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetName(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetResourceGroup(this AzureMysqlServerConfigurationSetSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetResourceGroup(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetServerName(this AzureMysqlServerConfigurationSetSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetServerName(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Value"/>.</em></p><p>Value of the configuration. If not provided, configuration value will be set to default.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetValue(this AzureMysqlServerConfigurationSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Value"/>.</em></p><p>Value of the configuration. If not provided, configuration value will be set to default.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetValue(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetDebug(this AzureMysqlServerConfigurationSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetDebug(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetHelp(this AzureMysqlServerConfigurationSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetHelp(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetOutput(this AzureMysqlServerConfigurationSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetOutput(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetQuery(this AzureMysqlServerConfigurationSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetQuery(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings SetVerbose(this AzureMysqlServerConfigurationSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationSetSettings ResetVerbose(this AzureMysqlServerConfigurationSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerConfigurationShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerConfigurationShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetName(this AzureMysqlServerConfigurationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Name"/>.</em></p><p>The name of the server configuration.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetName(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetResourceGroup(this AzureMysqlServerConfigurationShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetResourceGroup(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetServerName(this AzureMysqlServerConfigurationShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetServerName(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetDebug(this AzureMysqlServerConfigurationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetDebug(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetHelp(this AzureMysqlServerConfigurationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetHelp(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetOutput(this AzureMysqlServerConfigurationShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetOutput(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetQuery(this AzureMysqlServerConfigurationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetQuery(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerConfigurationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings SetVerbose(this AzureMysqlServerConfigurationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerConfigurationShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerConfigurationShowSettings ResetVerbose(this AzureMysqlServerConfigurationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleCreateSettingsExtensions
    {
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetEndIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetEndIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetResourceGroup(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetServerName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetServerName(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetStartIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetStartIpAddress(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetDebug(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetDebug(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetHelp(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetHelp(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetOutput(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetOutput(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetQuery(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetQuery(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings SetVerbose(this AzureMysqlServerFirewallRuleCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleCreateSettings ResetVerbose(this AzureMysqlServerFirewallRuleCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetResourceGroup(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetServerName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetServerName(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetYes(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Yes"/>.</em></p><p>Do not prompt for confirmation.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetYes(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetDebug(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetDebug(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetHelp(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetHelp(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetOutput(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetOutput(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetQuery(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetQuery(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings SetVerbose(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleDeleteSettings ResetVerbose(this AzureMysqlServerFirewallRuleDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetResourceGroup(this AzureMysqlServerFirewallRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetServerName(this AzureMysqlServerFirewallRuleListSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetServerName(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetDebug(this AzureMysqlServerFirewallRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetDebug(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetHelp(this AzureMysqlServerFirewallRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetHelp(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetOutput(this AzureMysqlServerFirewallRuleListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetOutput(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetQuery(this AzureMysqlServerFirewallRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetQuery(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings SetVerbose(this AzureMysqlServerFirewallRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleListSettings ResetVerbose(this AzureMysqlServerFirewallRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetName(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetName(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetResourceGroup(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetServerName(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetServerName(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetDebug(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetDebug(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetHelp(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetHelp(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetOutput(this AzureMysqlServerFirewallRuleShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetOutput(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetQuery(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetQuery(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings SetVerbose(this AzureMysqlServerFirewallRuleShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleShowSettings ResetVerbose(this AzureMysqlServerFirewallRuleShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureMysqlServerFirewallRuleUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureMysqlServerFirewallRuleUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Name"/>.</em></p><p>The name of the firewall rule.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetResourceGroup(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetResourceGroup(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ServerName
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetServerName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string serverName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = serverName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.ServerName"/>.</em></p><p>Name of the server.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetServerName(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServerName = null;
            return toolSettings;
        }
        #endregion
        #region EndIpAddress
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetEndIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string endIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = endIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.EndIpAddress"/>.</em></p><p>The end IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetEndIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region StartIpAddress
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetStartIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string startIpAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = startIpAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.StartIpAddress"/>.</em></p><p>The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' to represent all Azure-internal IP addresses.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetStartIpAddress(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartIpAddress = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetAdd(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetAdd(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetRemove(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetRemove(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetSet(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetSet(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetDebug(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetDebug(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetHelp(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetHelp(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetOutput(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetOutput(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetQuery(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetQuery(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings SetVerbose(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureMysqlServerFirewallRuleUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureMysqlServerFirewallRuleUpdateSettings ResetVerbose(this AzureMysqlServerFirewallRuleUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region MysqlServerSslEnforcement
    /// <summary><p>Used within <see cref="AzureMysqlTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class MysqlServerSslEnforcement : Enumeration
    {
        public static MysqlServerSslEnforcement disabled = new MysqlServerSslEnforcement { Value = "disabled" };
        public static MysqlServerSslEnforcement enabled = new MysqlServerSslEnforcement { Value = "enabled" };
    }
    #endregion
}
