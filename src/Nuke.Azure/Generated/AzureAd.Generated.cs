// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.2 [CommitSha: ff25463a].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAd.json.

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
    public static partial class AzureAdTasks
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public static string AzureAdPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p></summary>
        public static IReadOnlyCollection<Output> AzureAd(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAdPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAd(Configure<AzureAdSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppCreate(Configure<AzureAdAppCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppDelete(Configure<AzureAdAppDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppList(Configure<AzureAdAppListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppShow(Configure<AzureAdAppShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppUpdate(Configure<AzureAdAppUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupCreate(Configure<AzureAdGroupCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupDelete(Configure<AzureAdGroupDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupGetMemberGroups(Configure<AzureAdGroupGetMemberGroupsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupGetMemberGroupsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupList(Configure<AzureAdGroupListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupShow(Configure<AzureAdGroupShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCreate(Configure<AzureAdSpCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCreateForRbac(Configure<AzureAdSpCreateForRbacSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCreateForRbacSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpDelete(Configure<AzureAdSpDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpList(Configure<AzureAdSpListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpShow(Configure<AzureAdSpShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserCreate(Configure<AzureAdUserCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserDelete(Configure<AzureAdUserDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserList(Configure<AzureAdUserListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserShow(Configure<AzureAdUserShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberAdd(Configure<AzureAdGroupMemberAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberCheck(Configure<AzureAdGroupMemberCheckSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberCheckSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberList(Configure<AzureAdGroupMemberListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberRemove(Configure<AzureAdGroupMemberRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialDelete(Configure<AzureAdSpCredentialDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCredentialDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialList(Configure<AzureAdSpCredentialListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCredentialListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialReset(Configure<AzureAdSpCredentialResetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCredentialResetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureAdSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
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
              .Add("ad")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdAppCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The display name of the application.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>The application can be used from any Azure AD tenants.</p></summary>
        public virtual bool? AvailableToOtherTenants { get; internal set; }
        /// <summary><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>The url where users can sign in and use your app.</p></summary>
        public virtual string Homepage { get; internal set; }
        /// <summary><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        public virtual string IdentifierUris { get; internal set; }
        /// <summary><p>The type of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyType KeyType { get; internal set; }
        /// <summary><p>The usage of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyUsage KeyUsage { get; internal set; }
        /// <summary><p>The value for the key credentials associated with the application.</p></summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary><p>An application which can be installed on a user's device or computer.</p></summary>
        public virtual bool? NativeApp { get; internal set; }
        /// <summary><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        public virtual bool? Oauth2AllowImplicitFlow { get; internal set; }
        /// <summary><p>App password, aka 'client secret'.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        public virtual string ReplyUrls { get; internal set; }
        /// <summary><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        public virtual string RequiredResourceAccesses { get; internal set; }
        /// <summary><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("ad app create")
              .Add("--display-name {value}", DisplayName)
              .Add("--available-to-other-tenants", AvailableToOtherTenants)
              .Add("--end-date {value}", EndDate)
              .Add("--homepage {value}", Homepage)
              .Add("--identifier-uris {value}", IdentifierUris)
              .Add("--key-type {value}", KeyType)
              .Add("--key-usage {value}", KeyUsage)
              .Add("--key-value {value}", KeyValue)
              .Add("--native-app", NativeApp)
              .Add("--oauth2-allow-implicit-flow", Oauth2AllowImplicitFlow)
              .Add("--password {value}", Password, secret: true)
              .Add("--reply-urls {value}", ReplyUrls)
              .Add("--required-resource-accesses {value}", RequiredResourceAccesses)
              .Add("--start-date {value}", StartDate)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdAppDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app delete")
              .Add("--id {value}", Id)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdAppListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Application id.</p></summary>
        public virtual string AppId { get; internal set; }
        /// <summary><p>The display name of the application.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Graph application identifier, must be in uri format.</p></summary>
        public virtual string IdentifierUri { get; internal set; }
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
              .Add("ad app list")
              .Add("--app-id {value}", AppId)
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--identifier-uri {value}", IdentifierUri)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdAppShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app show")
              .Add("--id {value}", Id)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdAppUpdateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>The application can be used from any Azure AD tenants.</p></summary>
        public virtual bool? AvailableToOtherTenants { get; internal set; }
        /// <summary><p>The display name of the application.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>The url where users can sign in and use your app.</p></summary>
        public virtual string Homepage { get; internal set; }
        /// <summary><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        public virtual string IdentifierUris { get; internal set; }
        /// <summary><p>The type of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyType KeyType { get; internal set; }
        /// <summary><p>The usage of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyUsage KeyUsage { get; internal set; }
        /// <summary><p>The value for the key credentials associated with the application.</p></summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        public virtual bool? Oauth2AllowImplicitFlow { get; internal set; }
        /// <summary><p>App password, aka 'client secret'.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        public virtual string ReplyUrls { get; internal set; }
        /// <summary><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        public virtual string RequiredResourceAccesses { get; internal set; }
        /// <summary><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("ad app update")
              .Add("--id {value}", Id)
              .Add("--available-to-other-tenants", AvailableToOtherTenants)
              .Add("--display-name {value}", DisplayName)
              .Add("--end-date {value}", EndDate)
              .Add("--homepage {value}", Homepage)
              .Add("--identifier-uris {value}", IdentifierUris)
              .Add("--key-type {value}", KeyType)
              .Add("--key-usage {value}", KeyUsage)
              .Add("--key-value {value}", KeyValue)
              .Add("--oauth2-allow-implicit-flow", Oauth2AllowImplicitFlow)
              .Add("--password {value}", Password, secret: true)
              .Add("--reply-urls {value}", ReplyUrls)
              .Add("--required-resource-accesses {value}", RequiredResourceAccesses)
              .Add("--start-date {value}", StartDate)
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
    #region AzureAdGroupCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string MailNickname { get; internal set; }
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
              .Add("ad group create")
              .Add("--display-name {value}", DisplayName)
              .Add("--mail-nickname {value}", MailNickname)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group delete")
              .Add("--group {value}", Group)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupGetMemberGroupsSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupGetMemberGroupsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        public virtual string AdditionalProperties { get; internal set; }
        /// <summary><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        public virtual bool? SecurityEnabledOnly { get; internal set; }
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
              .Add("ad group get-member-groups")
              .Add("--group {value}", Group)
              .Add("--additional-properties {value}", AdditionalProperties)
              .Add("--security-enabled-only", SecurityEnabledOnly)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
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
              .Add("ad group list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group show")
              .Add("--group {value}", Group)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp create")
              .Add("--id {value}", Id)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpCreateForRbacSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCreateForRbacSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Name or app URI to associate the RBAC with. If not present, a name will be generated.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Role of the service principal.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        public virtual IReadOnlyList<string> Scopes => ScopesInternal.AsReadOnly();
        internal List<string> ScopesInternal { get; set; } = new List<string>();
        /// <summary><p>Output result in compatible with Azure SDK auth file.</p></summary>
        public virtual bool? SdkAuth { get; internal set; }
        /// <summary><p>Do not create default assignment.</p></summary>
        public virtual bool? SkipAssignment { get; internal set; }
        /// <summary><p>Certificate to use for credentials.</p></summary>
        public virtual string Cert { get; internal set; }
        /// <summary><p>Create a self-signed certificate to use for the credential.</p></summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>The password used to log in.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad sp create-for-rbac")
              .Add("--name {value}", Name)
              .Add("--role {value}", Role)
              .Add("--scopes {value}", Scopes, separator: ' ')
              .Add("--sdk-auth", SdkAuth)
              .Add("--skip-assignment", SkipAssignment)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp delete")
              .Add("--id {value}", Id)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Service principal name.</p></summary>
        public virtual string Spn { get; internal set; }
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
              .Add("ad sp list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--spn {value}", Spn)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp show")
              .Add("--id {value}", Id)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdUserCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p></summary>
        public virtual string UserPrincipalName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual bool? ForceChangePasswordNextLogin { get; internal set; }
        /// <summary><p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p></summary>
        public virtual string ImmutableId { get; internal set; }
        /// <summary><p>Mail alias. Defaults to user principal name.</p></summary>
        public virtual string MailNickname { get; internal set; }
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
              .Add("ad user create")
              .Add("--display-name {value}", DisplayName)
              .Add("--password {value}", Password, secret: true)
              .Add("--user-principal-name {value}", UserPrincipalName)
              .Add("--force-change-password-next-login", ForceChangePasswordNextLogin, secret: true)
              .Add("--immutable-id {value}", ImmutableId)
              .Add("--mail-nickname {value}", MailNickname)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdUserDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The object ID or principal name of the user to delete.</p></summary>
        public virtual string UpnOrObjectId { get; internal set; }
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
              .Add("ad user delete")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdUserListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>User principal name, e.g. john.doe@contoso.com.</p></summary>
        public virtual string Upn { get; internal set; }
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
              .Add("ad user list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--upn {value}", Upn)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdUserShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The object ID or principal name of the user for which to get information.</p></summary>
        public virtual string UpnOrObjectId { get; internal set; }
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
              .Add("ad user show")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupMemberAddSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The object ID of the contact, group, user, or service principal.</p></summary>
        public virtual string MemberId { get; internal set; }
        /// <summary><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        public virtual string AdditionalProperties { get; internal set; }
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
              .Add("ad group member add")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
              .Add("--additional-properties {value}", AdditionalProperties)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupMemberCheckSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberCheckSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The object ID of the contact, group, user, or service principal.</p></summary>
        public virtual string MemberId { get; internal set; }
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
              .Add("ad group member check")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupMemberListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group member list")
              .Add("--group {value}", Group)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdGroupMemberRemoveSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The object ID of the contact, group, user, or service principal.</p></summary>
        public virtual string MemberId { get; internal set; }
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
              .Add("ad group member remove")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpCredentialDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Credential key id.</p></summary>
        public virtual string KeyId { get; internal set; }
        /// <summary><p>A certificate based credential.</p></summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad sp credential delete")
              .Add("--id {value}", Id)
              .Add("--key-id {value}", KeyId)
              .Add("--cert {value}", Cert)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpCredentialListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>A certificate based credential.</p></summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad sp credential list")
              .Add("--id {value}", Id)
              .Add("--cert {value}", Cert)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSpCredentialResetSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialResetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Name or app URI for the credential.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Append the new credential instead of overwriting.</p></summary>
        public virtual string Append { get; internal set; }
        /// <summary><p>Certificate to use for credentials.</p></summary>
        public virtual string Cert { get; internal set; }
        /// <summary><p>Create a self-signed certificate to use for the credential.</p></summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>The password used to log in.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad sp credential reset")
              .Add("--name {value}", Name)
              .Add("--append {value}", Append)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings SetDebug(this AzureAdSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings ResetDebug(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSettings SetHelp(this AzureAdSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSettings ResetHelp(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSettings SetOutput(this AzureAdSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSettings ResetOutput(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSettings SetQuery(this AzureAdSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSettings ResetQuery(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings SetVerbose(this AzureAdSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings ResetVerbose(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetDisplayName(this AzureAdAppCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetDisplayName(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region AvailableToOtherTenants
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings, bool? availableToOtherTenants)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = availableToOtherTenants;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = !toolSettings.AvailableToOtherTenants;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetEndDate(this AzureAdAppCreateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetEndDate(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Homepage
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetHomepage(this AzureAdAppCreateSettings toolSettings, string homepage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = homepage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetHomepage(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUris
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetIdentifierUris(this AzureAdAppCreateSettings toolSettings, string identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUris = identifierUris;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetIdentifierUris(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUris = null;
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyType(this AzureAdAppCreateSettings toolSettings, AdAppKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyType(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region KeyUsage
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyUsage(this AzureAdAppCreateSettings toolSettings, AdAppKeyUsage keyUsage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = keyUsage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyUsage(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyValue(this AzureAdAppCreateSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyValue(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region NativeApp
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetNativeApp(this AzureAdAppCreateSettings toolSettings, bool? nativeApp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = nativeApp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = !toolSettings.NativeApp;
            return toolSettings;
        }
        #endregion
        #region Oauth2AllowImplicitFlow
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings, bool? oauth2AllowImplicitFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = !toolSettings.Oauth2AllowImplicitFlow;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetPassword(this AzureAdAppCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetPassword(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReplyUrls
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetReplyUrls(this AzureAdAppCreateSettings toolSettings, string replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrls = replyUrls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetReplyUrls(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrls = null;
            return toolSettings;
        }
        #endregion
        #region RequiredResourceAccesses
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetRequiredResourceAccesses(this AzureAdAppCreateSettings toolSettings, string requiredResourceAccesses)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = requiredResourceAccesses;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetRequiredResourceAccesses(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetStartDate(this AzureAdAppCreateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetStartDate(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetDebug(this AzureAdAppCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetDebug(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetHelp(this AzureAdAppCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetHelp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetOutput(this AzureAdAppCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetOutput(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetQuery(this AzureAdAppCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetQuery(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetVerbose(this AzureAdAppCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetVerbose(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetId(this AzureAdAppDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetId(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetDebug(this AzureAdAppDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetDebug(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetHelp(this AzureAdAppDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetHelp(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetOutput(this AzureAdAppDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetOutput(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetQuery(this AzureAdAppDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetQuery(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetVerbose(this AzureAdAppDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetVerbose(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppListSettingsExtensions
    {
        #region AppId
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.AppId"/>.</em></p><p>Application id.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetAppId(this AzureAdAppListSettings toolSettings, string appId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppId = appId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.AppId"/>.</em></p><p>Application id.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetAppId(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppId = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetDisplayName(this AzureAdAppListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetDisplayName(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetFilter(this AzureAdAppListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetFilter(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUri
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.IdentifierUri"/>.</em></p><p>Graph application identifier, must be in uri format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetIdentifierUri(this AzureAdAppListSettings toolSettings, string identifierUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUri = identifierUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.IdentifierUri"/>.</em></p><p>Graph application identifier, must be in uri format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetIdentifierUri(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUri = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetDebug(this AzureAdAppListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetDebug(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetHelp(this AzureAdAppListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetHelp(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetOutput(this AzureAdAppListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetOutput(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetQuery(this AzureAdAppListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetQuery(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetVerbose(this AzureAdAppListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetVerbose(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppShowSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetId(this AzureAdAppShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetId(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetDebug(this AzureAdAppShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetDebug(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetHelp(this AzureAdAppShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetHelp(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetOutput(this AzureAdAppShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetOutput(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetQuery(this AzureAdAppShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetQuery(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetVerbose(this AzureAdAppShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetVerbose(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppUpdateSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetId(this AzureAdAppUpdateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetId(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region AvailableToOtherTenants
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings, bool? availableToOtherTenants)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = availableToOtherTenants;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings EnableAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings DisableAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ToggleAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = !toolSettings.AvailableToOtherTenants;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetDisplayName(this AzureAdAppUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetDisplayName(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetEndDate(this AzureAdAppUpdateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetEndDate(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Homepage
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetHomepage(this AzureAdAppUpdateSettings toolSettings, string homepage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = homepage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetHomepage(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUris
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetIdentifierUris(this AzureAdAppUpdateSettings toolSettings, string identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUris = identifierUris;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetIdentifierUris(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUris = null;
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyType(this AzureAdAppUpdateSettings toolSettings, AdAppKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyType(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region KeyUsage
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyUsage(this AzureAdAppUpdateSettings toolSettings, AdAppKeyUsage keyUsage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = keyUsage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyUsage(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyValue(this AzureAdAppUpdateSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyValue(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Oauth2AllowImplicitFlow
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings, bool? oauth2AllowImplicitFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings EnableOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings DisableOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ToggleOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = !toolSettings.Oauth2AllowImplicitFlow;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetPassword(this AzureAdAppUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetPassword(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReplyUrls
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetReplyUrls(this AzureAdAppUpdateSettings toolSettings, string replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrls = replyUrls;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetReplyUrls(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrls = null;
            return toolSettings;
        }
        #endregion
        #region RequiredResourceAccesses
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetRequiredResourceAccesses(this AzureAdAppUpdateSettings toolSettings, string requiredResourceAccesses)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = requiredResourceAccesses;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetRequiredResourceAccesses(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetStartDate(this AzureAdAppUpdateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetStartDate(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAdd(this AzureAdAppUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAdd(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetForceString(this AzureAdAppUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetForceString(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetRemove(this AzureAdAppUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetRemove(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetSet(this AzureAdAppUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetSet(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetDebug(this AzureAdAppUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetDebug(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetHelp(this AzureAdAppUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetHelp(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetOutput(this AzureAdAppUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetOutput(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetQuery(this AzureAdAppUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetQuery(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetVerbose(this AzureAdAppUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetVerbose(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetDisplayName(this AzureAdGroupCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetDisplayName(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region MailNickname
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.MailNickname"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetMailNickname(this AzureAdGroupCreateSettings toolSettings, string mailNickname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = mailNickname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.MailNickname"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetMailNickname(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetDebug(this AzureAdGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetDebug(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetHelp(this AzureAdGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetHelp(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetOutput(this AzureAdGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetOutput(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetQuery(this AzureAdGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetQuery(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetVerbose(this AzureAdGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetVerbose(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupDeleteSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetGroup(this AzureAdGroupDeleteSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetGroup(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetDebug(this AzureAdGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetDebug(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetHelp(this AzureAdGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetHelp(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetOutput(this AzureAdGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetOutput(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetQuery(this AzureAdGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetQuery(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetVerbose(this AzureAdGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetVerbose(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupGetMemberGroupsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupGetMemberGroupsSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetGroup(this AzureAdGroupGetMemberGroupsSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetGroup(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region AdditionalProperties
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetAdditionalProperties(this AzureAdGroupGetMemberGroupsSettings toolSettings, string additionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = additionalProperties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetAdditionalProperties(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region SecurityEnabledOnly
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings, bool? securityEnabledOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = securityEnabledOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings EnableSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings DisableSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ToggleSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = !toolSettings.SecurityEnabledOnly;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetDebug(this AzureAdGroupGetMemberGroupsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetDebug(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetHelp(this AzureAdGroupGetMemberGroupsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetHelp(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetOutput(this AzureAdGroupGetMemberGroupsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetOutput(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetQuery(this AzureAdGroupGetMemberGroupsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetQuery(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetVerbose(this AzureAdGroupGetMemberGroupsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetVerbose(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupListSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetDisplayName(this AzureAdGroupListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetDisplayName(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetFilter(this AzureAdGroupListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetFilter(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetDebug(this AzureAdGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetDebug(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetHelp(this AzureAdGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetHelp(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetOutput(this AzureAdGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetOutput(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetQuery(this AzureAdGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetQuery(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetVerbose(this AzureAdGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetVerbose(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupShowSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetGroup(this AzureAdGroupShowSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetGroup(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetDebug(this AzureAdGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetDebug(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetHelp(this AzureAdGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetHelp(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetOutput(this AzureAdGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetOutput(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetQuery(this AzureAdGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetQuery(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetVerbose(this AzureAdGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetVerbose(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCreateSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetId(this AzureAdSpCreateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetId(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetDebug(this AzureAdSpCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetDebug(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetHelp(this AzureAdSpCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetHelp(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetOutput(this AzureAdSpCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetOutput(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetQuery(this AzureAdSpCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetQuery(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetVerbose(this AzureAdSpCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetVerbose(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCreateForRbacSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCreateForRbacSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Name"/>.</em></p><p>Name or app URI to associate the RBAC with. If not present, a name will be generated.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetName(this AzureAdSpCreateForRbacSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Name"/>.</em></p><p>Name or app URI to associate the RBAC with. If not present, a name will be generated.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetName(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Role"/>.</em></p><p>Role of the service principal.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetRole(this AzureAdSpCreateForRbacSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Role"/>.</em></p><p>Role of the service principal.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetRole(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scopes
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings AddScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings AddScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ClearScopes(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings RemoveScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings RemoveScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region SdkAuth
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings, bool? sdkAuth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = sdkAuth;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings EnableSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings DisableSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ToggleSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = !toolSettings.SdkAuth;
            return toolSettings;
        }
        #endregion
        #region SkipAssignment
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings, bool? skipAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = skipAssignment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings EnableSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings DisableSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ToggleSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = !toolSettings.SkipAssignment;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetCert(this AzureAdSpCreateForRbacSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetCert(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetCreateCert(this AzureAdSpCreateForRbacSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetCreateCert(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetKeyvault(this AzureAdSpCreateForRbacSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetKeyvault(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetPassword(this AzureAdSpCreateForRbacSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetPassword(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetYears(this AzureAdSpCreateForRbacSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetYears(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetDebug(this AzureAdSpCreateForRbacSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetDebug(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetHelp(this AzureAdSpCreateForRbacSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetHelp(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetOutput(this AzureAdSpCreateForRbacSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetOutput(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetQuery(this AzureAdSpCreateForRbacSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetQuery(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetVerbose(this AzureAdSpCreateForRbacSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetVerbose(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetId(this AzureAdSpDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetId(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetDebug(this AzureAdSpDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetDebug(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetHelp(this AzureAdSpDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetHelp(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetOutput(this AzureAdSpDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetOutput(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetQuery(this AzureAdSpDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetQuery(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetVerbose(this AzureAdSpDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetVerbose(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpListSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetDisplayName(this AzureAdSpListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetDisplayName(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetFilter(this AzureAdSpListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetFilter(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Spn
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Spn"/>.</em></p><p>Service principal name.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetSpn(this AzureAdSpListSettings toolSettings, string spn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = spn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Spn"/>.</em></p><p>Service principal name.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetSpn(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetDebug(this AzureAdSpListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetDebug(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetHelp(this AzureAdSpListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetHelp(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetOutput(this AzureAdSpListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetOutput(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetQuery(this AzureAdSpListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetQuery(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetVerbose(this AzureAdSpListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetVerbose(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpShowSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetId(this AzureAdSpShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetId(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetDebug(this AzureAdSpShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetDebug(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetHelp(this AzureAdSpShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetHelp(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetOutput(this AzureAdSpShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetOutput(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetQuery(this AzureAdSpShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetQuery(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetVerbose(this AzureAdSpShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetVerbose(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetDisplayName(this AzureAdUserCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetDisplayName(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Password"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetPassword(this AzureAdUserCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Password"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetPassword(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region UserPrincipalName
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.UserPrincipalName"/>.</em></p><p>The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetUserPrincipalName(this AzureAdUserCreateSettings toolSettings, string userPrincipalName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserPrincipalName = userPrincipalName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.UserPrincipalName"/>.</em></p><p>The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetUserPrincipalName(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserPrincipalName = null;
            return toolSettings;
        }
        #endregion
        #region ForceChangePasswordNextLogin
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings, bool? forceChangePasswordNextLogin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = forceChangePasswordNextLogin;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings EnableForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings DisableForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ToggleForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = !toolSettings.ForceChangePasswordNextLogin;
            return toolSettings;
        }
        #endregion
        #region ImmutableId
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.ImmutableId"/>.</em></p><p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetImmutableId(this AzureAdUserCreateSettings toolSettings, string immutableId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableId = immutableId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.ImmutableId"/>.</em></p><p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetImmutableId(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableId = null;
            return toolSettings;
        }
        #endregion
        #region MailNickname
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.MailNickname"/>.</em></p><p>Mail alias. Defaults to user principal name.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetMailNickname(this AzureAdUserCreateSettings toolSettings, string mailNickname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = mailNickname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.MailNickname"/>.</em></p><p>Mail alias. Defaults to user principal name.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetMailNickname(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetDebug(this AzureAdUserCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetDebug(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetHelp(this AzureAdUserCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetHelp(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetOutput(this AzureAdUserCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetOutput(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetQuery(this AzureAdUserCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetQuery(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetVerbose(this AzureAdUserCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetVerbose(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserDeleteSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user to delete.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetUpnOrObjectId(this AzureAdUserDeleteSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user to delete.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetUpnOrObjectId(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetDebug(this AzureAdUserDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetDebug(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetHelp(this AzureAdUserDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetHelp(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetOutput(this AzureAdUserDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetOutput(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetQuery(this AzureAdUserDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetQuery(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetVerbose(this AzureAdUserDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetVerbose(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserListSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetDisplayName(this AzureAdUserListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetDisplayName(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetFilter(this AzureAdUserListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetFilter(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Upn
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Upn"/>.</em></p><p>User principal name, e.g. john.doe@contoso.com.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetUpn(this AzureAdUserListSettings toolSettings, string upn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = upn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Upn"/>.</em></p><p>User principal name, e.g. john.doe@contoso.com.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetUpn(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetDebug(this AzureAdUserListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetDebug(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetHelp(this AzureAdUserListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetHelp(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetOutput(this AzureAdUserListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetOutput(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetQuery(this AzureAdUserListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetQuery(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetVerbose(this AzureAdUserListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetVerbose(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserShowSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user for which to get information.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetUpnOrObjectId(this AzureAdUserShowSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user for which to get information.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetUpnOrObjectId(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetDebug(this AzureAdUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetDebug(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetHelp(this AzureAdUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetHelp(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetOutput(this AzureAdUserShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetOutput(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetQuery(this AzureAdUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetQuery(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetVerbose(this AzureAdUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetVerbose(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberAddSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetGroup(this AzureAdGroupMemberAddSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetGroup(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetMemberId(this AzureAdGroupMemberAddSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetMemberId(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region AdditionalProperties
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetAdditionalProperties(this AzureAdGroupMemberAddSettings toolSettings, string additionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = additionalProperties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetAdditionalProperties(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetDebug(this AzureAdGroupMemberAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetDebug(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetHelp(this AzureAdGroupMemberAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetHelp(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetOutput(this AzureAdGroupMemberAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetOutput(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetQuery(this AzureAdGroupMemberAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetQuery(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetVerbose(this AzureAdGroupMemberAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetVerbose(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberCheckSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberCheckSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetGroup(this AzureAdGroupMemberCheckSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetGroup(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetMemberId(this AzureAdGroupMemberCheckSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetMemberId(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetDebug(this AzureAdGroupMemberCheckSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetDebug(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetHelp(this AzureAdGroupMemberCheckSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetHelp(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetOutput(this AzureAdGroupMemberCheckSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetOutput(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetQuery(this AzureAdGroupMemberCheckSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetQuery(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetVerbose(this AzureAdGroupMemberCheckSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetVerbose(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberListSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetGroup(this AzureAdGroupMemberListSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetGroup(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetDebug(this AzureAdGroupMemberListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetDebug(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetHelp(this AzureAdGroupMemberListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetHelp(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetOutput(this AzureAdGroupMemberListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetOutput(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetQuery(this AzureAdGroupMemberListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetQuery(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetVerbose(this AzureAdGroupMemberListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetVerbose(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberRemoveSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetGroup(this AzureAdGroupMemberRemoveSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetGroup(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetMemberId(this AzureAdGroupMemberRemoveSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetMemberId(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetDebug(this AzureAdGroupMemberRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetDebug(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetHelp(this AzureAdGroupMemberRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetHelp(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetOutput(this AzureAdGroupMemberRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetOutput(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetQuery(this AzureAdGroupMemberRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetQuery(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetVerbose(this AzureAdGroupMemberRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetVerbose(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetId(this AzureAdSpCredentialDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetId(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region KeyId
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/>.</em></p><p>Credential key id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetKeyId(this AzureAdSpCredentialDeleteSettings toolSettings, string keyId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = keyId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/>.</em></p><p>Credential key id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetKeyId(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetCert(this AzureAdSpCredentialDeleteSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetCert(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetDebug(this AzureAdSpCredentialDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetDebug(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetHelp(this AzureAdSpCredentialDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetHelp(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetOutput(this AzureAdSpCredentialDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetOutput(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetQuery(this AzureAdSpCredentialDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetQuery(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetVerbose(this AzureAdSpCredentialDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetVerbose(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialListSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetId(this AzureAdSpCredentialListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetId(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetCert(this AzureAdSpCredentialListSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetCert(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetDebug(this AzureAdSpCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetDebug(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetHelp(this AzureAdSpCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetHelp(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetOutput(this AzureAdSpCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetOutput(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetQuery(this AzureAdSpCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetQuery(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetVerbose(this AzureAdSpCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetVerbose(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialResetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialResetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Name"/>.</em></p><p>Name or app URI for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetName(this AzureAdSpCredentialResetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Name"/>.</em></p><p>Name or app URI for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetName(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Append
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Append"/>.</em></p><p>Append the new credential instead of overwriting.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetAppend(this AzureAdSpCredentialResetSettings toolSettings, string append)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = append;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Append"/>.</em></p><p>Append the new credential instead of overwriting.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetAppend(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCert(this AzureAdSpCredentialResetSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCert(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCreateCert(this AzureAdSpCredentialResetSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCreateCert(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetKeyvault(this AzureAdSpCredentialResetSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetKeyvault(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetPassword(this AzureAdSpCredentialResetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetPassword(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetYears(this AzureAdSpCredentialResetSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetYears(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetDebug(this AzureAdSpCredentialResetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetDebug(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetHelp(this AzureAdSpCredentialResetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetHelp(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetOutput(this AzureAdSpCredentialResetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetOutput(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetQuery(this AzureAdSpCredentialResetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetQuery(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetVerbose(this AzureAdSpCredentialResetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetVerbose(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AdAppKeyType
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AdAppKeyType : Enumeration
    {
        public static AdAppKeyType asymmetricx509cert = new AdAppKeyType { Value = "asymmetricx509cert" };
        public static AdAppKeyType password = new AdAppKeyType { Value = "password" };
        public static AdAppKeyType symmetric = new AdAppKeyType { Value = "symmetric" };
    }
    #endregion
    #region AdAppKeyUsage
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AdAppKeyUsage : Enumeration
    {
        public static AdAppKeyUsage sign = new AdAppKeyUsage { Value = "sign" };
        public static AdAppKeyUsage verify = new AdAppKeyUsage { Value = "verify" };
    }
    #endregion
}
