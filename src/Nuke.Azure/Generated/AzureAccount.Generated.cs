// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.5.0-alpha.20 [CommitSha: 67bb27fd].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAccount.json.

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
    public static partial class AzureAccountTasks
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public static string AzureAccountPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure subscription information.</p></summary>
        public static IEnumerable<string> AzureAccount(string arguments, string workingDirectory = null, ProcessSettings processSettings = null)
        {
            var process = ProcessTasks.StartProcess(AzureAccountPath, arguments, workingDirectory, processSettings?.EnvironmentVariables, processSettings?.ExecutionTimeout, processSettings?.RedirectOutput ?? true);
            process.AssertZeroExitCode();
            return process.Output.Select(x => x.Text);
        }
        static partial void PreProcess(AzureAccountClearSettings toolSettings);
        static partial void PostProcess(AzureAccountClearSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountClear(Configure<AzureAccountClearSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountClearSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountGetAccessTokenSettings toolSettings);
        static partial void PostProcess(AzureAccountGetAccessTokenSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountGetAccessToken(Configure<AzureAccountGetAccessTokenSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountGetAccessTokenSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountListSettings toolSettings);
        static partial void PostProcess(AzureAccountListSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountList(Configure<AzureAccountListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountListLocationsSettings toolSettings);
        static partial void PostProcess(AzureAccountListLocationsSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountListLocations(Configure<AzureAccountListLocationsSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountListLocationsSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountSetSettings toolSettings);
        static partial void PostProcess(AzureAccountSetSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountSet(Configure<AzureAccountSetSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountSetSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountShowSettings toolSettings);
        static partial void PostProcess(AzureAccountShowSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountShow(Configure<AzureAccountShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountLockCreateSettings toolSettings);
        static partial void PostProcess(AzureAccountLockCreateSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountLockCreate(Configure<AzureAccountLockCreateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountLockCreateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountLockDeleteSettings toolSettings);
        static partial void PostProcess(AzureAccountLockDeleteSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountLockDelete(Configure<AzureAccountLockDeleteSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountLockDeleteSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountLockListSettings toolSettings);
        static partial void PostProcess(AzureAccountLockListSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountLockList(Configure<AzureAccountLockListSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountLockListSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountLockShowSettings toolSettings);
        static partial void PostProcess(AzureAccountLockShowSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountLockShow(Configure<AzureAccountLockShowSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountLockShowSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
        static partial void PreProcess(AzureAccountLockUpdateSettings toolSettings);
        static partial void PostProcess(AzureAccountLockUpdateSettings toolSettings);
        /// <summary><p>Manage Azure subscription information.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/account?view=azure-cli-latest">official website</a>.</p></summary>
        public static void AzureAccountLockUpdate(Configure<AzureAccountLockUpdateSettings> configurator = null, ProcessSettings processSettings = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAccountLockUpdateSettings());
            PreProcess(toolSettings);
            var process = ProcessTasks.StartProcess(toolSettings, processSettings);
            process.AssertZeroExitCode();
            PostProcess(toolSettings);
        }
    }
    #region AzureAccountClearSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountClearSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
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
              .Add("account clear")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountGetAccessTokenSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountGetAccessTokenSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name or ID of subscription.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("account get-access-token")
              .Add("--resource {value}", Resource)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountListSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>List all subscriptions, rather just 'Enabled' ones.</p></summary>
        public virtual string All { get; internal set; }
        /// <summary><p>Retrieve up-to-date subscriptions from server.</p></summary>
        public virtual string Refresh { get; internal set; }
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
              .Add("account list")
              .Add("--all {value}", All)
              .Add("--refresh {value}", Refresh)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountListLocationsSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountListLocationsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
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
              .Add("account list-locations")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountSetSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountSetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>Name or ID of subscription.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("account set")
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountShowSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>Output result in compatible with Azure SDK auth file.</p></summary>
        public virtual string SdkAuth { get; internal set; }
        /// <summary><p>Name or ID of subscription.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("account show")
              .Add("--sdk-auth {value}", SdkAuth)
              .Add("--subscription {value}", Subscription)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountLockCreateSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p></p></summary>
        public virtual AccountLockLockType LockType { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Notes about this lock.</p></summary>
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
              .Add("account lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
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
    #region AzureAccountLockDeleteSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
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
              .Add("account lock delete")
              .Add("--ids {value}", Ids)
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
    #region AzureAccountLockListSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>A query filter to use to restrict the results.</p></summary>
        public virtual string FilterString { get; internal set; }
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
              .Add("account lock list")
              .Add("--filter-string {value}", FilterString)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAccountLockShowSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
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
              .Add("account lock show")
              .Add("--ids {value}", Ids)
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
    #region AzureAccountLockUpdateSettings
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAccountLockUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAccount executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAccountTasks.AzureAccountPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p></p></summary>
        public virtual AccountLockLockType LockType { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Notes about this lock.</p></summary>
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
              .Add("account lock update")
              .Add("--ids {value}", Ids)
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
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
    #region AzureAccountClearSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountClearSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountClearSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountClearSettings SetDebug(this AzureAccountClearSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountClearSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountClearSettings ResetDebug(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountClearSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountClearSettings SetHelp(this AzureAccountClearSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountClearSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountClearSettings ResetHelp(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountClearSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountClearSettings SetOutput(this AzureAccountClearSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountClearSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountClearSettings ResetOutput(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountClearSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountClearSettings SetQuery(this AzureAccountClearSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountClearSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountClearSettings ResetQuery(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountClearSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountClearSettings SetVerbose(this AzureAccountClearSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountClearSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountClearSettings ResetVerbose(this AzureAccountClearSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountGetAccessTokenSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountGetAccessTokenSettingsExtensions
    {
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Resource"/>.</em></p><p>Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetResource(this AzureAccountGetAccessTokenSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Resource"/>.</em></p><p>Azure resource endpoints. Default to Azure Resource Manager Use 'az cloud show' command for other Azure resources.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetResource(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Subscription"/>.</em></p><p>Name or ID of subscription.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetSubscription(this AzureAccountGetAccessTokenSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Subscription"/>.</em></p><p>Name or ID of subscription.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetSubscription(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetDebug(this AzureAccountGetAccessTokenSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetDebug(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetHelp(this AzureAccountGetAccessTokenSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetHelp(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetOutput(this AzureAccountGetAccessTokenSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetOutput(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetQuery(this AzureAccountGetAccessTokenSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetQuery(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountGetAccessTokenSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings SetVerbose(this AzureAccountGetAccessTokenSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountGetAccessTokenSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountGetAccessTokenSettings ResetVerbose(this AzureAccountGetAccessTokenSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountListSettingsExtensions
    {
        #region All
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.All"/>.</em></p><p>List all subscriptions, rather just 'Enabled' ones.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetAll(this AzureAccountListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.All"/>.</em></p><p>List all subscriptions, rather just 'Enabled' ones.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetAll(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region Refresh
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.Refresh"/>.</em></p><p>Retrieve up-to-date subscriptions from server.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetRefresh(this AzureAccountListSettings toolSettings, string refresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = refresh;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.Refresh"/>.</em></p><p>Retrieve up-to-date subscriptions from server.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetRefresh(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetDebug(this AzureAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetDebug(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetHelp(this AzureAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetHelp(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetOutput(this AzureAccountListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetOutput(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetQuery(this AzureAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetQuery(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountListSettings SetVerbose(this AzureAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountListSettings ResetVerbose(this AzureAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountListLocationsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountListLocationsSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountListLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetDebug(this AzureAccountListLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListLocationsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetDebug(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountListLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetHelp(this AzureAccountListLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListLocationsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetHelp(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountListLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetOutput(this AzureAccountListLocationsSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListLocationsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetOutput(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountListLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetQuery(this AzureAccountListLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListLocationsSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetQuery(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountListLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings SetVerbose(this AzureAccountListLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountListLocationsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountListLocationsSettings ResetVerbose(this AzureAccountListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountSetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountSetSettingsExtensions
    {
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAccountSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription.</p></summary>
        [Pure]
        public static AzureAccountSetSettings SetSubscription(this AzureAccountSetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountSetSettings.Subscription"/>.</em></p><p>Name or ID of subscription.</p></summary>
        [Pure]
        public static AzureAccountSetSettings ResetSubscription(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountSetSettings SetDebug(this AzureAccountSetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountSetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountSetSettings ResetDebug(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountSetSettings SetHelp(this AzureAccountSetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountSetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountSetSettings ResetHelp(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountSetSettings SetOutput(this AzureAccountSetSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountSetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountSetSettings ResetOutput(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountSetSettings SetQuery(this AzureAccountSetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountSetSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountSetSettings ResetQuery(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountSetSettings SetVerbose(this AzureAccountSetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountSetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountSetSettings ResetVerbose(this AzureAccountSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountShowSettingsExtensions
    {
        #region SdkAuth
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetSdkAuth(this AzureAccountShowSettings toolSettings, string sdkAuth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = sdkAuth;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetSdkAuth(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetSubscription(this AzureAccountShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetSubscription(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetDebug(this AzureAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetDebug(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetHelp(this AzureAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetHelp(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetOutput(this AzureAccountShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetOutput(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetQuery(this AzureAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetQuery(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountShowSettings SetVerbose(this AzureAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountShowSettings ResetVerbose(this AzureAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetLockType(this AzureAccountLockCreateSettings toolSettings, AccountLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetLockType(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetName(this AzureAccountLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetName(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetNotes(this AzureAccountLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetNotes(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetDebug(this AzureAccountLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetDebug(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetHelp(this AzureAccountLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetHelp(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetOutput(this AzureAccountLockCreateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetOutput(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetQuery(this AzureAccountLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetQuery(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountLockCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings SetVerbose(this AzureAccountLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockCreateSettings ResetVerbose(this AzureAccountLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetIds(this AzureAccountLockDeleteSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetIds(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetName(this AzureAccountLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetName(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetDebug(this AzureAccountLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetDebug(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetHelp(this AzureAccountLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetHelp(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetOutput(this AzureAccountLockDeleteSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetOutput(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetQuery(this AzureAccountLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetQuery(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountLockDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings SetVerbose(this AzureAccountLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockDeleteSettings ResetVerbose(this AzureAccountLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockListSettingsExtensions
    {
        #region FilterString
        /// <summary><p><em>Sets <see cref="AzureAccountLockListSettings.FilterString"/>.</em></p><p>A query filter to use to restrict the results.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings SetFilterString(this AzureAccountLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockListSettings.FilterString"/>.</em></p><p>A query filter to use to restrict the results.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings ResetFilterString(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountLockListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings SetDebug(this AzureAccountLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings ResetDebug(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountLockListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings SetHelp(this AzureAccountLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings ResetHelp(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountLockListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings SetOutput(this AzureAccountLockListSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings ResetOutput(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountLockListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings SetQuery(this AzureAccountLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockListSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings ResetQuery(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountLockListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings SetVerbose(this AzureAccountLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockListSettings ResetVerbose(this AzureAccountLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockShowSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetIds(this AzureAccountLockShowSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetIds(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetName(this AzureAccountLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetName(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetDebug(this AzureAccountLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetDebug(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetHelp(this AzureAccountLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetHelp(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetOutput(this AzureAccountLockShowSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetOutput(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetQuery(this AzureAccountLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetQuery(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountLockShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings SetVerbose(this AzureAccountLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockShowSettings ResetVerbose(this AzureAccountLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAccountLockUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAccountLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetIds(this AzureAccountLockUpdateSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetIds(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetLockType(this AzureAccountLockUpdateSettings toolSettings, AccountLockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetLockType(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetName(this AzureAccountLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetName(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetNotes(this AzureAccountLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetNotes(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetDebug(this AzureAccountLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetDebug(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetHelp(this AzureAccountLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetHelp(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetOutput(this AzureAccountLockUpdateSettings toolSettings, Output output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetOutput(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetQuery(this AzureAccountLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See &lt;a href="http://jmespath.org/"&gt;http://jmespath.org/&lt;/a&gt; for more information and examples.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetQuery(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAccountLockUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings SetVerbose(this AzureAccountLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAccountLockUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAccountLockUpdateSettings ResetVerbose(this AzureAccountLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AccountLockLockType
    /// <summary><p>Used within <see cref="AzureAccountTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    public partial class AccountLockLockType : Enumeration
    {
        public static AccountLockLockType cannotdelete = new AccountLockLockType { Value = "cannotdelete" };
        public static AccountLockLockType readonly_ = new AccountLockLockType { Value = "readonly" };
    }
    #endregion
}
