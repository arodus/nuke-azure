// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureRole.json.

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
    public static partial class AzureRoleTasks
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public static string AzureRolePath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p></summary>
        public static IReadOnlyCollection<Output> AzureRole(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureRolePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRole(Configure<AzureRoleSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleAssignmentCreate(Configure<AzureRoleAssignmentCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleAssignmentCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleAssignmentDelete(Configure<AzureRoleAssignmentDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleAssignmentDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleAssignmentList(Configure<AzureRoleAssignmentListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleAssignmentListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleAssignmentListChangelogs(Configure<AzureRoleAssignmentListChangelogsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleAssignmentListChangelogsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleDefinitionCreate(Configure<AzureRoleDefinitionCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleDefinitionCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleDefinitionDelete(Configure<AzureRoleDefinitionDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleDefinitionDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleDefinitionList(Configure<AzureRoleDefinitionListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleDefinitionListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage user roles for access control with Azure Active Directory and service principals.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/role?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureRoleDefinitionUpdate(Configure<AzureRoleDefinitionUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureRoleDefinitionUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureRoleSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
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
              .Add("role")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleAssignmentCreateSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleAssignmentCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>Role name or id.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        public virtual string Assignee { get; internal set; }
        /// <summary><p>Assignee's graph object id, such as the 'principal id' from a managed service identity. Use this instead of '--assignee' to bypass graph permission issues.</p></summary>
        public virtual string AssigneeObjectId { get; internal set; }
        /// <summary><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("role assignment create")
              .Add("--role {value}", Role)
              .Add("--assignee {value}", Assignee)
              .Add("--assignee-object-id {value}", AssigneeObjectId)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleAssignmentDeleteSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleAssignmentDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        public virtual string Assignee { get; internal set; }
        /// <summary><p>Space-separated role assignment ids.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Include assignments applied on parent scopes.</p></summary>
        public virtual string IncludeInherited { get; internal set; }
        /// <summary><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Role name or id.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("role assignment delete")
              .Add("--assignee {value}", Assignee)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--include-inherited {value}", IncludeInherited)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleAssignmentListSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleAssignmentListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>Show all assignments under the current subscription.</p></summary>
        public virtual string All { get; internal set; }
        /// <summary><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        public virtual string Assignee { get; internal set; }
        /// <summary><p>List default role assignments for subscription classic administrators, aka co-admins.</p></summary>
        public virtual bool? IncludeClassicAdministrators { get; internal set; }
        /// <summary><p>Include extra assignments to the groups of which the user is a member(transitively).</p></summary>
        public virtual string IncludeGroups { get; internal set; }
        /// <summary><p>Include assignments applied on parent scopes.</p></summary>
        public virtual string IncludeInherited { get; internal set; }
        /// <summary><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Role name or id.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("role assignment list")
              .Add("--all {value}", All)
              .Add("--assignee {value}", Assignee)
              .Add("--include-classic-administrators", IncludeClassicAdministrators)
              .Add("--include-groups {value}", IncludeGroups)
              .Add("--include-inherited {value}", IncludeInherited)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--role {value}", Role)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleAssignmentListChangelogsSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleAssignmentListChangelogsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>The end time of the query in the format of %Y-%m-%dT%H:%M:%SZ, e.g. 2000-12-31T12:59:59Z. Defaults to the current time.</p></summary>
        public virtual string EndTime { get; internal set; }
        /// <summary><p>The start time of the query in the format of %Y-%m-%dT%H:%M:%SZ, e.g. 2000-12-31T12:59:59Z. Defaults to 1 Hour prior to the current time.</p></summary>
        public virtual string StartTime { get; internal set; }
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
              .Add("role assignment list-changelogs")
              .Add("--end-time {value}", EndTime)
              .Add("--start-time {value}", StartTime)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleDefinitionCreateSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleDefinitionCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>Description of a role as JSON, or a path to a file containing a JSON description.</p></summary>
        public virtual string RoleDefinition { get; internal set; }
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
              .Add("role definition create")
              .Add("--role-definition {value}", RoleDefinition)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleDefinitionDeleteSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleDefinitionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>The role's name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Custom roles only(vs. build-in ones).</p></summary>
        public virtual bool? CustomRoleOnly { get; internal set; }
        /// <summary><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("role definition delete")
              .Add("--name {value}", Name)
              .Add("--custom-role-only", CustomRoleOnly)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleDefinitionListSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleDefinitionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>Custom roles only(vs. build-in ones).</p></summary>
        public virtual bool? CustomRoleOnly { get; internal set; }
        /// <summary><p>The role's name.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("role definition list")
              .Add("--custom-role-only", CustomRoleOnly)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--scope {value}", Scope)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleDefinitionUpdateSettings
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureRoleDefinitionUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureRole executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureRoleTasks.AzureRolePath;
        /// <summary><p>Description of a role as JSON, or a path to a file containing a JSON description.</p></summary>
        public virtual string RoleDefinition { get; internal set; }
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
              .Add("role definition update")
              .Add("--role-definition {value}", RoleDefinition)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureRoleSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleSettings SetDebug(this AzureRoleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleSettings ResetDebug(this AzureRoleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleSettings SetHelp(this AzureRoleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleSettings ResetHelp(this AzureRoleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleSettings SetOutput(this AzureRoleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleSettings ResetOutput(this AzureRoleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleSettings SetQuery(this AzureRoleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleSettings ResetQuery(this AzureRoleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleSettings SetVerbose(this AzureRoleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleSettings ResetVerbose(this AzureRoleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleAssignmentCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleAssignmentCreateSettingsExtensions
    {
        #region Role
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Role"/>.</em></p><p>Role name or id.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetRole(this AzureRoleAssignmentCreateSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Role"/>.</em></p><p>Role name or id.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetRole(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Assignee
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Assignee"/>.</em></p><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetAssignee(this AzureRoleAssignmentCreateSettings toolSettings, string assignee)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignee = assignee;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Assignee"/>.</em></p><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetAssignee(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignee = null;
            return toolSettings;
        }
        #endregion
        #region AssigneeObjectId
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.AssigneeObjectId"/>.</em></p><p>Assignee's graph object id, such as the 'principal id' from a managed service identity. Use this instead of '--assignee' to bypass graph permission issues.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetAssigneeObjectId(this AzureRoleAssignmentCreateSettings toolSettings, string assigneeObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssigneeObjectId = assigneeObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.AssigneeObjectId"/>.</em></p><p>Assignee's graph object id, such as the 'principal id' from a managed service identity. Use this instead of '--assignee' to bypass graph permission issues.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetAssigneeObjectId(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AssigneeObjectId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetResourceGroup(this AzureRoleAssignmentCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetResourceGroup(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetScope(this AzureRoleAssignmentCreateSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetScope(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetDebug(this AzureRoleAssignmentCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetDebug(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetHelp(this AzureRoleAssignmentCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetHelp(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetOutput(this AzureRoleAssignmentCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetOutput(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetQuery(this AzureRoleAssignmentCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetQuery(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings SetVerbose(this AzureRoleAssignmentCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentCreateSettings ResetVerbose(this AzureRoleAssignmentCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleAssignmentDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleAssignmentDeleteSettingsExtensions
    {
        #region Assignee
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Assignee"/>.</em></p><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetAssignee(this AzureRoleAssignmentDeleteSettings toolSettings, string assignee)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignee = assignee;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Assignee"/>.</em></p><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetAssignee(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignee = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Ids"/> to a new list.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetIds(this AzureRoleAssignmentDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Ids"/> to a new list.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetIds(this AzureRoleAssignmentDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureRoleAssignmentDeleteSettings.Ids"/>.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings AddIds(this AzureRoleAssignmentDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureRoleAssignmentDeleteSettings.Ids"/>.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings AddIds(this AzureRoleAssignmentDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureRoleAssignmentDeleteSettings.Ids"/>.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ClearIds(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureRoleAssignmentDeleteSettings.Ids"/>.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings RemoveIds(this AzureRoleAssignmentDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureRoleAssignmentDeleteSettings.Ids"/>.</em></p><p>Space-separated role assignment ids.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings RemoveIds(this AzureRoleAssignmentDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region IncludeInherited
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.IncludeInherited"/>.</em></p><p>Include assignments applied on parent scopes.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetIncludeInherited(this AzureRoleAssignmentDeleteSettings toolSettings, string includeInherited)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeInherited = includeInherited;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.IncludeInherited"/>.</em></p><p>Include assignments applied on parent scopes.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetIncludeInherited(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeInherited = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetResourceGroup(this AzureRoleAssignmentDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetResourceGroup(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Role"/>.</em></p><p>Role name or id.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetRole(this AzureRoleAssignmentDeleteSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Role"/>.</em></p><p>Role name or id.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetRole(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetScope(this AzureRoleAssignmentDeleteSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetScope(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetDebug(this AzureRoleAssignmentDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetDebug(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetHelp(this AzureRoleAssignmentDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetHelp(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetOutput(this AzureRoleAssignmentDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetOutput(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetQuery(this AzureRoleAssignmentDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetQuery(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings SetVerbose(this AzureRoleAssignmentDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentDeleteSettings ResetVerbose(this AzureRoleAssignmentDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleAssignmentListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleAssignmentListSettingsExtensions
    {
        #region All
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.All"/>.</em></p><p>Show all assignments under the current subscription.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetAll(this AzureRoleAssignmentListSettings toolSettings, string all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.All"/>.</em></p><p>Show all assignments under the current subscription.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetAll(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        #endregion
        #region Assignee
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Assignee"/>.</em></p><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetAssignee(this AzureRoleAssignmentListSettings toolSettings, string assignee)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignee = assignee;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Assignee"/>.</em></p><p>Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetAssignee(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Assignee = null;
            return toolSettings;
        }
        #endregion
        #region IncludeClassicAdministrators
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.IncludeClassicAdministrators"/>.</em></p><p>List default role assignments for subscription classic administrators, aka co-admins.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetIncludeClassicAdministrators(this AzureRoleAssignmentListSettings toolSettings, bool? includeClassicAdministrators)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeClassicAdministrators = includeClassicAdministrators;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.IncludeClassicAdministrators"/>.</em></p><p>List default role assignments for subscription classic administrators, aka co-admins.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetIncludeClassicAdministrators(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeClassicAdministrators = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureRoleAssignmentListSettings.IncludeClassicAdministrators"/>.</em></p><p>List default role assignments for subscription classic administrators, aka co-admins.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings EnableIncludeClassicAdministrators(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeClassicAdministrators = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureRoleAssignmentListSettings.IncludeClassicAdministrators"/>.</em></p><p>List default role assignments for subscription classic administrators, aka co-admins.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings DisableIncludeClassicAdministrators(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeClassicAdministrators = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureRoleAssignmentListSettings.IncludeClassicAdministrators"/>.</em></p><p>List default role assignments for subscription classic administrators, aka co-admins.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ToggleIncludeClassicAdministrators(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeClassicAdministrators = !toolSettings.IncludeClassicAdministrators;
            return toolSettings;
        }
        #endregion
        #region IncludeGroups
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.IncludeGroups"/>.</em></p><p>Include extra assignments to the groups of which the user is a member(transitively).</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetIncludeGroups(this AzureRoleAssignmentListSettings toolSettings, string includeGroups)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeGroups = includeGroups;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.IncludeGroups"/>.</em></p><p>Include extra assignments to the groups of which the user is a member(transitively).</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetIncludeGroups(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeGroups = null;
            return toolSettings;
        }
        #endregion
        #region IncludeInherited
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.IncludeInherited"/>.</em></p><p>Include assignments applied on parent scopes.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetIncludeInherited(this AzureRoleAssignmentListSettings toolSettings, string includeInherited)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeInherited = includeInherited;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.IncludeInherited"/>.</em></p><p>Include assignments applied on parent scopes.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetIncludeInherited(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeInherited = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetResourceGroup(this AzureRoleAssignmentListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetResourceGroup(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Role"/>.</em></p><p>Role name or id.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetRole(this AzureRoleAssignmentListSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Role"/>.</em></p><p>Role name or id.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetRole(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetScope(this AzureRoleAssignmentListSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetScope(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetDebug(this AzureRoleAssignmentListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetDebug(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetHelp(this AzureRoleAssignmentListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetHelp(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetOutput(this AzureRoleAssignmentListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetOutput(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetQuery(this AzureRoleAssignmentListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetQuery(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings SetVerbose(this AzureRoleAssignmentListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListSettings ResetVerbose(this AzureRoleAssignmentListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleAssignmentListChangelogsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleAssignmentListChangelogsSettingsExtensions
    {
        #region EndTime
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.EndTime"/>.</em></p><p>The end time of the query in the format of %Y-%m-%dT%H:%M:%SZ, e.g. 2000-12-31T12:59:59Z. Defaults to the current time.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetEndTime(this AzureRoleAssignmentListChangelogsSettings toolSettings, string endTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = endTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.EndTime"/>.</em></p><p>The end time of the query in the format of %Y-%m-%dT%H:%M:%SZ, e.g. 2000-12-31T12:59:59Z. Defaults to the current time.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetEndTime(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndTime = null;
            return toolSettings;
        }
        #endregion
        #region StartTime
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.StartTime"/>.</em></p><p>The start time of the query in the format of %Y-%m-%dT%H:%M:%SZ, e.g. 2000-12-31T12:59:59Z. Defaults to 1 Hour prior to the current time.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetStartTime(this AzureRoleAssignmentListChangelogsSettings toolSettings, string startTime)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = startTime;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.StartTime"/>.</em></p><p>The start time of the query in the format of %Y-%m-%dT%H:%M:%SZ, e.g. 2000-12-31T12:59:59Z. Defaults to 1 Hour prior to the current time.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetStartTime(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartTime = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetDebug(this AzureRoleAssignmentListChangelogsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetDebug(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetHelp(this AzureRoleAssignmentListChangelogsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetHelp(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetOutput(this AzureRoleAssignmentListChangelogsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetOutput(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetQuery(this AzureRoleAssignmentListChangelogsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetQuery(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleAssignmentListChangelogsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings SetVerbose(this AzureRoleAssignmentListChangelogsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleAssignmentListChangelogsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleAssignmentListChangelogsSettings ResetVerbose(this AzureRoleAssignmentListChangelogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleDefinitionCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleDefinitionCreateSettingsExtensions
    {
        #region RoleDefinition
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionCreateSettings.RoleDefinition"/>.</em></p><p>Description of a role as JSON, or a path to a file containing a JSON description.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings SetRoleDefinition(this AzureRoleDefinitionCreateSettings toolSettings, string roleDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RoleDefinition = roleDefinition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionCreateSettings.RoleDefinition"/>.</em></p><p>Description of a role as JSON, or a path to a file containing a JSON description.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings ResetRoleDefinition(this AzureRoleDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RoleDefinition = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings SetDebug(this AzureRoleDefinitionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings ResetDebug(this AzureRoleDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings SetHelp(this AzureRoleDefinitionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings ResetHelp(this AzureRoleDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings SetOutput(this AzureRoleDefinitionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings ResetOutput(this AzureRoleDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings SetQuery(this AzureRoleDefinitionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings ResetQuery(this AzureRoleDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings SetVerbose(this AzureRoleDefinitionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionCreateSettings ResetVerbose(this AzureRoleDefinitionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleDefinitionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleDefinitionDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Name"/>.</em></p><p>The role's name.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetName(this AzureRoleDefinitionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Name"/>.</em></p><p>The role's name.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetName(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region CustomRoleOnly
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetCustomRoleOnly(this AzureRoleDefinitionDeleteSettings toolSettings, bool? customRoleOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = customRoleOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetCustomRoleOnly(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureRoleDefinitionDeleteSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings EnableCustomRoleOnly(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureRoleDefinitionDeleteSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings DisableCustomRoleOnly(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureRoleDefinitionDeleteSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ToggleCustomRoleOnly(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = !toolSettings.CustomRoleOnly;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetResourceGroup(this AzureRoleDefinitionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetResourceGroup(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetScope(this AzureRoleDefinitionDeleteSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetScope(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetDebug(this AzureRoleDefinitionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetDebug(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetHelp(this AzureRoleDefinitionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetHelp(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetOutput(this AzureRoleDefinitionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetOutput(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetQuery(this AzureRoleDefinitionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetQuery(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings SetVerbose(this AzureRoleDefinitionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionDeleteSettings ResetVerbose(this AzureRoleDefinitionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleDefinitionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleDefinitionListSettingsExtensions
    {
        #region CustomRoleOnly
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetCustomRoleOnly(this AzureRoleDefinitionListSettings toolSettings, bool? customRoleOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = customRoleOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetCustomRoleOnly(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureRoleDefinitionListSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings EnableCustomRoleOnly(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureRoleDefinitionListSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings DisableCustomRoleOnly(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureRoleDefinitionListSettings.CustomRoleOnly"/>.</em></p><p>Custom roles only(vs. build-in ones).</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ToggleCustomRoleOnly(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomRoleOnly = !toolSettings.CustomRoleOnly;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Name"/>.</em></p><p>The role's name.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetName(this AzureRoleDefinitionListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Name"/>.</em></p><p>The role's name.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetName(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetResourceGroup(this AzureRoleDefinitionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.ResourceGroup"/>.</em></p><p>Use it only if the role or assignment was added at the level of a resource group.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetResourceGroup(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetScope(this AzureRoleDefinitionListSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Scope"/>.</em></p><p>Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetScope(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetDebug(this AzureRoleDefinitionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetDebug(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetHelp(this AzureRoleDefinitionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetHelp(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetOutput(this AzureRoleDefinitionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetOutput(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetQuery(this AzureRoleDefinitionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetQuery(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings SetVerbose(this AzureRoleDefinitionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionListSettings ResetVerbose(this AzureRoleDefinitionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureRoleDefinitionUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureRoleTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureRoleDefinitionUpdateSettingsExtensions
    {
        #region RoleDefinition
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionUpdateSettings.RoleDefinition"/>.</em></p><p>Description of a role as JSON, or a path to a file containing a JSON description.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings SetRoleDefinition(this AzureRoleDefinitionUpdateSettings toolSettings, string roleDefinition)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RoleDefinition = roleDefinition;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionUpdateSettings.RoleDefinition"/>.</em></p><p>Description of a role as JSON, or a path to a file containing a JSON description.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings ResetRoleDefinition(this AzureRoleDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RoleDefinition = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings SetDebug(this AzureRoleDefinitionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings ResetDebug(this AzureRoleDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings SetHelp(this AzureRoleDefinitionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings ResetHelp(this AzureRoleDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings SetOutput(this AzureRoleDefinitionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings ResetOutput(this AzureRoleDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings SetQuery(this AzureRoleDefinitionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings ResetQuery(this AzureRoleDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureRoleDefinitionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings SetVerbose(this AzureRoleDefinitionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureRoleDefinitionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureRoleDefinitionUpdateSettings ResetVerbose(this AzureRoleDefinitionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
