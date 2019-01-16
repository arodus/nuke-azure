// Copyright 2019 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureEventgrid.json.

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
    public static partial class AzureEventgridTasks
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public static string AzureEventgridPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgrid(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureEventgridPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgrid(Configure<AzureEventgridSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeList(Configure<AzureEventgridTopicTypeListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicTypeListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeListEventTypes(Configure<AzureEventgridTopicTypeListEventTypesSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicTypeListEventTypesSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicTypeShow(Configure<AzureEventgridTopicTypeShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicTypeShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicCreate(Configure<AzureEventgridTopicCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicDelete(Configure<AzureEventgridTopicDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicList(Configure<AzureEventgridTopicListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicShow(Configure<AzureEventgridTopicShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicUpdate(Configure<AzureEventgridTopicUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionCreate(Configure<AzureEventgridEventSubscriptionCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridEventSubscriptionCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionDelete(Configure<AzureEventgridEventSubscriptionDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridEventSubscriptionDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionList(Configure<AzureEventgridEventSubscriptionListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridEventSubscriptionListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionShow(Configure<AzureEventgridEventSubscriptionShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridEventSubscriptionShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridEventSubscriptionUpdate(Configure<AzureEventgridEventSubscriptionUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridEventSubscriptionUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicKeyList(Configure<AzureEventgridTopicKeyListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicKeyListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Event Grid topics and subscriptions.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/eventgrid?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureEventgridTopicKeyRegenerate(Configure<AzureEventgridTopicKeyRegenerateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureEventgridTopicKeyRegenerateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureEventgridSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
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
              .Add("eventgrid")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureEventgridTopicTypeListSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicTypeListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic-type list")
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
    #region AzureEventgridTopicTypeListEventTypesSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicTypeListEventTypesSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name of the topic type.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic-type list-event-types")
              .Add("--name {value}", Name)
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
    #region AzureEventgridTopicTypeShowSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicTypeShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name of the topic type.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic-type show")
              .Add("--name {value}", Name)
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
    #region AzureEventgridTopicCreateSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of the topic.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic create")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--tags {value}", Tags)
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
    #region AzureEventgridTopicDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the topic.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic delete")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridTopicListSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic list")
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridTopicShowSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the topic.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridTopicUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the topic.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic update")
              .Add("--tags {value}", Tags)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--subscription {value}", Subscription)
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
    #region AzureEventgridEventSubscriptionCreateSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.</p></summary>
        public virtual string Endpoint { get; internal set; }
        /// <summary><p>Name of the new event subscription.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p></p></summary>
        public virtual EventgridEventSubscriptionEndpointType EndpointType { get; internal set; }
        /// <summary><p>A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.</p></summary>
        public virtual string IncludedEventTypes { get; internal set; }
        /// <summary><p>A space-separated list of labels to associate with this event subscription.</p></summary>
        public virtual string Labels { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Fully qualified identifier of the Azure resource to which the event subscription needs to be created.</p></summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary><p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p></summary>
        public virtual string SubjectBeginsWith { get; internal set; }
        /// <summary><p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p></summary>
        public virtual bool? SubjectCaseSensitive { get; internal set; }
        /// <summary><p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p></summary>
        public virtual string SubjectEndsWith { get; internal set; }
        /// <summary><p>Name of the Event Grid topic to which the event subscription needs to be created.</p></summary>
        public virtual string TopicName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid event-subscription create")
              .Add("--endpoint {value}", Endpoint)
              .Add("--name {value}", Name)
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--included-event-types {value}", IncludedEventTypes)
              .Add("--labels {value}", Labels)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--subject-begins-with {value}", SubjectBeginsWith)
              .Add("--subject-case-sensitive", SubjectCaseSensitive)
              .Add("--subject-ends-with {value}", SubjectEndsWith)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridEventSubscriptionDeleteSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name of the event subscription.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.</p></summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary><p>Name of the Event Grid topic whose event subscription needs to be deleted.</p></summary>
        public virtual string TopicName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid event-subscription delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridEventSubscriptionListSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Fully qualified identifier of the Azure resource.</p></summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary><p>Name of the Event Grid topic.</p></summary>
        public virtual string TopicName { get; internal set; }
        /// <summary><p>Name of the topic type.</p></summary>
        public virtual string TopicTypeName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid event-subscription list")
              .Add("--location {value}", Location)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--topic-name {value}", TopicName)
              .Add("--topic-type-name {value}", TopicTypeName)
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
    #region AzureEventgridEventSubscriptionShowSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name of the event subscription.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p></summary>
        public virtual bool? IncludeFullEndpointUrl { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Fully qualified identifier of the Azure resource.</p></summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary><p>Name of the Event Grid topic.</p></summary>
        public virtual string TopicName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid event-subscription show")
              .Add("--name {value}", Name)
              .Add("--include-full-endpoint-url", IncludeFullEndpointUrl)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--topic-name {value}", TopicName)
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
    #region AzureEventgridEventSubscriptionUpdateSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridEventSubscriptionUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Name of the event subscription.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.</p></summary>
        public virtual string Endpoint { get; internal set; }
        /// <summary><p></p></summary>
        public virtual EventgridEventSubscriptionEndpointType EndpointType { get; internal set; }
        /// <summary><p>A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.</p></summary>
        public virtual string IncludedEventTypes { get; internal set; }
        /// <summary><p>A space-separated list of labels to associate with this event subscription.</p></summary>
        public virtual string Labels { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Fully qualified identifier of the Azure resource.</p></summary>
        public virtual string ResourceId { get; internal set; }
        /// <summary><p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p></summary>
        public virtual string SubjectBeginsWith { get; internal set; }
        /// <summary><p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p></summary>
        public virtual string SubjectEndsWith { get; internal set; }
        /// <summary><p>Name of the Event Grid topic.</p></summary>
        public virtual string TopicName { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        public virtual string ForceString { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid event-subscription update")
              .Add("--name {value}", Name)
              .Add("--endpoint {value}", Endpoint)
              .Add("--endpoint-type {value}", EndpointType)
              .Add("--included-event-types {value}", IncludedEventTypes)
              .Add("--labels {value}", Labels)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--resource-id {value}", ResourceId)
              .Add("--subject-begins-with {value}", SubjectBeginsWith)
              .Add("--subject-ends-with {value}", SubjectEndsWith)
              .Add("--topic-name {value}", TopicName)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
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
    #region AzureEventgridTopicKeyListSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicKeyListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the topic.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic key list")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridTopicKeyRegenerateSettings
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureEventgridTopicKeyRegenerateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureEventgrid executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureEventgridTasks.AzureEventgridPath;
        /// <summary><p>Key name to regenerate key1 or key2.</p></summary>
        public virtual string KeyName { get; internal set; }
        /// <summary><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary><p>Name of the topic.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
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
              .Add("eventgrid topic key regenerate")
              .Add("--key-name {value}", KeyName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
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
    #region AzureEventgridSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridSettings SetDebug(this AzureEventgridSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridSettings ResetDebug(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridSettings SetHelp(this AzureEventgridSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridSettings ResetHelp(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridSettings SetOutput(this AzureEventgridSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridSettings ResetOutput(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridSettings SetQuery(this AzureEventgridSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridSettings ResetQuery(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridSettings SetVerbose(this AzureEventgridSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridSettings ResetVerbose(this AzureEventgridSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicTypeListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicTypeListSettingsExtensions
    {
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetSubscription(this AzureEventgridTopicTypeListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetSubscription(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetDebug(this AzureEventgridTopicTypeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetDebug(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetHelp(this AzureEventgridTopicTypeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetHelp(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetOutput(this AzureEventgridTopicTypeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetOutput(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetQuery(this AzureEventgridTopicTypeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetQuery(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings SetVerbose(this AzureEventgridTopicTypeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListSettings ResetVerbose(this AzureEventgridTopicTypeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicTypeListEventTypesSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicTypeListEventTypesSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Name"/>.</em></p><p>Name of the topic type.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetName(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Name"/>.</em></p><p>Name of the topic type.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetName(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetSubscription(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetSubscription(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetDebug(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetDebug(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetHelp(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetHelp(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetOutput(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetOutput(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetQuery(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetQuery(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings SetVerbose(this AzureEventgridTopicTypeListEventTypesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeListEventTypesSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeListEventTypesSettings ResetVerbose(this AzureEventgridTopicTypeListEventTypesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicTypeShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicTypeShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Name"/>.</em></p><p>Name of the topic type.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetName(this AzureEventgridTopicTypeShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Name"/>.</em></p><p>Name of the topic type.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetName(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetSubscription(this AzureEventgridTopicTypeShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetSubscription(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetDebug(this AzureEventgridTopicTypeShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetDebug(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetHelp(this AzureEventgridTopicTypeShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetHelp(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetOutput(this AzureEventgridTopicTypeShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetOutput(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetQuery(this AzureEventgridTopicTypeShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetQuery(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicTypeShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings SetVerbose(this AzureEventgridTopicTypeShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicTypeShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicTypeShowSettings ResetVerbose(this AzureEventgridTopicTypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicCreateSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetLocation(this AzureEventgridTopicCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetLocation(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetName(this AzureEventgridTopicCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetName(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetResourceGroup(this AzureEventgridTopicCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetResourceGroup(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetTags(this AzureEventgridTopicCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetTags(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetSubscription(this AzureEventgridTopicCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetSubscription(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetDebug(this AzureEventgridTopicCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetDebug(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetHelp(this AzureEventgridTopicCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetHelp(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetOutput(this AzureEventgridTopicCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetOutput(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetQuery(this AzureEventgridTopicCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetQuery(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings SetVerbose(this AzureEventgridTopicCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicCreateSettings ResetVerbose(this AzureEventgridTopicCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicDeleteSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetIds(this AzureEventgridTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetIds(this AzureEventgridTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings AddIds(this AzureEventgridTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings AddIds(this AzureEventgridTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventgridTopicDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ClearIds(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings RemoveIds(this AzureEventgridTopicDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicDeleteSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings RemoveIds(this AzureEventgridTopicDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetName(this AzureEventgridTopicDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetName(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetResourceGroup(this AzureEventgridTopicDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetResourceGroup(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetSubscription(this AzureEventgridTopicDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetSubscription(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetDebug(this AzureEventgridTopicDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetDebug(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetHelp(this AzureEventgridTopicDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetHelp(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetOutput(this AzureEventgridTopicDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetOutput(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetQuery(this AzureEventgridTopicDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetQuery(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings SetVerbose(this AzureEventgridTopicDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicDeleteSettings ResetVerbose(this AzureEventgridTopicDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetResourceGroup(this AzureEventgridTopicListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetResourceGroup(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetSubscription(this AzureEventgridTopicListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetSubscription(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetDebug(this AzureEventgridTopicListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetDebug(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetHelp(this AzureEventgridTopicListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetHelp(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetOutput(this AzureEventgridTopicListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetOutput(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetQuery(this AzureEventgridTopicListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetQuery(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings SetVerbose(this AzureEventgridTopicListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicListSettings ResetVerbose(this AzureEventgridTopicListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicShowSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetIds(this AzureEventgridTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetIds(this AzureEventgridTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings AddIds(this AzureEventgridTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings AddIds(this AzureEventgridTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventgridTopicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ClearIds(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings RemoveIds(this AzureEventgridTopicShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicShowSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings RemoveIds(this AzureEventgridTopicShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetName(this AzureEventgridTopicShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetName(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetResourceGroup(this AzureEventgridTopicShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetResourceGroup(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetSubscription(this AzureEventgridTopicShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetSubscription(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetDebug(this AzureEventgridTopicShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetDebug(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetHelp(this AzureEventgridTopicShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetHelp(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetOutput(this AzureEventgridTopicShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetOutput(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetQuery(this AzureEventgridTopicShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetQuery(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings SetVerbose(this AzureEventgridTopicShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicShowSettings ResetVerbose(this AzureEventgridTopicShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicUpdateSettingsExtensions
    {
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetTags(this AzureEventgridTopicUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetTags(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetIds(this AzureEventgridTopicUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetIds(this AzureEventgridTopicUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings AddIds(this AzureEventgridTopicUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings AddIds(this AzureEventgridTopicUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventgridTopicUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ClearIds(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings RemoveIds(this AzureEventgridTopicUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicUpdateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings RemoveIds(this AzureEventgridTopicUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetName(this AzureEventgridTopicUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetName(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetResourceGroup(this AzureEventgridTopicUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetResourceGroup(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetSubscription(this AzureEventgridTopicUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetSubscription(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetAdd(this AzureEventgridTopicUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetAdd(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetForceString(this AzureEventgridTopicUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetForceString(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetRemove(this AzureEventgridTopicUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetRemove(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetSet(this AzureEventgridTopicUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetSet(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetDebug(this AzureEventgridTopicUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetDebug(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetHelp(this AzureEventgridTopicUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetHelp(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetOutput(this AzureEventgridTopicUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetOutput(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetQuery(this AzureEventgridTopicUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetQuery(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings SetVerbose(this AzureEventgridTopicUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicUpdateSettings ResetVerbose(this AzureEventgridTopicUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionCreateSettingsExtensions
    {
        #region Endpoint
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Endpoint"/>.</em></p><p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetEndpoint(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string endpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = endpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Endpoint"/>.</em></p><p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetEndpoint(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Name"/>.</em></p><p>Name of the new event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetName(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Name"/>.</em></p><p>Name of the new event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetName(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region EndpointType
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.EndpointType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetEndpointType(this AzureEventgridEventSubscriptionCreateSettings toolSettings, EventgridEventSubscriptionEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.EndpointType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetEndpointType(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region IncludedEventTypes
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.IncludedEventTypes"/>.</em></p><p>A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetIncludedEventTypes(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string includedEventTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = includedEventTypes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.IncludedEventTypes"/>.</em></p><p>A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetIncludedEventTypes(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = null;
            return toolSettings;
        }
        #endregion
        #region Labels
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Labels"/>.</em></p><p>A space-separated list of labels to associate with this event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetLabels(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string labels)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = labels;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Labels"/>.</em></p><p>A space-separated list of labels to associate with this event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetLabels(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetResourceGroup(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetResourceGroup(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource to which the event subscription needs to be created.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetResourceId(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource to which the event subscription needs to be created.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetResourceId(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SubjectBeginsWith
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectBeginsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubjectBeginsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string subjectBeginsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = subjectBeginsWith;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectBeginsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubjectBeginsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = null;
            return toolSettings;
        }
        #endregion
        #region SubjectCaseSensitive
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/>.</em></p><p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings, bool? subjectCaseSensitive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = subjectCaseSensitive;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/>.</em></p><p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/>.</em></p><p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings EnableSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/>.</em></p><p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings DisableSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectCaseSensitive"/>.</em></p><p>Specify to indicate whether the subject fields should be compared in a case sensitive manner. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ToggleSubjectCaseSensitive(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectCaseSensitive = !toolSettings.SubjectCaseSensitive;
            return toolSettings;
        }
        #endregion
        #region SubjectEndsWith
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectEndsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubjectEndsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string subjectEndsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = subjectEndsWith;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.SubjectEndsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubjectEndsWith(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic to which the event subscription needs to be created.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetTopicName(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic to which the event subscription needs to be created.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetTopicName(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetSubscription(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetSubscription(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetDebug(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetDebug(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetHelp(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetHelp(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetOutput(this AzureEventgridEventSubscriptionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetOutput(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetQuery(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetQuery(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings SetVerbose(this AzureEventgridEventSubscriptionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionCreateSettings ResetVerbose(this AzureEventgridEventSubscriptionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Name"/>.</em></p><p>Name of the event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Name"/>.</em></p><p>Name of the event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetResourceGroup(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetResourceGroup(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetResourceId(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource whose event subscription needs to be deleted.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetResourceId(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic whose event subscription needs to be deleted.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetTopicName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic whose event subscription needs to be deleted.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetTopicName(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetSubscription(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetSubscription(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetDebug(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetDebug(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetHelp(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetHelp(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetOutput(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetOutput(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetQuery(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetQuery(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings SetVerbose(this AzureEventgridEventSubscriptionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionDeleteSettings ResetVerbose(this AzureEventgridEventSubscriptionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionListSettingsExtensions
    {
        #region Location
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetLocation(this AzureEventgridEventSubscriptionListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Location"/>.</em></p><p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetLocation(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetResourceGroup(this AzureEventgridEventSubscriptionListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetResourceGroup(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetResourceId(this AzureEventgridEventSubscriptionListSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetResourceId(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetTopicName(this AzureEventgridEventSubscriptionListSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetTopicName(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region TopicTypeName
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.TopicTypeName"/>.</em></p><p>Name of the topic type.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetTopicTypeName(this AzureEventgridEventSubscriptionListSettings toolSettings, string topicTypeName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicTypeName = topicTypeName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.TopicTypeName"/>.</em></p><p>Name of the topic type.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetTopicTypeName(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicTypeName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetSubscription(this AzureEventgridEventSubscriptionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetSubscription(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetDebug(this AzureEventgridEventSubscriptionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetDebug(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetHelp(this AzureEventgridEventSubscriptionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetHelp(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetOutput(this AzureEventgridEventSubscriptionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetOutput(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetQuery(this AzureEventgridEventSubscriptionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetQuery(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings SetVerbose(this AzureEventgridEventSubscriptionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionListSettings ResetVerbose(this AzureEventgridEventSubscriptionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Name"/>.</em></p><p>Name of the event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetName(this AzureEventgridEventSubscriptionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Name"/>.</em></p><p>Name of the event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetName(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region IncludeFullEndpointUrl
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/>.</em></p><p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings, bool? includeFullEndpointUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = includeFullEndpointUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/>.</em></p><p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/>.</em></p><p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings EnableIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/>.</em></p><p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings DisableIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureEventgridEventSubscriptionShowSettings.IncludeFullEndpointUrl"/>.</em></p><p>Specify to indicate whether the full endpoint URL should be returned. True if flag present.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ToggleIncludeFullEndpointUrl(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludeFullEndpointUrl = !toolSettings.IncludeFullEndpointUrl;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetResourceGroup(this AzureEventgridEventSubscriptionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetResourceGroup(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetResourceId(this AzureEventgridEventSubscriptionShowSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetResourceId(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetTopicName(this AzureEventgridEventSubscriptionShowSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetTopicName(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetSubscription(this AzureEventgridEventSubscriptionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetSubscription(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetDebug(this AzureEventgridEventSubscriptionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetDebug(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetHelp(this AzureEventgridEventSubscriptionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetHelp(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetOutput(this AzureEventgridEventSubscriptionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetOutput(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetQuery(this AzureEventgridEventSubscriptionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetQuery(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings SetVerbose(this AzureEventgridEventSubscriptionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionShowSettings ResetVerbose(this AzureEventgridEventSubscriptionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridEventSubscriptionUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridEventSubscriptionUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Name"/>.</em></p><p>Name of the event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Name"/>.</em></p><p>Name of the event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Endpoint
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Endpoint"/>.</em></p><p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetEndpoint(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string endpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = endpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Endpoint"/>.</em></p><p>Endpoint where EventGrid should deliver events matching this event subscription. For webhook endpoint type, this should be the corresponding webhook URL. For eventhub endpoint type, this should be the Azure ResourceID of the event hub.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetEndpoint(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = null;
            return toolSettings;
        }
        #endregion
        #region EndpointType
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.EndpointType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetEndpointType(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, EventgridEventSubscriptionEndpointType endpointType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = endpointType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.EndpointType"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetEndpointType(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointType = null;
            return toolSettings;
        }
        #endregion
        #region IncludedEventTypes
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.IncludedEventTypes"/>.</em></p><p>A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetIncludedEventTypes(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string includedEventTypes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = includedEventTypes;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.IncludedEventTypes"/>.</em></p><p>A space-separated list of event types. To subscribe to all event types, the string "All" should be specified.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetIncludedEventTypes(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IncludedEventTypes = null;
            return toolSettings;
        }
        #endregion
        #region Labels
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Labels"/>.</em></p><p>A space-separated list of labels to associate with this event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetLabels(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string labels)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = labels;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Labels"/>.</em></p><p>A space-separated list of labels to associate with this event subscription.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetLabels(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Labels = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetResourceGroup(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetResourceGroup(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ResourceId
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetResourceId(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string resourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = resourceId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ResourceId"/>.</em></p><p>Fully qualified identifier of the Azure resource.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetResourceId(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceId = null;
            return toolSettings;
        }
        #endregion
        #region SubjectBeginsWith
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectBeginsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSubjectBeginsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string subjectBeginsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = subjectBeginsWith;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectBeginsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a prefix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSubjectBeginsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectBeginsWith = null;
            return toolSettings;
        }
        #endregion
        #region SubjectEndsWith
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectEndsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSubjectEndsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string subjectEndsWith)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = subjectEndsWith;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.SubjectEndsWith"/>.</em></p><p>An optional string to filter events for an event subscription based on a suffix. Wildcard characters are not supported.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSubjectEndsWith(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubjectEndsWith = null;
            return toolSettings;
        }
        #endregion
        #region TopicName
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetTopicName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string topicName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = topicName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.TopicName"/>.</em></p><p>Name of the Event Grid topic.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetTopicName(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TopicName = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetAdd(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetAdd(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetForceString(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetForceString(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetRemove(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetRemove(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSet(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSet(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetSubscription(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetSubscription(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetDebug(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetDebug(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetHelp(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetHelp(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetOutput(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetOutput(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetQuery(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetQuery(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings SetVerbose(this AzureEventgridEventSubscriptionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridEventSubscriptionUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridEventSubscriptionUpdateSettings ResetVerbose(this AzureEventgridEventSubscriptionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicKeyListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicKeyListSettingsExtensions
    {
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetIds(this AzureEventgridTopicKeyListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetIds(this AzureEventgridTopicKeyListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicKeyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings AddIds(this AzureEventgridTopicKeyListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicKeyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings AddIds(this AzureEventgridTopicKeyListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventgridTopicKeyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ClearIds(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicKeyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings RemoveIds(this AzureEventgridTopicKeyListSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicKeyListSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings RemoveIds(this AzureEventgridTopicKeyListSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetName(this AzureEventgridTopicKeyListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetName(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetResourceGroup(this AzureEventgridTopicKeyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetResourceGroup(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetSubscription(this AzureEventgridTopicKeyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetSubscription(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetDebug(this AzureEventgridTopicKeyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetDebug(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetHelp(this AzureEventgridTopicKeyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetHelp(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetOutput(this AzureEventgridTopicKeyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetOutput(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetQuery(this AzureEventgridTopicKeyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetQuery(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings SetVerbose(this AzureEventgridTopicKeyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyListSettings ResetVerbose(this AzureEventgridTopicKeyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureEventgridTopicKeyRegenerateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureEventgridTopicKeyRegenerateSettingsExtensions
    {
        #region KeyName
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.KeyName"/>.</em></p><p>Key name to regenerate key1 or key2.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetKeyName(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string keyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = keyName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.KeyName"/>.</em></p><p>Key name to regenerate key1 or key2.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetKeyName(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/> to a new list.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings AddIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings AddIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ClearIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings RemoveIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureEventgridTopicKeyRegenerateSettings.Ids"/>.</em></p><p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings RemoveIds(this AzureEventgridTopicKeyRegenerateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetName(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Name"/>.</em></p><p>Name of the topic.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetName(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetResourceGroup(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetResourceGroup(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetSubscription(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetSubscription(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetDebug(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetDebug(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetHelp(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetHelp(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetOutput(this AzureEventgridTopicKeyRegenerateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetOutput(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetQuery(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetQuery(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureEventgridTopicKeyRegenerateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings SetVerbose(this AzureEventgridTopicKeyRegenerateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureEventgridTopicKeyRegenerateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureEventgridTopicKeyRegenerateSettings ResetVerbose(this AzureEventgridTopicKeyRegenerateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region EventgridEventSubscriptionEndpointType
    /// <summary><p>Used within <see cref="AzureEventgridTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class EventgridEventSubscriptionEndpointType : Enumeration
    {
        public static EventgridEventSubscriptionEndpointType eventhub = new EventgridEventSubscriptionEndpointType { Value = "eventhub" };
        public static EventgridEventSubscriptionEndpointType webhook = new EventgridEventSubscriptionEndpointType { Value = "webhook" };
    }
    #endregion
}
