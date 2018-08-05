// Copyright Matthias Koch, Sebastian Karasek 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.6.0 [CommitSha: 5a428f0d].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureLock.json.

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
    public static partial class AzureLockTasks
    {
        /// <summary><p>Path to the AzureLock executable.</p></summary>
        public static string AzureLockPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure locks.</p></summary>
        public static IReadOnlyCollection<Output> AzureLock(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureLockPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure locks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLockCreate(Configure<AzureLockCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLockCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure locks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLockDelete(Configure<AzureLockDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLockDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure locks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLockList(Configure<AzureLockListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLockListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure locks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLockShow(Configure<AzureLockShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLockShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure locks.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/lock?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureLockUpdate(Configure<AzureLockUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureLockUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureLockCreateSettings
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLock executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        /// <summary><p></p></summary>
        public virtual LockLockType LockType { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Notes about this lock.</p></summary>
        public virtual string Notes { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock create")
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--notes {value}", Notes)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLockDeleteSettings
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLock executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock delete")
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLockListSettings
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLock executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        /// <summary><p>A query filter to use to restrict the results.</p></summary>
        public virtual string FilterString { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock list")
              .Add("--filter-string {value}", FilterString)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLockShowSettings
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLock executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock show")
              .Add("--ids {value}", Ids)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLockUpdateSettings
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureLockUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureLock executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureLockTasks.AzureLockPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        public virtual string Ids { get; internal set; }
        /// <summary><p></p></summary>
        public virtual LockLockType LockType { get; internal set; }
        /// <summary><p>Name of the lock.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        public virtual string Namespace { get; internal set; }
        /// <summary><p>Notes about this lock.</p></summary>
        public virtual string Notes { get; internal set; }
        /// <summary><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        public virtual string Parent { get; internal set; }
        /// <summary><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        public virtual string Resource { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        public virtual string ResourceType { get; internal set; }
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
              .Add("lock update")
              .Add("--ids {value}", Ids)
              .Add("--lock-type {value}", LockType)
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
              .Add("--notes {value}", Notes)
              .Add("--parent {value}", Parent)
              .Add("--resource {value}", Resource)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-type {value}", ResourceType)
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureLockCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockCreateSettingsExtensions
    {
        #region LockType
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureLockCreateSettings SetLockType(this AzureLockCreateSettings toolSettings, LockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetLockType(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetName(this AzureLockCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetName(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetNamespace(this AzureLockCreateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetNamespace(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetNotes(this AzureLockCreateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetNotes(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetParent(this AzureLockCreateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetParent(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetResource(this AzureLockCreateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetResource(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetResourceGroup(this AzureLockCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetResourceGroup(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetResourceType(this AzureLockCreateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetResourceType(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetDebug(this AzureLockCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetDebug(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetHelp(this AzureLockCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetHelp(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetOutput(this AzureLockCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetOutput(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetQuery(this AzureLockCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetQuery(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLockCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockCreateSettings SetVerbose(this AzureLockCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockCreateSettings ResetVerbose(this AzureLockCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockDeleteSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetIds(this AzureLockDeleteSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetIds(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetName(this AzureLockDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetName(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetNamespace(this AzureLockDeleteSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetNamespace(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetParent(this AzureLockDeleteSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetParent(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetResource(this AzureLockDeleteSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetResource(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetResourceGroup(this AzureLockDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetResourceGroup(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetResourceType(this AzureLockDeleteSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetResourceType(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetDebug(this AzureLockDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetDebug(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetHelp(this AzureLockDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetHelp(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetOutput(this AzureLockDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetOutput(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetQuery(this AzureLockDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetQuery(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLockDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings SetVerbose(this AzureLockDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockDeleteSettings ResetVerbose(this AzureLockDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockListSettingsExtensions
    {
        #region FilterString
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.FilterString"/>.</em></p><p>A query filter to use to restrict the results.</p></summary>
        [Pure]
        public static AzureLockListSettings SetFilterString(this AzureLockListSettings toolSettings, string filterString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = filterString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.FilterString"/>.</em></p><p>A query filter to use to restrict the results.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetFilterString(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FilterString = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockListSettings SetNamespace(this AzureLockListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockListSettings ResetNamespace(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockListSettings SetParent(this AzureLockListSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockListSettings ResetParent(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockListSettings SetResource(this AzureLockListSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetResource(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockListSettings SetResourceGroup(this AzureLockListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetResourceGroup(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockListSettings SetResourceType(this AzureLockListSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockListSettings ResetResourceType(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockListSettings SetDebug(this AzureLockListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetDebug(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockListSettings SetHelp(this AzureLockListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetHelp(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockListSettings SetOutput(this AzureLockListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetOutput(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockListSettings SetQuery(this AzureLockListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetQuery(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLockListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockListSettings SetVerbose(this AzureLockListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockListSettings ResetVerbose(this AzureLockListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockShowSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetIds(this AzureLockShowSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetIds(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetName(this AzureLockShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetName(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockShowSettings SetNamespace(this AzureLockShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetNamespace(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockShowSettings SetParent(this AzureLockShowSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetParent(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetResource(this AzureLockShowSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetResource(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetResourceGroup(this AzureLockShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetResourceGroup(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockShowSettings SetResourceType(this AzureLockShowSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetResourceType(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetDebug(this AzureLockShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetDebug(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetHelp(this AzureLockShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetHelp(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetOutput(this AzureLockShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetOutput(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetQuery(this AzureLockShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetQuery(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLockShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockShowSettings SetVerbose(this AzureLockShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockShowSettings ResetVerbose(this AzureLockShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureLockUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureLockUpdateSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetIds(this AzureLockUpdateSettings toolSettings, string ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = ids;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetIds(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Ids = null;
            return toolSettings;
        }
        #endregion
        #region LockType
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetLockType(this AzureLockUpdateSettings toolSettings, LockLockType lockType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = lockType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.LockType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetLockType(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LockType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetName(this AzureLockUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Name"/>.</em></p><p>Name of the lock.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetName(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetNamespace(this AzureLockUpdateSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Namespace"/>.</em></p><p>Provider namespace (Ex: 'Microsoft.Provider').</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetNamespace(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Notes
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetNotes(this AzureLockUpdateSettings toolSettings, string notes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = notes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Notes"/>.</em></p><p>Notes about this lock.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetNotes(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Notes = null;
            return toolSettings;
        }
        #endregion
        #region Parent
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetParent(this AzureLockUpdateSettings toolSettings, string parent)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = parent;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Parent"/>.</em></p><p>The parent path (Ex: 'resA/myA/resB/myB').</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetParent(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parent = null;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetResource(this AzureLockUpdateSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Resource"/>.</em></p><p>Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetResource(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetResourceGroup(this AzureLockUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetResourceGroup(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceType
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetResourceType(this AzureLockUpdateSettings toolSettings, string resourceType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = resourceType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.ResourceType"/>.</em></p><p>The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetResourceType(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceType = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetDebug(this AzureLockUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetDebug(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetHelp(this AzureLockUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetHelp(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetOutput(this AzureLockUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetOutput(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetQuery(this AzureLockUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetQuery(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureLockUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings SetVerbose(this AzureLockUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureLockUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureLockUpdateSettings ResetVerbose(this AzureLockUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region LockLockType
    /// <summary><p>Used within <see cref="AzureLockTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class LockLockType : Enumeration
    {
        public static LockLockType cannotdelete = new LockLockType { Value = "cannotdelete" };
        public static LockLockType readonly_ = new LockLockType { Value = "readonly" };
    }
    #endregion
}
